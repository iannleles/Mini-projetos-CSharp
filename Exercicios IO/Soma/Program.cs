using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;

            while (n != 0) { 
            Console.WriteLine("Escolha opção: ");
            Console.WriteLine("1 - SOMA");
            Console.WriteLine("2 - RAIO DO CIRCULO");
            Console.WriteLine("3 - DIFERENÇA");
            Console.WriteLine("4 - SALARIO");
            Console.WriteLine("5 - VALOR A PAGAR");
            Console.WriteLine("6 - TRES VALORES");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {

                case 1:
                    int n1 = int.Parse(Console.ReadLine());
                    int n2 = int.Parse(Console.ReadLine());
                    int Soma = n1 + n2;
                    Console.WriteLine("SOMA = {0}", Soma);
                    break;
                case 2:

                    double entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    double area = 3.14159 * Math.Pow(entrada, 2);

                    Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

                    break;
                case 3:
                    int A = int.Parse(Console.ReadLine());
                    int B = int.Parse(Console.ReadLine());
                    int C = int.Parse(Console.ReadLine());
                    int D = int.Parse(Console.ReadLine());

                    int diferenca = (A * B) - (C * D);

                    Console.WriteLine($"DIFERENCA = {diferenca}");
                    break;
                case 4:
                    int numero = int.Parse(Console.ReadLine());
                    int horas = int.Parse(Console.ReadLine());
                    double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    double horasTrabalhadas = valor * horas;
                    Console.WriteLine("NUMBER = {0}", numero);
                    Console.WriteLine("SALARY = U$ " + horasTrabalhadas.ToString("F2", CultureInfo.InvariantCulture));

                    break;
                case 5:

                    string[] vet = Console.ReadLine().Split(' ');

                    int codigo1 = int.Parse(vet[0]);
                    int numero1 = int.Parse(vet[1]);
                    double valor1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                    string[] vet2 = Console.ReadLine().Split(' ');

                    int codigo2 = int.Parse(vet2[0]);
                    int numero2 = int.Parse(vet2[1]);
                    double valor2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

                    double total = (numero1 * valor1) + (numero2 * valor2);

                    Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;

                case 6:

                    string[] vetor = Console.ReadLine().Split(' ');

                    double A6 = double.Parse(vetor[0], CultureInfo.InvariantCulture);
                    double B6 = double.Parse(vetor[1], CultureInfo.InvariantCulture);
                    double C6 = double.Parse(vetor[2], CultureInfo.InvariantCulture);

                    double triangulo = A6 * C6 / 2.0 ;
                    double circulo = 3.14159 * Math.Pow(C6, 2);
                    double trapezio = (A6 + B6) / 2 * C6;
                    double quadrado = B6 * B6;
                    double retangulo = A6 * B6;

                    Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
                    Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
                    Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
                    Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
                    Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

                    break;

                default:
                    Console.WriteLine("Opção Errada!");
                    break;
            }
                Console.WriteLine("Executar o programa novamente pressione 1, ou 0 para sair");

                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Aplicação encerrada!");



        }
        }
    }
