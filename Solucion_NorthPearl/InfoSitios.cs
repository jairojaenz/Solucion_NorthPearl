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

        private void FrmInfoSitio_Load(object sender, EventArgs e)
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
            
            this.Close();
        }

        private void lblNombreSitio_Click(object sender, EventArgs e)
        {

        }

        private void btnAmpliar_Click(object sender, EventArgs e)
        {
            FrmImagenAmpliada forma10 = new FrmImagenAmpliada();
            forma10.Sitio2 = picImagenSitio.Image;
            forma10.Nombresitio = lblNomSitio.Text;
            forma10.ShowDialog();
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            FrmCalificacion miforma2 = new FrmCalificacion();
            miforma2.Show();
        }
    }
}
