using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Durmstrang
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            CarregarTabela();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            CarregarTabela();
        }

        // SALVAR
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!mtbDataContratacao.MaskFull)
            {
                MessageBox.Show("Preencha a data completa!");
                return;
            }

            DateTime.TryParse(mtbDataContratacao.Text, out DateTime data);

            CadastroProfessor prof = new CadastroProfessor();
            prof.Nome_Professor = txtNomeProf.Text;
            prof.Sobrenome = txtSobrenomeProf.Text;
            prof.Data_Contratacao = data;
            prof.Especialidade = cmbEspecialidade.Text;

            prof.Inserir();
            CarregarTabela();
        }

        // EDITAR
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProfessores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um professor.");
                return;
            }

            DateTime.TryParse(mtbDataContratacao.Text, out DateTime data);

            CadastroProfessor prof = new CadastroProfessor();
            prof.IdProfessor = Convert.ToInt32(dgvProfessores.CurrentRow.Cells["id_professor"].Value);
            prof.Nome_Professor = txtNomeProf.Text;
            prof.Sobrenome = txtSobrenomeProf.Text;
            prof.Data_Contratacao = data;
            prof.Especialidade = cmbEspecialidade.Text;

            prof.Editar();
            CarregarTabela();
        }

        // EXCLUIR
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvProfessores.SelectedRows.Count > 0)
            {
                CadastroProfessor prof = new CadastroProfessor();
                prof.IdProfessor = Convert.ToInt32(dgvProfessores.CurrentRow.Cells["id_professor"].Value);
                prof.Excluir();

                CarregarTabela();
            }
        }

        // LIMPAR
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeProf.Clear();
            txtSobrenomeProf.Clear();
            mtbDataContratacao.Clear();
            cmbEspecialidade.SelectedIndex = -1;
            txtNomeProf.Focus();
        }

        // CARREGAR TABELA
        private void CarregarTabela()
        {
            try
            {
                string conexaoString = "Server=localhost;Database=durmstrang;Uid=root;Pwd=;";
                using (MySqlConnection con = new MySqlConnection(conexaoString))
                {
                    string sql = "SELECT * FROM professores";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvProfessores.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tabela:\n" + ex.Message);
            }
        }

        // SELECIONAR ITEM DA TABELA
        private void dgvProfessores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProfessores.CurrentRow != null)
            {
                txtNomeProf.Text = dgvProfessores.CurrentRow.Cells["nome_professor"].Value.ToString();
                txtSobrenomeProf.Text = dgvProfessores.CurrentRow.Cells["sobrenome"].Value.ToString();
                mtbDataContratacao.Text = dgvProfessores.CurrentRow.Cells["data_contratacao"].Value.ToString();
                cmbEspecialidade.Text = dgvProfessores.CurrentRow.Cells["especialidade"].Value.ToString();
            }
        }

        private void sobreNos_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }
    }
}
