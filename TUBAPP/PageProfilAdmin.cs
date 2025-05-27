using MySql.Data.MySqlClient;

namespace TUBAPP
{
    public partial class frmPageProfilAdmin : Form
    {
        public frmPageProfilAdmin()
        {
            InitializeComponent();
        }

        private void PageProfilAdmin_Load(object sender, EventArgs e)
        {
            var admin = SessionManager.CurrentUser;

            if (admin != null)
            {
                lblNomPrenom.Text = $"{admin.Nom ?? "Nom"} {admin.Prenom ?? "Prénom"}";
                lblMailValue.Text = admin.Email ?? "Non renseigné";
                lblNaissanceValue.Text = admin.DateNaissance?.ToString("dd/MM/yyyy") ?? "Non renseignée";
            }
            else
            {
                lblNomPrenom.Text = "Nom Prénom";
                lblMailValue.Text = "Non renseigné";
                lblNaissanceValue.Text = "Non renseignée";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmMenuPricipal FrmMenuPrincipal = new frmMenuPricipal();
            FrmMenuPrincipal.Show();

            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmInfoLigne infoLigne = new frmInfoLigne();
            infoLigne.Show();
            this.Close(); // Masquer le formulaire de profil admin
        }

        private void btnCreerCompte_Click(object sender, EventArgs e)
        {
            frmOptionAdmin optionAdmin = new frmOptionAdmin();
            optionAdmin.Show();
            this.Close(); // Masquer le formulaire de profil admin
        }
        private void btnDeconnecter_Click(object sender, EventArgs e)
        {
            // Clear the session
            SessionManager.CurrentUser = null;

            // Redirect to the login form
            frmConnexion frmConnexion = new frmConnexion();
            frmConnexion.Show();

            this.Close();
        }
    }
}
