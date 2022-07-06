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
    public partial class frmRecuperar : Form
    {
        public frmRecuperar()
        {
            InitializeComponent();
            
        }

        private void v_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            frmPantallaPrincipal miforma5 = new frmPantallaPrincipal();
            miforma5.Show();
            this.Hide();
        }

        private void btnCambiarContra_Click(object sender, EventArgs e)
        {
            frmCambiarContrasena miforma3 = new frmCambiarContrasena();
            miforma3.Show();
            this.Close();

        }
    }
}
