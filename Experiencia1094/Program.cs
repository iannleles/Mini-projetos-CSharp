using System;
using System.Globalization;

namespace Experiencia1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, Quantia = 0, C = 0, R = 0, S = 0;
            
            char tipo;

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                Quantia = int.Parse(vet[0]);
                tipo = char.Parse(vet[1]);
                if (tipo == 'C')
                {
                   C = Quantia + C;
                   
                } else if (tipo == 'R')
                {
                   R =  Quantia + R;
                   
                } else if (tipo == 'S')
                {
                    S = Quantia + S;
                    
                }
              
            }
            int  total = C + R + S;
            double porcentagemC = (double) C / total * 100.0;
            double porcentagemR = (double) R / total * 100.0;
            double porcentagemS = (double) S / total * 100.0;

            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + C);
            Console.WriteLine("Total de ratos: " + R);
            Console.WriteLine("Total de sapos: " + S);
            Console.WriteLine("Percentual de coelhos: " + porcentagemC.ToString("F2") + " %");
            Console.WriteLine("Percentual de coelhos: " + porcentagemR.ToString("F2") + " %");
            Console.WriteLine("Percentual de coelhos: " + porcentagemS.ToString("F2") + " %");

        }
    }
}
