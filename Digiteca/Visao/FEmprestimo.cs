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
        DataTable dtLivrosSel = new DataTable();

        public fmEmprestimo()
        {
            InitializeComponent();
            dtpDataEmprestimo.Value = DateTime.Now;
            dtLivrosSel.Columns.Add("Código Livro");
            dtLivrosSel.Columns.Add("Titulo do Livro");
            dtLivrosSel.Columns.Add("Quantidade");
            dtLivrosSel.Columns.Add("Nome da Editora");

            dgvLivrosSel.DataSource = dtLivrosSel;
            lbCpf.Visible = false;
            lbCodUsu.Visible = false;
        }

        private void btnPesqUsu_Click(object sender, EventArgs e)
        {
            acao = "PU";
            notificarObservadores();
        }

        public void adicionarObservadores(IObservador observador)
        {
            listaObservadores.Add(observador);
        }

        public void notificarObservadores()
        {
            foreach (IObservador observador in listaObservadores)
            {
                if (acao == "PLE")
                {
                    observador.notificar(acao, tbPesqLivro.Text);
                }
                else if (acao == "PU")
                {
                    observador.notificar(acao, 2, tbUsuario.Text);
                }
                else if (acao == "IE") // Incluir Empréstimo
                {
                    observador.notificar(acao, tbPesqLivro.Text,
                                                tbUsuario.Text);
                }
            }
        }

        private bool ValidarCampos()
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
            if (ValidarCampos())
            {
                acao = "IE";
                notificarObservadores();
            }
            else
                MessageBox.Show("Ainda há campos faltando preenchimento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnPesqLivro_Click(object sender, EventArgs e)
        {
            acao = "PLE";
            notificarObservadores();
        }

        private DataRow adicionarLinha(DataGridViewRow linha)
        {
            DataRow novaLinha = dtLivrosSel.NewRow();
            novaLinha[0] = linha.Cells[0].Value;
            novaLinha[1] = linha.Cells[1].Value;
            novaLinha[2] = linha.Cells[2].Value;
            return novaLinha;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!dgvLivrosPesq.CurrentRow.IsNewRow)
            {
                dtLivrosSel.Rows.Add(adicionarLinha(dgvLivrosPesq.CurrentRow));
                dgvLivrosSel.DataSource = dtLivrosSel;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!dgvLivrosSel.CurrentRow.IsNewRow)
            {
                if (this.dgvLivrosSel.SelectedRows.Count > 0 &&
                            this.dgvLivrosSel.SelectedRows[0].Index !=
                            this.dgvLivrosSel.Rows.Count)
                {
                    this.dgvLivrosSel.Rows.RemoveAt(
                        this.dgvLivrosSel.SelectedRows[0].Index);
                }   
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
                dgvLivrosPesq.Rows.Count == 0 &&
                dgvLivrosSel.Rows.Count == 0)
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
                    dgvLivrosPesq.Rows.Clear();
                    dgvLivrosSel.Rows.Clear();
                    dtpDataEmprestimo.Value = DateTime.Now;
                }
            }
            else
                MessageBox.Show("Não há dados para limpar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {
            lbCpf.Visible = false;
            lbCodUsu.Visible = false;
        }
    }
}
