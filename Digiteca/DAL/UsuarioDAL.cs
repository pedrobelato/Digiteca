using Digiteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiteca.DAL
{
    public class UsuarioDAL
    {
        MySQLPersistencia _banco = new MySQLPersistencia();
        public (int, string) GravarUsuario(Usuario usuario)
        {
            int linhasAfetadas = 0;
            string msg = "";
            try
            {
                string sql = "insert into usuario (id, nome,...) values (@id, @nome...)";

                Dictionary<string, object> ps = new Dictionary<string, object>();
                ps.Add("@id", usuario.Id);
                ps.Add("@nome", usuario.Cpf);

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
    }
}
