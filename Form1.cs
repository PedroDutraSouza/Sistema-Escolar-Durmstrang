using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Durmstrang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sobreNos_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void gradeCurricular_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void matriculeJa_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void entrar_Click(object sender, EventArgs e)
        {
            // Validação simples dos campos obrigatórios 
            if (login.Text == "" || senha.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Simulação de login
            if (login.Text == "admin" && senha.Text == "1234")
            {
                // Abrir o Form5 após o login bem-sucedido
                Form5 form5 = new Form5();
                form5.Show();
                this.Hide();
            }
            else

          
            // Simulação de login para professor
            if (login.Text == "professor" && senha.Text == "4321")
            {
                // Abrir o Form5 após o login bem-sucedido
                Form10 form10 = new Form10();
                form10.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login ou senha incorretos. Tente novamente.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
