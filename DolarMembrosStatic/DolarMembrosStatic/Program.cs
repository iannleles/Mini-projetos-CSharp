using System;
using System.Globalization;

namespace DolarMembrosStatic
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dolar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dolar você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoeda.DolarParaReal(quantia, cotacao);
            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
