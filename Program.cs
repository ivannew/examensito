using System.Collections.Concurrent;

namespace examensito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada lista=new ListaEnlazada();
            Console.WriteLine($"la lista esta vacia?{lista.EstaVacia()}");
            Console.WriteLine($"la lista esta llena?{lista.EstaLlena()}");
            Console.WriteLine("ingrese la longitud");
            int longitud = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<longitud;i++)
            {
                Console.WriteLine("-------------INGRESE A LA PERSONA PARA AGREGARLA AL FINAL---------------");
                Console.WriteLine("Nombre: ");
                string nombre=Console.ReadLine();
                Console.WriteLine("Edad: ");
                int edad =Convert.ToInt32(Console.ReadLine());

                Persona persona = new Persona(nombre,edad);
                lista.InsertarFinal(persona);

            }
            
            lista.Mostrar();

           /* Console.WriteLine("ingrese la edad de la persona que busca");
            int edadbuscar=Convert.ToInt32(Console.ReadLine());
            lista.Buscar(edadbuscar);*/
            
        }
    }
}