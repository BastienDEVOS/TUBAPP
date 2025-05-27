using MySql.Data.MySqlClient;

namespace TUBAPP
{
    public partial class frmOptionAdminModif : Form
    {
        public frmOptionAdminModif()
        {
            InitializeComponent();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            frmOptionAdmin optionAdmin = new frmOptionAdmin();
            optionAdmin.Show();
            this.Close();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            frmMenuPricipal frmMenuPricipal = new frmMenuPricipal();
            frmMenuPricipal.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmInfoLigne infoLigne = new frmInfoLigne();
            infoLigne.Show();
            this.Close();

        }
    }
}
