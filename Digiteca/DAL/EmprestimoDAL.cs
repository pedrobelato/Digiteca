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

        public (int, string) GravarEmprestimo(Emprestimo_Devolucao emprestimo)
        {
            int linhasAfetadas = 0;
            string msg = "";
            try
            {
                string sql = "insert into emprestimo_devolucao (cod_emp_dev, data, situacao, cod_usuario, cod_seq_exemplar) values (@codEmp, @data, @situ, @usu, @seq)";

                Dictionary<string, object> ps = new Dictionary<string, object>();
                ps.Add("@cod_emp_dev", emprestimo.CodEmpDev);
                ps.Add("@data", emprestimo.Data);
                ps.Add("@situacao", emprestimo.Situacao);
                ps.Add("@cod_usuario", emprestimo.CodUsuario);
                ps.Add("@cod_seq_exemplar", emprestimo.CodSeqExemplar);

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


        public List<Emprestimo_Devolucao> ObterTodas()
        {
            List<Emprestimo_Devolucao> emprestimo = new List<Emprestimo_Devolucao>();
            string sql = "select * from emprestimo_devolucao";
            _banco.AbrirConexao();
            DataTable _dados = _banco.ExecutarSelect(sql);
            for (int i = 0; i < _dados.Rows.Count; i++)
            {
                emprestimo.Add(new Emprestimo_Devolucao(Convert.ToInt32(_dados.Rows[i]["cod_emp_dev"]),
                    Convert.ToDateTime(_dados.Rows[i]["data"]), 
                    _dados.Rows[i]["situacao"].ToString(), 
                    Convert.ToInt32(_dados.Rows[i]["cod_usuario"]), 
                    Convert.ToInt32(_dados.Rows[i]["cod_seq_exemplar"])));
            }
            _banco.FecharConexao();
            return emprestimo;
        }



        public (int, string) Atualizar(Emprestimo_Devolucao emprestimo)
        {
            int linhasAfetadas = 0;
            string msg = "";
            try
            {
                string sql = "update emprestimo_devolucao set data = @data, situacao = @situ, cod_usuario = @usu, cod_seq_exemplar = @seq where cod_emp_dev = @cod";

                Dictionary<string, object> ps = new Dictionary<string, object>();
                ps.Add("@cod_emp_dev", emprestimo.CodEmpDev);
                ps.Add("@data", emprestimo.Data);
                ps.Add("@situacao", emprestimo.Situacao);
                ps.Add("@cod_usuario", emprestimo.CodUsuario);
                ps.Add("@cod_seq_exemplar", emprestimo.CodSeqExemplar);

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

   
