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
    public partial class frmMostrarStock : Form
    {
        private Expendedora _expendedora;
        public frmMostrarStock(Expendedora expend)
        {
            _expendedora = expend;
            InitializeComponent();
        }

        private void frmMostrarStock_Load(object sender, EventArgs e)
        {
            lstStock.DataSource = _expendedora.Latas;
        }

        private void frmMostrarStock_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Owner.Show();
        }
    }
}
