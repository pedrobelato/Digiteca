namespace Digiteca.Visao
{
    partial class fmClientes
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
            this.lbClientes = new System.Windows.Forms.Label();
            this.btncFechar = new System.Windows.Forms.Button();
            this.mascara = new System.Windows.Forms.Label();
            this.dgvTabClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbClientes
            // 
            this.lbClientes.AutoSize = true;
            this.lbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbClientes.Location = new System.Drawing.Point(24, 9);
            this.lbClientes.Name = "lbClientes";
            this.lbClientes.Size = new System.Drawing.Size(219, 24);
            this.lbClientes.TabIndex = 27;
            this.lbClientes.Text = "Resultado da busca por: ";
            // 
            // btncFechar
            // 
            this.btncFechar.FlatAppearance.BorderSize = 0;
            this.btncFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncFechar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btncFechar.Location = new System.Drawing.Point(610, 2);
            this.btncFechar.Name = "btncFechar";
            this.btncFechar.Size = new System.Drawing.Size(34, 31);
            this.btncFechar.TabIndex = 28;
            this.btncFechar.TabStop = false;
            this.btncFechar.Text = "x";
            this.btncFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btncFechar.UseVisualStyleBackColor = true;
            this.btncFechar.Click += new System.EventHandler(this.btncFechar_Click);
            // 
            // mascara
            // 
            this.mascara.AutoSize = true;
            this.mascara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.mascara.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mascara.ForeColor = System.Drawing.Color.Red;
            this.mascara.Location = new System.Drawing.Point(249, 12);
            this.mascara.Name = "mascara";
            this.mascara.Size = new System.Drawing.Size(0, 24);
            this.mascara.TabIndex = 27;
            // 
            // dgvTabClientes
            // 
            this.dgvTabClientes.AllowUserToAddRows = false;
            this.dgvTabClientes.AllowUserToDeleteRows = false;
            this.dgvTabClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabClientes.Location = new System.Drawing.Point(12, 39);
            this.dgvTabClientes.Name = "dgvTabClientes";
            this.dgvTabClientes.ReadOnly = true;
            this.dgvTabClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabClientes.Size = new System.Drawing.Size(618, 239);
            this.dgvTabClientes.TabIndex = 29;
            this.dgvTabClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabClientes_CellDoubleClick);
            // 
            // fmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(642, 290);
            this.Controls.Add(this.dgvTabClientes);
            this.Controls.Add(this.btncFechar);
            this.Controls.Add(this.mascara);
            this.Controls.Add(this.lbClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbClientes;
        private System.Windows.Forms.Button btncFechar;
        public System.Windows.Forms.Label mascara;
        public System.Windows.Forms.DataGridView dgvTabClientes;
    }
}