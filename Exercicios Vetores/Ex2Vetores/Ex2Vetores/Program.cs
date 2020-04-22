using System;

namespace Ex2Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] numeros = new int[N];

            // para ler os dados
            string[] s = Console.ReadLine().Split(' ');

            for (int i=0; i < N; i++)
            {
                numeros[i] = int.Parse(s[i]);
            }

            // para analizar e mostrar os pares
            int cont = 0;
            for(int i = 0; i < N; i++)
            {
                if(numeros[i] % 2 == 0)
                {
                    Console.Write(numeros[i] +  " ");
                    cont++;

                }
            }
            Console.WriteLine();
            Console.WriteLine(cont);


            Console.ReadLine();
        }
    }
}
