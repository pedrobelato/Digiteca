using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiteca.Model
{
    public class Livro
    {
        private int _cod_livro;
        private string _tit_livro;
        private string _autor_livro;
        private string _ano_livro;
        private string _editora_livro;
        private string _local_prateleira_livro;
        private string _qtde_exemplares;

        public Livro(string tit_livro, string autor_livro, string ano_livro, string editora_livro, string local_prateleira_livro, string qtde_exemplares)
        {
            _tit_livro = tit_livro;
            _autor_livro = autor_livro;
            _ano_livro = ano_livro;
            _editora_livro = editora_livro;
            _local_prateleira_livro = local_prateleira_livro;
            _qtde_exemplares = qtde_exemplares;
        }

        public int Cod_livro { get => _cod_livro; set => _cod_livro = value; }
        public string Tit_livro { get => _tit_livro; set => _tit_livro = value; }
        public string Autor_livro { get => _autor_livro; set => _autor_livro = value; }
        public string Ano_livro { get => _ano_livro; set => _ano_livro = value; }
        public string Editora_livro { get => _editora_livro; set => _editora_livro = value; }
        public string Local_prateleira_livro { get => _local_prateleira_livro; set => _local_prateleira_livro = value; }
        public string Qtde_exemplares { get => _qtde_exemplares; set => _qtde_exemplares = value; }
    }
}
