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
        private string _situacao;
        private List<Reserva> _reservas;
        private List<Emprestimo_Devolucao> _emprestimo_devolucao;

        public Exemplar(int codSeqExemplar, int codLivro, string situacao)
        {
            _codSeqExemplar = codSeqExemplar;
            _codLivro = codLivro;
            _situacao = situacao;
        }

        public Exemplar(int codSeqExemplar, int codLivro, string situacao, List<Reserva> reservas)
        {
            _codSeqExemplar = codSeqExemplar;
            _codLivro = codLivro;
            _situacao = situacao;
            _reservas = reservas;
        }

        public Exemplar(int codSeqExemplar, int codLivro, string situacao, List<Emprestimo_Devolucao> emprestimo_devolucao)
        {
            _codSeqExemplar = codSeqExemplar;
            _codLivro = codLivro;
            _situacao = situacao;
            _emprestimo_devolucao = emprestimo_devolucao;
        }

        public Exemplar(int codSeqExemplar, int codLivro, string situacao, List<Reserva> reservas, List<Emprestimo_Devolucao> emprestimo_devolucao)
        {
            _codSeqExemplar = codSeqExemplar;
            _codLivro = codLivro;
            _situacao = situacao;
            _reservas = reservas;
            _emprestimo_devolucao = emprestimo_devolucao;
        }

        public int CodSeqExemplar { get => _codSeqExemplar; set => _codSeqExemplar = value; }
        public int CodLivro { get => _codLivro; set => _codLivro = value; }
        public string Situacao { get => _situacao; set => _situacao = value; }
        public List<Reserva> Reservas { get => _reservas; set => _reservas = value; }
        public List<Emprestimo_Devolucao> Emprestimo_devolucao { get => _emprestimo_devolucao; set => _emprestimo_devolucao = value; }
    }
}
