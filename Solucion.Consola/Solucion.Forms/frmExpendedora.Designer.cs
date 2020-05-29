namespace Solucion.Forms
{
    partial class frmExpendedora
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
            this.btnIngresarLata = new System.Windows.Forms.Button();
            this.btnExtraerLata = new System.Windows.Forms.Button();
            this.btnObtenerBalance = new System.Windows.Forms.Button();
            this.btnMostrarStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngresarLata
            // 
            this.btnIngresarLata.Location = new System.Drawing.Point(144, 51);
            this.btnIngresarLata.Name = "btnIngresarLata";
            this.btnIngresarLata.Size = new System.Drawing.Size(274, 53);
            this.btnIngresarLata.TabIndex = 0;
            this.btnIngresarLata.Text = "INGRESAR LATA";
            this.btnIngresarLata.UseVisualStyleBackColor = true;
            this.btnIngresarLata.Click += new System.EventHandler(this.btnIngresarLata_Click);
            // 
            // btnExtraerLata
            // 
            this.btnExtraerLata.Location = new System.Drawing.Point(143, 141);
            this.btnExtraerLata.Name = "btnExtraerLata";
            this.btnExtraerLata.Size = new System.Drawing.Size(274, 51);
            this.btnExtraerLata.TabIndex = 1;
            this.btnExtraerLata.Text = "EXTRAER LATA";
            this.btnExtraerLata.UseVisualStyleBackColor = true;
            // 
            // btnObtenerBalance
            // 
            this.btnObtenerBalance.Location = new System.Drawing.Point(146, 226);
            this.btnObtenerBalance.Name = "btnObtenerBalance";
            this.btnObtenerBalance.Size = new System.Drawing.Size(270, 49);
            this.btnObtenerBalance.TabIndex = 2;
            this.btnObtenerBalance.Text = "OBTENER BALANCE";
            this.btnObtenerBalance.UseVisualStyleBackColor = true;
            // 
            // btnMostrarStock
            // 
            this.btnMostrarStock.Location = new System.Drawing.Point(146, 317);
            this.btnMostrarStock.Name = "btnMostrarStock";
            this.btnMostrarStock.Size = new System.Drawing.Size(271, 53);
            this.btnMostrarStock.TabIndex = 3;
            this.btnMostrarStock.Text = "MOSTRAR STOCK";
            this.btnMostrarStock.UseVisualStyleBackColor = true;
            this.btnMostrarStock.Click += new System.EventHandler(this.btnMostrarStock_Click);
            // 
            // frmExpendedora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarStock);
            this.Controls.Add(this.btnObtenerBalance);
            this.Controls.Add(this.btnExtraerLata);
            this.Controls.Add(this.btnIngresarLata);
            this.Name = "frmExpendedora";
            this.Text = "frmExpendedora";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarLata;
        private System.Windows.Forms.Button btnExtraerLata;
        private System.Windows.Forms.Button btnObtenerBalance;
        private System.Windows.Forms.Button btnMostrarStock;
    }
}