using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiteca.Model
{
    public class Logradouro
    {
        private int _codUsuario;
        private int _codEstado;
        private string _nomeCidade;
        private string _rua;
        private string _bairro;
        private string _numero;
        private string _cep;

        public Logradouro(int codUsuario, int codEstado, string nomeCidade, string rua, string bairro, string numero, string cep)
        {
            _codUsuario = codUsuario;
            _codEstado = codEstado;
            _nomeCidade = nomeCidade;
            _rua = rua;
            _bairro = bairro;
            _numero = numero;
            _cep = cep;
        }

        public int CodUsuario { get => _codUsuario; set => _codUsuario = value; }
        public int CodEstado { get => _codEstado; set => _codEstado = value; }
        public string NomeCidade { get => _nomeCidade; set => _nomeCidade = value; }
        public string Rua { get => _rua; set => _rua = value; }
        public string Bairro { get => _bairro; set => _bairro = value; }
        public string Numero { get => _numero; set => _numero = value; }
        public string Cep { get => _cep; set => _cep = value; }
    }
}
