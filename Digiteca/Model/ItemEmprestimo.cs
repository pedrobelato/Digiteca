using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiteca.Model
{
    public class ItemEmprestimo
    {
        private string _codEmprestimo;
        private int _codUsuario;
        private int _codExemplar;
        private DateTime _dataEmp;
        private DateTime _dataLimite;
        private int _devolucao;

        public ItemEmprestimo(string codEmprestimo, int codUsuario, int codExemplar, DateTime dataEmp, DateTime dataLimite, int devolucao)
        {
            _codEmprestimo = codEmprestimo;
            _codUsuario = codUsuario;
            _codExemplar = codExemplar;
            _dataEmp = dataEmp;
            _dataLimite = dataLimite;
            _devolucao = devolucao;
        }

        public string CodEmprestimo { get => _codEmprestimo; set => _codEmprestimo = value; }
        public int CodUsuario { get => _codUsuario; set => _codUsuario = value; }
        public int CodExemplar { get => _codExemplar; set => _codExemplar = value; }
        public DateTime DataEmp { get => _dataEmp; set => _dataEmp = value; }
        public DateTime DataLimite { get => _dataLimite; set => _dataLimite = value; }
        public int Devolucao { get => _devolucao; set => _devolucao = value; }
    }
}
