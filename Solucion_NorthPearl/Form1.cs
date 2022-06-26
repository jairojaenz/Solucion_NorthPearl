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
       static bool encontrado;
        static StreamReader lectura;
        static string cadena;
        static string[] registro = new string[4];
        
        public frmNorthPearl()
        {
            InitializeComponent();
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
            encontrado = false;
            if (txtCorreo.Text != "" && txtContrasena.Text != "")
            {
                lectura = File.OpenText("usuarios.txt");
                cadena = lectura.ReadLine();               
                    registro = cadena.Split(',');
                if (registro[0].Trim().Equals(txtCorreo.Text) && registro[1].Trim().Equals(txtContrasena.Text))
                {
                    MessageBox.Show("usuario encontrado", "iniciar sesion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    encontrado = true;
                    this.Hide();
                    frmPantallaPrincipal forma5 = new frmPantallaPrincipal();
                    forma5.ShowDialog();

                    cadena = lectura.ReadLine();
                }
                else
                {
                    MessageBox.Show("usuario no encontrado", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Faltan Datos", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}