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
        }

        public void adicionarObservadores(IObservador observador)
        {
            listaObservadores.Add(observador);
        }

        public void notificarObservadores()
        {
            foreach (IObservador observador in listaObservadores)
            {
                if (acao == "I")
                {
                    observador.notificar(acao); // ação e os parâmetros
                }
            }
        }

        private void btnPesqUsu_Click(object sender, System.EventArgs e)
        {
            var form = Application.OpenForms["fmClientes"];
            if (form != null)
                form.Close();
            form = new fmClientes();
            form.Show();
        }
    }
}
