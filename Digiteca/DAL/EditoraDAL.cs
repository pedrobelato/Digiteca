using Digiteca.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiteca.DAL
{
    public class EditoraDAL
    {
        MySQLPersistencia _banco = new MySQLPersistencia();

        public Editora ObterPorID(int id)
        {
            Editora editora = new Editora();
            string sql = $"select * from editora where codEditora = '{id}'";
            _banco.AbrirConexao();
            DataTable _dados = _banco.ExecutarSelect(sql);
            if(_dados.Rows.Count > 0)
            {
                editora = new Editora(Convert.ToInt32(_dados.Rows[0]["codEditora"]),
                            _dados.Rows[0]["editora"].ToString(),
                            _dados.Rows[0]["endereco"].ToString(),
                            _dados.Rows[0]["telefone"].ToString(),
                            _dados.Rows[0]["email"].ToString());
            }
            _banco.FecharConexao();
            return editora;
        }
    }
}
