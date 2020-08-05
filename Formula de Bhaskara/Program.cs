using System;
using System.Globalization;

namespace Formula_de_Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, r1, r2;

            String[] vet = Console.ReadLine().Split(' ');

            // para ler numeros na mesma linha

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            // para calcular o valor de delta utilizando a função de potenciação Math.Pow

            delta = Math.Pow(b, 2.0) - 4 * a * c;

            // para verificar se não é possivel calcular

            if (a == 0 || delta < 0.0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                // para calcular o valor de r1 e r2 utilizando a função de raiz quadrada Math.Sqrt

                r1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                r2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

                Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
            }

        }
    }
}
