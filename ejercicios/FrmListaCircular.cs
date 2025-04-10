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
    public partial class FrmListaCircular : Form
    {
        clases.ListaCircular lc = new clases.ListaCircular(); //instancia de la clase ListaCircular
        public FrmListaCircular()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            listNumeros.Items.Clear(); //limpiar el listbox
            lc.insertar(int.Parse(textNumero.Text));
            lc.mostrar(listNumeros);
            textNumero.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lc.eliminar(int.Parse(textNumero.Text));
            listNumeros.Items.Clear(); //limpiar el listbox
            lc.mostrar(listNumeros);
            textNumero.Clear();
        }
    }
}
