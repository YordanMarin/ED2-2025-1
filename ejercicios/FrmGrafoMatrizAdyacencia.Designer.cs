namespace ejercicios {
    partial class FrmGrafoMatrizAdyacencia {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.textProfundidad = new System.Windows.Forms.TextBox();
            this.textAmplitud = new System.Windows.Forms.TextBox();
            this.btnProfundidad = new System.Windows.Forms.Button();
            this.btnAmplitud = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnMatriz = new System.Windows.Forms.Button();
            this.textDestino = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInsertarRaiz = new System.Windows.Forms.Button();
            this.textOrigen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textProfundidad
            // 
            this.textProfundidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProfundidad.Location = new System.Drawing.Point(515, 547);
            this.textProfundidad.Margin = new System.Windows.Forms.Padding(4);
            this.textProfundidad.Name = "textProfundidad";
            this.textProfundidad.Size = new System.Drawing.Size(469, 30);
            this.textProfundidad.TabIndex = 60;
            // 
            // textAmplitud
            // 
            this.textAmplitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAmplitud.Location = new System.Drawing.Point(515, 494);
            this.textAmplitud.Margin = new System.Windows.Forms.Padding(4);
            this.textAmplitud.Name = "textAmplitud";
            this.textAmplitud.Size = new System.Drawing.Size(469, 30);
            this.textAmplitud.TabIndex = 59;
            // 
            // btnProfundidad
            // 
            this.btnProfundidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfundidad.Location = new System.Drawing.Point(294, 541);
            this.btnProfundidad.Margin = new System.Windows.Forms.Padding(4);
            this.btnProfundidad.Name = "btnProfundidad";
            this.btnProfundidad.Size = new System.Drawing.Size(189, 42);
            this.btnProfundidad.TabIndex = 58;
            this.btnProfundidad.Text = "Profundidad";
            this.btnProfundidad.UseVisualStyleBackColor = true;
            this.btnProfundidad.Click += new System.EventHandler(this.btnProfundidad_Click);
            // 
            // btnAmplitud
            // 
            this.btnAmplitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmplitud.Location = new System.Drawing.Point(294, 489);
            this.btnAmplitud.Margin = new System.Windows.Forms.Padding(4);
            this.btnAmplitud.Name = "btnAmplitud";
            this.btnAmplitud.Size = new System.Drawing.Size(189, 42);
            this.btnAmplitud.TabIndex = 57;
            this.btnAmplitud.Text = "Amplitud";
            this.btnAmplitud.UseVisualStyleBackColor = true;
            this.btnAmplitud.Click += new System.EventHandler(this.btnAmplitud_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(294, 148);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(691, 307);
            this.richTextBox1.TabIndex = 56;
            this.richTextBox1.Text = "";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(56, 263);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 329);
            this.listBox1.TabIndex = 55;
            // 
            // btnMatriz
            // 
            this.btnMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatriz.Location = new System.Drawing.Point(294, 87);
            this.btnMatriz.Margin = new System.Windows.Forms.Padding(4);
            this.btnMatriz.Name = "btnMatriz";
            this.btnMatriz.Size = new System.Drawing.Size(692, 52);
            this.btnMatriz.TabIndex = 54;
            this.btnMatriz.Text = "Matriz Adyacencia";
            this.btnMatriz.UseVisualStyleBackColor = true;
            this.btnMatriz.Click += new System.EventHandler(this.btnMatriz_Click);
            // 
            // textDestino
            // 
            this.textDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDestino.Location = new System.Drawing.Point(135, 142);
            this.textDestino.Margin = new System.Windows.Forms.Padding(4);
            this.textDestino.Name = "textDestino";
            this.textDestino.Size = new System.Drawing.Size(95, 30);
            this.textDestino.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "Destino:";
            // 
            // btnInsertarRaiz
            // 
            this.btnInsertarRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarRaiz.Location = new System.Drawing.Point(42, 195);
            this.btnInsertarRaiz.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertarRaiz.Name = "btnInsertarRaiz";
            this.btnInsertarRaiz.Size = new System.Drawing.Size(189, 42);
            this.btnInsertarRaiz.TabIndex = 51;
            this.btnInsertarRaiz.Text = "Insertar";
            this.btnInsertarRaiz.UseVisualStyleBackColor = true;
            this.btnInsertarRaiz.Click += new System.EventHandler(this.btnInsertarRaiz_Click);
            // 
            // textOrigen
            // 
            this.textOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOrigen.Location = new System.Drawing.Point(135, 92);
            this.textOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.textOrigen.Name = "textOrigen";
            this.textOrigen.Size = new System.Drawing.Size(95, 30);
            this.textOrigen.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Origen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 46);
            this.label1.TabIndex = 48;
            this.label1.Text = "GRAFO DIRIGIDO";
            // 
            // FrmGrafoMatrizAdyacencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 626);
            this.Controls.Add(this.textProfundidad);
            this.Controls.Add(this.textAmplitud);
            this.Controls.Add(this.btnProfundidad);
            this.Controls.Add(this.btnAmplitud);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnMatriz);
            this.Controls.Add(this.textDestino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnInsertarRaiz);
            this.Controls.Add(this.textOrigen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmGrafoMatrizAdyacencia";
            this.Text = "FrmGrafoMatrizAdyacencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textProfundidad;
        private System.Windows.Forms.TextBox textAmplitud;
        private System.Windows.Forms.Button btnProfundidad;
        private System.Windows.Forms.Button btnAmplitud;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnMatriz;
        private System.Windows.Forms.TextBox textDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInsertarRaiz;
        private System.Windows.Forms.TextBox textOrigen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}