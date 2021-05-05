using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digiteca.Model
{
    public class Usuario
    {
        private int _id;
        private string _nome;
        private string _cpf;
        private List<Telefone> _telefone;
        private List<Logradouro> _logradouro;
        private List<Reserva> _reservas;

        public Usuario(){}

        public Usuario(int id, string nome, string cpf, List<Telefone> telefone, List<Logradouro> logradouro)
        {
            _id = id;
            _nome = nome;
            _cpf = cpf;
            _telefone = telefone;
            _logradouro = logradouro;
        }

        public Usuario(int id, string nome, string cpf, List<Telefone> telefone, List<Logradouro> logradouro, List<Reserva> reservas)
        {
            _id = id;
            _nome = nome;
            _cpf = cpf;
            _telefone = telefone;
            _logradouro = logradouro;
            _reservas = reservas;
        }

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public List<Telefone> Telefone { get => _telefone; set => _telefone = value; }
        public List<Logradouro> Logradouro { get => _logradouro; set => _logradouro = value; }
        public List<Reserva> Reservas { get => _reservas; set => _reservas = value; }
    }
}
