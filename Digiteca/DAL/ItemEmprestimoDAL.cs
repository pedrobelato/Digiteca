using Digiteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiteca.DAL
{
    public class ItemEmprestimoDAL
    {
        MySQLPersistencia _banco = new MySQLPersistencia();

        public (int, string) GravarItemEmprestimo(ItemEmprestimo itememprestimo)
        {
            int linhasAfetadas = 0;
            string msg = "";
            try
            {
                string sql = "insert into itememprestimo (codEmprestimo, codUsuario, codExemplar, dataEmp, dataLimite, devolucao) values (@codEmp, @codUsu, @codExe, @dataEmp, @sdataLimite, @dev)";

                Dictionary<string, object> ps = new Dictionary<string, object>();
                ps.Add("@codEmprestimo", itememprestimo.CodEmprestimo);
                ps.Add("@codUsuario", itememprestimo.CodUsuario);
                ps.Add("@codExemplar", itememprestimo.CodExemplar);
                ps.Add("@dataEmp", itememprestimo.DataEmp);
                ps.Add("@dataLimite", itememprestimo.DataLimite);
                ps.Add("@devolucao", itememprestimo.Devolucao);

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

        /*
        public (int, string) Atualizar(ItemEmprestimo itememprestimo)
        {
            int linhasAfetadas = 0;
            string msg = "";
            try
            {
                string sql = "update itememprestimo set codUsuario = @codUsu, codExemplar = @codExe, dataEmp = @dataemp, dataLimite = @datali, devolucao = @dev where codEmprestimo = @cod";

                Dictionary<string, object> ps = new Dictionary<string, object>();
                ps.Add("@codEmprestimo", itememprestimo.CodEmprestimo);
                ps.Add("@codUsuario", itememprestimo.CodUsuario);
                ps.Add("@codExemplar", itememprestimo.CodExemplar);
                ps.Add("@dataEmp", itememprestimo.DataEmp);
                ps.Add("@dataLimite", itememprestimo.DataLimite);
                ps.Add("@devolucao", itememprestimo.Devolucao);

                _banco.AbrirConexao();
                linhasAfetadas = _banco.ExecutarNonQuery(sql);
                _banco.FecharConexao();
            }
            catch
            {
                msg = "Não foi possível salvar! Tente novamente.";
            }

            return (linhasAfetadas, msg);
        }*/
    }
}
