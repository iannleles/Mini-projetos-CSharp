using System;


namespace DDD
{
    class Program
    {
        static void Main(string[] args)
        {
            int DDD;
            string cidade;

            DDD = int.Parse(Console.ReadLine());

            if (DDD == 11)
            {
                cidade = "Sao Paulo";
                Console.WriteLine(cidade);
            }else
            if (DDD == 61)
            {
                cidade = "Brasilia";
                Console.WriteLine(cidade);
            }else
            if (DDD == 71)
            {
                cidade = "Salvador";
                Console.WriteLine(cidade);
            }else
            if (DDD == 21)
            {
                cidade = "Rio de Janeiro";
                Console.WriteLine(cidade);
            }else
            if (DDD == 32)
            {
                cidade = "Juiz de Fora";
                Console.WriteLine(cidade);
            }else
            if (DDD == 19)
            {
                cidade = "Campinas";
                Console.WriteLine(cidade);
            }else
            if (DDD == 27)
            {
                cidade = "Vitoria";
                Console.WriteLine(cidade);
            }else
            if (DDD == 31)
            {
                cidade = "Belo Horizonte";
                Console.WriteLine(cidade);
            }
            else
            {
                Console.WriteLine("DDD nao cadastrado");
            }

            Console.ReadKey();
        }
    }
}
