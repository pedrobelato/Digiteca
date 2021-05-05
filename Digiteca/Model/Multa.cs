using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiteca.Model
{
    public class Multa
    {
        private int _codMulta;
        private double _baseMulta;
        private double _juroMulta;
        private string _codEmpDev;
        private int _codUsuario;

        public Multa(int codMulta, double baseMulta, double juroMulta, string codEmpDev, int codUsuario)
        {
            _codMulta = codMulta;
            _baseMulta = baseMulta;
            _juroMulta = juroMulta;
            _codEmpDev = codEmpDev;
            _codUsuario = codUsuario;
        }

        public int CodMulta { get => _codMulta; set => _codMulta = value; }
        public double BaseMulta { get => _baseMulta; set => _baseMulta = value; }
        public double JuroMulta { get => _juroMulta; set => _juroMulta = value; }
        public string CodEmpDev { get => _codEmpDev; set => _codEmpDev = value; }
        public int CodUsuario { get => _codUsuario; set => _codUsuario = value; }
    }
}
