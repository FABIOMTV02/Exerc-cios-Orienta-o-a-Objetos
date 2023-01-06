using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Chamando Classe
            Banco contabancaria;

            Console.WriteLine("Entre com os dados da conta: ");
            
            Console.Write("Número: ");
            int conta = int.Parse(Console.ReadLine());
            
            Console.Write("Nome do Titular: ");
            string nome = Console.ReadLine();
           
            Console.Write("Haverá depósito inicial?: ");
            char deposito = char.Parse(Console.ReadLine());
            
            if (deposito == 's' || deposito == 'S')
            {
                Console.Write("Qual o valor do depósito?: ");
                double depositoinicial = double.Parse(Console.ReadLine());
                
                //Chamando Classe
                contabancaria = new Banco(conta, nome, depositoinicial);
            }
            else
            {
                //Chamando Classe
                contabancaria = new Banco(conta, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da Conta:");
            Console.Write(contabancaria);

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Digite o valor do TED: ");
            double quantia = double.Parse(Console.ReadLine());
            contabancaria.Deposito(quantia);
            
            Console.WriteLine("Dados da Conta: " + contabancaria);

            Console.WriteLine();
            Console.Write("Digite o valor de Saque: ");
            quantia = double.Parse(Console.ReadLine());
            contabancaria.Saque(quantia);
            Console.WriteLine();
            Console.WriteLine("Dados da Conta: " + contabancaria);




        }
    }
}
