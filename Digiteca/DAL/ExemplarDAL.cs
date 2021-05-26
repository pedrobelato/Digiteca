﻿using Digiteca.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiteca.DAL
{
    public class ExemplarDAL
    {
        MySQLPersistencia _banco = new MySQLPersistencia();

        public Exemplar ObterExemplar(int idTitulo)
        {
            Exemplar exemplar = null;
            try
            {
                string sql = $"select * from digiteca.exemplar where codTitulo = '{idTitulo}' and codSituacao = 0;";

                _banco.AbrirConexao();
                DataTable dados = _banco.ExecutarSelect(sql);
                if (dados.Rows.Count > 0)
                {
                    exemplar = new Exemplar(Convert.ToInt32(dados.Rows[0]["codExemplar"]),
                                                    Convert.ToInt32(dados.Rows[0]["codTitulo"].ToString()),
                                                    Convert.ToInt32(dados.Rows[0]["codSituacao"].ToString()));
                }
                _banco.FecharConexao();
            }
            catch { }
            return exemplar;
        }

        public int Emprestar(int idEx, int idTit)
        {
            int linhasAfetadas = 0;
            try
            {
                string sql = $"UPDATE digiteca.exemplar SET codSituacao = '1' WHERE (codExemplar = {idEx})";
                //string sqls = $"UPDATE digiteca.titulo SET quantidade = quantidade-1 WHERE (codTitulo = {idTit})";
                _banco.AbrirConexao();
                linhasAfetadas = _banco.ExecutarNonQuery(sql);
                //linhasAfetadas = _banco.ExecutarNonQuery(sqls);
                _banco.FecharConexao();
            }
            catch
            {

            }
            return linhasAfetadas;
        }
    }
}
