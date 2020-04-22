using System;

namespace Exercicio6Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            // para informar a quantidade de pessoas a ser cadastrada
            int N = int.Parse(Console.ReadLine());

            // para criar os vetores com a quantidade informada
            string[] nomes = new string[N];
            int [] idades = new int[N];

            // para ler os nomes e idades das pessoas no vetor
            for(int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                idades[i] = int.Parse(s[1]);
            }

            // para verificar a idade mais velha
            int cont = 0;
            int maior = 0;
            for(int i = 0; i < N; i++)
            {
                if (maior < idades[i])
                {
                    maior = idades[i];
                }
            }

            // para informar a pessoa com idade mais velha do vetor
            for(int i=0; i<N; i++)
            {
                if(idades[i] == maior)
                {
                    Console.WriteLine("Pessoa mais velha: " + nomes[i]);
                }
            }

        }
    }
}
