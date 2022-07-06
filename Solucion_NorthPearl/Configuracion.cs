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
    public partial class FrmConfiguracion : Form
    {
        public FrmConfiguracion()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            FrmIdioma miforma5 = new FrmIdioma();
            miforma5.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            FrmRegistroSitios miforma5 = new FrmRegistroSitios();
            miforma5.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            FrmAcercaCreadores miforma5 = new FrmAcercaCreadores();
            miforma5.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FrmApariencia miforma5 = new FrmApariencia();
            miforma5.Show();
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            frmPantallaPrincipal miforma5 = new frmPantallaPrincipal();
            miforma5.Show();
            this.Hide();

        }
    }
}
