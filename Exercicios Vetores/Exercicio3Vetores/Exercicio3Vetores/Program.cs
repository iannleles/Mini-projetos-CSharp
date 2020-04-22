using System;

namespace Exercicio3Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            // para criar e ler o vetor A;
            int[] A = new int[N];
            string[] s = Console.ReadLine().Split(' ');
            for(int i = 0; i<N; i++)
            {
                A[i] = int.Parse(s[i]);
            }

            // para criar e ler o vetor B;
            int[] B = new int[N];
            string[] s2 = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                B[i] = int.Parse(s2[i]);
            }

            // para criar o vetor C apresentando a soma dos vetores A + B;
            int[] C = new int[N];
            for (int i = 0; i < N; i++)
            {
                C[i] = A[i] + B[i];
                Console.Write(C[i] + " ");
            }

            Console.ReadLine();

       
        }
    }
}
