﻿namespace Digiteca.Visao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmReserva));
            this.tbPesqLivro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPesqUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataReserva = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnPesqUsu = new System.Windows.Forms.Button();
            this.btnPesqLivro = new System.Windows.Forms.Button();
            this.lbCpf = new System.Windows.Forms.Label();
            this.lbCodUsu = new System.Windows.Forms.Label();
            this.dgvTabLivro = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPesqLivro
            // 
            this.tbPesqLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tbPesqLivro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPesqLivro.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPesqLivro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbPesqLivro.Location = new System.Drawing.Point(12, 121);
            this.tbPesqLivro.Multiline = true;
            this.tbPesqLivro.Name = "tbPesqLivro";
            this.tbPesqLivro.Size = new System.Drawing.Size(327, 34);
            this.tbPesqLivro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(8, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Digite o nome do livro para pesquisar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(12, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Digite o nome do usuário para pesquisar:";
            // 
            // tbPesqUsuario
            // 
            this.tbPesqUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tbPesqUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPesqUsuario.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPesqUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tbPesqUsuario.Location = new System.Drawing.Point(16, 409);
            this.tbPesqUsuario.Multiline = true;
            this.tbPesqUsuario.Name = "tbPesqUsuario";
            this.tbPesqUsuario.Size = new System.Drawing.Size(327, 34);
            this.tbPesqUsuario.TabIndex = 3;
            this.tbPesqUsuario.TextChanged += new System.EventHandler(this.tbPesqUsuario_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(606, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Data da Reserva";
            // 
            // dtpDataReserva
            // 
            this.dtpDataReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataReserva.Location = new System.Drawing.Point(591, 410);
            this.dtpDataReserva.Name = "dtpDataReserva";
            this.dtpDataReserva.Size = new System.Drawing.Size(162, 20);
            this.dtpDataReserva.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label4.Location = new System.Drawing.Point(251, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "Realizar Reserva";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::Digiteca.Properties.Resources.iconfinder_cancel_2_309095;
            this.btnCancelar.Location = new System.Drawing.Point(273, 504);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 61);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Image = global::Digiteca.Properties.Resources.iconfinder_check_326572;
            this.btnConfirmar.Location = new System.Drawing.Point(405, 504);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(85, 61);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnPesqUsu
            // 
            this.btnPesqUsu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesqUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesqUsu.Image = ((System.Drawing.Image)(resources.GetObject("btnPesqUsu.Image")));
            this.btnPesqUsu.Location = new System.Drawing.Point(348, 409);
            this.btnPesqUsu.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesqUsu.Name = "btnPesqUsu";
            this.btnPesqUsu.Size = new System.Drawing.Size(35, 34);
            this.btnPesqUsu.TabIndex = 4;
            this.btnPesqUsu.UseVisualStyleBackColor = true;
            this.btnPesqUsu.Click += new System.EventHandler(this.btnPesqUsu_Click);
            // 
            // btnPesqLivro
            // 
            this.btnPesqLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesqLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesqLivro.Image = ((System.Drawing.Image)(resources.GetObject("btnPesqLivro.Image")));
            this.btnPesqLivro.Location = new System.Drawing.Point(344, 121);
            this.btnPesqLivro.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesqLivro.Name = "btnPesqLivro";
            this.btnPesqLivro.Size = new System.Drawing.Size(33, 34);
            this.btnPesqLivro.TabIndex = 2;
            this.btnPesqLivro.UseVisualStyleBackColor = true;
            this.btnPesqLivro.Click += new System.EventHandler(this.btnPesqLivro_Click);
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpf.ForeColor = System.Drawing.Color.Red;
            this.lbCpf.Location = new System.Drawing.Point(12, 446);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(52, 24);
            this.lbCpf.TabIndex = 13;
            this.lbCpf.Text = "CPF:";
            // 
            // lbCodUsu
            // 
            this.lbCodUsu.AutoSize = true;
            this.lbCodUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodUsu.ForeColor = System.Drawing.Color.Red;
            this.lbCodUsu.Location = new System.Drawing.Point(70, 446);
            this.lbCodUsu.Name = "lbCodUsu";
            this.lbCodUsu.Size = new System.Drawing.Size(0, 24);
            this.lbCodUsu.TabIndex = 13;
            // 
            // dgvTabLivro
            // 
            this.dgvTabLivro.AllowUserToAddRows = false;
            this.dgvTabLivro.AllowUserToDeleteRows = false;
            this.dgvTabLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabLivro.Location = new System.Drawing.Point(12, 181);
            this.dgvTabLivro.Name = "dgvTabLivro";
            this.dgvTabLivro.ReadOnly = true;
            this.dgvTabLivro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabLivro.Size = new System.Drawing.Size(741, 198);
            this.dgvTabLivro.TabIndex = 18;
            this.dgvTabLivro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabLivro_CellDoubleClick);
            // 
            // fmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(765, 577);
            this.Controls.Add(this.dgvTabLivro);
            this.Controls.Add(this.dtpDataReserva);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPesqUsuario);
            this.Controls.Add(this.btnPesqUsu);
            this.Controls.Add(this.lbCodUsu);
            this.Controls.Add(this.lbCpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Button btnPesqLivro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesqUsu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpDataReserva;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbPesqUsuario;
        public System.Windows.Forms.Label lbCpf;
        public System.Windows.Forms.Label lbCodUsu;
        public System.Windows.Forms.TextBox tbPesqLivro;
        public System.Windows.Forms.DataGridView dgvTabLivro;
    }
}