namespace Digiteca.Visao
{
    partial class fmReserva
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbPesqLivro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTabLivro = new System.Windows.Forms.DataGridView();
            this.codLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exemplar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDataReserva = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnPesqUsu = new System.Windows.Forms.Button();
            this.btnPesqLivro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPesqLivro
            // 
            this.tbPesqLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tbPesqLivro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPesqLivro.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPesqLivro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbPesqLivro.Location = new System.Drawing.Point(12, 65);
            this.tbPesqLivro.Multiline = true;
            this.tbPesqLivro.Name = "tbPesqLivro";
            this.tbPesqLivro.Size = new System.Drawing.Size(292, 20);
            this.tbPesqLivro.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pesquisar Livro";
            // 
            // dgvTabLivro
            // 
            this.dgvTabLivro.AllowUserToAddRows = false;
            this.dgvTabLivro.AllowUserToDeleteRows = false;
            this.dgvTabLivro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.dgvTabLivro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabLivro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTabLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabLivro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codLivro,
            this.exemplar,
            this.titulo,
            this.autor,
            this.Ano});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTabLivro.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTabLivro.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.dgvTabLivro.Location = new System.Drawing.Point(12, 104);
            this.dgvTabLivro.Name = "dgvTabLivro";
            this.dgvTabLivro.ReadOnly = true;
            this.dgvTabLivro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabLivro.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.dgvTabLivro.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTabLivro.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.dgvTabLivro.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.dgvTabLivro.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.dgvTabLivro.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.dgvTabLivro.Size = new System.Drawing.Size(545, 150);
            this.dgvTabLivro.TabIndex = 12;
            // 
            // codLivro
            // 
            this.codLivro.HeaderText = "Código livro";
            this.codLivro.Name = "codLivro";
            this.codLivro.ReadOnly = true;
            // 
            // exemplar
            // 
            this.exemplar.HeaderText = "Exemplar";
            this.exemplar.Name = "exemplar";
            this.exemplar.ReadOnly = true;
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Título";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            // 
            // autor
            // 
            this.autor.HeaderText = "Autor";
            this.autor.Name = "autor";
            this.autor.ReadOnly = true;
            // 
            // Ano
            // 
            this.Ano.HeaderText = "Ano";
            this.Ano.Name = "Ano";
            this.Ano.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(12, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome do Usúario";
            // 
            // tbUsuario
            // 
            this.tbUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsuario.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbUsuario.Location = new System.Drawing.Point(12, 327);
            this.tbUsuario.Multiline = true;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(158, 20);
            this.tbUsuario.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(12, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Data da Reserva";
            // 
            // tbDataReserva
            // 
            this.tbDataReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tbDataReserva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDataReserva.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDataReserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbDataReserva.Location = new System.Drawing.Point(12, 433);
            this.tbDataReserva.Multiline = true;
            this.tbDataReserva.Name = "tbDataReserva";
            this.tbDataReserva.Size = new System.Drawing.Size(158, 20);
            this.tbDataReserva.TabIndex = 17;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::Digiteca.Properties.Resources.iconfinder_cancel_2_309095;
            this.btnCancelar.Location = new System.Drawing.Point(16, 504);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 61);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Image = global::Digiteca.Properties.Resources.iconfinder_check_326572;
            this.btnConfirmar.Location = new System.Drawing.Point(119, 504);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(85, 61);
            this.btnConfirmar.TabIndex = 18;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnPesqUsu
            // 
            this.btnPesqUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesqUsu.Image = global::Digiteca.Properties.Resources.iconfinder_icon_search_211885;
            this.btnPesqUsu.Location = new System.Drawing.Point(187, 300);
            this.btnPesqUsu.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesqUsu.Name = "btnPesqUsu";
            this.btnPesqUsu.Size = new System.Drawing.Size(54, 47);
            this.btnPesqUsu.TabIndex = 14;
            this.btnPesqUsu.UseVisualStyleBackColor = true;
            // 
            // btnPesqLivro
            // 
            this.btnPesqLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesqLivro.Image = global::Digiteca.Properties.Resources.iconfinder_icon_search_211885;
            this.btnPesqLivro.Location = new System.Drawing.Point(309, 52);
            this.btnPesqLivro.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesqLivro.Name = "btnPesqLivro";
            this.btnPesqLivro.Size = new System.Drawing.Size(54, 47);
            this.btnPesqLivro.TabIndex = 9;
            this.btnPesqLivro.UseVisualStyleBackColor = true;
            // 
            // fmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(765, 577);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.tbDataReserva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.btnPesqUsu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTabLivro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesqLivro);
            this.Controls.Add(this.tbPesqLivro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmReserva";
            this.Text = "Reserva";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabLivro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPesqLivro;
        private System.Windows.Forms.Button btnPesqLivro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTabLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn exemplar;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesqUsu;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDataReserva;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
    }
}