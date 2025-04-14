using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios.clases
{
    internal class NodoDoble
    {
        private int numero;
        private string nombre;  //esto es para analisis
        private byte edad;      // esto es para analisis
        private NodoDoble siguiente;
        private NodoDoble anterior;

        public int Numero { get => numero; set => numero = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public byte Edad { get => edad; set => edad = value; }
        internal NodoDoble Siguiente { get => siguiente; set => siguiente = value; }
        internal NodoDoble Anterior { get => anterior; set => anterior = value; }
    }
}
