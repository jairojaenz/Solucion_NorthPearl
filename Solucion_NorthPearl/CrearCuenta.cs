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
    public partial class frmCrearCuenta : Form
    {
       static bool encontrado;
       static StreamReader lectura;
       static StreamWriter escritura;
       static string cadena;
       static string[] registro = new string[4];
        public frmCrearCuenta()
        {
            InitializeComponent();
        }
        private void btnCrearFrm2_Click(object sender, EventArgs e)
        {
            encontrado = false;

            if (txtNombre.Text != "" && txtContrasena.Text != "" && txtCorreo.Text != "" && comboBox1.Text != "" && comboBox1.Text != "" && cbbxEntrada.Text != "" && txtTelefono.Text != "")
            {
                lectura = File.OpenText("usuarios.txt");
                txtNombre.Text = txtNombre.Text.ToUpper();
                cadena = lectura.ReadLine();


                while (cadena != null)
                {
                    registro = cadena.Split(',');
                    if (registro[0].Trim().Equals(txtNombre.Text))
                        encontrado = true;

                    cadena = lectura.ReadLine();
                }



                lectura.Close();

                if (encontrado == false)
                {
                    escritura = File.AppendText("usuarios.txt");
                    txtNombre.Text = txtNombre.Text.ToUpper();
                    escritura.WriteLine(txtNombre.Text + ',' + txtCorreo.Text + ',' + txtContrasena.Text + ',' + comboBox1.Text + ',' + cbbxEntrada.Text + ',' + txtTelefono.Text);
                    MessageBox.Show("Registro almacenado", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    escritura.Close();
                    txtNombre.Text = "";
                    txtContrasena.Text = "";
                    txtCorreo.Text = "";
                    comboBox1.Text = "";
                    cbbxEntrada.Text = "";
                    txtTelefono.Text = "";
                    
                    
                }
                else
                {
                    MessageBox.Show("Registro ya existe", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            else
            {
                MessageBox.Show("Faltan Datos", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmNorthPearl abrir = new frmNorthPearl();
            this.Close();
            abrir.Show();
        }
    }
}
