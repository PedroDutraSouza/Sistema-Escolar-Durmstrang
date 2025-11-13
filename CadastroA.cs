using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Data;

namespace Durmstrang
{
    internal class CadastroAluno
    {
        public int IdAluno { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string AnoEscolar { get; set; }

        string conexao = "Server=localhost;Database=durmstrang;Uid=root;Pwd=;";

        public void Inserir()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();
                    string sql = "INSERT INTO alunos (nome_aluno, sobrenome, data_nascimento, ano_escolar) VALUES (@n, @s, @d, @a)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@n", Nome);
                    cmd.Parameters.AddWithValue("@s", Sobrenome);
                    cmd.Parameters.AddWithValue("@d", DataNascimento);
                    cmd.Parameters.AddWithValue("@a", AnoEscolar);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Aluno cadastrado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

        public void Editar()
        {
            
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();
                    string sql = "UPDATE FROM alunos SET nome_aluno=@n, sobrenome=@s, data_nascimento=@d, ano_escolar=@a WHERE id_aluno=@id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id", IdAluno);
                    cmd.Parameters.AddWithValue("@n", Nome);
                    cmd.Parameters.AddWithValue("@s", Sobrenome);
                    cmd.Parameters.AddWithValue("@d", DataNascimento);
                    cmd.Parameters.AddWithValue("@a", AnoEscolar);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro atualizado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar: " + ex.Message);
            }
        }

        public void Excluir()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();
                    string sql = "DELETE FROM alunos WHERE id_aluno=@id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id", IdAluno);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Aluno removido!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir: " + ex.Message);
            }
        }
    }
}

