namespace AplicacionAnimacionC
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbAnimacion = new System.Windows.Forms.CheckBox();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(42, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 233);
            this.panel1.TabIndex = 0;
            // 
            // cbAnimacion
            // 
            this.cbAnimacion.AutoSize = true;
            this.cbAnimacion.Location = new System.Drawing.Point(405, 281);
            this.cbAnimacion.Name = "cbAnimacion";
            this.cbAnimacion.Size = new System.Drawing.Size(75, 17);
            this.cbAnimacion.TabIndex = 1;
            this.cbAnimacion.Text = "Animacion";
            this.cbAnimacion.UseVisualStyleBackColor = true;
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(51, 271);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(156, 35);
            this.btnDibujar.TabIndex = 2;
            this.btnDibujar.Text = "Dibujar Circulo";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 328);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.cbAnimacion);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbAnimacion;
        private System.Windows.Forms.Button btnDibujar;
    }
}

