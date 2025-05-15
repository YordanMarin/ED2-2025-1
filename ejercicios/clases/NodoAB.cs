using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios.clases
{
    class NodoAB
    {
        private int numero;
        private NodoAB izquierda;
        private NodoAB derecha;

        public int Numero { get => numero; set => numero = value; }
        internal NodoAB Izquierda { get => izquierda; set => izquierda = value; }
        internal NodoAB Derecha { get => derecha; set => derecha = value; }
    }
}
