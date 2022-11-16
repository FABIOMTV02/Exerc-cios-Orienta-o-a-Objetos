using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioFuncionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salario salario = new Salario();
            
            Console.Write("Nome: ");
            salario.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            salario.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            salario.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + salario);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double pct = double.Parse(Console.ReadLine());
            salario.AdicionarSal(pct);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + salario);


            Console.ReadLine();
        }
    }
}
