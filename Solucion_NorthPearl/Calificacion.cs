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
    public partial class FrmCalificacion : Form
    {
        static bool encontrado;
        static StreamReader lectura;
        static StreamWriter escritura;
        static string cadena;
        static string[] registro = new string[4];
        public FrmCalificacion()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            encontrado = false;

            if (txtResena.Text != "")
            {
                lectura = File.OpenText("registro de reseñas.txt");
                cadena = lectura.ReadLine();


                while (cadena != null)
                {
                    registro = cadena.Split('.');
                    if (registro[0].Trim().Equals(txtResena.Text))
                        encontrado = true;

                    cadena = lectura.ReadLine();
                }



                lectura.Close();

                if (encontrado == false)
                {
                    escritura = File.AppendText("registro de reseñas.txt");
                    escritura.WriteLine(txtResena.Text + '.' );
                    MessageBox.Show("Registro de reseña almacenado", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    escritura.Close();

                    txtResena.Text = "";
                }
                else
                {
                    MessageBox.Show("Registro de reseña ya existe", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            else
            {
                MessageBox.Show("Gracias por su contribución", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmPantallaPrincipal miforma5 = new frmPantallaPrincipal();
            miforma5.Show();
            this.Hide();
        }
    }
}
