namespace ConsoleApp1
{
  public class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            int ultimoElemento = stack.Pop  ();

            Console.WriteLine("Elemento retirado por Pop" + ultimoElemento);

            Console.WriteLine("");

        }
    }
}
