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
            ReservaDAL reservaDAL = new ReservaDAL();
            EditoraDAL editoraDAL = new EditoraDAL();
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

                case "PU":
                    
                    break;
                case "PL": // pesquisar livro
                    DataTable dtLivros = new DataTable();
                    dtLivros.Columns.Add("Código Livro");
                    dtLivros.Columns.Add("Titulo do Livro");
                    dtLivros.Columns.Add("Quantidade");

                    dtLivros.Columns.Add($"{}");
                    foreach (var item in tituloDAL.ObterTodos())
                    {

                    }
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