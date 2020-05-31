namespace Solucion.Forms
{
    partial class frmObtenerBalance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDinero = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblDineroValor = new System.Windows.Forms.Label();
            this.lblCantidadValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDinero
            // 
            this.lblDinero.AutoSize = true;
            this.lblDinero.Location = new System.Drawing.Point(35, 83);
            this.lblDinero.Name = "lblDinero";
            this.lblDinero.Size = new System.Drawing.Size(93, 17);
            this.lblDinero.TabIndex = 0;
            this.lblDinero.Text = "Monto actual:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(34, 140);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(122, 17);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad de latas:";
            // 
            // lblDineroValor
            // 
            this.lblDineroValor.AutoSize = true;
            this.lblDineroValor.Location = new System.Drawing.Point(212, 83);
            this.lblDineroValor.Name = "lblDineroValor";
            this.lblDineroValor.Size = new System.Drawing.Size(13, 17);
            this.lblDineroValor.TabIndex = 2;
            this.lblDineroValor.Text = "-";
            // 
            // lblCantidadValor
            // 
            this.lblCantidadValor.AutoSize = true;
            this.lblCantidadValor.Location = new System.Drawing.Point(212, 140);
            this.lblCantidadValor.Name = "lblCantidadValor";
            this.lblCantidadValor.Size = new System.Drawing.Size(13, 17);
            this.lblCantidadValor.TabIndex = 3;
            this.lblCantidadValor.Text = "-";
            // 
            // frmObtenerBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCantidadValor);
            this.Controls.Add(this.lblDineroValor);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblDinero);
            this.Name = "frmObtenerBalance";
            this.Text = "BALANCE";
            this.Load += new System.EventHandler(this.frmObtenerBalance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDinero;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblDineroValor;
        private System.Windows.Forms.Label lblCantidadValor;
    }
}