using System;
using System.Globalization;

namespace Exercicio8Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            // para ler a quantidade de indices do vetor
            int N = int.Parse(Console.ReadLine());

            // para declarar a altura e sexo de cada vetor
            double[] altura = new double[N];
            char[] sexo = new char[N];

            // para ler os valores de altura e sexo
            for (int i=0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(s[0], CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(s[1]);
            }
            // para declarar qual a maior e a menor altura
            double menor = altura[N-1];
            double maior = 0.0;
            for (int i= 0;i < N; i++)
            {
                if(menor > altura[i])
                {
                    menor = altura[i];

                }
                if(maior < altura[i])
                {
                    maior = altura[i];
                }
            }
            // para apresentar a maior e a menor altura
            Console.WriteLine("Menor altura = " + menor.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Maior altura = " + maior.ToString("F2", CultureInfo.InvariantCulture));

            // para calcular  a media de altura das mulheres e a quantidade de homens
            double soma = 0.0;
            int contF = 0;
            double mediaF = 0.0;
            int contM = 0;
            for (int i=0; i<N; i++)
            {
                // para verificar o sexo feminino e somar a quantidade e a altura de todas as Mulheres
                if(sexo[i] == 'F')
                {
                    soma = soma + altura[i];
                    contF++;
                }
                // para verificar e somar a quantidade de todos do sexo Masculino
                if(sexo[i] == 'M')
                {
                    contM++;
                }
            }
            // para armazenar a media de altura das mulheres
            mediaF = (double) soma / contF;

            //para apresentar a Media das alturas das mulheres
            Console.WriteLine("Media das alturas das mulheres = " + mediaF.ToString("F2", CultureInfo.InvariantCulture));
            // para apresentar a quantidade de homens
            Console.WriteLine("Numero de homens = " + contM);



        }
    }
}
