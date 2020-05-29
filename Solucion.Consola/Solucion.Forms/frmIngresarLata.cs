using Solucion.LibreriaNegocio;
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
    public partial class frmIngresarLata : Form
    {
        private Expendedora _expendedora;

        public frmIngresarLata(Expendedora expend)
        {
            _expendedora = expend;
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Lata lat = new Lata(txtCodigo.Text,
                                    double.Parse(txtPrecio.Text),
                                    double.Parse(txtVolumen.Text));

                _expendedora.AgregarLata(lat);
                MessageBox.Show("La lata ha sido agregada.");

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

        private void frmIngresarLata_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
