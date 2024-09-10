namespace List
{
   class Program
    {
        static void Main(string[] args)
        {
            //Crea un programa que permita al usuario agregar nombres a una lista hasta que
            //ingrese "salir". Luego imprime todos los nombres ingresados.

            List<string> nombres = new List<string>();
            string nombre;

            do
            {
                Console.WriteLine("Ingrese un nombre o escriba 'salir' para terminar");
                nombre = Console.ReadLine();

                if (nombre.ToLower () != "Salir")
                {
                    nombres.Add(nombre);
                }

            } while (nombre.ToLower() != "salir");

            Console.WriteLine("Nombres ingresados");

            foreach (string n in nombres)
            {
                Console.WriteLine(n);
            }

        }
    }
}
