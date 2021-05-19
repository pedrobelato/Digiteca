using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiteca.Model
{
    public class Autor
    {
        private int _codAutor;
        private string _autor;
        private string _endereco;
        private string _telefone;
        private string _email;

        public Autor(int codAutor, string autor, string endereco, string telefone, string email)
        {
            this._codAutor = codAutor;
            this._autor = autor;
            this._endereco = endereco;
            this._telefone = telefone;
            this._email = email;
        }

        public int codAutor { get => _codAutor; set => _codAutor = value; }
        public string autor { get => _autor; set => _autor = value; }
        public string endereco { get => _endereco; set => _endereco = value; }
        public string telefone { get => _telefone; set => _telefone = value; }
        public string email { get => _email; set => _email = value; }
    }
}
