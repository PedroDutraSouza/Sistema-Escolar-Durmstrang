using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace connection
{
    internal class conexao
    {
        private const string servidor = "localhost";
        private const string banco = "durmstrang";
        private const string usuario = "root";
        private const string pwd = "";

        public static readonly string stringConexao = $"Server={servidor}; Database={banco}; Uid={usuario}; Pwd={pwd};";

    }

    public class Conexao
    {
        private static string connectionString =
            "server=127.0.0.1;database=durmstrang;user=root;password=;pwd='';";

        public static MySqlConnection Conectar()
        {
            try
            {
                string connString = "Server=localhost; Database=durmstrang; Uid=root; Pwd='';";
                var con = new MySqlConnection(connString);
                con.Open();
                return con;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar: " + ex.Message);
                return null; // <-- ESTE É O PROBLEMA
            }
        }


    }
}
