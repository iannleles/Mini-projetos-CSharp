using System;
using System.Collections.Generic;
using System.Globalization;

namespace FuncionariosExLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employe #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionario(id, name, salary));
                Console.WriteLine();

            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());

            Funcionario emp = list.Find(x => x.Id == searchId);

            if (emp != null)
            {
                Console.Write("Enther the porcentage : ");
                double porcentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(porcentage);
            }
            else
            {
                Console.WriteLine("This Id does is not exist!");
            }
            Console.WriteLine();
            Console.WriteLine("Update list of employes: ");
            foreach(Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }



        }
    }
}
