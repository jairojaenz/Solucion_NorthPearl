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
            this.Close();
        }

        private void btnBuscarFrm5_Click(object sender, EventArgs e)
        {
            try
            {
                busqueda = btnBuscarFrm5.Text;
                StreamReader leer;
                leer = File.OpenText("datos de los sitios.txt");
                string cadena;
                string[] arreglo = new string[2];
                char[] separador = { ',' };
                bool autorizado = false;
                cadena = leer.ReadLine();
                

                Image miImage = Image.FromFile("CERRO APANTE.jpg");
                Image miImage1 = Image.FromFile("CASCADA LA LUNA.jpg");
                Image miImage2 = Image.FromFile("BIOLOGIA AGUALI.jpg");
                Image miImage3 = Image.FromFile("CASTILLO CACAO.jpg");
                Image miImage4 = Image.FromFile("CATEDRAL MATAGALPA.jpg");
                Image miImage5 = Image.FromFile("MIRADOR CALVARIO.jpg");
                Image miImage6 = Image.FromFile("MUSEO CFA.jpg");
                Image miImage7 = Image.FromFile("MUSEO COFFEE.jpg");
                Image miImage8 = Image.FromFile("SELVA NEGRA.jpg");


                
               
                while (cadena != null && autorizado == false)
                {
                    arreglo = cadena.Split(separador);
                    if (arreglo[0].Trim().Equals(textBox1.Text.ToUpper()))
                    {
                        FrmInfoSitio forma2 = new FrmInfoSitio(textBox1.Text);                    
                        forma2.Ubicacion = arreglo[1];
                        forma2.Nomdueno = arreglo[2];
                        forma2.Numerotelefono = arreglo[3];
                        forma2.Correo = arreglo[4];
                        forma2.Horarioatencion = arreglo[5];
                        forma2.Costoservicio = arreglo[6];

                        if (arreglo[0].Trim().Equals("CERRO APANTE"))
                        {
                            forma2.Sitio1 = miImage;
                            
                        }
                        if (arreglo[0].Trim().Equals("CASCADA LA LUNA"))
                        {
                            forma2.Sitio1 = miImage1;
                            
                           
                        }
                        if (arreglo[0].Trim().Equals("CASTILLO CACAO"))
                        {
                            forma2.Sitio1 = miImage3;
                        }
                        if (arreglo[0].Trim().Equals("CATEDRAL"))
                        {
                            forma2.Sitio1 = miImage4;
                        }
                        if (arreglo[0].Trim().Equals("ESTACION AGUALI"))
                        {
                            forma2.Sitio1 = miImage2;
                        }
                        if (arreglo[0].Trim().Equals("MIRADOR EL CALVARIO"))
                        {
                            forma2.Sitio1 = miImage5;
                        }
                        if (arreglo[0].Trim().Equals("SELVA NEGRA"))
                        {
                            forma2.Sitio1 = miImage8;
                        }
                        if (arreglo[0].Trim().Equals("MUSEO CFA"))
                        {
                            forma2.Sitio1 = miImage6;
                        }
                        if (arreglo[0].Trim().Equals("MUSEO COFFEE"))
                        {
                            forma2.Sitio1 = miImage7;
                        }
                        
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

        private void picbxMenu_Click(object sender, EventArgs e)
        {

            FrmConfiguracion miforma5 = new FrmConfiguracion();
            miforma5.Show();
            this.Close();
        }

        private void frmPantallaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
        
    

