using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agencia CaixaEletronico;

            Console.Write("Digite o número da Conta: ");
            int titular = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Digite o nome do Titular: ");
            string nome = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Deseja efetuar um depósito inicial? (s/n): ");
            char deposito = char.Parse(Console.ReadLine());
            if (deposito == 's' || deposito == 'S')
            {
                Console.WriteLine();
                Console.Write("Digite o valor do depósito: ");
                double depositoinicial = double.Parse(Console.ReadLine());
                CaixaEletronico = new Agencia(titular, nome, depositoinicial);
            }
            else
            {
                CaixaEletronico = new Agencia(titular, nome);
            }

            Console.WriteLine();
            Console.WriteLine(CaixaEletronico);

            Console.WriteLine();
            Console.Write("Deseja realizar mais um Depósito: ");
            double valor = double.Parse(Console.ReadLine());
            CaixaEletronico.Deposito(valor);

            Console.WriteLine();
            Console.WriteLine(CaixaEletronico);

            Console.WriteLine();
            Console.Write("Deseja realizar um Saque: ");
            valor = double.Parse(Console.ReadLine());
            CaixaEletronico.Saque(valor);

            Console.WriteLine();
            Console.WriteLine(CaixaEletronico);
        }
    }
}
