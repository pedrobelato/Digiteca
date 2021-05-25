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
    }
}
