namespace UsoCadenas.FE
{
    partial class frmInicial
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
            this.lblPregunta = new System.Windows.Forms.Label();
            this.lblOtraCosa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(281, 46);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(61, 13);
            this.lblPregunta.TabIndex = 0;
            this.lblPregunta.Text = "Desea Salir";
            // 
            // lblOtraCosa
            // 
            this.lblOtraCosa.AutoSize = true;
            this.lblOtraCosa.Location = new System.Drawing.Point(152, 99);
            this.lblOtraCosa.Name = "lblOtraCosa";
            this.lblOtraCosa.Size = new System.Drawing.Size(68, 13);
            this.lblOtraCosa.TabIndex = 1;
            this.lblOtraCosa.Text = "Otra etiqueta";
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOtraCosa);
            this.Controls.Add(this.lblPregunta);
            this.Name = "frmInicial";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Label lblOtraCosa;
    }
}

