using System;
using System.Globalization;

namespace Exercicios4For
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    int x = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= x; i++)
                    {
                        if (i % 2 == 1)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;
                case 2:
                    int N = int.Parse(Console.ReadLine());
                    int dentro = 0;
                    int fora = 0;
                    for (int i = 0; i < 5; i++)
                    {
                        int valor = int.Parse(Console.ReadLine());
                        if (valor >= 10 && valor <= 20)
                        {
                            dentro += 1;
                        }
                        else
                        {
                            fora += 1;
                        }
                    }
                    Console.WriteLine($"{dentro} in");
                    Console.WriteLine($"{fora} out");
                    break;
                case 3:
                    int N2 = int.Parse(Console.ReadLine());

                    for (int i = 0; i < N2; i++)
                    {
                        string[] vet = Console.ReadLine().Split(' ');

                        double v1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                        double v2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                        double v3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                        double mediaP = (v1 * 2 + v2 * 3 + v3 * 5) / 10;

                        Console.WriteLine(mediaP.ToString("F1", CultureInfo.InvariantCulture));

                    }


                    break;

                case 4:
                    int N3 = int.Parse(Console.ReadLine());

                    for (int i = 0; i < N3; i++)
                    {
                        
                        string [] vet2 = Console.ReadLine().Split(' ');

                        int Num1 = int.Parse(vet2[0]);
                        int Num2 = int.Parse(vet2[1]);

                        if (Num2 == 0)
                        {
                            Console.WriteLine("Divisao impossível");
                           
                        }
                        else
                        {
                            double div = (double)Num1 / Num2;
                            Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
                        }


                    }
                    break;

                case 5:
                    int N4 = int.Parse(Console.ReadLine());
                    int fat = 1;
                    for (int i = 1; i <= N4; i++)
                    {
                        fat = fat * i;

                    }
                        Console.WriteLine(fat);


                    break;
                case 6:
                    int N5 = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= N5; i++)
                    {
                        if (N5 % i == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }

                    break;
                case 7:
                    int N6 = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= N6; i++)
                    {
                        Console.WriteLine(i + " " + i * i + " " + i * i * i);
                    }


                    break;

            }


        }
    }
}
