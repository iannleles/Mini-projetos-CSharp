using System;
using System.Globalization;

namespace VetoresEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            string[] s = Console.ReadLine().Split(' ');

            // para fazer a leitura dos dados
            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }



            // analisar dados
            double maior = 0.0;
            int posicao = 0;
            for (int i=0; i<N; i++)
            {
                if (maior < vet[i])
                {
                     maior = vet[i];
                        posicao = i;
                }
            }
            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicao);


            Console.ReadLine();


        }
    }
}
