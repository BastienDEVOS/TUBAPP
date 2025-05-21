namespace TUBAPP
{
    public partial class OptionAdmin : Form
    {
        public OptionAdmin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmMenuPricipal FrmMenuPrincipal = new frmMenuPricipal();
            FrmMenuPrincipal.Show();

            this.Close();
        }

        private void OptionAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
