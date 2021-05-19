using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digiteca.Visao
{
    public partial class fmEmprestimo : Form
    {
        public fmEmprestimo()
        {
            InitializeComponent();
        }

        private void btnPesqUsu_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms["fmClientes"];
            if (form != null)
                form.Close();
            form = new fmClientes();
            form.Show();
        }
    }
}
