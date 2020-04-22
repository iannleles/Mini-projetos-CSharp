using System;
using System.Globalization;

namespace Ex7Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            double[] av1 = new double[N];
            double[] av2 = new double[N];

            // para ler os dados "nomes", "Nota1", "Nota2";

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                av1[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                av2[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            // para apresentar os alunos aprovados
            Console.WriteLine("Alunos aprovados: ");

            double[] media = new double[N];
            for (int i = 0; i < N; i++)
            {
                // para calcular a media de cada aluno
                media[i] = ((double)av1[i] + av2[i]) / 2;
                // para  mostrar somente os alunos aprovados com notas acima de 6
                if (media[i] >= 6.0)
                {

                    Console.WriteLine(nomes[i]);
                }
            }


            Console.ReadLine();

        }
    }
}
