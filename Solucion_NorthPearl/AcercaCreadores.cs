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
    public partial class FrmAcercaCreadores : Form
    {
        public FrmAcercaCreadores()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnOkis_Click(object sender, EventArgs e)
        {
            FrmConfiguracion miforma5 = new FrmConfiguracion();
            miforma5.Show();
            this.Hide();
        }
    }
}
