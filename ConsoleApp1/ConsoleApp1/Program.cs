using System;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um número para realizarmos uma contagem regressiva à partir dele.");

            int numero = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Pressione uma tecla para proseguirmos");

            Console.ReadKey();

            Console.WriteLine("Preparar...");

            Console.ReadKey();

            Console.WriteLine("Apontar...");

            Console.ReadKey();

            Console.WriteLine("FOGO!");

            for (int i = numero; i > 0; i--)
            {

                Console.WriteLine(i);

                Console.Beep();

                Thread.Sleep(1000);

            }

            Console.WriteLine("ACABOU!");


        }

    }

}