﻿using Digiteca.DAL;
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

        public void mostrarTelaPrincipal(string nome)
        {
            telaPrincipal = new fmMain();
            telaPrincipal.adicionarObservadores(this);
            telaPrincipal.lbName.Text = nome;
            telaPrincipal.ShowDialog();
        }

        public void mostrarTelaEmprestimo()
        {
            telaEmprestimo = new fmEmprestimo();
            telaEmprestimo.adicionarObservadores(this);
            telaEmprestimo.ShowDialog();
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
            switch (acao)
            {
                case "IR": // incluir Reserva
                    Usuario usuario = usuarioDAL.ObterPorCPF(parametros[0].ToString());
                    if (reservaDAL.GravarReserva(new Reserva(Convert.ToDateTime(parametros[2]),
                                                usuario.Id,
                                                Convert.ToInt32(parametros[1]))))
                    {
                        MessageBox.Show("Sua Reserva foi Gravada!","Sucesso!",MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                        MessageBox.Show("Erro durante a gravação...","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    telaClientes.dgvTabClientes.Columns[0].Width = 100;
                    telaClientes.dgvTabClientes.Columns[1].Width = 80;
                    telaClientes.dgvTabClientes.Columns[2].Width = 400;
                    telaClientes.adicionarObservadores(this);
                    telaClientes.mascara.Text = parametros[0].ToString();
                    telaClientes.ShowDialog();
                    break;

                case "PUC": // pesquisar usuario consulta
                    telaReserva.tbPesqUsuario.Text = parametros[0].ToString();
                    telaReserva.lbCpf.Visible = true;
                    telaReserva.lbCodUsu.Visible = true;
                    telaReserva.lbCodUsu.Text = parametros[1].ToString();
                    break;

                case "PL": // pesquisar livro
                    DataTable dtLivros = new DataTable();
                    dtLivros.Columns.Add("Código Livro");
                    dtLivros.Columns.Add("Titulo do Livro");
                    dtLivros.Columns.Add("Quantidade");
                    dtLivros.Columns.Add("Nome da Editora");
                    foreach (Titulo tit in tituloDAL.ObterPorNome(parametros[0].ToString()))
                    {
                        Editora editora = editoraDAL.ObterPorID(tit.CodEditora);
                        DataRow linhaPL = dtLivros.NewRow();
                        linhaPL[0] = tit.CodTitulo;
                        linhaPL[1] = tit.TituloLivro;
                        linhaPL[2] = tit.Quantidade;
                        linhaPL[3] = editora.editora;
                        dtLivros.Rows.Add(linhaPL);
                    }
                    telaReserva.dgvTabLivro.DataSource = dtLivros;
                    telaReserva.dgvTabLivro.Columns[0].Width = 100;
                    telaReserva.dgvTabLivro.Columns[1].Width = 350;
                    telaReserva.dgvTabLivro.Columns[2].Width = 80;
                    telaReserva.dgvTabLivro.Columns[3].Width = 185;
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