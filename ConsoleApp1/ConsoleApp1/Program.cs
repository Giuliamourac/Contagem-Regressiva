using System;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um número para realizarmos uma contagem regressiva à partir dele.");

            int numero = Convert.ToInt32( Console.ReadLine());

            int contagem = numero;

            Console.WriteLine("Pressione uma tecla para proseguirmos");

            Console.ReadKey();

            Console.WriteLine("Preparar...");

            Console.ReadKey();

            Console.WriteLine("Apontar...");

            Console.ReadKey();

            Console.WriteLine("FOGO!");

            Console.WriteLine(numero);

            Console.Beep();

            Thread.Sleep(1000);

            for (int i = 0; i < numero; i++)
            {

                int temp = contagem - 1;

                contagem = temp;
                
                Console.WriteLine(temp);

                Console.Beep();

                Thread.Sleep(1000);

            }

            Console.WriteLine("ACABOU!");


        }

    }

}