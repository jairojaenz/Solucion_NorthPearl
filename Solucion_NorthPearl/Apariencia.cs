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
    public partial class FrmApariencia : Form
    {
        public FrmApariencia()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FrmConfiguracion miforma5 = new FrmConfiguracion();
            miforma5.Show();
            this.Hide();
        }
    }
}
