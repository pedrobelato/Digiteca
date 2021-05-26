using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // importação do provider mysql

namespace Digiteca.DAL
{
    public class MySQLPersistencia
    {
        string _strCon = "";
        MySqlConnection _conexao;
        MySqlCommand _comando;

        public MySQLPersistencia()
        {
            _strCon = "Server=den1.mysql6.gear.host;Database=digiteca;Uid=digiteca;Pwd=livroxx-;";
            _conexao = new MySqlConnection(_strCon);
            _comando = _conexao.CreateCommand();
        }

        public void AbrirConexao()
        {
            if (_conexao.State != System.Data.ConnectionState.Open)
            {
                _conexao.Open();
            }
        }

        public void FecharConexao()
        {
            _conexao.Close();
            _comando.CommandText = "select, insert, delete...";
        }

        public int UltimoId { get; set; }

        /// <summary>
        /// Executa Insert, Delete ou Update. Além de Stored Procedure.
        /// </summary>
        public int ExecutarNonQuery(string instrucao, Dictionary<string, object> parametros = null) // lista de parâmetros sem obrigatoriedade
        {
            _comando.CommandText = instrucao;
            if (parametros != null)
            {
                foreach (var item in parametros)
                {
                    _comando.Parameters.AddWithValue(item.Key, item.Value);
                }
            }
            int linhasAfetadas = _comando.ExecuteNonQuery();
            if (linhasAfetadas > 0)
            {
                UltimoId = Convert.ToInt32(_comando.LastInsertedId);
            }
            return linhasAfetadas;
        }

        public DataTable ExecutarSelect(string sql, Dictionary<string, object> parametros = null)
        {
            _comando.CommandText = sql;
            DataTable dados = new DataTable();
            if (parametros != null)
            {
                foreach (var item in parametros)
                {
                    _comando.Parameters.AddWithValue(item.Key, item.Value);
                }
            }
            dados.Load(_comando.ExecuteReader()); //carregar o datatable com os dados retornados do _comando
            return dados;
        }

        public object ExecutarConsultaSimples(string sql, Dictionary<string, object> parametros = null)
        {
            object valor = null;
            _comando.CommandText = sql;
            
            if (parametros != null)
            {
                foreach (var item in parametros)
                {
                    _comando.Parameters.AddWithValue(item.Key, item.Value);
                }
            }

            valor = _comando.ExecuteScalar();

            return valor;
        }
    }
}
