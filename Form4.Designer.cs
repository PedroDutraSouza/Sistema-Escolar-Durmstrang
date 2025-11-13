namespace Durmstrang
{
    partial class Form4
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
            this.sobreNos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nomeMatricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailMatricula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.periodoLetivoMatricula = new System.Windows.Forms.ComboBox();
            this.celularMatricula = new System.Windows.Forms.MaskedTextBox();
            this.entrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sobreNos
            // 
            this.sobreNos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.sobreNos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sobreNos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sobreNos.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobreNos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(181)))), ((int)(((byte)(90)))));
            this.sobreNos.Location = new System.Drawing.Point(9, 10);
            this.sobreNos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sobreNos.Name = "sobreNos";
            this.sobreNos.Size = new System.Drawing.Size(88, 36);
            this.sobreNos.TabIndex = 5;
            this.sobreNos.Text = "<- Voltar";
            this.sobreNos.UseVisualStyleBackColor = false;
            this.sobreNos.Click += new System.EventHandler(this.sobreNos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(181)))), ((int)(((byte)(90)))));
            this.label1.Location = new System.Drawing.Point(604, 244);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome:";
            // 
            // nomeMatricula
            // 
            this.nomeMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(208)))), ((int)(((byte)(185)))));
            this.nomeMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeMatricula.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeMatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.nomeMatricula.Location = new System.Drawing.Point(608, 262);
            this.nomeMatricula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nomeMatricula.Name = "nomeMatricula";
            this.nomeMatricula.Size = new System.Drawing.Size(210, 23);
            this.nomeMatricula.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.label2.Font = new System.Drawing.Font("Matura MT Script Capitals", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(181)))), ((int)(((byte)(90)))));
            this.label2.Location = new System.Drawing.Point(604, 287);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "E-mail:";
            // 
            // emailMatricula
            // 
            this.emailMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(208)))), ((int)(((byte)(185)))));
            this.emailMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailMatricula.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailMatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.emailMatricula.Location = new System.Drawing.Point(608, 306);
            this.emailMatricula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailMatricula.Name = "emailMatricula";
            this.emailMatricula.Size = new System.Drawing.Size(210, 23);
            this.emailMatricula.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.label3.Font = new System.Drawing.Font("Matura MT Script Capitals", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(181)))), ((int)(((byte)(90)))));
            this.label3.Location = new System.Drawing.Point(604, 330);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Celular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.label4.Font = new System.Drawing.Font("Matura MT Script Capitals", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(181)))), ((int)(((byte)(90)))));
            this.label4.Location = new System.Drawing.Point(604, 373);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Período Letivo:";
            // 
            // periodoLetivoMatricula
            // 
            this.periodoLetivoMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(208)))), ((int)(((byte)(185)))));
            this.periodoLetivoMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.periodoLetivoMatricula.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodoLetivoMatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.periodoLetivoMatricula.FormattingEnabled = true;
            this.periodoLetivoMatricula.Items.AddRange(new object[] {
            "2026",
            "2027"});
            this.periodoLetivoMatricula.Location = new System.Drawing.Point(608, 392);
            this.periodoLetivoMatricula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.periodoLetivoMatricula.Name = "periodoLetivoMatricula";
            this.periodoLetivoMatricula.Size = new System.Drawing.Size(211, 24);
            this.periodoLetivoMatricula.TabIndex = 20;
            // 
            // celularMatricula
            // 
            this.celularMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(208)))), ((int)(((byte)(185)))));
            this.celularMatricula.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celularMatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.celularMatricula.Location = new System.Drawing.Point(608, 349);
            this.celularMatricula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.celularMatricula.Mask = "(00) 00000 - 0000";
            this.celularMatricula.Name = "celularMatricula";
            this.celularMatricula.Size = new System.Drawing.Size(211, 23);
            this.celularMatricula.TabIndex = 21;
            // 
            // entrar
            // 
            this.entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entrar.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(181)))), ((int)(((byte)(90)))));
            this.entrar.Location = new System.Drawing.Point(641, 432);
            this.entrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(139, 36);
            this.entrar.TabIndex = 22;
            this.entrar.Text = "Enviar Matrícula";
            this.entrar.UseVisualStyleBackColor = false;
            this.entrar.Click += new System.EventHandler(this.entrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.label5.Font = new System.Drawing.Font("Matura MT Script Capitals", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(181)))), ((int)(((byte)(90)))));
            this.label5.Location = new System.Drawing.Point(614, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 40);
            this.label5.TabIndex = 24;
            this.label5.Text = "Matricule-se";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.pictureBox3.Image = global::Durmstrang.Properties.Resources.DurmstrangCrest;
            this.pictureBox3.Location = new System.Drawing.Point(650, 10);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(118, 132);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Durmstrang.Properties.Resources.Carta;
            this.pictureBox1.Location = new System.Drawing.Point(-177, -65);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(722, 700);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(868, 574);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.entrar);
            this.Controls.Add(this.celularMatricula);
            this.Controls.Add(this.periodoLetivoMatricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailMatricula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomeMatricula);
            this.Controls.Add(this.sobreNos);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sobreNos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeMatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailMatricula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox periodoLetivoMatricula;
        private System.Windows.Forms.MaskedTextBox celularMatricula;
        private System.Windows.Forms.Button entrar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
    }
}