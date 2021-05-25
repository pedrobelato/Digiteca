using Digiteca.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace Digiteca.DAL
{
    public class ReservaDAL
    {
        MySQLPersistencia _banco = new MySQLPersistencia();

        public bool GravarReserva(Reserva reserva)
        {
            bool sucesso;
            int linhasAfetadas;
            try
            {
                string sql = "insert into reserva (codUsuario, codTitulo, data) values (@usu, @tit, @data)";

                Dictionary<string, object> ps = new Dictionary<string, object>();
                ps.Add("@usu", reserva.CodUsuario);
                ps.Add("@tit", reserva.CodTitulo);
                ps.Add("@data", reserva.Data.ToString("yyyy/MM/dd"));

                _banco.AbrirConexao();
                linhasAfetadas = _banco.ExecutarNonQuery(sql, ps);
                if (linhasAfetadas > 0)
                {
                    sucesso = true;
                }
                else
                    sucesso = false;
                _banco.FecharConexao();
            }
            catch
            {
                sucesso = false;
            }
            return sucesso;
        }
        /*

        public List<Reserva> ObterTodas()
        {
            List<Reserva> reserva = new List<Reserva>();
            string sql = "select * from reserva";
            _banco.AbrirConexao();
            DataTable _dados = _banco.ExecutarSelect(sql);
            for (int i = 0; i < _dados.Rows.Count; i++)
            {
                reserva.Add(new Reserva(Convert.ToInt32(_dados.Rows[i]["codReserva"]),
                    Convert.ToDateTime(_dados.Rows[i]["data"]),
                    Convert.ToInt32(_dados.Rows[i]["codUsuario"]),
                    Convert.ToInt32(_dados.Rows[i]["codTitulo"]),
                    Convert.ToInt32(_dados.Rows[i]["codEditora"])));
            }
            _banco.FecharConexao();
            return reserva;
        }


        public (int, string) Atualizar(Reserva reserva)
        {
            int linhasAfetadas = 0;
            string msg = "";
            try
            {
                string sql = "update reserva set data = @data, codUsuario = @usu, codTitulo = @tit, codEditora = @edi where codReserva = @cod";

                Dictionary<string, object> ps = new Dictionary<string, object>();
                ps.Add("@codReserva", reserva.CodReserva);
                ps.Add("@data", reserva.Data);
                ps.Add("@codUsuario", reserva.CodUsuario);
                ps.Add("@codTitulo", reserva.CodTitulo);
                ps.Add("@codEditora", reserva.CodEditora);

                _banco.AbrirConexao();
                linhasAfetadas = _banco.ExecutarNonQuery(sql);
                _banco.FecharConexao();
            }
            catch
            {
                msg = "Não foi possível salvar! Tente novamente.";
            }

            return (linhasAfetadas, msg);
        }
        */
    }
}
