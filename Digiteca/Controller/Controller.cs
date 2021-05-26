using Digiteca.DAL;
using Digiteca.Model;
using Digiteca.Visao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Digiteca.Controller
{
    public class Controller : IObservador
    {
        fmReserva telaReserva;
        fmClientes telaClientes;
        fmEmprestimo telaEmprestimo;
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

        public void abrirEmprestimo<MiForm>() where MiForm : Form, new()
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
                telaEmprestimo = (fmEmprestimo)formulario;
                telaEmprestimo.adicionarObservadores(this);
            }
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                    formulario.WindowState = FormWindowState.Normal;
                formulario.BringToFront();
            }
        }

        public void mostrarTelaPrincipal(string nome)
        {
            telaPrincipal = new fmMain();
            telaPrincipal.adicionarObservadores(this);
            telaPrincipal.lbName.Text = nome;
            telaPrincipal.ShowDialog();
        }

        public (bool, string) Autenticar(int id, string senha)
        {
            bool sucesso;
            string nome = "";
            BibliotecaDAL bibliotecaDAL = new BibliotecaDAL();
            (sucesso, nome) = bibliotecaDAL.Autenticar(id, senha);
            return (sucesso, nome);
        }

        public void notificar(string acao, params object[] parametros)
        {
            TituloDAL tituloDAL = new TituloDAL();
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            ReservaDAL reservaDAL = new ReservaDAL();
            EditoraDAL editoraDAL = new EditoraDAL();
            BibliotecaDAL bibliotecaDAL = new BibliotecaDAL();
            EmprestimoDAL emprestimoDAL = new EmprestimoDAL();
            ItemEmprestimoDAL itemDAL = new ItemEmprestimoDAL();
            ExemplarDAL exemplarDAL = new ExemplarDAL();
            bool sucesso;
            switch (acao)
            {
                case "IE": // Inserir Empréstimo
                    bool gravou = false;
                    Usuario usuarioEmp = usuarioDAL.ObterPorCPF(parametros[0].ToString());
                    Emprestimo emp = new Emprestimo(Convert.ToDateTime(parametros[1]), usuarioEmp);
                    if (emprestimoDAL.GravarEmprestimo(emp))
                    {
                        List<Titulo> livros = (List<Titulo>)parametros[3];
                        foreach (var item in livros)
                        {
                            gravou = false;
                            // 1 - Emprestado
                            // 2 - Reservado
                            // 0 - Disponível

                            Exemplar exemplar = null;
                            exemplar = exemplarDAL.ObterExemplar(item.CodTitulo);
                            if (exemplar != null)
                            {
                                emp = emprestimoDAL.ObterUltimoEmprestimo();
                                ItemEmprestimo itemEmp = new ItemEmprestimo(emp.CodEmp,
                                                                            emp.Usuario, exemplar,
                                                                            Convert.ToDateTime(parametros[1]),
                                                                            Convert.ToDateTime(parametros[2]),
                                                                            1);
                                exemplarDAL = new ExemplarDAL();
                                if (exemplarDAL.Emprestar(exemplar.CodSeqExemplar) == 1)
                                {
                                    if (itemDAL.GravarItemEmprestimo(itemEmp))
                                    {
                                        MessageBox.Show($"Seu Empréstimo do livro = '{item.TituloLivro}' foi Gravado!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.None);
                                        gravou = true;
                                    }
                                }                                
                            }
                        }
                    }
                    if (!gravou)
                    {
                        MessageBox.Show("Erro durante a gravação...", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }   
                    break;
                case "IR": // incluir Reserva

                    /// Procurar se o livro tem quantidade disponível e ir no banco pegando o códigoSequencial do exemplar
                    /// cujo codSituação = 0
                    /// retorna o exemplar, marcar codSituação como 2 e cabow
                    
                    gravou = false;
                    Titulo titulo;
                    (titulo, sucesso) = tituloDAL.ObterTitulo_Qtde(Convert.ToInt32(parametros[1]));
                    if (sucesso)
                    {
                        Exemplar exemplar = exemplarDAL.ObterExemplar(titulo.CodTitulo);
                        if (exemplarDAL.Reservar(exemplar.CodLivro) > 0)
                        {
                            Usuario usuario = usuarioDAL.ObterPorCPF(parametros[0].ToString());
                            if (reservaDAL.GravarReserva(new Reserva(Convert.ToDateTime(parametros[2]),
                                                        usuario.Id,
                                                        Convert.ToInt32(parametros[1]))))
                            {
                                MessageBox.Show("Sua Reserva foi Gravada!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.None);
                                gravou = true;
                            }
                        }
                    }
                    else
                        MessageBox.Show("Esse Livro não tem exemplares disponíveis", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (!gravou)
                    {
                        MessageBox.Show("Erro durante a gravação...", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "PU": // Pesquisar Usuário
                    DataTable dtUsuarioBusca = new DataTable();
                    dtUsuarioBusca.Columns.Add("CPF");
                    dtUsuarioBusca.Columns.Add("Código do Usuário");
                    dtUsuarioBusca.Columns.Add("Nome do Usuário");
                    foreach (Usuario usu in usuarioDAL.ObterPorNome(parametros[1].ToString()))
                    {
                        DataRow linhaUsu = dtUsuarioBusca.NewRow();
                        linhaUsu[0] = usu.Cpf;
                        linhaUsu[1] = usu.Id;
                        linhaUsu[2] = usu.Nome;
                        dtUsuarioBusca.Rows.Add(linhaUsu);
                    }
                    telaClientes = new fmClientes((int)parametros[0]);
                    telaClientes.dgvTabClientes.DataSource = dtUsuarioBusca;
                    telaClientes.dgvTabClientes.Columns[0].Width = 100;
                    telaClientes.dgvTabClientes.Columns[1].Width = 80;
                    telaClientes.dgvTabClientes.Columns[2].Width = 400;
                    telaClientes.adicionarObservadores(this);
                    telaClientes.mascara.Text = parametros[1].ToString();
                    telaClientes.ShowDialog();
                    break;

                case "PUC": // pesquisar usuario consulta
                    telaReserva.tbPesqUsuario.Text = parametros[0].ToString();
                    telaReserva.lbCpf.Visible = true;
                    telaReserva.lbCodUsu.Visible = true;
                    telaReserva.lbCodUsu.Text = parametros[1].ToString();
                    break;

                case "PUCE": // pesquisar usuario consulta para tela Emprestimo
                    telaEmprestimo.tbUsuario.Text = parametros[0].ToString();
                    telaEmprestimo.lbCpf.Visible = true;
                    telaEmprestimo.lbCodUsu.Visible = true;
                    telaEmprestimo.lbCodUsu.Text = parametros[1].ToString();
                    break;

                case "PL": // pesquisar livro
                    DataTable dtLivros = new DataTable();
                    dtLivros.Columns.Add("Código Livro");
                    dtLivros.Columns.Add("Titulo do Livro");
                    dtLivros.Columns.Add("Quantidade");
                    dtLivros.Columns.Add("ID da Editora");
                    foreach (Titulo tit in tituloDAL.ObterPorNome(parametros[0].ToString()))
                    {
                        DataRow linhaPL = dtLivros.NewRow();
                        linhaPL[0] = tit.CodTitulo;
                        linhaPL[1] = tit.TituloLivro;
                        linhaPL[2] = tit.Quantidade;
                        linhaPL[3] = tit.CodEditora;
                        dtLivros.Rows.Add(linhaPL);
                    }
                    telaReserva.dgvTabLivro.DataSource = dtLivros;
                    telaReserva.dgvTabLivro.Columns[0].Width = 100;
                    telaReserva.dgvTabLivro.Columns[1].Width = 350;
                    telaReserva.dgvTabLivro.Columns[2].Width = 80;
                    telaReserva.dgvTabLivro.Columns[3].Width = 185;
                    break;
                case "PLE": // pesquisar livro
                    DataTable dtLivrosEmp = new DataTable();
                    dtLivrosEmp.Columns.Add("Código Livro");
                    dtLivrosEmp.Columns.Add("Titulo do Livro");
                    dtLivrosEmp.Columns.Add("Quantidade");
                    dtLivrosEmp.Columns.Add("ID da Editora");
                    foreach (Titulo tit in tituloDAL.ObterPorNome(parametros[0].ToString()))
                    {
                        DataRow linhaPL = dtLivrosEmp.NewRow();
                        linhaPL[0] = tit.CodTitulo;
                        linhaPL[1] = tit.TituloLivro;
                        linhaPL[2] = tit.Quantidade;
                        linhaPL[3] = tit.CodEditora;
                        dtLivrosEmp.Rows.Add(linhaPL);
                    }
                    telaEmprestimo.dgvLivrosPesq.DataSource = dtLivrosEmp;
                    break;
                default:
                    break;
            }
        }
    }
}