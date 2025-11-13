using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Durmstrang
{
    internal class CadastroD
    {
        public class CadastroTurma
        {
            public string Diciplina { get; set; }
            public string Descriçao { get; set; }
            public string AnoMinimo { get; set; }
            public string LivroPrincipal { get; set; }
            public string Nome {  get; set; }
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

                        string insert = "INSERT INTO Materias (Diciplina, Descriçao, AnoMinimo, LivroPrincipal) " +
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
