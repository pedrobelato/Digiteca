using Digiteca.Model;
using System;
using System.Collections.Generic;
using System.Data;
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
                string sql = "insert into usuario (codUsuario, usuario, cpf) values (@id, @nome, cpf)";

                Dictionary<string, object> ps = new Dictionary<string, object>();
                ps.Add("@codUsuario", usuario.Id);
                ps.Add("@usuario", usuario.Nome);
                ps.Add("@cpf", usuario.Cpf);

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

        public Usuario ObterPorCPF(string cpf)
        {
            Usuario usuario = new Usuario();
            try
            {
                string sql = $"select * from digiteca.usuario where cpf = '{cpf}'";

                _banco.AbrirConexao();
                DataTable dados = _banco.ExecutarSelect(sql);
                if (dados.Rows.Count > 0)
                {
                    usuario = new Usuario(Convert.ToInt32(dados.Rows[0]["codUsuario"]),
                                                    dados.Rows[0]["usuario"].ToString(),
                                                    dados.Rows[0]["cpf"].ToString());
                }
                _banco.FecharConexao();
            }
            catch{}
            return usuario;
        }

        public List<Usuario> ObterPorNome(string nome)
        {
            List<Usuario> usuarios = new List<Usuario>();
            string sql = $"SELECT * FROM digiteca.usuario where usuario like '%{nome}%'";
            _banco.AbrirConexao();
            DataTable dados = _banco.ExecutarSelect(sql);
            for (int i = 0; i < dados.Rows.Count; i++)
            {
                usuarios.Add(new Usuario(Convert.ToInt32(dados.Rows[i]["codUsuario"]),
                                                    dados.Rows[i]["usuario"].ToString(),
                                                    dados.Rows[i]["cpf"].ToString()));
            }
            _banco.FecharConexao();
            return usuarios;
        }
    }
}
