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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void picbxLogoApp_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarCuenta_Click(object sender, EventArgs e)
        {
            frmEditarCuenta miforma5 = new frmEditarCuenta();
            miforma5.Show();
            this.Hide();
        }
    }
}
