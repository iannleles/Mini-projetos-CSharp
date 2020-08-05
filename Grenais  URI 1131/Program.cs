using System;

namespace Grenais__URI_1131
{
    class Program
    {
        static void Main(string[] args)
        {
            
             int gremio, inter, grenais = 1, ptsInter = 0, ptsGremio = 0, empates = 0;

            

         
            while( grenais == 1)
            {
                string[] vet = Console.ReadLine().Split(' ');

                inter = int.Parse(vet[0]);

                gremio = int.Parse(vet[1]);

                if (inter > gremio)
                {
                    ptsInter = ptsInter + 1;
                }else if(gremio > inter)
                {
                    ptsGremio = ptsGremio + 1;
                }else
                {
                    empates = empates + 1;
                }
               
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                grenais = int.Parse(Console.ReadLine());                   

                

            }
            int total = ptsGremio + ptsInter + empates;

            Console.WriteLine(total + " grenais");
            Console.WriteLine("Inter:" + ptsInter);
            Console.WriteLine("Gremio:" + ptsGremio);
            Console.WriteLine("Empates:" + empates);
            if (ptsGremio > ptsInter)
            {
                Console.WriteLine("Gremio venceu mais");
            }else if (ptsInter > ptsGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }else
            {
                Console.WriteLine("Nao houve vencedor");
            } 
                   



        }
    }
}
