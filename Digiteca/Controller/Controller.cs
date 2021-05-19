using Digiteca.DAL;
using Digiteca.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Digiteca.Controller
{
    public class Controller : IObservador
    {
        public void notificar(string acao, params object[] parametros)
        {
            TituloDAL tituloDAL = new TituloDAL();
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            bool sucesso;
            switch (acao)
            {
                case "IR": // incluir Reserva
                    Usuario usuario = new Usuario();
                    (usuario, sucesso) = usuarioDAL.obterUsuario(parametros[0].ToString());
                    tituloDAL.
                    Reserva reserva = new(Convert.ToDateTime(parametros[1]).ToShortDateString(),
                                            usuario.Id,
                                            );
                    break;

                case "PU": // Pesquisar Usuário
                    
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
    }
}