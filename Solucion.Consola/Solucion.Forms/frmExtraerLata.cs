﻿using Solucion.LibreriaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucion.Forms
{
    public partial class frmExtraerLata : Form
    {
        private Expendedora _expendedora;

        public frmExtraerLata(Expendedora expend)
        {
            _expendedora= expend;
            InitializeComponent();
        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                _expendedora.ExtraerLata(txtCodigo.Text, Convert.ToDouble(txtDinero.Text));
               
                MessageBox.Show("Retire su bebida");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

        private void frmExtraerLata_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
