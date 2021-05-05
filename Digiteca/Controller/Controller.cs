using AutoPecas.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Digiteca.Controller
{
    public class Controller : IObservador
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
            /*PedidoBD pedBD = new PedidoBD(bancoDeDados);
            ClienteBD cliBD = new ClienteBD(bancoDeDados);
            ItemPedidoBD prodBD = new ItemPedidoBD(bancoDeDados);
            PecaBD peca = new PecaBD(bancoDeDados);*/
            switch (acao)
            {
                case "I":
 
                    break;

                case "A":

                    break;
                case "E":

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
        public enum TIPO_BD { SQLSERVER, ORACLE, MYSQL, FIREBIRD }
    }
}