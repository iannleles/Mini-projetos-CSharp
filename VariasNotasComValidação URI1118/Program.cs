using System;
using System.Globalization;

namespace VariasNotasComValidação_URI1118
{
    class Program
    {
        static void Main(string[] args)
        {
            double media = 0.0;
            double valor1, valor2;
            int opcao = 1;

            

            while (opcao == 1)
            {
                valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (valor1 < 0.0 || valor1 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (valor2 < 0.0 || valor2 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                media = (valor1 + valor2) / 2;
                Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                opcao = int.Parse(Console.ReadLine());


                while (opcao != 1 && opcao != 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    opcao = int.Parse(Console.ReadLine());
                   
                }
                
            }




        }
    }
}
