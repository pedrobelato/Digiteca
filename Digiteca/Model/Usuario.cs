using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiteca.Model
{
    public class Usuario
    {
        private int _id;
        private string _nome;
        private string _cpf;
        private string _telefone;
        private string _logradouro;

        public Usuario(){}

        public Usuario(int id, string nome, string cpf, string telefone, string logradouro)
        {
            _id = id;
            _nome = nome;
            _cpf = cpf;
            _telefone = telefone;
            _logradouro = logradouro;
        }

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public string Logradouro { get => _logradouro; set => _logradouro = value; }
    }
}
