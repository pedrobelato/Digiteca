using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiteca.Model
{
    public class Telefone
    {
        private int _codUsuario;
        private int _DDD;
        private string _nrTel;

        public Telefone(int codUsuario, int dDD, string nrTel)
        {
            _codUsuario = codUsuario;
            _DDD = dDD;
            _nrTel = nrTel;
        }

        public int CodUsuario { get => _codUsuario; set => _codUsuario = value; }
        public int DDD { get => _DDD; set => _DDD = value; }
        public string NrTel { get => _nrTel; set => _nrTel = value; }
    }
}
