using Digiteca.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiteca.DAL
{
    public class ReservaDAL
    {
        MySQLPersistencia _banco = new MySQLPersistencia();

        public (int, string) GravarReserva(Reserva reserva)
        {
            int linhasAfetadas = 0;
            string msg = "";
            try
            {
                string sql = "insert into reserva (cod_reserva, data, cod_usuario, cod_seq_exemplar) values (@codRes, @data, @usu, @seq)";

                Dictionary<string, object> ps = new Dictionary<string, object>();
                ps.Add("@cod_reserva", reserva.CodReserva);
                ps.Add("@data", reserva.Data);
                ps.Add("@cod_usuario", reserva.CodUsuario);
                ps.Add("@cod_seq_exemplar", reserva.CodSeqExemplar);

                _banco.AbrirConexao();
                linhasAfetadas = _banco.ExecutarNonQuery(sql, ps);
                _banco.FecharConexao();
            }
            catch
            {
                msg = "Não foi possível salvar! Tente novamente.";
            }
            return (linhasAfetadas, msg);
        }


        public List<Reserva> ObterTodas()
        {
            List<Reserva> reserva = new List<Reserva>();
            string sql = "select * from reserva";
            _banco.AbrirConexao();
            DataTable _dados = _banco.ExecutarSelect(sql);
            for (int i = 0; i < _dados.Rows.Count; i++)
            {
                reserva.Add(new Reserva(Convert.ToInt32(_dados.Rows[i]["cod_reserva"]),
                    Convert.ToDateTime(_dados.Rows[i]["data"]),
                    Convert.ToInt32(_dados.Rows[i]["cod_usuario"]),
                    Convert.ToInt32(_dados.Rows[i]["cod_seq_exemplar"])));
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
                string sql = "update reserva set data = @data, cod_usuario = @usu, cod_seq_exemplar = @seq where cod_reserva = @cod";

                Dictionary<string, object> ps = new Dictionary<string, object>();
                ps.Add("@cod_reserva", reserva.CodReserva);
                ps.Add("@data", reserva.Data);
                ps.Add("@cod_usuario", reserva.CodUsuario);
                ps.Add("@cod_seq_exemplar", reserva.CodSeqExemplar);

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
    }
}
