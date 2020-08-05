using System;

namespace Números_Pares_URI1059
{
    class Program
    {
        static void Main(string[] args)
        {
            int pares = 0;

            while(pares % 2 == 0 && pares <= 98)
            {
                pares += +2;
                Console.WriteLine(pares);
            }
        }
    }
}
