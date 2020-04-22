using System;

namespace PrimeirosExerciciosClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // para criar os objetos da classe Pessoa
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();


            
            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");

            //para ler os dados chamando o objeto 'P1' e o atributo 'NOME'
            p1.nome = Console.ReadLine();
            Console.Write("Idade: ");

            //para ler os dados chamando o objeto 'P1' e o atributo 'IDADE'
            p1.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");

            // para ler os dados chamando o objeto P2 e o atributo nome da classe Pessoa
            p2.nome = Console.ReadLine();
            Console.Write("Idade: ");


            // para ler os dados chamando o objeto P2 e o atributo Idade da classe Pessoa
            p2.idade = int.Parse(Console.ReadLine());


            // para verificar qual a maior idade seguindo o seus objetos
            if (p1.idade > p2.idade)
            {
                Console.WriteLine("Pessoa mais velha: {0}", p1.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: {0}", p2.nome);
            }

            Console.ReadLine();
        }
    }
}
