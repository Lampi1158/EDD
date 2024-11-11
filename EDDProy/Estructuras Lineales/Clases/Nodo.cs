using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    public class Nodo
    {
       
        public Nodo sig;
        public string Dato { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(string dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
