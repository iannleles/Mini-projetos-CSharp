using System;

namespace MatrizExResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int [,] mat = new int[N,N];

            for(int i=0; i<N; i++)
            {
                string [] vet = Console.ReadLine().Split(' ');

                for(int j = 0; j<N; j++)
                {
                    mat[i,j] = int.Parse(vet[j]);   
                }
            }
            Console.WriteLine("Main diagonal: ");

            for (int i =0; i<N; i++)
            {
                Console.Write(mat[i,i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < N; i++)
            {
                for(int j = 0; j <N; j++)
                if (mat[i, j] < 0)
                {
                        count++;
                }
            }
            Console.WriteLine("Negative numbers: " + count);
        }
    }
}
