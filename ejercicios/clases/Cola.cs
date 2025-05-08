using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios.clases
{
    class Cola
    {
        private Nodo primero = null;
        private Nodo ultimo = null;
        private int cant = 0;

        public void Enqueue(string nom) { //encolar
            Nodo nuevo = new Nodo();
            nuevo.Nombre = nom;

            if (primero ==null) {
                primero = nuevo;
                ultimo = nuevo;
            } else {
                ultimo.Siguiente = nuevo;
                ultimo = nuevo;
            }
            cant++;
        }

        public void mostrar(ListBox list) {
            Nodo actual = primero;

            while(actual != null) {
                list.Items.Add(actual.Nombre);
                actual = actual.Siguiente;
            }
        }

        public string Dequeue() {
            if (primero == null) return null;
            else {
                string nom = primero.Nombre;
                primero = primero.Siguiente;
                cant--;
                return nom;
            }
        }

        public string Peek() {
            if (primero == null) return null;
            return primero.Nombre;
        }

        public int Count() {
            return cant;
        }

        public void Clear() {
            primero = null;
            ultimo = null;
            cant = 0;
        }

        public bool buscar(string nom) {
            Nodo actual = primero;
            while(actual != null){
                if (actual.Nombre == nom) return true;
                actual = actual.Siguiente;
            }
            return false;
        }


    }
}
