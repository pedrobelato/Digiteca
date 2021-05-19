﻿using Digiteca.DAL;
using Digiteca.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Digiteca.Visao;

namespace Digiteca.Controller
{
    public class Controller : IObservador
    {
        FReserva telaReserva;
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
                    Editora editora = new Editora();
                    dtLivros.Columns.Add("Código Livro");
                    dtLivros.Columns.Add("Titulo do Livro");
                    dtLivros.Columns.Add("Quantidade");
                    dtLivros.Columns.Add("Nome da Editora");
                    foreach (var item in tituloDAL.ObterTodas(parametros[0].ToString()))
                    {
                        editora = editoraDAL.ObterPorID(item.CodEditora);
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