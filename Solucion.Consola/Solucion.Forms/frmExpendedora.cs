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

        private void frmExpendedora_Load(object sender, EventArgs e)
        {
            Lata lat1 = new Lata("CO1", 1, 2);
            Lata lat2 = new Lata("CO2", 1, 2);
            Lata lat3 = new Lata("SP1", 1, 2);
            Lata lat4 = new Lata("FA1", 1, 2);
            _expendedora.AgregarLata(lat1);
            _expendedora.AgregarLata(lat2);
            _expendedora.AgregarLata(lat3);
            _expendedora.AgregarLata(lat4);
        }

        private void btnExtraerLata_Click(object sender, EventArgs e)
        {
            frmExtraerLata expend = new frmExtraerLata(this._expendedora);
            expend.Owner = this;
            expend.Show();
            this.Hide();
        }

        private void btnObtenerBalance_Click(object sender, EventArgs e)
        {
            frmObtenerBalance expend = new frmObtenerBalance(this._expendedora);
            expend.Show();

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
