using System;

namespace ExemploForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] vet = new string[N];

            for(int i=0; i < N; i++)
            {
                vet[i] = Console.ReadLine();
            }
            // tradução de 'foreach' = "para cada", tradução de 'in' = "dentro de"
            Console.WriteLine("Nomes lidos: ");
            foreach (string x in vet) // X é o apelido da posição do vetor, in (dentro de), VET é o vetor;
            {
                Console.WriteLine(x); // X mostra o conteúdo da posição do vetor
            }
            Console.ReadLine();
        }
    }
}
