﻿namespace Solucion.Forms
{
    partial class frmMostrarStock
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
            this.lstStock = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstStock
            // 
            this.lstStock.FormattingEnabled = true;
            this.lstStock.ItemHeight = 16;
            this.lstStock.Location = new System.Drawing.Point(48, 85);
            this.lstStock.Name = "lstStock";
            this.lstStock.Size = new System.Drawing.Size(655, 292);
            this.lstStock.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de latas disponibles:";
            // 
            // frmMostrarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstStock);
            this.Name = "frmMostrarStock";
            this.Text = "STOCK";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMostrarStock_FormClosed);
            this.Load += new System.EventHandler(this.frmMostrarStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstStock;
        private System.Windows.Forms.Label label1;
    }
}