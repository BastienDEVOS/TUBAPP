using MySql.Data.MySqlClient;

namespace TUBAPP
{
    public partial class OptionAdminModif : Form
    {
        public OptionAdminModif()
        {
            InitializeComponent();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            OptionAdmin optionAdmin = new OptionAdmin();
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
            InfoLigne infoLigne = new InfoLigne();
            infoLigne.Show();
            this.Close();

        }
    }
}
