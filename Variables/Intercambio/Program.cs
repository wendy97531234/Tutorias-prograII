using System;
using static System.Console;
namespace Intercambio
{
     class Program
    {
        static void Main(string[] args)
        {
            //Intercambiar Valores de Dos Variables: Escribe un programa que pida al usuario dos números y
            //luego intercambie sus valores. Muestra los valores antes y después del intercambio.
            WriteLine("Ingrese el primer valor");
            int a = int. Parse(ReadLine());

            WriteLine("Ingrese el segunrdo valor");
            int  b = int.Parse(ReadLine());

            

            

            WriteLine($"Sus valores antes de la conversion: valor1: {a} y valor2: {b}");
            int c = a;
            a = b;
            b = c;
            WriteLine($"Sus valores antes de la conversion: valor1: {a} y valor2: {b}");






        }
    }
}
