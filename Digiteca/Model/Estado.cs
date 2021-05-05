using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiteca.Model
{
    public class Estado
    {
        private int _codEstado;
        private int _siglaEstado;
        private int _nomeEstado;

        public Estado(int codEstado, int siglaEstado, int nomeEstado)
        {
            _codEstado = codEstado;
            _siglaEstado = siglaEstado;
            _nomeEstado = nomeEstado;
        }

        public int CodEstado { get => _codEstado; set => _codEstado = value; }
        public int SiglaEstado { get => _siglaEstado; set => _siglaEstado = value; }
        public int NomeEstado { get => _nomeEstado; set => _nomeEstado = value; }
    }
}
