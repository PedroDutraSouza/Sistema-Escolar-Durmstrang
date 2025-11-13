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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void sobreNos_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void entrar_Click(object sender, EventArgs e)
        {
            // Validação simples dos campos obrigatórios

            if (nomeMatricula.Text == "" || emailMatricula.Text == "" || celularMatricula.Text == "" || periodoLetivoMatricula.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Simulação de envio do pedido de matrícula
            else
            {
                MessageBox.Show("Pedido de matrícula enviado! Sua coruja chegará em breve.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }
    }
}
