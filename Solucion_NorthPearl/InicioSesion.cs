using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Solucion_NorthPearl
{
    public partial class frmNorthPearl : Form
    {
        string user_verificar;
        string contra_verificar;
        public frmNorthPearl()
        {
            InitializeComponent();
        }

        public void pantaPrincipal()
        {
            frmPantallaPrincipal principal = new frmPantallaPrincipal();
            principal.Show();
            this.Hide();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            frmCrearCuenta miforma = new frmCrearCuenta();
            miforma.ShowDialog();
        }

        private void linklblRecuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecuperar miforma2 = new frmRecuperar();
            miforma2.ShowDialog();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                user_verificar = txtCorreo.Text;
                contra_verificar = txtContrasena.Text;
                StreamReader leer;
                leer = File.OpenText("usuarios.txt");
                string cadena;
                string[] arreglo = new string[2];
                char[] separador = { ',' };
                bool autorizado = false;
                cadena = leer.ReadLine();
                while (cadena != null && autorizado == false)
                {
                    arreglo = cadena.Split(separador);
                    if (arreglo[1].Trim().Equals(user_verificar) && arreglo[2].Trim().Equals(contra_verificar))
                    {
                        MessageBox.Show("Usuario y contraseña correctos","sesion iniciada",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        pantaPrincipal();
                        autorizado = true;
                    }
                    else
                    {
                        cadena = leer.ReadLine();
                    }
                }
                if (autorizado == false)
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: "+error);
                
            }  
        }
    }
}