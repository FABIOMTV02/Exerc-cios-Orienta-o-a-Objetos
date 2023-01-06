using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    internal class Banco
    {
        public int Conta { get; private set; }
        public string Nome { get;  set; }
        public double Saldo { get; private set; }

        public Banco(int conta, string nome)
        {
            Conta = conta;
            Nome = nome;
        }

        public Banco(int conta, string nome, double depositoinicial ) : this(conta, nome)
        {
            Deposito(depositoinicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia;
            Saldo -= 5;
        }
        public override string ToString()
        {
            return "Conta: " + Conta
                + ", Titular: " + Nome
                + ", Saldo: " + Saldo;
        }
    }
}
