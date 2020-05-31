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
    public partial class frmObtenerBalance : Form
    {
        private Expendedora _expendedora;
        public frmObtenerBalance(Expendedora expend)
        {
            _expendedora = expend;
            InitializeComponent();
        }

        private void frmObtenerBalance_Load(object sender, EventArgs e)
        {
            //lblDineroValor.Text=_expendedora.GetBalance();
            lblBalance.Text = "El monto acumulado es de $" + _expendedora.GetBalance() + ". La cantidad de latas restantes son: " + _expendedora.GetCapacidadRestante() + " unidades";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
