using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examensito
{
    public class Nodo
    {
        public Persona Dato;
        public Nodo Siguiente;
        public Nodo(Persona dato)
        {
            Dato = dato;
            Siguiente=null;
        }
    }
}
