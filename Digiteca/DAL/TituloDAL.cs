using Digiteca.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiteca.DAL
{
    public class TituloDAL
    {
        MySQLPersistencia _banco = new MySQLPersistencia();

        public (Titulo, bool) ObterTitulo_Qtde(int id)
        {
            bool sucesso;
            Titulo titulo = new Titulo();
            try
            {
                string sql = $"select * from digiteca.titulo where codTitulo = {id} and quantidade > 0;";

                _banco.AbrirConexao();
                DataTable dados = _banco.ExecutarSelect(sql);
                if (dados.Rows.Count > 0)
                { 
                    titulo = new Titulo(Convert.ToInt32(dados.Rows[0]["codTitulo"]),
                                        dados.Rows[0]["titulo"].ToString(),
                                        Convert.ToInt32(dados.Rows[0]["quantidade"]),
                                        Convert.ToInt32(dados.Rows[0]["codEditora"]));
                }
                _banco.FecharConexao();
                sucesso = true;
            }
            catch
            {
                sucesso = false;
            }
            return (titulo, sucesso);
        }

        public List<Titulo> ObterPorNome(string nome)
        {
            List<Titulo> titulo = new List<Titulo>();
            string sql = $"SELECT* FROM digiteca.titulo where titulo like '%{nome}%'";
            _banco.AbrirConexao();
            DataTable dados = _banco.ExecutarSelect(sql);
            for (int i = 0; i < dados.Rows.Count; i++)
            {
                titulo.Add(new Titulo(Convert.ToInt32(dados.Rows[i]["codTitulo"]),
                                        dados.Rows[i]["titulo"].ToString(),
                                        Convert.ToInt32(dados.Rows[i]["quantidade"]),
                                        Convert.ToInt32(dados.Rows[i]["codEditora"])));
            }
            _banco.FecharConexao();
            return titulo;
        }

        public int atualizarQuantidade(int codTit)
        {
            int linhasAfetadas = 0;
            try
            {
                string sql = $"update digiteca.titulo set quantidade = quantidade-1 where (codTitulo = {codTit})";
                _banco.AbrirConexao();

                linhasAfetadas = _banco.ExecutarNonQuery(sql);
                _banco.FecharConexao();
            }
            catch(Exception e) { Console.WriteLine(e);}
            return linhasAfetadas;
        }
    }
}
