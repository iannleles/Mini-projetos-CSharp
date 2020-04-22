using System;
using System.Globalization;

namespace Ex5Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] vet = new int[N];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(s[i]);
            }


            // para somar os numeros pares lidos
            int soma = 0;
            int cont = 0;
            for (int i = 0; i<N; i++)
            {
                if (vet[i] % 2 == 0)
                {
                  soma = soma + vet[i];
                    cont++;
                }
            }

            // para calcular e apresentar a media aritimetica dos numeros pares lidos

            double media =  soma / cont;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));


        }
    }
}
