using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoV2
{
    internal class Agencia
    {
        public int Titular { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Agencia(int titular, string nome)
        {
            Titular = titular;
            Nome = nome;
        }

        public Agencia(int titular, string nome, double saldo) : this(titular, nome)
        {
            Saldo = saldo;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double saque)
        {
            Saldo -= saque;
            Saldo -= 5;
        }

        public override string ToString()
        {
            return "Nome: " + Nome
                + ", Titular: " + Titular
                + ", Saldo: " + Saldo
                + " ";
        }
    }
}
