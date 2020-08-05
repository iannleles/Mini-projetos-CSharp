using System;
using System.Globalization;

namespace Fanquia_Minutos
{
    class Program
    {
        static void Main(string[] args)
        {
            int Min;
            double Preco;

            Console.WriteLine("Digite a quantidade de minutos gastos: ");
            Min = int.Parse(Console.ReadLine());
            Preco = 50.00;

            if (Min > 100)
            {
                // Exemplos de como usar operadores de atribuição comulativa (Preco += ....)
                Preco += (Min - 100) * 2;
            }

            Console.WriteLine("Valor a pagar: R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
