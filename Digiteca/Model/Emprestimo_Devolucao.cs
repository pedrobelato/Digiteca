using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiteca.Model
{
    public class Emprestimo_Devolucao
    {
        private int _codEmpDev;
        private DateTime _data;
        private string _situacao;
        private int _codUsuario;
        private int _codSeqExemplar;
        private List<Multa> _multas;

        public Emprestimo_Devolucao(int codEmpDev, DateTime data, string situacao, int codUsuario, int codSeqExemplar)
        {
            _codEmpDev = codEmpDev;
            _data = data;
            _situacao = situacao;
            _codUsuario = codUsuario;
            _codSeqExemplar = codSeqExemplar;
        }

        public int CodEmpDev { get => _codEmpDev; set => _codEmpDev = value; }
        public DateTime Data { get => _data; set => _data = value; }
        public string Situacao { get => _situacao; set => _situacao = value; }
        public int CodUsuario { get => _codUsuario; set => _codUsuario = value; }
        public int CodSeqExemplar { get => _codSeqExemplar; set => _codSeqExemplar = value; }
        public List<Multa> Multas { get => _multas; set => _multas = value; }
    }
}
