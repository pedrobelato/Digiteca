using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Digiteca.Visao;

namespace Digiteca
{
    public partial class fmMain : Form
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

        public fmMain()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnReserva.Height;
            pnlNav.Top = btnReserva.Top;
            pnlNav.Left = btnReserva.Left;
            btnReserva.PerformClick();
            abrirFormularioPanel<fmReserva>();
        }

        private void abrirFormularioPanel<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelConteudo.Controls.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelConteudo.Controls.Add(formulario);
                panelConteudo.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                    formulario.WindowState = FormWindowState.Normal;
                formulario.BringToFront();
            }
        }

        private void btnEmprestimo_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnEmprestimo.Height;
            pnlNav.Top = btnEmprestimo.Top;
            pnlNav.Left = btnEmprestimo.Left;
            btnEmprestimo.BackColor = Color.FromArgb(46, 51, 73);
            abrirFormularioPanel<fmEmprestimo>();
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnReserva.Height;
            pnlNav.Top = btnReserva.Top;
            pnlNav.Left = btnReserva.Left;
            btnReserva.BackColor = Color.FromArgb(46, 51, 73);
            abrirFormularioPanel<fmReserva>();
        }

        private void btnReserva_Leave(object sender, EventArgs e)
        {
            btnReserva.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnEmprestimo_Leave(object sender, EventArgs e)
        {
           btnEmprestimo.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
