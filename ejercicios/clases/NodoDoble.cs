﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios.clases
{
    internal class NodoDoble
    {
        private int numero;
        private NodoDoble siguiente;
        private NodoDoble anterior;

        public int Numero { get => numero; set => numero = value; }
        internal NodoDoble Siguiente { get => siguiente; set => siguiente = value; }
        internal NodoDoble Anterior { get => anterior; set => anterior = value; }
    }
}
