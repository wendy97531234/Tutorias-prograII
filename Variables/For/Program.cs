using System;

namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tablas de multiplicar  Escribe un programa que pida al usuario un número y
            // luego muestre la tabla de multiplicar de ese número del 1 al 10.
            Console.WriteLine("Escriba un valor:");

            int valor = int.Parse(Console.ReadLine());
            Console.WriteLine("***TABLA***");

            for (int i = 1; i <= 10; i++)
            {
                int resultado = valor * i;
                {

                    Console.WriteLine($"\n{valor} x {i} = {resultado}");

                }
            }
        }
    }
}

