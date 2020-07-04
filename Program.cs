using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int finish;
            bool vlvalido; // vl = valor

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine(" ----- TABUADA ----- \n");

            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Digite um número: ");
                    vlvalido = Int32.TryParse (Console.ReadLine(), out numero);

            if (!vlvalido || numero < 1)

            {
            Console.Write("Programa finalizado: número ");
                      Console.ForegroundColor = ConsoleColor.DarkRed;
                              Console.WriteLine("INVÁLIDO.");
                                      Console.ForegroundColor = ConsoleColor.White;
                                              Console.WriteLine("Pressione enter.");
                                                      Console.ReadKey();
                                                              Environment.Exit(-1);
            }

            for (int x = 0; x <= 10; x++)
            
            {
            
            finish = numero * x;
            Console.WriteLine($"{numero} x {x} = {finish}");

            }

            Console.WriteLine("\nPressione enter para finalizar <3 ");
                    Console.ReadKey();

        }
    }
}
