using System;
using System.Globalization;

namespace Exercicio9Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            // para ler a quantidade de cadastros
            int N = int.Parse(Console.ReadLine());

            // para declarar os vetores de nomes, preços de compra e venda com a quantidade informada
            string[] nome = new string[N];
            double[] PrecoCompra = new double[N];
            double[] PrecoVenda = new double[N];

            
            // para ler todos os cadastros de nomes, preços de compra e venda;
            for (int i= 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nome[i] = s[0];
                PrecoCompra[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                PrecoVenda[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }
            // para declarar as variveis e criar o vetor necessario para armazenar os lucros de cada posição
            double[] lucro = new double[N];
            int LucroAB10 = 0;
            int Lucro10E20 = 0;
            int LucroAcima20 = 0;
            double ValorTotalCompra = 0.0;
            double ValorTotalVenda = 0.0;
            double LucroTotal = 0.0;

            // para analisar e calcular os lucros de cada posição
            for (int i = 0; i < N; i++)
            {
                lucro[i] = (PrecoVenda[i] / PrecoCompra[i] * 100) - 100;
                if(lucro[i] < 10.0)
                {
                    LucroAB10++;
                }
                if(lucro[i] >= 10.0 && lucro[i] <= 20.0)
                {
                    Lucro10E20++;
                }
                if(lucro[i] > 20.0)
                {
                    LucroAcima20++;
                }
                // para calcular o valor total da compra e venda
                ValorTotalCompra = ValorTotalCompra + PrecoCompra[i];
                ValorTotalVenda = ValorTotalVenda + PrecoVenda[i];
            }
            // para calcular o lucro total
            LucroTotal = ValorTotalVenda - ValorTotalCompra;

            // para apresentar na tela o resultado da pesquisa
            Console.WriteLine("Lucro abaixo de 10%: " + LucroAB10);
            Console.WriteLine("Lucro entre 10% e 20%: " + Lucro10E20);
            Console.WriteLine("Lucro acima de 20%: "+ LucroAcima20);
            Console.WriteLine("Valor total de compra: " + ValorTotalCompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + ValorTotalVenda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + LucroTotal.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
