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
        private int _codSeqExemplar;

        public Reserva(int codReserva, DateTime data, int codUsuario, int codSeqExemplar)
        {
            _codReserva = codReserva;
            _data = data;
            _codUsuario = codUsuario;
            _codSeqExemplar = codSeqExemplar;
        }

        public int CodReserva { get => _codReserva; set => _codReserva = value; }
        public DateTime Data { get => _data; set => _data = value; }
        public int CodUsuario { get => _codUsuario; set => _codUsuario = value; }
        public int CodSeqExemplar { get => _codSeqExemplar; set => _codSeqExemplar = value; }
    }
}
