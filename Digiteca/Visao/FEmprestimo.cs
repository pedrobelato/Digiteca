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
        string acao = "";
        public fmEmprestimo()
        {
            InitializeComponent();
            
            //adicionarObservadores();
            listaLivrosPesq.View = View.Details;
            listaLivrosPesq.Columns.Add("Código", 70);
            listaLivrosPesq.Columns.Add("Nome do Livro", 190);
            listaLivrosPesq.Columns.Add("Autor", 70);
            listaLivrosPesq.Columns.Add("Ano", 50);

            listaLivrosSel.View = View.Details;
            listaLivrosSel.Columns.Add("Código", 70);
            listaLivrosSel.Columns.Add("Nome do Livro", 190);
            listaLivrosSel.Columns.Add("Autor", 70);
            listaLivrosSel.Columns.Add("Ano", 50);

            ListViewItem item = new ListViewItem(new[] { "1", "Harry Potter", "Pedrão", "2000" });
            ListViewItem item1 = new ListViewItem(new[] { "2", "Harry Potter", "Pedrão", "2000" });
            ListViewItem item2 = new ListViewItem(new[] { "3", "Harry Potter", "Pedrão", "2000" });
            listaLivrosPesq.Items.Add(item);
            listaLivrosPesq.Items.Add(item1);
            listaLivrosPesq.Items.Add(item2);
        }

        private void btnPesqUsu_Click(object sender, EventArgs e)
        {
            acao = "PU";
            notificarObservadores();
            /*var form = Application.OpenForms["fmClientes"];
            if (form != null)
                form.Close();
            form = new fmClientes();
            form.Show();*/
        }

        public void adicionarObservadores(IObservador observador)
        {
            listaObservadores.Add(observador);
        }

        public void notificarObservadores()
        {
            foreach (IObservador observador in listaObservadores)
            {
                if (acao == "PL")
                {
                    observador.notificar(acao, tbPesqLivro.Text);
                }
                else if (acao == "PU")
                {
                    observador.notificar(acao, tbUsuario.Text);
                }
                else if (acao == "IE") // Incluir Empréstimo
                {
                    observador.notificar(acao, tbPesqLivro.Text,
                                                tbUsuario.Text);
                }
            }
        }

        private bool validar()
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

        private void btnPesqLivro_Click(object sender, EventArgs e)
        {
            acao = "PL";
            notificarObservadores();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            foreach (int i in listaLivrosPesq.SelectedIndices)
            {
                var item = listaLivrosPesq.Items[i];
                listaLivrosPesq.Items.RemoveAt(i);
                listaLivrosSel.Items.Add(item);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            foreach (int i in listaLivrosSel.SelectedIndices)
            {
                var item = listaLivrosSel.Items[i];
                listaLivrosSel.Items.RemoveAt(i);
                listaLivrosPesq.Items.Add(item);
            }
        }

        private void dtpDataEmprestimo_ValueChanged(object sender, EventArgs e)
        {
            dtpDevolucao.Value = dtpDataEmprestimo.Value.AddDays(28);
        }

        private bool existeDados()
        {
            if (tbPesqLivro.Text == "" && tbUsuario.Text == "" &&
                Convert.ToDateTime(dtpDataEmprestimo.Value).ToShortDateString() == DateTime.Now.ToShortDateString() && 
                listaLivrosPesq.Items.Count == 0 &&
                listaLivrosSel.Items.Count == 0)
            {
                return false;
            }
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (existeDados())
            {
                if (MessageBox.Show("Deseja cancelar a reserva do livro e limpar os campos ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    tbPesqLivro.Text = "";
                    tbUsuario.Text = "";
                    tbBibliotecaria.Text = "";
                    listaLivrosPesq.Items.Clear();
                    listaLivrosSel.Items.Clear();
                    dtpDataEmprestimo.Value = DateTime.Now;
                }
            }
            else
                MessageBox.Show("Não há dados para limpar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
