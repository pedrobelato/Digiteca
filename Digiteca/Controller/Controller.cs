using AutoPecas.Modelo;
using AutoPecas.Persistencia;
using AutoPecas.Visao;
using Microsoft.Reporting.WinForms;
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
        private Pedido pedido;
        private Cliente cliente;
        private ItemPedido produto;
        FPrincipal telaPrincipal;
        FClientes telaMostrarClientes;

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

        public void mostrarTelaPrincipal()
        {
            ClienteBD cliBD = new ClienteBD(this.bancoDeDados);
            PedidoBD pedBD = new PedidoBD(this.bancoDeDados);
            telaPrincipal = new FPrincipal();
            telaPrincipal.adicionarObservadores(this);
            telaPrincipal.ShowDialog();
        }

        public void notificar(string acao, params object[] parametros)
        {
            PedidoBD pedBD = new PedidoBD(bancoDeDados);
            ClienteBD cliBD = new ClienteBD(bancoDeDados);
            ItemPedidoBD prodBD = new ItemPedidoBD(bancoDeDados);
            PecaBD peca = new PecaBD(bancoDeDados);
            switch (acao)
            {
                case "RPC":
                    double vlrtotalCli = 0;
                    DataTable dtRelPedidosCli = new DataTable();
                    dtRelPedidosCli.Columns.Add("Código do Pedido");
                    dtRelPedidosCli.Columns.Add("Data do Pedido");
                    dtRelPedidosCli.Columns.Add("Data do Vencimento");
                    dtRelPedidosCli.Columns.Add("Valor Total");
                    foreach (Pedido pedido in pedBD.consultaPorCliente(parametros[0].ToString(), parametros[1].ToString(), parametros[2].ToString()))
                    {
                        DataRow linhaPed = dtRelPedidosCli.NewRow();
                        linhaPed[0] = pedido.Ped_codigo;
                        linhaPed[1] = pedido.Ped_date.ToString("dd/MM/yyyy");
                        linhaPed[2] = pedido.Ped_date_vencimento.ToString("dd/MM/yyyy");
                        linhaPed[3] = string.Format("R$  " + pedido.Ped_total_geral.ToString("F"));
                        vlrtotalCli += pedido.Ped_total_geral;
                        dtRelPedidosCli.Rows.Add(linhaPed);
                    }
                    telaPrincipal.dgvRelatorios.DataSource = dtRelPedidosCli;
                    telaPrincipal.dgvRelatorios.Columns[0].Width = 190;
                    telaPrincipal.dgvRelatorios.Columns[1].Width = 200;
                    telaPrincipal.dgvRelatorios.Columns[2].Width = 200;
                    telaPrincipal.dgvRelatorios.Columns[3].Width = 184;
                    telaPrincipal.vlrTotalPedidos.Text = string.Format("R$  " + vlrtotalCli.ToString("F"));
                    break;

                case "RPP":
                    double vlrtotal = 0;
                    DataTable dtRelPedidos = new DataTable();
                    dtRelPedidos.Columns.Add("Código do Pedido");
                    dtRelPedidos.Columns.Add("Nome do Cliente");
                    dtRelPedidos.Columns.Add("Data do Pedido");
                    dtRelPedidos.Columns.Add("Data do Vencimento");
                    dtRelPedidos.Columns.Add("Valor Total");
                    foreach (Pedido pedido in pedBD.consulta(parametros[0].ToString(), parametros[1].ToString()))
                    {
                        DataRow linhaPed = dtRelPedidos.NewRow();
                        linhaPed[0] = pedido.Ped_codigo;
                        Cliente C = cliBD.consulta(pedido.Cli_codigo);
                        linhaPed[1] = C.Cli_nome;
                        linhaPed[2] = pedido.Ped_date.ToString("dd/MM/yyyy");
                        linhaPed[3] = pedido.Ped_date_vencimento.ToString("dd/MM/yyyy");
                        linhaPed[4] = string.Format("R$  " + pedido.Ped_total_geral.ToString("F"));
                        vlrtotal += pedido.Ped_total_geral;
                        dtRelPedidos.Rows.Add(linhaPed);
                    }
                    telaPrincipal.dgvRelatorios.DataSource = dtRelPedidos;
                    telaPrincipal.dgvRelatorios.Columns[0].Width = 150;
                    telaPrincipal.dgvRelatorios.Columns[1].Width = 234;
                    telaPrincipal.dgvRelatorios.Columns[2].Width = 140;
                    telaPrincipal.dgvRelatorios.Columns[3].Width = 140;
                    telaPrincipal.dgvRelatorios.Columns[4].Width = 110;
                    telaPrincipal.vlrTotalPedidos.Text = string.Format("R$  " + vlrtotal.ToString("F"));
                    break;

                case "EDP":
                    if (MessageBox.Show("Deseja realmente excluir ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataGridViewRow linhaExcluir = (DataGridViewRow)parametros[0];
                        peca.excluir(linhaExcluir.Cells[0].Value.ToString());
                        MessageBox.Show("Dados Excluidos!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
                case "GDP":
                    DataGridViewRow linhaGravar = (DataGridViewRow)parametros[0];
                    peca.alterar(new Peca(linhaGravar.Cells[0].Value.ToString(),
                                        linhaGravar.Cells[1].Value.ToString(),
                                        linhaGravar.Cells[2].Value.ToString(),
                                        Convert.ToInt32(linhaGravar.Cells[3].Value)));
                    MessageBox.Show("Dados Gravados", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "PP": // Pesquisar Peça
                    DataTable dtPecas = new DataTable();
                    dtPecas.Columns.Add("Nº Peça");
                    dtPecas.Columns.Add("Nome da Peça");
                    dtPecas.Columns.Add("Local Estoque");
                    dtPecas.Columns.Add("Quantidade");
                    if (telaPrincipal.radioPesqCodigo.Checked)
                    {
                        Peca pecas;
                        pecas = peca.consulta(Convert.ToString(parametros[0]));
                        if (pecas != null)
                        {
                            DataRow linhaP = dtPecas.NewRow();
                            linhaP[0] = pecas.Num_peca;
                            linhaP[1] = pecas.Nome_peca;
                            linhaP[2] = pecas.Local_estoque;
                            linhaP[3] = pecas.Qtde_estoque;
                            dtPecas.Rows.Add(linhaP);
                        }
                        else
                            MessageBox.Show("Peça Não Encontrada !", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        foreach (Peca pecas in peca.busca(Convert.ToString(parametros[0])))
                        {
                            DataRow linhaP = dtPecas.NewRow();
                            linhaP[0] = pecas.Num_peca;
                            linhaP[1] = pecas.Nome_peca;
                            linhaP[2] = pecas.Local_estoque;
                            linhaP[3] = pecas.Qtde_estoque;
                            dtPecas.Rows.Add(linhaP);
                        }
                    }
                    telaPrincipal.dgvPecas.DataSource = dtPecas;
                    telaPrincipal.dgvPecas.Columns[0].Width = 170;
                    telaPrincipal.dgvPecas.Columns[1].Width = 420;
                    telaPrincipal.dgvPecas.Columns[2].Width = 100;
                    telaPrincipal.dgvPecas.Columns[3].Width = 80;
                    telaPrincipal.ContLinEncontradas.Text = (telaPrincipal.dgvPecas.RowCount).ToString();
                    break;

                case "VP":

                    break;

                case "SP":

                    if (telaPrincipal.chbVerfica.Checked)
                    {
                        // Verificar Peca e completar o nome dinamicamente...
                        /// no caso, ele completa o campo após a linha estiver preenchida
                        foreach (DataGridViewRow lin in telaPrincipal.dgvPedido.Rows)
                        {
                            if (lin.Index + 1 < telaPrincipal.dgvPedido.Rows.Count)
                            {
                                Peca VerifPeca = peca.consulta(lin.Cells[0].Value.ToString());
                                if (VerifPeca != null)
                                {
                                    lin.Cells[1].Value = VerifPeca.Nome_peca;
                                }
                                else
                                {
                                    MessageBox.Show("Peça: " + "'(" + lin.Cells[0].Value + ")'" + " não foi encontrada na Base de dados, portanto, foi inserida para efetuar o pedido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    peca.incluir(new Peca(lin.Cells[0].Value.ToString(),
                                                        lin.Cells[1].Value.ToString(), "Auto", 0));
                                }
                            }
                        }
                    }
                    telaPrincipal.dgvPedido.Refresh();
                    double total = 0;
                    // SALVAR O PEDIDO
                    foreach (DataGridViewRow linhaPed in telaPrincipal.dgvPedido.Rows)
                    {
                        if (linhaPed.Index + 1 < telaPrincipal.dgvPedido.Rows.Count)
                        {
                            total += Convert.ToDouble(linhaPed.Cells[5].Value);
                        }
                    }
                    
                    pedBD.incluir(new Pedido(parametros[0].ToString(),
                                        Convert.ToDateTime(parametros[2].ToString()),
                                        Convert.ToDateTime(parametros[3].ToString()),
                                        total,
                                        parametros[1].ToString()));

                    foreach (DataGridViewRow linhaPed in telaPrincipal.dgvPedido.Rows)
                    {
                        if (linhaPed.Index + 1 < telaPrincipal.dgvPedido.Rows.Count)
                        {
                            produto = new ItemPedido(linhaPed.Cells[0].Value.ToString(),
                                                linhaPed.Cells[1].Value.ToString(),
                                                Convert.ToInt32(linhaPed.Cells[2].Value),
                                                Convert.ToDouble(linhaPed.Cells[3].Value),
                                                Convert.ToInt32(linhaPed.Cells[4].Value),
                                                Convert.ToDouble(linhaPed.Cells[5].Value),
                                                parametros[0].ToString());
                            Peca pc = peca.consulta(linhaPed.Cells[0].Value.ToString());
                            if (pc.Qtde_estoque - Convert.ToInt32(linhaPed.Cells[4].Value) >= 0)
                            {
                                pc.Qtde_estoque -= Convert.ToInt32(linhaPed.Cells[4].Value);
                                peca.alterar(pc);
                            }
                            else
                            {
                                MessageBox.Show("Cuidado! A peça: " + "'(" +pc.Num_peca + ")'" + " não possui quantidade suficiente no estoque!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            prodBD.incluir(produto);
                        }
                    }
                    MessageBox.Show("Pedido Salvo !", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    break;

                case "EP": // excluir pedido
                    if (MessageBox.Show("Deseja realmente excluir permanentemente esse pedido?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        pedBD.excluir(Convert.ToString(parametros[0]));
                        pedido = null;
                        MessageBox.Show("Pedido Excluído com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

                case "CP": // consultar Pedido (Informar todos os detalhes)
                    /// 1- Criar um form.
                    /// 2- Buscar no banco as informações do cliente e exibir nos campos
                    /// 3- Buscar no banco as informações das linhas dos produtos.
                    /// 4- Exibir todas as linhas...
                    break;
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
