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
    public partial class frmPantallaPrincipal : Form
    {
        string busqueda;
        public frmPantallaPrincipal()
        {
            InitializeComponent();
        }

        public void pantaPrincipal()
        {
            frmPantallaPrincipal principal = new frmPantallaPrincipal();
            principal.Show();
            this.Hide();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCrearCuenta_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picCatedral_Click(object sender, EventArgs e)
        {

        }

        private void picbxUsuario_Click(object sender, EventArgs e)
        {
            Form7 miforma4 = new Form7();
            miforma4.Show();
            this.Hide();
        }

        private void btnBuscarFrm5_Click(object sender, EventArgs e)
        {
            try
            {
                busqueda = btnBuscarFrm5.Text;
                
                StreamReader leer;
                leer = File.OpenText("datos.txt");
                string cadena;
                string[] arreglo = new string[2];
                char[] separador = { ',' };
                bool autorizado = false;
                cadena = leer.ReadLine();
                while (cadena != null && autorizado == false)
                {
                    arreglo = cadena.Split(separador);
                    if (arreglo[1].Trim().Equals(busqueda))
                    {
                       
                       
                        autorizado = true;
                    }
                    else
                    {
                        cadena = leer.ReadLine();
                    }
                }
                if (autorizado == false)
                {
                    MessageBox.Show("Sitio no encontrado","Error" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error);

            }
        }
    }
}
        
    

