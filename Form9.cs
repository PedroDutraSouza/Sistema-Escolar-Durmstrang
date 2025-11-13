using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Durmstrang
{
    public partial class Form9 : Form
    {
        string conString = "server=localhost;user id=root;database=durmstrang;";

        public Form9()
        {
            InitializeComponent();
            mostrar();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            mostrar();
            anoTurma.Items.Add("Primeiro Ano");
            anoTurma.Items.Add("Segundo Ano");
            anoTurma.Items.Add("Terceiro Ano");
            anoTurma.Items.Add("Quarto Ano");
            anoTurma.Items.Add("Quinto Ano");
            anoTurma.Items.Add("Sexto Ano");
            anoTurma.Items.Add("Sétimo Ano");

            capAlunos.Items.Add("10");
            capAlunos.Items.Add("20");
            capAlunos.Items.Add("30");
            capAlunos.Items.Add("40");
            capAlunos.Items.Add("50");
        }

        void mostrar()
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM turmas", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                mostrarTurmas.DataSource = dt;
            }
        }

        private void sobreNos_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void salvarT_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO turmas(nome_turma, ano_turma, capacidade) VALUES (@n,@a,@c)", con);
                cmd.Parameters.AddWithValue("@n", nomeT.Text);
                cmd.Parameters.AddWithValue("@a", anoTurma.Text);
                cmd.Parameters.AddWithValue("@c", capAlunos.Text);
                cmd.ExecuteNonQuery();
            }
            mostrar();
        }

        private void editarT_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE turmas SET nome_turma=@n, ano_turma=@a, capacidade=@c WHERE id_turma=@id", con);
                cmd.Parameters.AddWithValue("@n", nomeT.Text);
                cmd.Parameters.AddWithValue("@a", anoTurma.Text);
                cmd.Parameters.AddWithValue("@c", capAlunos.Text);
                cmd.Parameters.AddWithValue("@id", mostrarTurmas.CurrentRow.Cells[0].Value);
                cmd.ExecuteNonQuery();
            }
            mostrar();
        }

        private void excluirT_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM turmas WHERE id_turma=@id", con);
                cmd.Parameters.AddWithValue("@id", mostrarTurmas.CurrentRow.Cells[0].Value);
                cmd.ExecuteNonQuery();
            }
            mostrar();
        }

        private void limparT_Click(object sender, EventArgs e)
        {
            nomeT.Clear();
            anoTurma.SelectedIndex = -1;
            capAlunos.SelectedIndex = -1;
        }

        private void pesquisaT_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM turmas WHERE nome_turma LIKE @pesq", con);
                da.SelectCommand.Parameters.AddWithValue("@pesq", "%" + digiteT.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                mostrarTurmas.DataSource = dt;
            }
        }
    }
}
