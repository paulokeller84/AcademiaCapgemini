using System;

namespace questao01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, lin, col, qtd;

            Console.WriteLine("Digite a quantidade de degraus\n");
            qtd = Convert.ToInt32(Console.ReadLine());
            n = 1;

            for (lin = 0; lin < qtd; lin++)
            {
                for (col = 0; col < n; col++)
                {
                    Console.Write("*");
                }

                n = n + 1;
                Console.Write("\n");
            }

            Console.ReadKey();
        }

    }
}
