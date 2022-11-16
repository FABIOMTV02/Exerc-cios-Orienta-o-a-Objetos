using System;

namespace ClassPerimetro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            Console.Write("Entre com a altura do retângulo: ");
            retangulo.Altura = double.Parse(Console.ReadLine());
            Console.Write("Entre com a largura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Area: " + retangulo.Area().ToString("F2"));

            Console.WriteLine();
            Console.WriteLine("Perimetro: " + retangulo.Perimetro().ToString("F2"));

            Console.WriteLine();
            Console.WriteLine("Diagonal: " + retangulo.Diagonal().ToString("F2"));

            Console.ReadLine();
        }
    }
}
