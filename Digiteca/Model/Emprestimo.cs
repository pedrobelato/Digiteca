using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiteca.Model
{
    public class Emprestimo
    {
        private int _codEmpDev;
        private DateTime _data;
        private Usuario usuario;

        public Emprestimo(DateTime data, Usuario usuario)
        {
            _data = data;
        }

        public int CodEmpDev { get => _codEmpDev; set => _codEmpDev = value; }
        public DateTime Data { get => _data; set => _data = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }
    }
}
