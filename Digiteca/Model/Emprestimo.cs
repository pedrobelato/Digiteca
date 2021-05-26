using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiteca.Model
{
    public class Emprestimo
    {
        private int _codEmp;
        private DateTime _data;
        private Usuario _usuario;

        public Emprestimo(DateTime data, Usuario usuario)
        {
            _data = data;
            _usuario = usuario;
        }

        public Emprestimo(int codEmp, DateTime data, Usuario usuario)
        {
            _codEmp = codEmp;
            _data = data;
            _usuario = usuario;
        }

        public int CodEmp { get => _codEmp; set => _codEmp = value; }
        public DateTime Data { get => _data; set => _data = value; }
        public Usuario Usuario { get => _usuario; set => _usuario = value; }
    }
}
