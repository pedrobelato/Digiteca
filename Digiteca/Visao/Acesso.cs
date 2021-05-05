﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Digiteca.Visao
{
    public partial class fmAcesso : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
             int nLeftRect,
             int nTopRect,
             int nRightRect,
             int nBottomRect,
             int nWidthEllipse,
             int nHeightEllipse
         );
        public fmAcesso()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            tbSenha2.PasswordChar = '*';
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text == "nome" && tbSenha.Text == "senha") //teste
            {
                Hide();
                fmMain var = new fmMain();
                var.ShowDialog();
                Close();
            }
            else
            {
                lbNotificar.Text = "Usuário ou senha incorreto";
                Task.Delay(1500).Wait();
                lbNotificar.Text = "";
            }
        }

        private void tbLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.PerformClick();
            }
        }

        private void tbSenha2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.PerformClick();
            }
        }

        private void btnMostrar_MouseDown(object sender, MouseEventArgs e)
        {
            tbSenha2.Hide();
        }

        private void btnMostrar_MouseUp(object sender, MouseEventArgs e)
        {
            tbSenha2.Show();
            tbSenha2.Select();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tbSenha.Text = tbSenha2.Text;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }     
}