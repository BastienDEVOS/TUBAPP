namespace TUBAPP
{
    public partial class frmAcceuil : Form
    {
        public frmAcceuil()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAcceuil_Load(object sender, EventArgs e)
        {

        }

        private void btnConnexion_MouseClick(object sender, MouseEventArgs e)
        {
            frmConnexion FrmConnexion = new frmConnexion();
            FrmConnexion.Show();

            this.Hide();
        }
    }
}
