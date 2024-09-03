using System;
using static System.Console;

namespace Bucle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero!");
            int valor = int.Parse(Console.ReadLine());

            if (valor % 2 == 0 )
            {
                Console.WriteLine("Es par");
            }
            else
            {
                Console.WriteLine("Es impar");
            }
        }
    }
}
