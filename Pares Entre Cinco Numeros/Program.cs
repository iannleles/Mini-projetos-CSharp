using System;

namespace Pares_Entre_Cinco_Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1, v2, v3, v4, v5, pares, cont = 0;

            v1 = int.Parse(Console.ReadLine());
            v2 = int.Parse(Console.ReadLine());
            v3 = int.Parse(Console.ReadLine());
            v4 = int.Parse(Console.ReadLine());
            v5 = int.Parse(Console.ReadLine());

            if (v1 % 2 == 0)
            {
                cont += +1;
            }
            if (v2 % 2 == 0)
            {
                cont += +1;
            }
            if (v3 % 2 == 0)
            {
                cont += +1;
            }
            if (v4 % 2 == 0)
            {
                cont += +1;
            }
            if (v5 % 2 == 0)
            {
                cont += +1;
            }

            pares = cont;

            Console.WriteLine(pares + " valores pares");
        }
    }
}
