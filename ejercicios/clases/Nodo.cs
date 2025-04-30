using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios.clases
{
    class Nodo
    {
        private int numero;
        private string nombre;
        private string infija;
        private string postfija;
        private string prefija;
        private Nodo siguiente;

        public int Numero { get => numero; set => numero = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Infija { get => infija; set => infija = value; }
        public string Postfija { get => postfija; set => postfija = value; }
        public string Prefija { get => prefija; set => prefija = value; }
        internal Nodo Siguiente { get => siguiente; set => siguiente = value; }
    }
}
