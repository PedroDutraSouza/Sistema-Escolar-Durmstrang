using MySql.Data.MySqlClient;
using QuestPDF.Fluent;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using testePDF; // Namespace onde estão Student e SubjectGrade
using System.Data; // Para DBNull

namespace BoletimApp // Use o mesmo namespace do seu Program.cs
{
    public class BoletimGenerator
    {
        // 1. String de conexão
        private string connectionString = "Server=localhost; Database=durmstrang; Uid=root; Pwd='';";

        // 2. Método público principal que o Form10 irá chamar
        public string GerarBoletim(int alunoId)
        {
            Student student = null;
            List<SubjectGrade> grades = new List<SubjectGrade>();

            // 3. Conectar ao banco e buscar os dados
            // MUDANÇA: 'using var' substituído por 'using'
            using (var connection = new MySqlConnection(connectionString))
            {
                Console.WriteLine("Conectando ao banco de dados MySQL...");
                connection.Open();
                Console.WriteLine("Conexão bem-sucedida!");

                // 3.1 Buscar dados do Aluno
                student = GetStudentInfo(connection, alunoId);

                if (student == null)
                {
                    // Lança uma exceção que o formulário pode capturar
                    throw new Exception($"Aluno com ID {alunoId} não foi encontrado.");
                }

                // 3.2 Buscar lista de Notas do Aluno
                grades = GetStudentGrades(connection, alunoId);
            }

            Console.WriteLine($"Dados encontrados para: {student.Name}");
            Console.WriteLine($"Total de matérias encontradas: {grades.Count}");

            // 4. Gerar o Documento PDF
            var document = new BoletimDocument(student, grades);
            var output = $"boletim_aluno_{alunoId}.pdf";
            document.GeneratePdf(output);

            Console.WriteLine($"PDF gerado com sucesso: {Path.GetFullPath(output)}");

            // 5. Retornar o caminho completo do ficheiro
            return Path.GetFullPath(output);
        }

        // --- Funções Auxiliares de Banco de Dados ---
        // (Copiladas do seu Program.cs, mas tornadas NÃO ESTÁTICAS)

        private Student GetStudentInfo(MySqlConnection connection, int alunoId)
        {
            string query = @"
                SELECT nome_aluno, sobrenome, ano_escolar 
                FROM alunos 
                WHERE id_aluno = @Id";

            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", alunoId);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Student
                        {
                            Name = $"{reader["nome_aluno"]} {reader["sobrenome"]}",
                            Class = reader["ano_escolar"].ToString() ?? string.Empty,
                            Registration = alunoId.ToString("D4"),
                            Period = "Ano Letivo 2025"
                        };
                    }
                }
            }
            return null;
        }

        private List<SubjectGrade> GetStudentGrades(MySqlConnection connection, int alunoId)
        {
            var gradesList = new List<SubjectGrade>();
            string query = @"
                SELECT m.nome_materia, n.B1, n.B2, n.B3, n.B4
                FROM notas n
                JOIN materias m ON n.id_materia = m.id_materia
                WHERE n.id_aluno = @Id
                ORDER BY m.nome_materia";

            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", alunoId);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var grade = new SubjectGrade
                        {
                            Subject = ReadGrade(reader, "nome_materia"),
                            Grade1 = ReadGrade(reader, "B1"),
                            Grade2 = ReadGrade(reader, "B2"),
                            Grade3 = ReadGrade(reader, "B3"),
                            Grade4 = ReadGrade(reader, "B4")
                        };
                        gradesList.Add(grade);
                    }
                }
            }
            return gradesList;
        }

        private string ReadGrade(MySqlDataReader reader, string columnName)
        {
            if (reader[columnName] == DBNull.Value)
            {
                return null;
            }

            object value = reader[columnName];
            if (value is decimal gradeValue)
            {
                return gradeValue.ToString("0.0", CultureInfo.GetCultureInfo("pt-BR"));
            }

            return value.ToString();
        }
    }
}