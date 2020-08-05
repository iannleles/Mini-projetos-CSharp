using System;

namespace Soma_de_Pares_Consecutivos_While_URI1159
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, soma;

            X = int.Parse(Console.ReadLine());

            while (X != 0)
            {
                
                if (X % 2 == 0)
                {
                    soma = X + (X + 2) + (X + 4) + (X + 6) + (X + 8);
                    Console.WriteLine(soma);
                }else
                {
                    soma = X + 1 + (X + 3) + (X + 5) + (X + 7) + (X + 9);
                    Console.WriteLine(soma);
                }
                X = int.Parse(Console.ReadLine());
            }

        }
    }
}
