﻿using System;
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
    public partial class frmCambiarContrasena : Form
    {
        public frmCambiarContrasena()
        {
            InitializeComponent();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
           Form7 miforma2 = new Form7();
            miforma2.Show();
            this.Hide();
        }
    }
}