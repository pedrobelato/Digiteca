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

        public bool GravarItemEmprestimo(ItemEmprestimo itememprestimo)
        {
            int linhasAfetadas = 0;
            bool sucesso;
            try
            {
                string sql = "insert into itememprestimo (codExemplar, codEmprestimo, codUsuario, data, vencimento, Devolucao) " +
                    "values (@codEmp, @codUsu, @codExe, @data, @vencimento, @dev)";

                Dictionary<string, object> ps = new Dictionary<string, object>();
                ps.Clear();
                ps.Add("@codEmp", itememprestimo.CodEmprestimo);
                ps.Add("@codUsu", itememprestimo.Usuario.Id);
                ps.Add("@codExe", itememprestimo.Exemplar.CodSeqExemplar);
                ps.Add("@data", itememprestimo.DataEmp);
                ps.Add("@vencimento", itememprestimo.DataLimite);
                ps.Add("@dev", itememprestimo.Devolucao);

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
            catch(Exception e)
            {
                Console.WriteLine(e);
                sucesso = false;
            }
            return sucesso;
        }
    }
}
