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
    public partial class FrmArbolBinario: Form
    {
        clases.ArbolBinario ab = new clases.ArbolBinario();
        NodoAB raiz;
        NodoAB seleccionado;
        
        public FrmArbolBinario()
        {
            InitializeComponent();
            radioIzquierda.Checked = true;
        }

        private void btnInsertarRaiz_Click(object sender, EventArgs e) {
            if (int.TryParse(textNumero.Text, out int num) & num>=0) {
                treeView1.Nodes.Clear();
                raiz = ab.insertar(null, num);
                ab.mostrar(raiz, treeView1, null);
                treeView1.ExpandAll();
                textNumero.Clear();

            } else MessageBox.Show("Solo se permiten números enteros mayores a 0!");
        }

        private void btnInsertarRamas_Click(object sender, EventArgs e) {
            
            if (int.TryParse(textNumero.Text, out int num) & num >= 0) {
                if(seleccionado != null) {
                    if (radioDerecha.Checked == true)
                        seleccionado.Derecha = ab.insertar(seleccionado.Derecha, num);
                    if (radioIzquierda.Checked == true)
                        seleccionado.Izquierda = ab.insertar(seleccionado.Izquierda, num);
                    
                    treeView1.Nodes.Clear();
                    ab.mostrar(raiz, treeView1, null);
                    treeView1.ExpandAll();
                    textNumero.Clear();
                } else MessageBox.Show("Seleciona un nodo!");
            } else MessageBox.Show("Solo se permiten números enteros mayores a 0!");

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) {
            seleccionado = (NodoAB)e.Node.Tag;
        }

        private void btnAltura_Click(object sender, EventArgs e) {
            MessageBox.Show("Altura: " + ab.altura(raiz));
        }
    }
}
