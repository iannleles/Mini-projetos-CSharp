using System;

namespace MatrizEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            // para declarar a matriz
            int[,] mat;
            mat = new int[N, N];
            //para ler os dados da matriz
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(s[j]);                                   
                }
            }
            //para criar o vetor que irar armazenar a soma dos dados de cada linha da matriz
            int[] vet;
            vet = new int[N];
            //para fazer a soma dos dados de cada linha da matriz e armazenar no vetor
            for (int i = 0; i < N; i++)
            {
                int soma = 0;
                for (int j = 0; j < N; j++)
                {
                    soma = soma + mat[i, j];
                }
                //armazena a soma no vetor de cada linha
                vet[i] = soma;
                Console.WriteLine(vet[i]);
            }
            Console.ReadLine();
        }
    }
}
