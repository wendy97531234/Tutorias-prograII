namespace Pilas
{
   public class Program
    {
        static void Main(string[] args)
        {
            
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            //int ultimoElemento = stack.Pop();

            //Console.WriteLine("Elemento retirado por Pop" + ultimoElemento);

            //Console.WriteLine("Elemento en la pila despues del pop" + stack.Count);

            int elementoSuperior = stack.Peek();
            Console.WriteLine("Elemento superior con peek" + elementoSuperior);

        }

        }
    }
