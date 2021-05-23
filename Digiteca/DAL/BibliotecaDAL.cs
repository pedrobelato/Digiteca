using Digiteca.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiteca.DAL
{
    public class BibliotecaDAL
    {
        MySQLPersistencia _banco = new MySQLPersistencia();

        public (bool, string) Autenticar(int id, string senha)
        {
            bool sucesso;
            string nome = "";
            try
            {
                string sql = $"SELECT * FROM biblioteca where id = '{id}' and senha = '{senha}'";

                _banco.AbrirConexao();
                DataTable dados = _banco.ExecutarSelect(sql);
                if (dados.Rows.Count > 0)
                {
                    nome = dados.Rows[0]["nome"].ToString();
                }
                _banco.FecharConexao();
                sucesso = true;
            }
            catch
            {
                sucesso = false;
            }
            return (sucesso, nome);
        }
    }
}
