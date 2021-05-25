using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiteca.Model
{
    public class Reserva
    {
        private int _codReserva;
        private DateTime _data;
        private int _codUsuario;
        private int _codTitulo;

        public Reserva(DateTime data, int codUsuario, int codTitulo)
        {
            _data = data;
            _codUsuario = codUsuario;
            _codTitulo = codTitulo;
        }

        public int CodReserva { get => _codReserva; set => _codReserva = value; }
        public DateTime Data { get => _data; set => _data = value; }
        public int CodUsuario { get => _codUsuario; set => _codUsuario = value; }
        public int CodTitulo { get => _codTitulo; set => _codTitulo = value; }
    }
}
