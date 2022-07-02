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
    public partial class FrmImagenAmpliada : Form
    {
        private Image sitio2;
        private string nombresitio;
       
        public FrmImagenAmpliada()
        {
            
            InitializeComponent();

        }
        public Image Sitio2
        {
          set
            {
                sitio2 = value;            
                picImagenAmpli.Image = sitio2;
                picImagenAmpli.SizeMode = PictureBoxSizeMode.StretchImage;

            }



        }
        public string Nombresitio
        {
            set
            {
                nombresitio = value;
                lblNombre.Text = nombresitio;
            }
        }

            


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picbxLogofrm2_Click(object sender, EventArgs e)
        {

        }
        
        
    }
}
