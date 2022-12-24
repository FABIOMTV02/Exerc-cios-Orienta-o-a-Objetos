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
            Banco b;


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
                double valordeposito = double.Parse(Console.ReadLine());
                
                //Chamando Classe
                b = new Banco(conta, nome, deposito, valordeposito);
            }
            else
            {
                //Chamando Classe
                b = new Banco(conta, nome);
            }


            Console.WriteLine("Dados da Conta:");
            Console.Write(b);

            Console.WriteLine("Digite o valor do TED: ");
            double transted = double.Parse(Console.ReadLine());
            b = new Banco(transted);
            Console.WriteLine("Dados da Conta: " + b);




        }
    }
}
