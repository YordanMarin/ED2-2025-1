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
    public partial class FrmCola: Form
    {
        clases.Cola c = new clases.Cola();
        public FrmCola()
        {
            InitializeComponent();
        }

        private void btnEncolar_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(textNombre.Text))
                MessageBox.Show("No se permiten valores nulos1");
            else {
                if(c.buscar(textNombre.Text.Trim().ToUpper()) == false) {
                    listDatos.Items.Clear();
                    c.Enqueue(textNombre.Text.Trim().ToUpper());
                    c.mostrar(listDatos);
                    textNombre.Clear();
                } else {
                    MessageBox.Show("Dato ya existe. No duplicados!");
                }
                
            }
        }

        private void btnDesencolar_Click(object sender, EventArgs e) {
            string nom = c.Dequeue();

            if (nom != null) MessageBox.Show($"{nom} desencolado");
            else MessageBox.Show("Cola vacía!");
        }

        private void btnVistazo_Click(object sender, EventArgs e) {
            string nom = c.Peek();

            if (nom != null) MessageBox.Show($"Primero en la fila: {nom}");
            else MessageBox.Show("Cola vacía!");
        }

        private void btnCantidad_Click(object sender, EventArgs e) {
            MessageBox.Show("cantidad: "+c.Count());
        }

        private void btnLimpiar_Click(object sender, EventArgs e) {
            c.Clear();
            listDatos.Items.Clear();
            MessageBox.Show("Datos eliminados!");
        }
    }
}
