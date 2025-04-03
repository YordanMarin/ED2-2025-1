﻿using System;
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
    public partial class FrmListaSimple: Form
    {
        clases.ListaSimple ls = new clases.ListaSimple();
        public FrmListaSimple()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            listNumeros.Items.Clear();
            ls.insertar(int.Parse(textNumero.Text));
            ls.mostrar(listNumeros);
            textNumero.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ls.eliminar(int.Parse(textNumero.Text));
            listNumeros.Items.Clear();
            ls.mostrar(listNumeros);
            textNumero.Clear();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            ls.ordenar();
            listNumeros.Items.Clear();
            ls.mostrar(listNumeros);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textNumero.Text);

            if(ls.buscar(num) != false)
            {
                MessageBox.Show($"El número {num} existe en la lista");
            }else
                MessageBox.Show($"El número {num} no existe en la lista");
        }
    }
}
