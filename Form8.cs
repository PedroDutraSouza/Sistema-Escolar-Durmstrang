using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Durmstrang;
using connection;
using MySql.Data.MySqlClient;

namespace Durmstrang
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void form8_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 7; i++)
                ano_minimo.Items.Add(i);

            ano_minimo.SelectedIndex = 0;

            CarregarGrid();
        }

        private void CarregarGrid()
        {
            try
            {
                string conexao = "Server=localhost;Database=durmstrang;Uid=root;Pwd='';";
                using (MySqlConnection con = new MySqlConnection(conexao))
                {
                    string sql = "SELECT * FROM alunos";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvMaterias.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tabela: " + ex.Message);
            }
        }

        private void sobreNos_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void salvarD_Click(object sender, EventArgs e)
        {
            using (var con = Conexao.Conectar())
            {
                con.Open();

                string sql = @"INSERT INTO materias 
                               (nome_materia, descricao, ano_minimo, livro_texto_principal)
                               VALUES (@nome, @desc, @ano, @livro)";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@nome", nome_materia.Text);
                cmd.Parameters.AddWithValue("@desc", descricao.Text);
                cmd.Parameters.AddWithValue("@ano", ano_minimo.SelectedItem);
                cmd.Parameters.AddWithValue("@livro", livro_texto_principal.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Disciplina cadastrada com sucesso!");
                CarregarGrid();
            }
        }

        private void editarD_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma disciplina para editar.");
                return;
            }

            int id = Convert.ToInt32(dgvMaterias.SelectedRows[0].Cells["id_materia"].Value);

            using (var con = Conexao.Conectar())
            {
                con.Open();

                string sql = @"UPDATE materias SET
                               nome_materia = @nome,
                               descricao = @desc,
                               ano_minimo = @ano,
                               livro_texto_principal = @livro
                               WHERE id_materia = @id";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@nome", nome_materia.Text);
                cmd.Parameters.AddWithValue("@desc", descricao.Text);
                cmd.Parameters.AddWithValue("@ano", ano_minimo.SelectedItem);
                cmd.Parameters.AddWithValue("@livro", livro_texto_principal.Text);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Disciplina atualizada!");
                CarregarGrid();
            }
        }

        private void excluirD_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma disciplina para excluir.");
                return;
            }

            int id = Convert.ToInt32(dgvMaterias.SelectedRows[0].Cells["id_materia"].Value);

            using (var con = Conexao.Conectar())
            {
                con.Open();

                string sql = "DELETE FROM materias WHERE id_materia = @id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Disciplina excluída!");
                CarregarGrid();
            }
        }

        private void limparD_Click(object sender, EventArgs e)
        {
            nome_materia.SelectedIndex = -1;
            descricao.Clear();
            livro_texto_principal.Clear();
            ano_minimo.SelectedIndex = 0;
        }

        private void pesquisaD_Click(object sender, EventArgs e)
        {
            using (var con = Conexao.Conectar())
            {
                con.Open();

                string sql = "SELECT * FROM materias WHERE nome_materia LIKE @nome";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", "%" + digiteD.Text + "%");

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvMaterias.DataSource = dt;
            }
        }

        private void dgvMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                nome_materia.Text = dgvMaterias.Rows[e.RowIndex].Cells["nome_materia"].Value.ToString();
                descricao.Text = dgvMaterias.Rows[e.RowIndex].Cells["descricao"].Value.ToString();
                ano_minimo.SelectedItem = dgvMaterias.Rows[e.RowIndex].Cells["ano_minimo"].Value;
                livro_texto_principal.Text = dgvMaterias.Rows[e.RowIndex].Cells["livro_texto_principal"].Value.ToString();
            }
        }
    }
}


