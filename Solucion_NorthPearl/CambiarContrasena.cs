using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Solucion_NorthPearl
{
    public partial class frmCambiarContrasena : Form
    {
        static StreamReader lectura;
        static StreamWriter escritura, temporal;
        static bool encontrado;
        static string linea;
        static string[] registro = new string[5];


        public frmCambiarContrasena()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Form7 miforma4 = new Form7();
            miforma4.Show();
            this.Close();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            encontrado = false;

            if (txbxContraActual.Text != "" && txtNuevaContrasena.Text != "" && txtConfirmarContrasena.Text!="")
            {
                lectura = File.OpenText("usuarios.txt");
                temporal = File.CreateText("tmp2.txt");
                linea = lectura.ReadLine();

                while (linea != null)
                {
                    registro = linea.Split(',');

                    if (registro[2].Trim().Equals(txbxContraActual.Text))
                    {

                        temporal.WriteLine(registro[0] + "," + registro[1] + "," + txtConfirmarContrasena.Text + "," + registro[3]+"," + registro[4] + "," + registro[5] + ",");
                        encontrado = true;
                    }
                    else
                    {
                        temporal.WriteLine(linea);
                    }
                    linea = lectura.ReadLine();
                }


                if (encontrado)
                {
                    MessageBox.Show("Contraseña modificada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lectura.Close();
                    temporal.Close();
                    File.Delete("usuarios.txt");
                    File.Move("tmp2.txt", "usuarios.txt");
                }
                else
                {

                    MessageBox.Show("Contraseña No Modificada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lectura.Close();
                    temporal.Close();

                }

            }
            else
            {
                MessageBox.Show("Favor ingresar datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
