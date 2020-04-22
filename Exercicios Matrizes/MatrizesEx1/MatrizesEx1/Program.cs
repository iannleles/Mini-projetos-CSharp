using System;

namespace MatrizesEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');

            int M = int.Parse(s[0]);
            int N = int.Parse(s[1]);

            //para declarar a matriz com as posições requeridas
            int[,] mat;
            mat = new int[M, N];

            // para ler os dados da matriz
            for (int i = 0; i < M; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j=0; j<N;j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
                
            }
            //para apresentar na tela os valores da matriz que são negativos
            Console.WriteLine("VALORES NEGATIVOS: ");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                   if(mat[i, j] < 0)
                    {
                        Console.WriteLine(mat[i,j]);
                    }
                }

            }
            Console.ReadLine();
        }
    }
}
