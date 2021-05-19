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
        private int _codSeqExemplar;

        public Reserva(DateTime data, int codUsuario, int codSeqExemplar)
        {
            _data = data;
            _codUsuario = codUsuario;
            _codSeqExemplar = codSeqExemplar;
        }

        public DateTime Data { get => _data; set => _data = value; }
        public int CodUsuario { get => _codUsuario; set => _codUsuario = value; }
        public int CodSeqExemplar { get => _codSeqExemplar; set => _codSeqExemplar = value; }
    }
}
