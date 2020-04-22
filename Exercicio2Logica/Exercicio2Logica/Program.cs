using System;
using System.Globalization;

namespace Exercicio2Logica
{
    class Program
    {
        static void Main(string[] args)
        {
            // para apresentar na tela a mensagem e fazer a leitura do nome completo
            Console.WriteLine("Entre com seu nome completo");
            string Fullname = Console.ReadLine();

            //para apresentar na tela a mensagem e fazer a leitura da quantidade de quartos
            Console.WriteLine("Quantos quartos tem sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            //para apresentar na tela a mensagem e fazer leitura do preço, com ponto e casas decimais (tipo double)
            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            // para aprensentar na tela a mensagem
            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha) ");
            
            // para fazer a leitura dos dados da linha separados por espaço
            string[] vet = Console.ReadLine().Split(' ');

            string lastname = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);


            // para apresentar na tela o valor das variáveis dos dados preenchidos
            Console.WriteLine(Fullname);
            Console.WriteLine(quartos);

            // para apresentar na tela o valor do preço com ponto separando duas casas decimais
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastname);
            Console.WriteLine(idade);

            // para apresentar na tela a altura com ponto e duas casas decimais
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));




        }
    }
}
