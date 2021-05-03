using AutoPecas.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AutoPecas.Controle
{
    class Controller : IObservador
    {
        private static Controller instancia = null;
        private static object trava = new object();
        private Banco bancoDeDados;

        private Controller(TIPO_BD tipoDeBanco)
        {
            if (tipoDeBanco == TIPO_BD.SQLSERVER)
            {
                bancoDeDados = new BancoSQLServer();
            }
        }

        public static Controller obterInstancia()
        {
            lock (trava)
            {
                if (instancia == null)
                {
                    instancia = new Controller(TIPO_BD.SQLSERVER);
                }
                return instancia;
            }
        }

        public void notificar(string acao, params object[] parametros)
        {
            PedidoBD pedBD = new PedidoBD(bancoDeDados);
            ClienteBD cliBD = new ClienteBD(bancoDeDados);
            ItemPedidoBD prodBD = new ItemPedidoBD(bancoDeDados);
            PecaBD peca = new PecaBD(bancoDeDados);
            switch (acao)
            {
                case "I":
                    if (cliBD.consulta(parametros[0].ToString()) == null)
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
                        MessageBox.Show("Código Já existe !","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    break;

                case "A":
                    cliBD.alterar(new Cliente(parametros[0].ToString(),
                                                   parametros[1].ToString(),
                                                   parametros[2].ToString(),
                                                   parametros[3].ToString(),
                                                   parametros[4].ToString(),
                                                   parametros[5].ToString()));
                    MessageBox.Show("Dados Alterados com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "E":
                    if (MessageBox.Show("Deseja realmente excluir ?","Atenção !",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        cliBD.excluir(Convert.ToString(parametros[0]));
                        cliente = null;
                        MessageBox.Show("Dados Excluídos com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

                case "M":
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
                    telaPrincipal.tabelaclientes.DataSource = dtClientes;
                    break;

                case "C": // consulta para preencher os campos

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
                    }
                    break;

                case "P":
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
                    telaMostrarClientes.ShowDialog();
                    break;

                case "ImprimirREL":
                    double totalIMP = 0;
                    foreach (DataGridViewRow linhaPedIMP in telaPrincipal.dgvPedido.Rows)
                    {
                        if (linhaPedIMP.Index + 1 < telaPrincipal.dgvPedido.Rows.Count)
                        {
                            totalIMP += Convert.ToDouble(linhaPedIMP.Cells[5].Value);
                        }
                    }
                    Pedido pedidoIMP = new Pedido(parametros[0].ToString(),
                                        Convert.ToDateTime(parametros[2].ToString()),
                                        Convert.ToDateTime(parametros[3].ToString()),
                                        totalIMP,
                                        parametros[1].ToString());
                    Cliente cliIMP = cliBD.consulta(parametros[1].ToString());
                    ReportParameter[] paramRel = new ReportParameter[7];
                    /// nomeAutoPecas
                    /// num_ped
                    /// ped_data
                    /// ped_data_vencimento
                    /// ped_total_geral
                    /// cli_nome
                    /// cli_codigo
                    paramRel[0] = new ReportParameter("nomeAutoPecas", "PEÇANOVA DISTRIBUIDORA LTDA.");
                    paramRel[1] = new ReportParameter("num_ped", pedidoIMP.Ped_codigo);
                    paramRel[2] = new ReportParameter("ped_data", pedidoIMP.Ped_date.ToString("dd/MM/yyyy"));
                    paramRel[3] = new ReportParameter("ped_data_vencimento", pedidoIMP.Ped_date_vencimento.ToString("dd/MM/yyyy"));
                    paramRel[4] = new ReportParameter("ped_total_geral", string.Format("R$  " + pedidoIMP.Ped_total_geral.ToString("F")));
                    paramRel[5] = new ReportParameter("cli_nome", cliIMP.Cli_nome);
                    paramRel[6] = new ReportParameter("cli_codigo", pedidoIMP.Cli_codigo);
                    FRelatorio telaRelatorio = new FRelatorio(prodBD.todosItens(pedidoIMP.Ped_codigo), paramRel);
                    telaRelatorio.Show();
                    break;
                default:
                    break;
            }
        }

        /// Instruções para gerar relatórios ↓↓
        /// 1 - Renomear o ReportViewer;
        /// 2 - Torná-lo público
        /// 3 - Não esquecer que "nomeFondeDeDados" é o nome do conjunto de dados definido no relatório
        /// 4 - Não esquecer de tornar as classes públicas quando precisar.
        /// 5 - Em relatório por agrupamento tabalha com tipos primitivos de dados,
        /// portanto, é necessário haver uma serialização = [Serializable].

        public void processaRelatorio(ReportViewer visualizador, string caminhoArquivoRelatorio, string nomeFonteDeDados, List<Pedido> dados, ReportParameter[] parametros)
        {
            visualizador.Reset();
            visualizador.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource(nomeFonteDeDados, dados);
            visualizador.LocalReport.DataSources.Add(rds);
            visualizador.LocalReport.ReportPath = caminhoArquivoRelatorio;
            if (parametros != null)
            {
                visualizador.LocalReport.SetParameters(parametros);
            }
            visualizador.RefreshReport();
        }
        public enum TIPO_BD { SQLSERVER, ORACLE, MYSQL, FIREBIRD }
    }
}
