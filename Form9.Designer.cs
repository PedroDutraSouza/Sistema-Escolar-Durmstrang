namespace Durmstrang
{
    partial class Form9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pesquisaT = new System.Windows.Forms.Button();
            this.digiteT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mostrarTurmas = new System.Windows.Forms.DataGridView();
            this.anoTurma = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sobreNos = new System.Windows.Forms.Button();
            this.capAlunos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.limparT = new System.Windows.Forms.Button();
            this.excluirT = new System.Windows.Forms.Button();
            this.editarT = new System.Windows.Forms.Button();
            this.salvarT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nomeT = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarTurmas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pesquisaT
            // 
            this.pesquisaT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.pesquisaT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pesquisaT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pesquisaT.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisaT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(181)))), ((int)(((byte)(90)))));
            this.pesquisaT.Location = new System.Drawing.Point(737, 143);
            this.pesquisaT.Margin = new System.Windows.Forms.Padding(2);
            this.pesquisaT.Name = "pesquisaT";
            this.pesquisaT.Size = new System.Drawing.Size(98, 36);
            this.pesquisaT.TabIndex = 89;
            this.pesquisaT.Text = "Pesquisar";
            this.pesquisaT.UseVisualStyleBackColor = false;
            this.pesquisaT.Click += new System.EventHandler(this.pesquisaT_Click);
            // 
            // digiteT
            // 
            this.digiteT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(208)))), ((int)(((byte)(185)))));
            this.digiteT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.digiteT.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digiteT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.digiteT.Location = new System.Drawing.Point(420, 157);
            this.digiteT.Margin = new System.Windows.Forms.Padding(2);
            this.digiteT.Name = "digiteT";
            this.digiteT.Size = new System.Drawing.Size(313, 23);
            this.digiteT.TabIndex = 88;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.label6.Font = new System.Drawing.Font("Matura MT Script Capitals", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(181)))), ((int)(((byte)(90)))));
            this.label6.Location = new System.Drawing.Point(417, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 83;
            this.label6.Text = "Digite a Turma:";
            // 
            // mostrarTurmas
            // 
            this.mostrarTurmas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(208)))), ((int)(((byte)(185)))));
            this.mostrarTurmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostrarTurmas.Location = new System.Drawing.Point(420, 184);
            this.mostrarTurmas.Margin = new System.Windows.Forms.Padding(2);
            this.mostrarTurmas.Name = "mostrarTurmas";
            this.mostrarTurmas.RowHeadersWidth = 51;
            this.mostrarTurmas.RowTemplate.Height = 24;
            this.mostrarTurmas.Size = new System.Drawing.Size(416, 351);
            this.mostrarTurmas.TabIndex = 82;
            // 
            // anoTurma
            // 
            this.anoTurma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(208)))), ((int)(((byte)(185)))));
            this.anoTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anoTurma.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anoTurma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.anoTurma.FormattingEnabled = true;
            this.anoTurma.Items.AddRange(new object[] {
            "1ª Série",
            "2ª Série",
            "3ª Série",
            "4ª Série",
            "5ª Série",
            "6ª Série",
            "7ª Série"});
            this.anoTurma.Location = new System.Drawing.Point(45, 200);
            this.anoTurma.Margin = new System.Windows.Forms.Padding(2);
            this.anoTurma.Name = "anoTurma";
            this.anoTurma.Size = new System.Drawing.Size(348, 24);
            this.anoTurma.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.label2.Font = new System.Drawing.Font("Matura MT Script Capitals", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(181)))), ((int)(((byte)(90)))));
            this.label2.Location = new System.Drawing.Point(42, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 77;
            this.label2.Text = "Série:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(181)))), ((int)(((byte)(90)))));
            this.label1.Location = new System.Drawing.Point(266, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 51);
            this.label1.TabIndex = 76;
            this.label1.Text = "Cadastrar Turma";
            // 
            // sobreNos
            // 
            this.sobreNos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.sobreNos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sobreNos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sobreNos.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobreNos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(181)))), ((int)(((byte)(90)))));
            this.sobreNos.Location = new System.Drawing.Point(9, 10);
            this.sobreNos.Margin = new System.Windows.Forms.Padding(2);
            this.sobreNos.Name = "sobreNos";
            this.sobreNos.Size = new System.Drawing.Size(88, 36);
            this.sobreNos.TabIndex = 75;
            this.sobreNos.Text = "<- Voltar";
            this.sobreNos.UseVisualStyleBackColor = false;
            this.sobreNos.Click += new System.EventHandler(this.sobreNos_Click);
            // 
            // capAlunos
            // 
            this.capAlunos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(208)))), ((int)(((byte)(185)))));
            this.capAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.capAlunos.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capAlunos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.capAlunos.FormattingEnabled = true;
            this.capAlunos.Items.AddRange(new object[] {
            "30",
            "35",
            "40",
            "45"});
            this.capAlunos.Location = new System.Drawing.Point(45, 243);
            this.capAlunos.Margin = new System.Windows.Forms.Padding(2);
            this.capAlunos.Name = "capAlunos";
            this.capAlunos.Size = new System.Drawing.Size(348, 24);
            this.capAlunos.TabIndex = 96;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.label7.Font = new System.Drawing.Font("Matura MT Script Capitals", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(181)))), ((int)(((byte)(90)))));
            this.label7.Location = new System.Drawing.Point(42, 224);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 16);
            this.label7.TabIndex = 97;
            this.label7.Text = "Capacidade de Alunos:";
            // 
            // limparT
            // 
            this.limparT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.limparT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limparT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limparT.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limparT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(181)))), ((int)(((byte)(90)))));
            this.limparT.Location = new System.Drawing.Point(317, 301);
            this.limparT.Margin = new System.Windows.Forms.Padding(2);
            this.limparT.Name = "limparT";
            this.limparT.Size = new System.Drawing.Size(74, 36);
            this.limparT.TabIndex = 101;
            this.limparT.Text = "Limpar";
            this.limparT.UseVisualStyleBackColor = false;
            this.limparT.Click += new System.EventHandler(this.limparT_Click);
            // 
            // excluirT
            // 
            this.excluirT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.excluirT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excluirT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirT.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(181)))), ((int)(((byte)(90)))));
            this.excluirT.Location = new System.Drawing.Point(226, 301);
            this.excluirT.Margin = new System.Windows.Forms.Padding(2);
            this.excluirT.Name = "excluirT";
            this.excluirT.Size = new System.Drawing.Size(74, 36);
            this.excluirT.TabIndex = 100;
            this.excluirT.Text = "Excluir";
            this.excluirT.UseVisualStyleBackColor = false;
            this.excluirT.Click += new System.EventHandler(this.excluirT_Click);
            // 
            // editarT
            // 
            this.editarT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.editarT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editarT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarT.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(181)))), ((int)(((byte)(90)))));
            this.editarT.Location = new System.Drawing.Point(136, 301);
            this.editarT.Margin = new System.Windows.Forms.Padding(2);
            this.editarT.Name = "editarT";
            this.editarT.Size = new System.Drawing.Size(74, 36);
            this.editarT.TabIndex = 99;
            this.editarT.Text = "Editar";
            this.editarT.UseVisualStyleBackColor = false;
            this.editarT.Click += new System.EventHandler(this.editarT_Click);
            // 
            // salvarT
            // 
            this.salvarT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.salvarT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salvarT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salvarT.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(181)))), ((int)(((byte)(90)))));
            this.salvarT.Location = new System.Drawing.Point(45, 301);
            this.salvarT.Margin = new System.Windows.Forms.Padding(2);
            this.salvarT.Name = "salvarT";
            this.salvarT.Size = new System.Drawing.Size(74, 36);
            this.salvarT.TabIndex = 98;
            this.salvarT.Text = "Salvar";
            this.salvarT.UseVisualStyleBackColor = false;
            this.salvarT.Click += new System.EventHandler(this.salvarT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.label3.Font = new System.Drawing.Font("Matura MT Script Capitals", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(181)))), ((int)(((byte)(90)))));
            this.label3.Location = new System.Drawing.Point(42, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 103;
            this.label3.Text = "Nome:";
            // 
            // nomeT
            // 
            this.nomeT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(208)))), ((int)(((byte)(185)))));
            this.nomeT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeT.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.nomeT.Location = new System.Drawing.Point(45, 157);
            this.nomeT.Margin = new System.Windows.Forms.Padding(2);
            this.nomeT.Name = "nomeT";
            this.nomeT.Size = new System.Drawing.Size(347, 23);
            this.nomeT.TabIndex = 102;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.pictureBox3.Image = global::Durmstrang.Properties.Resources.DurmstrangCrest;
            this.pictureBox3.Location = new System.Drawing.Point(746, -63);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(111, 278);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 104;
            this.pictureBox3.TabStop = false;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(868, 574);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nomeT);
            this.Controls.Add(this.limparT);
            this.Controls.Add(this.excluirT);
            this.Controls.Add(this.editarT);
            this.Controls.Add(this.salvarT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.capAlunos);
            this.Controls.Add(this.pesquisaT);
            this.Controls.Add(this.digiteT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mostrarTurmas);
            this.Controls.Add(this.anoTurma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sobreNos);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.mostrarTurmas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button pesquisaT;
        private System.Windows.Forms.TextBox digiteT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView mostrarTurmas;
        private System.Windows.Forms.ComboBox anoTurma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sobreNos;
        private System.Windows.Forms.ComboBox capAlunos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button limparT;
        private System.Windows.Forms.Button excluirT;
        private System.Windows.Forms.Button editarT;
        private System.Windows.Forms.Button salvarT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomeT;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}