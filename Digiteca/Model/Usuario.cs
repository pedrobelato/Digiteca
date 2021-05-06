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

        public static bool ValidarCPF(string vrCPF)
        {
            string valor = vrCPF.Replace(".", "");

            valor = valor.Replace("-", "");

            if (valor.Length != 11)
                return false;

            bool igual = true;
            for (int i = 1; i < 11 && igual; i++)
                if (valor[i] != valor[0])
                    igual = false;

            if (igual || valor == "12345678909")
                return false;

            int[] numeros = new int[11];

            for (int i = 0; i < 11; i++)
                numeros[i] = int.Parse(valor[i].ToString());

            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += (10 - i) * numeros[i];

            int resultado = soma % 11;
            if (resultado == 1 || resultado == 0)
            {
                if (numeros[9] != 0)
                    return false;
            }
            else if (numeros[9] != 11 - resultado)
                return false;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += (11 - i) * numeros[i];

            resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[10] != 0)
                    return false;
            }
            else
                if (numeros[10] != 11 - resultado)
                return false;
            return true;
        }
    }
}
