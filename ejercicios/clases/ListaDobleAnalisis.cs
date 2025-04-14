using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios.clases
{
    internal class ListaDobleAnalisis
    {
        private NodoDoble primero = null;
        private NodoDoble ultimo =null;

        public void insertar(string nom, byte ed)
        {
            NodoDoble nuevo = new NodoDoble();
            nuevo.Nombre = nom;
            nuevo.Edad = ed;

            if (primero ==null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Anterior = ultimo;
                ultimo = nuevo;
            }
        }

        public void mostrar(ListView list)
        {
            NodoDoble actual = primero;

            while(actual != null)
            {
                ListViewItem item = new ListViewItem(actual.Nombre);
                item.SubItems.Add(actual.Edad.ToString());
                list.Items.Add(item);
                actual = actual.Siguiente;
            }
        }

        public NodoDoble buscar(string nom)
        {
            NodoDoble actual = primero;

            while (actual != null)
            {
                if (actual.Nombre == nom)
                {
                    return actual;
                }
                actual = actual.Siguiente;
            }
            return null;
        }

        public void modificar(string actualNom, string nuevoNom, byte nuevoEd)
        {
            NodoDoble modi = buscar(actualNom);

            if(modi != null)
            {
                modi.Nombre = nuevoNom;
                modi.Edad = nuevoEd;
            }
            else
            {
                MessageBox.Show("No se encontró el nombre a modificar.");
            }
        }

        public void eliminar(string nom)
        {
            NodoDoble eli = buscar(nom);

            if(eli != null)
            {
                if(eli == primero)
                {
                    primero = primero.Siguiente;
                    if(primero != null)
                    {
                        primero.Anterior = null;
                    }
                }
                else if(eli == ultimo)
                {
                    ultimo = ultimo.Anterior;
                    if (ultimo != null)
                    {
                        ultimo.Siguiente = null;
                    }
                }
                else
                {
                    eli.Anterior.Siguiente = eli.Siguiente;
                    eli.Siguiente.Anterior = eli.Anterior;
                }
            }
        }
    }
}
