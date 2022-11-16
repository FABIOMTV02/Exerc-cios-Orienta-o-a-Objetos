using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionarios colaborador1, colaborador2;
            colaborador1 = new Funcionarios();
            colaborador2 = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            colaborador1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            colaborador1.salario = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            colaborador2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            colaborador2.salario = double.Parse(Console.ReadLine());

            double salariomedio = (colaborador1.salario + colaborador2.salario) / 2;
            Console.WriteLine("O Salário médio é de: " + salariomedio.ToString("F2"));


            Console.ReadLine();
        }
    }
}
