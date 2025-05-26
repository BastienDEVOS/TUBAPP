using MySql.Data.MySqlClient;

namespace TUBAPP
{
    public partial class PageProfilAdmin : Form
    {
        public PageProfilAdmin()
        {
            InitializeComponent();
        }

        private void PageProfilAdmin_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmMenuPricipal FrmMenuPrincipal = new frmMenuPricipal();
            FrmMenuPrincipal.Show();

            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            InfoLigne infoLigne = new InfoLigne();
            infoLigne.Show();
            this.Close(); // Masquer le formulaire de profil admin
        }

        private void btnCreerCompte_Click(object sender, EventArgs e)
        {
            OptionAdmin optionAdmin = new OptionAdmin();
            optionAdmin.Show();
            this.Close(); // Masquer le formulaire de profil admin
        }
    }
}
