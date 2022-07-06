using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucion_NorthPearl
{
    public partial class frmEditarCuenta : Form
    {
        public frmEditarCuenta()
        {
            InitializeComponent();
        }

        private void btnGuarardarCambiosFrm2_Click(object sender, EventArgs e)
        {
            frmPantallaPrincipal miforma5 = new frmPantallaPrincipal();
            miforma5.Show();
            this.Hide();
        }
    }
}
