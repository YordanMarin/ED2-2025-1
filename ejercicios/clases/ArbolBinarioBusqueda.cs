using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios.clases
{
    class ArbolBinarioBusqueda
    {
        public NodoAB insertar(NodoAB actual, int num) {
            NodoAB nuevo = new NodoAB();
            nuevo.Numero = num;

            if (actual == null) return nuevo;

            if (num < actual.Numero)
                actual.Izquierda = insertar(actual.Izquierda, num);
            else if (num > actual.Numero)
                actual.Derecha = insertar(actual.Derecha, num);
            else MessageBox.Show("No duplicados!");

            return actual;
        }

        public void mostrar(NodoAB actual, TreeView tree, TreeNode tallo){
            if (actual == null) return;

            TreeNode cabeRaiz = new TreeNode(actual.Numero.ToString());

            if (tallo == null) tree.Nodes.Add(cabeRaiz);
            else tallo.Nodes.Add(cabeRaiz);

            mostrar(actual.Izquierda, tree, cabeRaiz);
            mostrar(actual.Derecha, tree, cabeRaiz);
        }

        public void preorden(NodoAB actual, TextBox text) {
            if (actual == null) return;

            text.Text += actual.Numero.ToString()+ " ";
            preorden(actual.Izquierda, text);
            preorden(actual.Derecha, text);
        }

        public void inorden(NodoAB actual, TextBox text) {
            if (actual == null) return;

            inorden(actual.Izquierda, text);
            text.Text += actual.Numero.ToString() + " ";
            inorden(actual.Derecha, text);
        }

        public void postorden(NodoAB actual, TextBox text) {
            if (actual == null) return;

            postorden(actual.Izquierda, text);
            postorden(actual.Derecha, text);
            text.Text += actual.Numero.ToString() + " ";
            
        }

        public NodoAB buscar(NodoAB actual, int num) {
            if (actual == null) return null;

            if (num == actual.Numero) return actual;
            else if (num < actual.Numero) return buscar(actual.Izquierda, num);
            else return buscar(actual.Derecha, num); 
        }

        public NodoAB eliminar(NodoAB actual, int num) {
            if (actual == null) return null;

            if (num < actual.Numero) actual.Izquierda= eliminar(actual.Izquierda, num);
            else if (num > actual.Numero) actual.Derecha = eliminar(actual.Derecha, num);
            else {
                
                if (actual.Izquierda == null) return actual.Derecha;
                else if (actual.Derecha == null) return actual.Izquierda;

                NodoAB sucesor = minimo(actual.Derecha);

                actual.Numero = sucesor.Numero;
                actual.Derecha = eliminar(actual.Derecha, sucesor.Numero);
            }
            return actual;
        }

        public NodoAB minimo(NodoAB actual) {
            while (actual.Izquierda != null)
                actual = actual.Izquierda;
            return actual;
        }

        public NodoAB maximo(NodoAB actual) {
            while (actual.Derecha != null)
                actual = actual.Derecha;
            return actual;
        }

        public int balanceado(NodoAB actual) {
            if (actual == null) return 0;

            int alturaIzq = balanceado(actual.Izquierda);
            if (alturaIzq == -1) return -1;

            int alturaDer = balanceado(actual.Derecha);
            if (alturaDer == -1) return -1;

            if (Math.Abs(alturaIzq - alturaDer) > 1)
                return -1;

            return Math.Max(alturaIzq, alturaDer) + 1;
        }

        public int suma(NodoAB actual) {
            if (actual == null) return 0;

            if (actual.Izquierda == null & actual.Derecha == null)
                return actual.Numero;

            return suma(actual.Izquierda) + suma(actual.Derecha);
        }
    }
}
