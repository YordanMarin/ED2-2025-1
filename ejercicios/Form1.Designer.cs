﻿namespace ejercicios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaEnlazadaSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaEnlazdaCircularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaEnlazadaDobleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.operacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(551, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(100, 32);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(140, 32);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaEnlazadaSimpleToolStripMenuItem,
            this.listaEnlazdaCircularToolStripMenuItem,
            this.listaEnlazadaDobleToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(143, 32);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // listaEnlazadaSimpleToolStripMenuItem
            // 
            this.listaEnlazadaSimpleToolStripMenuItem.Name = "listaEnlazadaSimpleToolStripMenuItem";
            this.listaEnlazadaSimpleToolStripMenuItem.Size = new System.Drawing.Size(309, 32);
            this.listaEnlazadaSimpleToolStripMenuItem.Text = "Lista enlazada simple";
            this.listaEnlazadaSimpleToolStripMenuItem.Click += new System.EventHandler(this.listaEnlazadaSimpleToolStripMenuItem_Click);
            // 
            // listaEnlazdaCircularToolStripMenuItem
            // 
            this.listaEnlazdaCircularToolStripMenuItem.Name = "listaEnlazdaCircularToolStripMenuItem";
            this.listaEnlazdaCircularToolStripMenuItem.Size = new System.Drawing.Size(309, 32);
            this.listaEnlazdaCircularToolStripMenuItem.Text = "Lista enlazada circular";
            this.listaEnlazdaCircularToolStripMenuItem.Click += new System.EventHandler(this.listaEnlazdaCircularToolStripMenuItem_Click);
            // 
            // listaEnlazadaDobleToolStripMenuItem
            // 
            this.listaEnlazadaDobleToolStripMenuItem.Name = "listaEnlazadaDobleToolStripMenuItem";
            this.listaEnlazadaDobleToolStripMenuItem.Size = new System.Drawing.Size(309, 32);
            this.listaEnlazadaDobleToolStripMenuItem.Text = "Lista enlazada doble";
            this.listaEnlazadaDobleToolStripMenuItem.Click += new System.EventHandler(this.listaEnlazadaDobleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 263);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura de datos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaEnlazadaSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaEnlazdaCircularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaEnlazadaDobleToolStripMenuItem;
    }
}

