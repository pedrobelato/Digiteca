using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiteca.Model
{
    public class Editora
    {
        private int _codEditora;
        private string _editora;
        private string _endereco;
        private string _telefone;
        private string _email;

        public Editora(int codEditora, string editora, string endereco, string telefone, string email)
        {
            _codEditora = codEditora;
            _editora = editora;
            _endereco = endereco;
            _telefone = telefone;
            _email = email;
        }
        public Editora()
        {
        }

        public int codEditora { get => _codEditora; set => _codEditora = value; }
        public string editora { get => _editora; set => _editora = value; }
        public string endereco { get => _endereco; set => _endereco = value; }
        public string telefone { get => _telefone; set => _telefone = value; }
        public string email { get => _email; set => _email = value; }
    }
}
