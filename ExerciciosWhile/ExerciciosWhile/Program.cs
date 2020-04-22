using System;

namespace ExerciciosWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 1;
            while (n != 0)
            {
                Console.WriteLine("Digite a opção do exercício: ");
                Console.WriteLine("1 - VERIFICA SENHA: 2002");
                Console.WriteLine("2 - QUADRANTE");
                Console.WriteLine("3 - POSTO DE COMBUSTIVEL");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        int senha = int.Parse(Console.ReadLine());
                        while(senha != 2002)
                        {
                            Console.WriteLine("Senha inválida!");
                            senha = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Acesso permitido!");

                        break;

                    case 2:
                        string[] vet = Console.ReadLine().Split(' ');

                        int x = int.Parse(vet[0]);
                        int y = int.Parse(vet[1]);
                        while (x != 0 && y != 0)
                        {
                            
                            if (x > 0 && y > 0)
                            {
                                Console.WriteLine("primeiro");
                            }
                            else if (x < 0 && y > 0)
                            {
                                Console.WriteLine("segundo");
                            }
                            else if (x < 0 && y < 0)
                            {
                                Console.WriteLine("terceiro");
                            }
                            else if (x > 0 && y < 0)
                            {
                                Console.WriteLine("quarto");
                            }
                            string[] vet2 = Console.ReadLine().Split(' ');
                            x = int.Parse(vet2[0]);
                            y = int.Parse(vet2[1]);

                        }
                        Console.WriteLine("");

                        break;

                    case 3:
                        int voto = int.Parse(Console.ReadLine());
                        int alcool = 0;
                        int gasolina = 0;
                        int Diesel = 0;
                        while(voto != 4)
                        {
                            if (voto == 1)
                            {
                                alcool = alcool + 1;
                            }
                            if (voto == 2)
                            {
                                gasolina += 1;
                            }
                            if (voto == 3)
                            {
                                Diesel++;
                            }
                            voto = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("MUITO OBRIGADO");
                        Console.WriteLine("Alcool: " + alcool);
                        Console.WriteLine("Gasolina: {0}", gasolina);
                        Console.WriteLine($"Diesel: {Diesel}");

                        break;
                }

                Console.WriteLine("Digite 1 para voltar ou 0 para sair");
                n = int.Parse(Console.ReadLine());
            }
        }
    }
}
