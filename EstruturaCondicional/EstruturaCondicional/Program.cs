using System;
using System.Globalization;

namespace EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        { 



            Console.WriteLine("Selecione a opção do Exercicio: ");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    int numero = int.Parse(Console.ReadLine());

                    if (numero < 0)
                    {
                        Console.WriteLine("NEGATIVO");
                    }
                    else
                    {
                        Console.WriteLine("NÃO NEGATIVO");
                    }
                    break;

                case 2:

                    int numero2 = int.Parse(Console.ReadLine());

                    if (numero2 % 2 == 0)
                    {
                        Console.WriteLine("PAR");
                    }
                    else if (numero2 == 0.0)
                    {
                        Console.WriteLine("PAR");
                    }
                    else
                    {
                        Console.WriteLine("IMPAR");
                    }

                    break;
                case 3:

                    string[] vet = Console.ReadLine().Split(' ');

                    int num1 = int.Parse(vet[0]);
                    int num2 = int.Parse(vet[1]);

                    int maior = 0;
                    int menor = 0;

                    if (num1 > num2)
                    {
                        maior = num1;
                        menor = num2;

                    }
                    else
                    {
                        menor = num1;
                        maior = num2;
                    }
                    if (maior % menor == 0)
                    {
                        Console.WriteLine("São Multiplos");
                    }
                    else
                    {
                        Console.WriteLine("Não são multiplos");
                    }

                    break;
                case 4:
                    int duracao = 0;
                    string[] vet2 = Console.ReadLine().Split(' ');

                    int horainicial = int.Parse(vet2[0]);
                    int horafinal = int.Parse(vet2[1]);

                    if (horainicial < horafinal)
                    {
                        duracao = horafinal - horainicial;
                    }
                    else
                    {
                        duracao = 24 - horainicial + horafinal;
                    }

                    Console.WriteLine("O JOGO DUROU {0} HORA(S)", duracao);

                    break;
                case 5:
                    string[] vet3 = Console.ReadLine().Split(' ');

                    int codigo = int.Parse(vet3[0]);
                    int quantidade = int.Parse(vet3[1]);
                    double preco = 0.0;
                    if (codigo == 1)
                    {
                        preco = 4.0 * quantidade;

                    }
                    else if (codigo == 2)
                    {
                        preco = 4.50 * quantidade;
                    }
                    else if (codigo == 3)
                    {
                        preco = 5.00 * quantidade;
                    }
                    else if (codigo == 4)
                    {
                        preco = 2.00 * quantidade;
                    }
                    else if (codigo == 5)
                    {
                        preco = 1.50 * quantidade;
                    }
                    else
                    {
                        Console.WriteLine("Codigo inválido");
                    }

                    Console.WriteLine("Total: R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));


                    break;

                case 6:
                    double entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    if (entrada < 0.0 || entrada > 100.0)
                    {
                        Console.WriteLine("Fora de intervalo");
                    }
                    else if (entrada <= 25.0)
                    {
                        Console.WriteLine("Intervalo (0,25]");
                    }
                    else if (entrada <= 50.0)
                    {
                        Console.WriteLine("Intervalo [25,50]");
                    }
                    else if (entrada <= 75.0)
                    {
                        Console.WriteLine("Intervalo [50,75]");
                    }
                    else
                    {
                        Console.WriteLine("Intervalo [75,100]");
                    }

                    break;

                case 7:
                    string[] vet4 = Console.ReadLine().Split(' ');

                    double x = double.Parse(vet4[0], CultureInfo.InvariantCulture);
                    double y = double.Parse(vet4[1], CultureInfo.InvariantCulture);

                    if (x > 0.0 && y > 0.0)
                    {
                        Console.WriteLine("Q1");
                    }
                    else if (x < 0.0 && y > 0.0)
                    {
                        Console.WriteLine("Q2");
                    }
                    else if (x < 0.0 && y < 0.0)
                    {
                        Console.WriteLine("Q3");
                    }

                    else if (x > 0.0 && y < 0.0)
                    {
                        Console.WriteLine("Q4");
                    }
                    else
                    {
                        Console.WriteLine("Origem");
                    }

                    break;

                case 8:
                    double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    double imposto = 0.0;

                    if (salario <= 2000.0)
                    {
                        imposto = 0.0;
                    }
                    else if (salario <= 3000.00)
                    {
                        imposto = (salario - 2000.00) * 0.08;
                    }
                    else if (salario <= 4500.00)
                    {
                        imposto = (salario - 3000.00) * 0.18 + 1000.0 * 0.08;
                    }
                    else
                    {
                        imposto = (salario - 4500.0) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
                    }


                    if (imposto == 0.0)
                    {
                        Console.WriteLine("Insento");
                    }
                    else
                    {
                        Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
                    }

                    break;

                default:
                    {
                        Console.WriteLine("Opcao inválida");

                    }
                    break;

            }
        }
    }
}
