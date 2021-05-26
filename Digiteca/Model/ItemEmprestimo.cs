using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiteca.Model
{
    public class ItemEmprestimo
    {
        private int _codEmprestimo;
        private Usuario _usuario;
        private Exemplar _exemplar;
        private DateTime _dataEmp;
        private DateTime _dataLimite;
        private int _devolucao;

        public ItemEmprestimo(int codEmprestimo, Usuario usuario, Exemplar exemplare, DateTime dataEmp, DateTime dataLimite, int devolucao)
        {
            _codEmprestimo = codEmprestimo;
            _usuario = usuario;
            _exemplar = exemplare;
            _dataEmp = dataEmp;
            _dataLimite = dataLimite;
            _devolucao = devolucao;
        }

        public int CodEmprestimo { get => _codEmprestimo; set => _codEmprestimo = value; }
        public DateTime DataEmp { get => _dataEmp; set => _dataEmp = value; }
        public DateTime DataLimite { get => _dataLimite; set => _dataLimite = value; }
        public int Devolucao { get => _devolucao; set => _devolucao = value; }
        public Usuario Usuario { get => _usuario; set => _usuario = value; }
        public Exemplar Exemplar { get => _exemplar; set => _exemplar = value; }
    }
}
