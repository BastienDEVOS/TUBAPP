using MySql.Data.MySqlClient;

namespace TUBAPP
{
    public partial class frmPageProfilConnecter : Form
    {
        private string userEmail;
        public frmPageProfilConnecter(string email)
        {
            InitializeComponent();
            userEmail = email;
            this.Load += PageProfilConnecter_Load;
        }

        private void PageProfilConnecter_Load(object sender, EventArgs e)
        {
            try
            {
                using (var conn = BD.GetConnection())
                {
                    var cmd = new MySql.Data.MySqlClient.MySqlCommand(
                        "SELECT NomClient, PrenomClient, MailClient, DateNaissanceClient FROM Client WHERE MailClient=@Mail", conn);
                    cmd.Parameters.AddWithValue("@Mail", userEmail);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Set the combined name and prenom
                            lblNomPrenom.Text = $"{reader.GetString("NomClient")} {reader.GetString("PrenomClient")}";
                            lblMailValue.Text = reader.GetString("MailClient");
                            lblNaissanceValue.Text = reader.GetDateTime("DateNaissanceClient").ToString("dd/MM/yyyy");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement du profil : " + ex.Message);
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmMenuPricipal FrmMenuPrincipal = new frmMenuPricipal();
            FrmMenuPrincipal.Show();

            this.Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            frmPageModifConnecter pageModif = new frmPageModifConnecter(userEmail);
            pageModif.Show();
            this.Close(); // Masquer le formulaire de profil connecté
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmInfoLigne infoLigne = new frmInfoLigne();
            infoLigne.Show();
            this.Close(); // Masquer le formulaire de profil
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            frmAcceuil FrmAcceuil = new frmAcceuil();
            FrmAcceuil.Show();

            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PageCarte page = new PageCarte();
            page.Show();
            this.Close();
        }

        private void lblNaissanceValue_Click(object sender, EventArgs e)
        {

        }
    }
}
