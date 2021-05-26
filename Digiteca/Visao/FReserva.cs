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
            lbCpf.Visible = false;
            lbCodUsu.Visible = false;
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
                    observador.notificar(acao, lbCodUsu.Text,
                                               dgvTabLivro.CurrentRow.Cells[0].Value.ToString(), // codigo do titulo
                                               dtpDataReserva.Value);
                }
                else if (acao == "PU")
                {
                    observador.notificar(acao, 1, tbPesqUsuario.Text);
                }
                else if (acao == "PL")
                {
                    observador.notificar(acao, tbPesqLivro.Text);
                }
            }
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
            limparTela(false);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                acao = "IR";
                notificarObservadores();
                limparTela(true);
            }
            else
                MessageBox.Show("Ainda há campos faltando preenchimento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void limparTela(bool Gravado)
        {
            if (existeDados())
            {
                if (Gravado)
                {
                    tbPesqLivro.Text = "";
                    tbPesqUsuario.Text = "";
                    for (int i = 0; i < dgvTabLivro.RowCount; i++)
                    {
                        dgvTabLivro.Rows[i].DataGridView.Columns.Clear();
                    }
                    dtpDataReserva.Value = DateTime.Now;
                }
                else if (MessageBox.Show("Deseja cancelar a reserva do livro e limpar os campos ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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

        private void btnPesqUsu_Click(object sender, System.EventArgs e)
        {
            acao = "PU";
            notificarObservadores();
        }

        private void tbPesqUsuario_TextChanged(object sender, EventArgs e)
        {
            lbCpf.Visible = false;
            lbCodUsu.Visible = false;
        }

        private void dgvTabLivro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!dgvTabLivro.CurrentRow.IsNewRow)
            {
                tbPesqLivro.Text = dgvTabLivro.CurrentRow.Cells[1].Value.ToString();
            }
        }
    }
}
