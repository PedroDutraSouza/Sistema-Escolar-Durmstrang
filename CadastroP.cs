using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Durmstrang
{
    internal class CadastroProfessor
    {
        public int IdProfessor { get; set; }
        public string Nome_Professor { get; set; }
        public string Sobrenome { get; set; }
        public DateTime Data_Contratacao { get; set; }
        public string Especialidade { get; set; }

        // CONEXÃO
        private string conexaoString = "Server=localhost;Database=durmstrang;Uid=root;Pwd=;";

        // INSERIR
        public void Inserir()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(conexaoString))
                {
                    con.Open();

                    string sql = "INSERT INTO professores (nome_professor, sobrenome, data_contratacao, especialidade) " +
                                 "VALUES (@nome_professor, @sobrenome, @data_contratacao, @especialidade)";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@nome_professor", Nome_Professor);
                    cmd.Parameters.AddWithValue("@sobrenome", Sobrenome);
                    cmd.Parameters.AddWithValue("@data_contratacao", Data_Contratacao);
                    cmd.Parameters.AddWithValue("@especialidade", Especialidade);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Professor cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir professor:\n" + ex.Message);
            }
        }

        // EDITAR
        public void Editar()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(conexaoString))
                {
                    con.Open();

                    string sql = "UPDATE professores SET nome_professor = @nome_professor, sobrenome = @sobrenome, " +
                                 "data_contratacao = @data_contratacao, especialidade = @especialidade " +
                                 "WHERE id_professor = @id";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id", IdProfessor);
                    cmd.Parameters.AddWithValue("@nome_professor", Nome_Professor);
                    cmd.Parameters.AddWithValue("@sobrenome", Sobrenome);
                    cmd.Parameters.AddWithValue("@data_contratacao", Data_Contratacao);
                    cmd.Parameters.AddWithValue("@especialidade", Especialidade);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Professor atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar professor:\n" + ex.Message);
            }
        }

        // EXCLUIR
        public void Excluir()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(conexaoString))
                {
                    con.Open();

                    string sql = "DELETE FROM professores WHERE id_professor = @id";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id", IdProfessor);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Professor excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir professor:\n" + ex.Message);
            }
        }
    }
}

