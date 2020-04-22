using System;
using System.Globalization;

namespace Exercicio4Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            // quantidade de indices dos vetores
            int N = int.Parse(Console.ReadLine());

            // para criar e ler o vetor
            double[] vet = new double[N];
            string[] s = Console.ReadLine().Split(' ');
            for (int i=0;i<N;i++)
            {
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            // para somar o total de todas as posições do vetor
            double soma = 0;
            for (int i=0; i<N; i++)
            {
                soma = soma + vet[i];
            }

            // para calcular e apresentar a media aritimetica dos valores no vetor
            double media = (double) soma / N;
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            // para analisar e apresentar os valores abaixo da média
            for(int i=0; i<N; i++)
            {
                if(vet[i] < media)
                {
                    Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
