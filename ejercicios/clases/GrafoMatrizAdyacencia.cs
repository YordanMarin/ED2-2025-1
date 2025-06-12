using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios.clases
{
    class GrafoMatrizAdyacencia {
        private int[,] matrizAdyacencia;
        private int numVertices;

        public GrafoMatrizAdyacencia(int numVertices) {
            this.numVertices = numVertices;
            matrizAdyacencia = new int[numVertices, numVertices];
        }

        public void insertar(int origen, int destino) {
            if (origen >= 0 && destino >= 0 && origen < numVertices && destino < numVertices) {
                matrizAdyacencia[origen, destino] = 1;
                //matrizAdyacencia[destino, origen] = 1; 
            } else
                MessageBox.Show("Error: El origen o destino esta fuera del rango");
        }

        public void imprimirArista(int origen, int destino, ListBox list) {
            if (origen >= 0 && destino >= 0 && origen < numVertices && destino < numVertices) {
                list.Items.Add($"({origen} , {destino})");
            }
        }

        public void imprimirMatriz(RichTextBox rich) {
            for(int i=0; i< numVertices; i++) {
                for(int j=0; j<numVertices; j++) {
                    rich.Text += matrizAdyacencia[i, j]+"\t";
                }
                rich.Text += "\n";
            }
        }

        public void amplitud(TextBox text) {
            int inicio = 0;
            bool[] visitado = new bool[numVertices];
            Queue<int> cola = new Queue<int>();

            visitado[inicio] = true;
            cola.Enqueue(inicio);

            while (cola.Count() != 0) {
                int actual = cola.Dequeue();
                text.Text += actual + " ";

                for(int i = inicio; i < numVertices; i++) {
                    if (matrizAdyacencia[actual, i] ==1 & !visitado[i]) {
                        visitado[i] = true;
                        cola.Enqueue(i);
                    }
                }
            }
        }

        public void profundidad(TextBox text) {
            int inicio = 0;
            bool[] visitado = new bool[numVertices];
            Stack<int> pila = new Stack<int>();

            visitado[inicio] = true;
            pila.Push(inicio);

            while (pila.Count() != 0) {
                int actual = pila.Pop();
                text.Text += actual + " ";

                for (int i = numVertices-1; i >= 0; i--) {
                    if (matrizAdyacencia[actual, i] == 1 & !visitado[i]) {
                        visitado[i] = true;
                        pila.Push(i);
                    }
                }
            }
        }
    }
}
