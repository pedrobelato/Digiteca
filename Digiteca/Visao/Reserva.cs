using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Digiteca.Controller;

namespace Digiteca.Visao
{
    public partial class fmReserva : Form, IObservada
    {
        private List<IObservador> listaObservadores = new List<IObservador>();
        string acao = "";
        public fmReserva()
        {
            InitializeComponent();
            dtpDataReserva.Value = DateTime.Now;
        }

        public void adicionarObservadores(IObservador observador)
        {
            listaObservadores.Add(observador);
        }

        public void notificarObservadores()
        {
            foreach (IObservador observador in listaObservadores)
            {
                if (acao == "IR")
                {
                    observador.notificar(acao, tbPesqUsuario.Text,
                                               dtpDataReserva.Value,
                                               dgvTabLivro.CurrentRow.Cells[0].Value.ToString(), // codigo do titulo
                                               dgvTabLivro.CurrentRow.Cells[1].Value.ToString()); // número do exemplar
                }
                else if (acao == "PU")
                {
                    observador.notificar(acao, tbPesqUsuario.Text);
                }
                else if (acao == "PL")
                {
                    observador.notificar(acao, tbPesqLivro.Text);
                }
            }
        }

        private void btnPesqUsu_Click(object sender, System.EventArgs e)
        {
            acao = "PU";
            notificarObservadores();
        }

        private void btnPesqLivro_Click(object sender, EventArgs e)
        {
            acao = "PL";
            notificarObservadores();
        }

        private bool ValidarCampos()
        {
            if (tbPesqLivro.Text == "")
            {
                return false;
            }
            else if (dgvTabLivro.RowCount == 0)
            {
                return false;
            }
            else if (tbPesqUsuario.Text == "")
            {
                return false;
            }
            return true;
        }

        private bool existeDados()
        {
            if (tbPesqLivro.Text == "" && tbPesqUsuario.Text == "" &&
                Convert.ToDateTime(dtpDataReserva.Value).ToShortDateString() == DateTime.Now.ToShortDateString() && dgvTabLivro.RowCount == 0)
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
                    tbPesqUsuario.Text = "";
                    for (int i = 0; i < dgvTabLivro.RowCount; i++)
                    {
                        dgvTabLivro.Rows[i].DataGridView.Columns.Clear();
                    }
                    dtpDataReserva.Value = DateTime.Now;
                }
            }
            else
                MessageBox.Show("Não há dados para limpar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                acao = "IR";
                notificarObservadores();
            }
            else
                MessageBox.Show("Ainda há campos faltando preenchimento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
