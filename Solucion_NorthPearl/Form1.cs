namespace Solucion_NorthPearl
{
    public partial class frmNorthPearl : Form
    {
        public frmNorthPearl()
        {
            InitializeComponent();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            frmCrearCuenta miforma = new frmCrearCuenta();
            miforma.ShowDialog();
        }
    }
}