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
    public partial class frmPantallaPrincipal : Form
    {
        string busqueda;

        public frmPantallaPrincipal()
        {
            InitializeComponent();
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
                leer = File.OpenText("busqueda.txt");
                string cadena;
                string[] arreglo = new string[2];
                char[] separador = { ',' };
                bool autorizado = false;
                cadena = leer.ReadLine();
                while (cadena != null && autorizado == false)
                {
                    arreglo = cadena.Split(separador);
                    if (arreglo[0].Trim().Equals(textBox1.Text))
                    {
                        FrmInfoSitio forma2 = new FrmInfoSitio(textBox1.Text);                    
                        forma2.Ubicacion = arreglo[1];
                        forma2.Nomdueno = arreglo[2];
                        forma2.Numerotelefono = arreglo[3];
                        forma2.Correo = arreglo[4];
                        forma2.Horarioatencion = arreglo[5];
                        forma2.Costoservicio = arreglo[6];
                        this.Hide();
                        forma2.ShowDialog();
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
        
    

