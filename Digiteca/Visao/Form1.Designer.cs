namespace Digiteca
{
    partial class fmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelNav = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnEmprestimo = new System.Windows.Forms.Button();
            this.btnReserva = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTexto = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.panelNav.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(54)))));
            this.panelNav.Controls.Add(this.btnSair);
            this.panelNav.Controls.Add(this.pnlNav);
            this.panelNav.Controls.Add(this.btnEmprestimo);
            this.panelNav.Controls.Add(this.btnReserva);
            this.panelNav.Controls.Add(this.panel2);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(186, 577);
            this.panelNav.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSair.Location = new System.Drawing.Point(0, 535);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(186, 42);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(3, 234);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 4;
            // 
            // btnEmprestimo
            // 
            this.btnEmprestimo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmprestimo.FlatAppearance.BorderSize = 0;
            this.btnEmprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmprestimo.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprestimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnEmprestimo.Location = new System.Drawing.Point(0, 186);
            this.btnEmprestimo.Name = "btnEmprestimo";
            this.btnEmprestimo.Size = new System.Drawing.Size(186, 42);
            this.btnEmprestimo.TabIndex = 3;
            this.btnEmprestimo.Text = "Realizar Empréstimo";
            this.btnEmprestimo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEmprestimo.UseVisualStyleBackColor = true;
            this.btnEmprestimo.Click += new System.EventHandler(this.btnEmprestimo_Click);
            this.btnEmprestimo.Leave += new System.EventHandler(this.btnEmprestimo_Leave);
            // 
            // btnReserva
            // 
            this.btnReserva.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReserva.FlatAppearance.BorderSize = 0;
            this.btnReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserva.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnReserva.Location = new System.Drawing.Point(0, 144);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(186, 42);
            this.btnReserva.TabIndex = 2;
            this.btnReserva.Text = "Realizar Reserva";
            this.btnReserva.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReserva.UseVisualStyleBackColor = true;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            this.btnReserva.Leave += new System.EventHandler(this.btnReserva_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbTexto);
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 1;
            // 
            // lbTexto
            // 
            this.lbTexto.AutoSize = true;
            this.lbTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.lbTexto.Location = new System.Drawing.Point(73, 123);
            this.lbTexto.Name = "lbTexto";
            this.lbTexto.Size = new System.Drawing.Size(33, 12);
            this.lbTexto.TabIndex = 2;
            this.lbTexto.Text = "Texto";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbName.Location = new System.Drawing.Point(66, 97);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(49, 16);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Nome";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelConteudo
            // 
            this.panelConteudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(186, 0);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(765, 577);
            this.panelConteudo.TabIndex = 2;
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.panelConteudo);
            this.Controls.Add(this.panelNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.panelNav.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnEmprestimo;
        private System.Windows.Forms.Button btnReserva;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTexto;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.Button btnSair;
    }
}

