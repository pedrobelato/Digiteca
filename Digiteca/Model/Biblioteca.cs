using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiteca.Model
{
    public class Biblioteca
    {
        private int _id;
        private string _nome;
        private string _senha;
        public Biblioteca()
        {

        }

        public Biblioteca(int id, string nome, string senha)
        {
            _id = id;
            _nome = nome;
            _senha = senha;
        }

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Senha { get => _senha; set => _senha = value; }
    }
}
