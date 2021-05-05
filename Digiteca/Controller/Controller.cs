using Digiteca.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Digiteca.Controller
{
    public class Controller : IObservador
    {
        
        //private static Controller instancia = null;
        //private static object trava = new object();
        //private Banco bancoDeDados;

        /*private Controller(TIPO_BD tipoDeBanco)
        {
            if (tipoDeBanco == TIPO_BD.SQLSERVER)
            {
                bancoDeDados = new BancoSQLServer();
            }
        }*/

        /*public static Controller obterInstancia()
        {
            lock (trava)
            {
                if (instancia == null)
                {
                    instancia = new Controller(TIPO_BD.SQLSERVER);
                }
                return instancia;
            }
        }*/

        public void notificar(string acao, params object[] parametros)
        {
            //PedidoBD pedBD = new PedidoBD(bancoDeDados);
            //ClienteBD cliBD = new ClienteBD(bancoDeDados);
            //ItemPedidoBD prodBD = new ItemPedidoBD(bancoDeDados);
            //PecaBD peca = new PecaBD(bancoDeDados);
            switch (acao)
            {
                case "I":
                    /*if (cliBD.consulta(parametros[0].ToString()) == null)
                    {
                        cliBD.incluir(new Cliente(parametros[0].ToString(),
                                                   parametros[1].ToString(),
                                                   parametros[2].ToString(),
                                                   parametros[3].ToString(),
                                                   parametros[4].ToString(),
                                                   parametros[5].ToString()));
                        MessageBox.Show("Dados Salvos com Sucesso", "Sucesso !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Código Já existe !","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);*/
                    break;

                case "A":
                    /*cliBD.alterar(new Cliente(parametros[0].ToString(),
                                                   parametros[1].ToString(),
                                                   parametros[2].ToString(),
                                                   parametros[3].ToString(),
                                                   parametros[4].ToString(),
                                                   parametros[5].ToString()));
                    MessageBox.Show("Dados Alterados com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    */break;
                case "E":/*
                    if (MessageBox.Show("Deseja realmente excluir ?","Atenção !",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        cliBD.excluir(Convert.ToString(parametros[0]));
                        cliente = null;
                        MessageBox.Show("Dados Excluídos com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }*/
                    break;

                case "M":/*
                    DataTable dtClientes = new DataTable();
                    dtClientes.Columns.Add("CPF / CNPJ");
                    dtClientes.Columns.Add("Nome");
                    dtClientes.Columns.Add("Responsável");
                    dtClientes.Columns.Add("Telefone");
                    dtClientes.Columns.Add("Logradouro");
                    dtClientes.Columns.Add("E-Mail");
                    foreach (Cliente cli in cliBD.busca(Convert.ToString(parametros[0])))
                    {
                        DataRow linhaMC = dtClientes.NewRow();
                        linhaMC[0] = cli.Cli_codigo;
                        linhaMC[1] = cli.Cli_nome;
                        linhaMC[2] = cli.Cli_responsavel;
                        linhaMC[3] = cli.Cli_telefone;
                        linhaMC[4] = cli.Cli_logradouro;
                        linhaMC[5] = cli.Cli_email;
                        dtClientes.Rows.Add(linhaMC);
                    }
                    telaPrincipal.tabelaclientes.DataSource = dtClientes;*/
                    break;

                case "C": // consulta para preencher os campos
                    /*
                    if (telaPrincipal.cbTipo.SelectedIndex == 1)
                    {
                        telaPrincipal.txCodigo.Text = parametros[0].ToString();
                        telaPrincipal.txNomeBusca.Text = parametros[1].ToString();
                        telaPrincipal.labelNomeCliente.Text = parametros[1].ToString();
                    }
                    else
                    {
                        telaPrincipal.txCodCli.Text = parametros[0].ToString();
                        telaPrincipal.txNome_Cliente.Text = parametros[1].ToString();
                        telaPrincipal.txNome_Resp.Text = parametros[2].ToString();
                    }*/
                    break;

                case "P":/*
                    DataTable dtClientesBusca = new DataTable();
                    dtClientesBusca.Columns.Add("CPF / CNPJ");
                    dtClientesBusca.Columns.Add("Nome do Cliente");
                    dtClientesBusca.Columns.Add("Nome do Responsável");
                    dtClientesBusca.Columns.Add("Nº Telefone");
                    dtClientesBusca.Columns.Add("Logradouro");
                    dtClientesBusca.Columns.Add("E-Mail");
                    foreach (Cliente cli in cliBD.busca(Convert.ToString(parametros[0])))
                    {
                        DataRow linhaC = dtClientesBusca.NewRow();
                        linhaC[0] = cli.Cli_codigo;
                        linhaC[1] = cli.Cli_nome;
                        linhaC[2] = cli.Cli_responsavel;
                        linhaC[3] = cli.Cli_telefone;
                        linhaC[4] = cli.Cli_logradouro;
                        linhaC[5] = cli.Cli_email;
                        dtClientesBusca.Rows.Add(linhaC);
                    }
                    telaMostrarClientes = new FClientes();
                    telaMostrarClientes.dgvClientes.DataSource = dtClientesBusca;
                    telaMostrarClientes.adicionarObservadores(this);
                    telaMostrarClientes.lmascara.Text = parametros[0].ToString();
                    telaMostrarClientes.ShowDialog();*/
                    break;
                default:
                    break;
            }
        }
        public enum TIPO_BD { SQLSERVER, ORACLE, MYSQL, FIREBIRD }
    }
}