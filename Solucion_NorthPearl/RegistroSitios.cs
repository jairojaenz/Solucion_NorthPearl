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
    

    public partial class FrmRegistroSitios : Form
    {
        static bool encontrado;
        static StreamReader lectura;
        static StreamWriter escritura;
        static string cadena;
        static string[] registro = new string[4];
        private string ruta;
        string direccion;
        

        public FrmRegistroSitios()
        {
            InitializeComponent();
        }
       

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            encontrado = false;
            if (txtNombreSitio.Text != "" && txtUbicacionSitio.Text != "" && txtNombreDueno.Text != "" && txtCorreoSitio.Text != "" && txtHorarioAtencion.Text != "" && txtCostoServicio.Text != "")
            { lectura = File.OpenText("datos de los sitios.txt");
                txtNombreSitio.Text = txtNombreSitio.Text.ToUpper();
                cadena = lectura.ReadLine();

                while (cadena != null)
                {
                    registro = cadena.Split(',');
                    if (registro[0].Trim().Equals(txtNombreSitio.Text))
                        encontrado = true;

                    cadena = lectura.ReadLine();
                }

                lectura.Close();


                if (encontrado == false)
                {
                    escritura = File.AppendText("datos de los sitios.txt");
                    txtNombreSitio.Text = txtNombreSitio.Text.ToUpper();
                    escritura.WriteLine(txtNombreSitio.Text + ',' + txtUbicacionSitio.Text + ',' + txtNombreDueno.Text + ',' + txtNumeroTelefono.Text + ',' + txtCorreoSitio.Text + ',' + txtHorarioAtencion.Text + ',' + txtCostoServicio.Text);
                    MessageBox.Show("Registro almacenado", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    escritura.Close();
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

        private void FrmRegistroSitios_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                direccion = openFileDialog1.FileName; 
            }
        }
        public string Ruta
        {
            set
            {
                ruta = direccion;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            FrmConfiguracion miforma5 = new FrmConfiguracion();
            miforma5.Show();
            this.Hide();

        }
    }
}
