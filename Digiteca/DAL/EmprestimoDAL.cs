using Digiteca.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiteca.DAL
{
    public class EmprestimoDAL
    {
        MySQLPersistencia _banco = new MySQLPersistencia();

        public bool GravarEmprestimo(Emprestimo emprestimo)
        {
            int linhasAfetadas = 0;
            bool sucesso = false;
            try
            {
                string sql = "insert into emprestimo (codUsuario, pessoa, data) values (@usu, @pessoa, @data)";

                Dictionary<string, object> ps = new Dictionary<string, object>();
                ps.Add("@data", emprestimo.Data);
                ps.Add("@pessoa", emprestimo.Usuario.Nome);
                ps.Add("@usu", emprestimo.Usuario.Id);

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
            catch{}
            return sucesso;
        }
    }
}

   
