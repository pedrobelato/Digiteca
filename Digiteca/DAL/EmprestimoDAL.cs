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

        public Emprestimo ObterUltimoEmprestimo()
        {
            Emprestimo emprestimo = null;
            try
            {
                string sql = $"select * from digiteca.emprestimo where codEmprestimo = {_banco.UltimoId}";

                _banco.AbrirConexao();
                DataTable dados = _banco.ExecutarSelect(sql);
                if (dados.Rows.Count > 0)
                {
                    Usuario usuario = new Usuario(Convert.ToInt32(dados.Rows[0]["codUsuario"]),
                                                    dados.Rows[0]["pessoa"].ToString());
                    emprestimo = new Emprestimo(Convert.ToInt32(dados.Rows[0]["codEmprestimo"]),
                                                 Convert.ToDateTime(dados.Rows[0]["data"]),
                                                 usuario);
                }
                _banco.FecharConexao();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return emprestimo;
        }
    }
}

   
