using System;

namespace VerificaDiaIFELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas;

            Console.WriteLine("Quantas horas?");
            horas = int.Parse(Console.ReadLine());

            if (horas < 12)
            {
                Console.WriteLine("Boa Tarde!");
            }
            else
            {
                if (horas < 18)
                {
                    Console.WriteLine("Boa Tarde!");
                }
                else
                {
                    Console.WriteLine("Boa noite!");
                }
            }

            Console.ReadKey();
        }
    }
}
