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
    public partial class frmEditarCuenta : Form
    {
        static StreamReader lectura;
        static StreamWriter escritura, temporal;
        static bool encontrado;
        static string linea;
        static string[] registro = new string[4];
        public frmEditarCuenta()
        {
            InitializeComponent();
        }

        private void txbxCorreo_TextChanged(object sender, EventArgs e)
        {
            Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form7 miforma4 = new Form7();
            miforma4.Show();
            this.Close();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGuarardarCambiosFrm2_Click(object sender, EventArgs e)
        {
            encontrado = false;
            if (txtNombre.Text != "" && txtTelefono.Text != "" && comboBox1.Text != "")
            {
                lectura = File.OpenText("usuarios.txt");
                temporal = File.CreateText("tmp.txt");
                linea = lectura.ReadLine();
                while (linea != null)
                {
                    registro = linea.Split(',');
                    if (registro[1].Trim().Equals(txbxCorreo.Text) && registro[2].Trim().Equals(txbxcontra.Text))
                    {
                        temporal.WriteLine(txtNombre.Text + "," + registro[1] + "," + registro[2] + "," + comboBox1.Text + "," + cbbxEntrada.Text + "," + txtTelefono.Text);
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
                    MessageBox.Show("Registro Modificado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lectura.Close();
                    temporal.Close();
                    File.Delete("usuarios.txt");
                    File.Move("tmp.txt", "usuarios.txt");
                    txtNombre.Text = "";
                    comboBox1.Text = "";
                    txtTelefono.Text = "";
                    cbbxEntrada.Text = "";

                }
                else
                {
                    MessageBox.Show("correo y/o contraseña incorrectas");
                    txbxCorreo.Clear();
                    txbxcontra.Clear();
                    lectura.Close();
                    temporal.Close();
                }

            }
            else
            {
                MessageBox.Show("Faltan datos , Registro No Modificado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}

