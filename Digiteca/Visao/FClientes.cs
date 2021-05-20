using Digiteca.Controller;
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
using Ubiety.Dns.Core.Records.NotUsed;

namespace Digiteca.Visao
{
    public partial class fmClientes : Form, IObservada
    {
        private List<IObservador> listaObservadores = new List<IObservador>();
        string acao = "";
        public fmClientes()
        {
            InitializeComponent();
        }

        public void adicionarObservadores(IObservador observador)
        {
            listaObservadores.Add(observador);
        }

        public void notificarObservadores()
        {
            foreach (IObservador observador in listaObservadores)
            {
                DataGridViewRow linha = dgvTabClientes.CurrentRow;
                observador.notificar(acao, linha.Cells[2].Value.ToString(), // nome Usuário
                                            linha.Cells[1].Value.ToString()); // código
            }
            this.Close();
        }

        private void btncFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTabClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            acao = "PUC";
            if (!dgvTabClientes.CurrentRow.IsNewRow)
                notificarObservadores();
        }
    }
}
