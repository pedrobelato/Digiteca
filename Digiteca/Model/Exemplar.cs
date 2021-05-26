using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiteca.Model
{
    public class Exemplar
    {
        private int _codSeqExemplar;
        private int _codLivro;
        private int _situacao;

        public Exemplar()
        {

        }

        public Exemplar(int codSeqExemplar, int codLivro, int situacao)
        {
            _codSeqExemplar = codSeqExemplar;
            _codLivro = codLivro;
            _situacao = situacao;
        }

        public int CodSeqExemplar { get => _codSeqExemplar; set => _codSeqExemplar = value; }
        public int CodLivro { get => _codLivro; set => _codLivro = value; }
        public int Situacao { get => _situacao; set => _situacao = value; }
    }
}
