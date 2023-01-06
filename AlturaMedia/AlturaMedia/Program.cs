using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlturaMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de pessoas: ");
            int n = int.Parse(Console.ReadLine());
            double[] vetor = new double[n];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite uma altura válida: ");
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0;

            for(int i = 0; i < n; i++)
            {
                soma+= vetor[i];
            }

            double media = soma / n;

            Console.WriteLine("Média das alturas foi de: " + media.ToString("F2"), CultureInfo.InvariantCulture);



        }
    }
}
