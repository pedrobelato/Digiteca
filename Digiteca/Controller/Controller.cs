using Digiteca.DAL;
using Digiteca.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Digiteca.Visao;
using System.Linq;

namespace Digiteca.Controller
{
    public class Controller : IObservador
    {
        fmReserva telaReserva;
        fmClientes telaClientes;
        fmEmprestimo telaEmprestimo;
        fmAcesso telaAcesso;
        fmMain telaPrincipal;

        private static Controller instancia = null;
        private static object trava = new object();
        public Controller()
        {
              
        }
        public static Controller obterInstancia()
        {
            lock (trava)
            {
                if (instancia == null)
                {
                    instancia = new Controller();
                }
                return instancia;
            }
        }


        public void abrirReserva<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = telaPrincipal.panelConteudo.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                telaPrincipal.panelConteudo.Controls.Add(formulario);
                telaPrincipal.panelConteudo.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                telaReserva = (fmReserva)formulario;
                telaReserva.adicionarObservadores(this);
            }
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                    formulario.WindowState = FormWindowState.Normal;
                formulario.BringToFront();
            }
        }

        public void mostrarTelaPrincipal()
        {
            telaPrincipal = new fmMain();
            telaPrincipal.adicionarObservadores(this);
            telaPrincipal.ShowDialog();
        }

        public void mostrarTelaEmprestimo()
        {
            telaEmprestimo = new fmEmprestimo();
            telaEmprestimo.adicionarObservadores(this);
            telaEmprestimo.ShowDialog();
        }

        public bool Autenticar(int id, string senha)
        {
            bool sucesso;
            BibliotecaDAL bibliotecaDAL = new BibliotecaDAL();
            (sucesso, _) = bibliotecaDAL.Autenticar(id, senha);
            return sucesso;
        }

        public void notificar(string acao, params object[] parametros)
        {
            TituloDAL tituloDAL = new TituloDAL();
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            ReservaDAL reservaDAL = new ReservaDAL();
            EditoraDAL editoraDAL = new EditoraDAL();
            BibliotecaDAL bibliotecaDAL = new BibliotecaDAL();
            bool sucesso;
            switch (acao)
            {
                case "IR": // incluir Reserva
                    Usuario usuario = new Usuario();
                    (usuario, sucesso) = usuarioDAL.obterUsuario(parametros[0].ToString());
                    //tituloDAL.
                    //Reserva reserva = new(Convert.ToDateTime(parametros[1]).ToShortDateString(),
                    //                        usuario.Id,
                    //                        );
                    break;

                case "PU": // Pesquisar Usuário
                    DataTable dtUsuarioBusca = new DataTable();
                    dtUsuarioBusca.Columns.Add("CPF");
                    dtUsuarioBusca.Columns.Add("Código do Usuário");
                    dtUsuarioBusca.Columns.Add("Nome do Usuário");
                    foreach (Usuario usu in usuarioDAL.ObterPorNome(parametros[0].ToString()))
                    {
                        DataRow linhaUsu = dtUsuarioBusca.NewRow();
                        linhaUsu[0] = usu.Cpf;
                        linhaUsu[1] = usu.Id;
                        linhaUsu[2] = usu.Nome;
                        dtUsuarioBusca.Rows.Add(linhaUsu);
                    }
                    telaClientes = new fmClientes();
                    telaClientes.dgvTabClientes.DataSource = dtUsuarioBusca;
                    telaClientes.adicionarObservadores(this);
                    telaClientes.mascara.Text = parametros[0].ToString();
                    telaClientes.ShowDialog();
                    break;

                case "PUC": // pesquisar usuario consulta
                    /*telaReserva.tbPesqUsuario.Text = parametros[0].ToString();
                    telaReserva.pCodUsu.Visible = true;
                    telaReserva.codigoUsu.Text = parametros[1].ToString();*/
                    break;

                case "PL": // pesquisar livro
                    DataTable dtLivros = new DataTable();
                    dtLivros.Columns.Add("Código Livro");
                    dtLivros.Columns.Add("Titulo do Livro");
                    dtLivros.Columns.Add("Quantidade");
                    dtLivros.Columns.Add("Nome da Editora");
                    foreach (var item in tituloDAL.ObterTodas(parametros[0].ToString()))
                    {
                        Editora editora = editoraDAL.ObterPorID(item.CodEditora);
                        DataRow linhaPL = dtLivros.NewRow();
                        linhaPL[0] = item.CodTitulo;
                        linhaPL[1] = item.TituloLivro;
                        linhaPL[2] = item.Quantidade;
                        linhaPL[3] = editora.editora;
                        dtLivros.Rows.Add(linhaPL);
                    }
                    telaReserva.dgvTabLivro.DataSource = dtLivros;
                    break;

                case "M":

                    break;

                case "C": // consulta para preencher os campos

                    break;

                case "P":

                    break;

                default:
                    break;
            }
        }
    }
}