using System;
using System.Globalization;

namespace ExercicioDeFixacaoLogica
{
    class Program
    {
        static void Main(string[] args)
        {
            //para armazenadr as palavras 'Computador' e 'Mesa de escritório' em suas respectivas variáveis
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            // para armazenar os valores em suas respectivas variáveis
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            
            // para armazenar os valores com ponto flutuante em suas respectivas variáveis
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            //para apresnetar na tela as mensagens utilizando os seguintes formatos
            Console.WriteLine("Produtos:");

            //Interpolação
            Console.WriteLine($"{produto1}, cujo o preço é $ {preco1:F2}");

            //placeholders
            Console.WriteLine("{0}, cujo preço é $ {1:F2} ", produto2, preco2);
            Console.WriteLine("");

            //Interpolação
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine("");

            //placeholders
            Console.WriteLine("Medida com 8 casas decimais: {0:F8}", medida);

            //placeholders
            Console.WriteLine("Arredondando 3 casas decimais {0:F3}", medida);

            //Concatenação
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
            

            
            

            

        }
    }
}
