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
    public partial class frmExpendedora : Form
    {
        private Expendedora _expendedora;

        public Expendedora Expendedora { get => _expendedora; set => _expendedora = value; }

        public frmExpendedora(Expendedora expend)
        {
            _expendedora = expend;

            InitializeComponent();
        }

        private void btnIngresarLata_Click(object sender, EventArgs e)
        {
            frmIngresarLata expend = new frmIngresarLata(this._expendedora);
            expend.Owner = this;
            expend.Show();
            this.Hide();
        }

        private void btnMostrarStock_Click(object sender, EventArgs e)
        {
            frmMostrarStock expend = new frmMostrarStock(this._expendedora);
            expend.Show();
        }
    }
}
