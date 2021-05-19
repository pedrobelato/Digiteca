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

        public List<Editora> ObterPorID(int id)
        {
            List<Editora> editora = new List<Editora>();
            string sql = $"select * from editora where codEditora = '{id}'";
            _banco.AbrirConexao();
            DataTable _dados = _banco.ExecutarSelect(sql);
            for (int i = 0; i < _dados.Rows.Count; i++)
            {
                editora.Add(new Editora(Convert.ToInt32(_dados.Rows[i]["codEditora"]),
                            _dados.Rows[i]["editora"].ToString(),
                            _dados.Rows[i]["endereco"].ToString(),
                            _dados.Rows[i]["telefone"].ToString(),
                            _dados.Rows[i]["email"].ToString()));
            }
            _banco.FecharConexao();
            return editora;
        }
    }
}
