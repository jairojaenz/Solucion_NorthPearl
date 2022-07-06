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

        private void btnCerrarSesión_Click(object sender, EventArgs e)
        {
            frmNorthPearl miforma6 = new frmNorthPearl();
            miforma6.Show();
            this.Hide();

        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            frmCambiarContrasena miforma2 = new frmCambiarContrasena();
            miforma2.ShowDialog();
            this.Hide();    
        }

        private void btnSalirFrm2_Click(object sender, EventArgs e)
        {
            frmPantallaPrincipal miforma5 = new frmPantallaPrincipal();
            miforma5.Show();
            this.Hide();
        }
    }
}
