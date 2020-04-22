using System;

namespace Exercicio3Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //para ler o valor a ser definido o tamanho da matriz
            int N = int.Parse(Console.ReadLine());


            // para declarar a matriz com a quantidade de indices solicitado
            int[,] mat;
            mat = new int[N, N];

            //para fazer a leitura dos dados de toda matriz
            for (int i =0; i < N; i++)
            {
                // para ler a linha de cada matriz
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    //para armazenar cada linha completa da matriz
                    mat[i, j] = int.Parse(s[j]);
                }
            }
            // para verificar qual o maior numero de cada linha da matriz
            for (int i = 0; i < N; i++)
            {
                int maior = 0;
                for (int j = 0; j < N; j++)
                {
                    //para vericar o maior numero de cada linha
                    if (maior < mat[i, j])
                    {
                        maior = mat[i, j];
                      
                    }
                    
                }
                //para apresentar na tela o valor do maior numero
                Console.WriteLine(maior);
            }

            Console.ReadLine();


        }
    }
}
