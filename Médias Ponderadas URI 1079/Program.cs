using System;
using System.Globalization;

namespace Médias_Ponderadas_URI_1079
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());


            for (int i = 1; i <= N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                double v1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double v2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double v3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                double media = (v1 * 2 + v2 * 3 + v3 * 5) / 10;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
            
        }
    }
}
