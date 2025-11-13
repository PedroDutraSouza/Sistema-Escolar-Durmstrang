using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;


namespace Durmstrang
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            CarregarTabela();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            CarregarTabela();
        }

        private void CarregarTabela()
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
                    dgvAlunos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tabela: " + ex.Message);
            }
        }

        // SALVAR
        private void button1_Click(object sender, EventArgs e)
        {
            if (!dtpNascimento.MaskFull)
            {
                MessageBox.Show("Data incompleta! Ex: 12/05/2010");
                return;
            }

            DateTime.TryParse(dtpNascimento.Text, out DateTime data);

            CadastroAluno aluno = new CadastroAluno();
            aluno.Nome = txtNome.Text;
            aluno.Sobrenome = txtSobrenome.Text;
            aluno.DataNascimento = data;
            aluno.AnoEscolar = cmbAno.Text;

            aluno.Inserir();
            CarregarTabela();
        }

        // EDITAR
        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvAlunos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma reserva!");
                return;
            }

            

            DateTime.TryParse(dtpNascimento.Text, out DateTime data);

            CadastroAluno aluno = new CadastroAluno();
            aluno.IdAluno = Convert.ToInt32(dgvAlunos.CurrentRow.Cells["id_aluno"].Value);
            /*aluno.Nome = txtNome.Text;
            aluno.Sobrenome = txtSobrenome.Text;
            aluno.DataNascimento = data;
            aluno.AnoEscolar = cmbAno.Text;*/

            aluno.Editar();
            CarregarTabela();
        }

        // EXCLUIR
        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvAlunos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um aluno para excluir.");
                return;
            }

            CadastroAluno aluno = new CadastroAluno();
            aluno.IdAluno = Convert.ToInt32(dgvAlunos.CurrentRow.Cells["id_aluno"].Value);
            aluno.Excluir();

            CarregarTabela();
        }

        // LIMPAR CAMPOS
        private void button4_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtSobrenome.Clear();
            dtpNascimento.Clear();
            cmbAno.SelectedIndex = -1;
            txtNome.Focus();
        }

        // AO CLICAR NA TABELA, CARREGA NOS CAMPOS
        private void dgvAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAlunos.CurrentRow != null)
            {
                txtNome.Text = dgvAlunos.CurrentRow.Cells["nome_aluno"].Value.ToString();
                txtSobrenome.Text = dgvAlunos.CurrentRow.Cells["sobrenome"].Value.ToString();
                dtpNascimento.Text = dgvAlunos.CurrentRow.Cells["data_nascimento"].Value.ToString();
                cmbAno.Text = dgvAlunos.CurrentRow.Cells["ano_escolar"].Value.ToString();
            }
        }

        private void dgvAlunos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sobreNos_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void dgvAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
