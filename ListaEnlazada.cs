using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examensito
{
    public class ListaEnlazada
    {
        public Nodo Principio;
        public ListaEnlazada()
        {
            Principio = null;
        }
        public bool EstaVacia()
        {
            return Principio == null;
        }
        public bool EstaLlena()
        {
            return Principio != null;
        }
        public void insertarInicio(Persona persona)
        {
            Nodo nuevoNodo = new Nodo(persona);
            nuevoNodo.Siguiente = Principio;
            Principio = nuevoNodo;

        }
        public void InsertarFinal(Persona persona)
        {
            Nodo nuevoNodo= new Nodo(persona);
            if(Principio==null)
            {
                Principio= nuevoNodo;
                return;
            }
            Nodo actual = Principio;
            while(actual.Siguiente != null) 
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo;
                
        }
        public void Mostrar()
        {
            Nodo actual = Principio;
            int longi = 0;
            while (actual != null)
            {
                longi++;
                Console.WriteLine($"Nombre:{actual.Dato.Nombre} Edad:{actual.Dato.Edad}" );
                actual = actual.Siguiente;
            }
            Console.WriteLine($"la longitud es de {longi}");
        }
    }
}
