using System;
using System.Globalization;

namespace Numeros_Positivos
{
    class Program
    {
        static void Main(string[] args)
        {
            double v1, v2, v3, v4, v5, v6, soma = 0;
            int cont = 0;

            v1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            v2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            v3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            v4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            v5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            v6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (v1 > 0)
            {
                cont += +1;
                soma += +v1;
            }
            if (v2 > 0)
            {
                cont += +1;
                soma += +v2;
            }
            if (v3 > 0)
            {
                cont += +1;
                soma += +v3;
            }
            if (v4 > 0)
            {
                cont += +1;
                soma += +v4;
            }
            if (v5 > 0)
            {
                cont += +1;
                soma += +v5;
            }
            if (v6 > 0)
            {
                cont += +1;
                soma += +v6;
            }

            Console.WriteLine(cont + " valores positivos");
            double media = soma / cont;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
