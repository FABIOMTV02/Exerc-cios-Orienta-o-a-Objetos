using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    internal class Banco
    {
        private int _conta;
        private string _nome;
        private char _deposito;
        private double _valordeposito;
        private double _ted;
        private double _saque;

        public Banco(int conta, string nome)
        {
            _conta = conta;
            _nome = nome;
        }

        public Banco(int conta, string nome, char deposito, double valordeposito)
        {
            _conta = conta;
            _nome = nome;
            _deposito = deposito;
            _valordeposito = valordeposito;
        }

        public Banco(double transted)
        {
            _ted = transted;
        }

        public double transted
        {
            get { return _ted; }
        }

        public double valordeposito
        {
            get { return _valordeposito; }
        }

        public double saque
        {
            get { return _saque; }
        }

        public double Saldo()
        {
            return (_valordeposito + _ted - _saque);
        }


        public override string ToString()
        {
            return "Conta: " + _conta
                + ", Titular: " + _nome
                + ", Saldo: " + Saldo()
                + " ";
        }
    }
}
