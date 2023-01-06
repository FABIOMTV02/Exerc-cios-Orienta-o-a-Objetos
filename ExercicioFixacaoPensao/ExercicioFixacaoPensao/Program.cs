using System;

namespace ExercicioFixacaoPensao
{
    class Program
    {
        static void Main(string[] args)
        {
            Quarto[] vetor = new Quarto[10];

            Console.Write("Digite a quantidade de quartos alugados: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n ; i++)

            {
                Console.WriteLine();
                Console.WriteLine(i + "° Aluguel:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Apartamento: ");
                int apartamento = int.Parse(Console.ReadLine());
                Console.WriteLine();

                vetor[apartamento] = new Quarto (nome, email);

            }
            Console.WriteLine();

            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                
                if (vetor[i] != null)
                {
                    Console.WriteLine("Quarto " + i + ": " + vetor[i]);
                }
            }


        }
    }
}
