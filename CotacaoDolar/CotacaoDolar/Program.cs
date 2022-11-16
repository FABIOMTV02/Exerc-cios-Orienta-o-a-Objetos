using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotacaoDolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da cotação: ");
            ConversorDeMoeda.valordol = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Quantos Dolares você vai comprar: ");
            double quantidade = double.Parse(Console.ReadLine());
            double valortotal = ConversorDeMoeda.Valortotal(quantidade);

            Console.WriteLine();

            Console.WriteLine("Valor da operação é: " + (valortotal * 1.15));

            Console.ReadLine();
        }
    }
}
