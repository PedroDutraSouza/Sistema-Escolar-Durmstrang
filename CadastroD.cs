using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Durmstrang
{
    internal class CadastroT
    {
        public class CadastroTurma
        {
            public string Nome { get; set; }
            public string Sobrenome { get; set; }
            public string DataNascimento { get; set; }
            public string AnoEscolar { get; set; }

            public void InserirFunc()
            {
                try
                {

                    string servidorBanco = "Server=localhost;Database=durmstrang;Uid=root;Pwd= ;";

                    using (MySqlConnection conexaoSql = new MySqlConnection(servidorBanco))
                    {
                        conexaoSql.Open();

                        string insert = "INSERT INTO Usuario(nome_aluno, sobrenome, data_nascimento, ano_escolar) " +
                                        "VALUES(@nome_aluno, @sobrenome, @data_nascimento, @ano_escolar);";

                        using (MySqlCommand cmd = new MySqlCommand(insert, conexaoSql))
                        {
                            cmd.Parameters.AddWithValue("@nome_aluno", Nome);
                            cmd.Parameters.AddWithValue("@sobrenome", Sobrenome);
                            cmd.Parameters.AddWithValue("@data_nascimento", DataNascimento);
                            cmd.Parameters.AddWithValue("@ano_escolar", AnoEscolar);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar com o banco - Método InserirFunc\n" + ex.Message);
                }
            }
        }
    }
}
