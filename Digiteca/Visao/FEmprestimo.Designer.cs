namespace Digiteca.Visao
{
    partial class fmEmprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmEmprestimo));
            this.label1 = new System.Windows.Forms.Label();
            this.tbPesqLivro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.dtpDataEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.tbBibliotecaria = new System.Windows.Forms.TextBox();
            this.dtpDevolucao = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPesqUsu = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPesqLivro = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.listaLivrosPesq = new System.Windows.Forms.ListView();
            this.listaLivrosSel = new System.Windows.Forms.ListView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Pesquisar Livro";
            // 
            // tbPesqLivro
            // 
            this.tbPesqLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tbPesqLivro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPesqLivro.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPesqLivro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbPesqLivro.Location = new System.Drawing.Point(12, 89);
            this.tbPesqLivro.Multiline = true;
            this.tbPesqLivro.Name = "tbPesqLivro";
            this.tbPesqLivro.Size = new System.Drawing.Size(292, 20);
            this.tbPesqLivro.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(490, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Livros selecionados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(8, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nome do usuário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label4.Location = new System.Drawing.Point(8, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Data do empréstimo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label5.Location = new System.Drawing.Point(619, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "Bibliotecária(o)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label6.Location = new System.Drawing.Point(586, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Data de devolução";
            // 
            // tbUsuario
            // 
            this.tbUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsuario.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbUsuario.Location = new System.Drawing.Point(12, 364);
            this.tbUsuario.Multiline = true;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(250, 20);
            this.tbUsuario.TabIndex = 22;
            // 
            // dtpDataEmprestimo
            // 
            this.dtpDataEmprestimo.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataEmprestimo.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.dtpDataEmprestimo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEmprestimo.Location = new System.Drawing.Point(12, 430);
            this.dtpDataEmprestimo.Name = "dtpDataEmprestimo";
            this.dtpDataEmprestimo.Size = new System.Drawing.Size(174, 20);
            this.dtpDataEmprestimo.TabIndex = 23;
            this.dtpDataEmprestimo.ValueChanged += new System.EventHandler(this.dtpDataEmprestimo_ValueChanged);
            // 
            // tbBibliotecaria
            // 
            this.tbBibliotecaria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tbBibliotecaria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBibliotecaria.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBibliotecaria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbBibliotecaria.Location = new System.Drawing.Point(503, 364);
            this.tbBibliotecaria.Multiline = true;
            this.tbBibliotecaria.Name = "tbBibliotecaria";
            this.tbBibliotecaria.Size = new System.Drawing.Size(250, 20);
            this.tbBibliotecaria.TabIndex = 24;
            // 
            // dtpDevolucao
            // 
            this.dtpDevolucao.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDevolucao.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.dtpDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDevolucao.Location = new System.Drawing.Point(579, 430);
            this.dtpDevolucao.Name = "dtpDevolucao";
            this.dtpDevolucao.Size = new System.Drawing.Size(174, 20);
            this.dtpDevolucao.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label7.Location = new System.Drawing.Point(104, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 24);
            this.label7.TabIndex = 26;
            this.label7.Text = "Livros pesquisados";
            // 
            // btnPesqUsu
            // 
            this.btnPesqUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesqUsu.Image = global::Digiteca.Properties.Resources.buscar;
            this.btnPesqUsu.Location = new System.Drawing.Point(267, 359);
            this.btnPesqUsu.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesqUsu.Name = "btnPesqUsu";
            this.btnPesqUsu.Size = new System.Drawing.Size(37, 32);
            this.btnPesqUsu.TabIndex = 29;
            this.btnPesqUsu.UseVisualStyleBackColor = true;
            this.btnPesqUsu.Click += new System.EventHandler(this.btnPesqUsu_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Image = global::Digiteca.Properties.Resources.iconfinder_check_326572;
            this.btnConfirmar.Location = new System.Drawing.Point(405, 504);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(85, 61);
            this.btnConfirmar.TabIndex = 28;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::Digiteca.Properties.Resources.iconfinder_cancel_2_309095;
            this.btnCancelar.Location = new System.Drawing.Point(267, 504);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 61);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPesqLivro
            // 
            this.btnPesqLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesqLivro.Image = global::Digiteca.Properties.Resources.buscar;
            this.btnPesqLivro.Location = new System.Drawing.Point(309, 84);
            this.btnPesqLivro.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesqLivro.Name = "btnPesqLivro";
            this.btnPesqLivro.Size = new System.Drawing.Size(37, 32);
            this.btnPesqLivro.TabIndex = 14;
            this.btnPesqLivro.UseVisualStyleBackColor = true;
            this.btnPesqLivro.Click += new System.EventHandler(this.btnPesqLivro_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Handwriting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label8.Location = new System.Drawing.Point(217, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(360, 37);
            this.label8.TabIndex = 12;
            this.label8.Text = "Realizar Empréstimo";
            // 
            // listaLivrosPesq
            // 
            this.listaLivrosPesq.HideSelection = false;
            this.listaLivrosPesq.Location = new System.Drawing.Point(16, 157);
            this.listaLivrosPesq.Name = "listaLivrosPesq";
            this.listaLivrosPesq.Size = new System.Drawing.Size(350, 160);
            this.listaLivrosPesq.TabIndex = 30;
            this.listaLivrosPesq.UseCompatibleStateImageBehavior = false;
            // 
            // listaLivrosSel
            // 
            this.listaLivrosSel.HideSelection = false;
            this.listaLivrosSel.Location = new System.Drawing.Point(418, 157);
            this.listaLivrosSel.Name = "listaLivrosSel";
            this.listaLivrosSel.Size = new System.Drawing.Size(335, 160);
            this.listaLivrosSel.TabIndex = 30;
            this.listaLivrosSel.UseCompatibleStateImageBehavior = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.Location = new System.Drawing.Point(374, 193);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(37, 32);
            this.btnAdicionar.TabIndex = 14;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(374, 247);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(37, 32);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // fmEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(765, 577);
            this.Controls.Add(this.listaLivrosSel);
            this.Controls.Add(this.listaLivrosPesq);
            this.Controls.Add(this.btnPesqUsu);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDevolucao);
            this.Controls.Add(this.tbBibliotecaria);
            this.Controls.Add(this.dtpDataEmprestimo);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnPesqLivro);
            this.Controls.Add(this.tbPesqLivro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emprestimo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPesqLivro;
        private System.Windows.Forms.Button btnPesqLivro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.DateTimePicker dtpDataEmprestimo;
        private System.Windows.Forms.DateTimePicker dtpDevolucao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnPesqUsu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listaLivrosPesq;
        private System.Windows.Forms.ListView listaLivrosSel;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.TextBox tbBibliotecaria;
    }
}