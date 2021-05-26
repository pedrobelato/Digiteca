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
            bool sucesso = false;
            try
            {
                string sql = "insert into itememprestimo (codEmprestimo, codUsuario, codExemplar, dataEmp, dataLimite, devolucao) values (@codEmp, @codUsu, @codExe, @dataEmp, @dataLimite, @dev)";

                Dictionary<string, object> ps = new Dictionary<string, object>();
                ps.Add("@codEmp", itememprestimo.CodEmprestimo);
                ps.Add("@codUsu", itememprestimo.Usuario.Id);
                ps.Add("@codExe", itememprestimo.Exemplar.CodSeqExemplar);
                ps.Add("@dataEmp", itememprestimo.DataEmp);
                ps.Add("@dataLimite", itememprestimo.DataLimite);
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
            catch
            {
                sucesso = false;
            }
            return sucesso;
        }
    }
}
