using ejercicios.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios
{
    public partial class FrmArbolBinarioBusqueda: Form
    {
        ArbolBinarioBusqueda ab = new ArbolBinarioBusqueda();
        NodoAB raiz;
        public FrmArbolBinarioBusqueda()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e) {
            if (int.TryParse(textNumero.Text, out int num)) {
                if (raiz == null) raiz = ab.insertar(null, num);
                else ab.insertar(raiz, num);

                treeView1.Nodes.Clear();
                ab.mostrar(raiz, treeView1, null);
                treeView1.ExpandAll();
                textNumero.Clear();

            } else MessageBox.Show("Solo se permiten números");
        }

        private void btnRecorrido_Click(object sender, EventArgs e) {
            textPre.Clear();
            textIn.Clear();
            textPost.Clear();

            ab.preorden(raiz, textPre);
            ab.inorden(raiz, textIn);
            ab.postorden(raiz, textPost);
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            if (int.TryParse(textNumero.Text, out int num)) {
                if(ab.buscar(raiz, num) != null) {
                    MessageBox.Show($"Número {num} existe");
                } else {
                    MessageBox.Show($"Número {num} no existe");
                }
            } else MessageBox.Show("Solo se permiten números");
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if (int.TryParse(textNumero.Text, out int num)) {
                if (ab.buscar(raiz, num) == null) {
                    MessageBox.Show($"Número {num} existe");
                } else {
                    raiz = ab.eliminar(raiz, num);
                    treeView1.Nodes.Clear();
                    ab.mostrar(raiz, treeView1, null);
                    treeView1.ExpandAll();
                    textNumero.Clear();
                }
            } else MessageBox.Show("Solo se permiten números");
        }

        private void btnMinimo_Click(object sender, EventArgs e) {
            if (raiz != null)
                MessageBox.Show("Mínimo: " + ab.minimo(raiz).Numero);
            else
                MessageBox.Show("Árbol vacío!");
        }

        private void btnMaximo_Click(object sender, EventArgs e) {
            if (raiz != null)
                MessageBox.Show("Máximo: " + ab.maximo(raiz).Numero);
            else
                MessageBox.Show("Árbol vacío!");
        }

        private void btnBalanceado_Click(object sender, EventArgs e) {
            if (raiz != null) {
                if (ab.balanceado(raiz) != -1)
                    MessageBox.Show("Árbol balanceado!");
                else
                    MessageBox.Show("Árbol no balanceado!");
            }

            else
                 MessageBox.Show("Árbol vacío!");
        }

        private void btnSuma_Click(object sender, EventArgs e) {
            if (raiz != null) {
                MessageBox.Show("Suma: " + ab.suma(raiz));
            } else
                MessageBox.Show("Árbol vacío!");
        }
    }
}
