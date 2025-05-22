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
    }
}
