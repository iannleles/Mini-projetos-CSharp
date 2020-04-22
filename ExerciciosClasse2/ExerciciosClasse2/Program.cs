using System;
using System.Globalization;

namespace ExerciciosClasse2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario Func1, Func2;

            Func1 = new Funcionario();
            Func2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario: ");
            Console.Write("Nome: ");
            Func1.nome = Console.ReadLine();
            Console.Write("Salario: ");
            Func1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados do segundo funcionario: ");
            Console.Write("Nome: ");
            Func2.nome = Console.ReadLine();
            Console.Write("Salario: ");
            Func2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (Func1.salario + Func2.salario) / 2.0;

            Console.WriteLine("Salario médio = " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
