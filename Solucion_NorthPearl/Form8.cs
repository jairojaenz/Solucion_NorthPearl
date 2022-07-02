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
    public partial class FrmInfoSitio : Form
    {
        private string ubicacion;
        private string nomdueno;
        private string numtelefono;
        private string correo;
        private string horarioatencion;
        private string costoservicio;
        private Image sitio1;

        public FrmInfoSitio(string datos)
        {
            InitializeComponent();
            lblNomSitio.Text = datos;
            
            
        }
        
        

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmInfoSitio_Load(object sender, EventArgs e)
        {

        }

        private void txbxCostoServicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbxNombreSitio_TextChanged(object sender, EventArgs e)
        {
            
        }
        public string Ubicacion
        {
            set
            {
                ubicacion = value;
                lblUbicacion.Text = ubicacion;
            }
        }
        public string Nomdueno
        {
            set
            {
                nomdueno = value;
               lblNomDueno.Text = nomdueno;
            }
        }
        public string Numerotelefono
        {
            set
            {
                numtelefono = value;
                lblNumtelefono.Text=numtelefono;
            }
        }
        public string Correo
        {
            set
            {
                correo = value;
                lblCorreoE.Text = correo;
            }
        }
        public string Horarioatencion
        {
            set
            {
                horarioatencion = value;
                lblHoraAten.Text = horarioatencion;
            }
        }
        public string Costoservicio
        {
            set
            {
                costoservicio = value;
                lblCosto.Text = costoservicio;
            }
        }
        public Image Sitio1
        {
            set
            {
                sitio1 = value;
                picImagenSitio.Image = sitio1;
                picImagenSitio.SizeMode = PictureBoxSizeMode.StretchImage; 
            }
        }


        private void lblNomSitio_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            frmPantallaPrincipal principal = new frmPantallaPrincipal();
            principal.Show();
            this.Hide();
        }

        private void lblNombreSitio_Click(object sender, EventArgs e)
        {

        }
    }
}
