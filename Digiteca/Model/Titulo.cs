using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiteca.Model
{
    public class Titulo
    {
        private int _codTitulo;
        private string _tituloLivro;
        private int _quantidade;
        private int _codEditora;

        public Titulo(){}

        public Titulo(int codTitulo, string tituloLivro, int quantidade, int codEditora)
        {
            _codTitulo = codTitulo;
            _tituloLivro = tituloLivro;
            _quantidade = quantidade;
            _codEditora = codEditora;
        }

        public int CodTitulo { get => _codTitulo; set => _codTitulo = value; }
        public string TituloLivro { get => _tituloLivro; set => _tituloLivro = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }
        public int CodEditora { get => _codEditora; set => _codEditora = value; }
    }
}
