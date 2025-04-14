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
    public partial class FrmListaDobleAnalisis : Form
    {
        clases.ListaDobleAnalisis lda = new clases.ListaDobleAnalisis();
        public FrmListaDobleAnalisis()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textNombre.Text) || string.IsNullOrWhiteSpace(textEdad.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else
            {
                try
                {
                    listView1.Items.Clear();
                    lda.insertar(textNombre.Text.Trim(), byte.Parse(textEdad.Text));
                    lda.mostrar(listView1);
                    textNombre.Clear();
                    textEdad.Clear();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Ingrese una edad válida: " + ex.Message);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre a buscar.");
            }
            else
            {
                NodoDoble buscar = lda.buscar(textNombre.Text.Trim());

                if(buscar != null)
                {
                    MessageBox.Show("Nombre: " + buscar.Nombre + "\nEdad: " + buscar.Edad);
                }
                else
                {
                    MessageBox.Show("No se encontró el nombre en la lista.");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string seleccionado = listView1.SelectedItems[0].Text;

                if (string.IsNullOrWhiteSpace(textNombre.Text) || string.IsNullOrWhiteSpace(textEdad.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos para modificar.");
                }
                else
                {
                    lda.modificar(seleccionado, textNombre.Text.Trim(), byte.Parse(textEdad.Text));
                    listView1.Items.Clear();
                    lda.mostrar(listView1);
                    textNombre.Clear();
                    textEdad.Clear();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un elemento de la lista para modificar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string seleccionado = listView1.SelectedItems[0].Text;

                lda.eliminar(seleccionado);
                listView1.Items.Clear();
                lda.mostrar(listView1);
            }
            else
            {
                MessageBox.Show("Seleccione un elemento de la lista para eliminar.");
            }
        }
    }
}
