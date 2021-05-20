using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Digiteca.Controller;

namespace Digiteca.Visao
{
    public partial class fmEmprestimo : Form, IObservada
    {
        private List<IObservador> listaObservadores = new List<IObservador>();
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

        public void adicionarObservadores(IObservador observador)
        {
            listaObservadores.Add(observador);
        }

        public void notificarObservadores()
        {

        }

        private Boolean validar()
        {
            if(tbPesqLivro.Text == "")
            {
                return false;
            }
            else 
            if(tbUsuario.Text == "")
            {
                return false;
            }
            else
            if(tbBibliotecaria.Text == "")
            {
                return false;
            }
            else
            if(dtpDataEmprestimo.Value < DateTime.Now)
            {
                return false;
            }
            else
            if(dtpDevolucao.Value < DateTime.Now)
            {
                return false;
            }
            return true;
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }
    }
}
