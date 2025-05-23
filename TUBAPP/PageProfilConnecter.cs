﻿using MySql.Data.MySqlClient;

namespace TUBAPP
{
    public partial class PageProfilConnecter : Form
    {
        private string userEmail;
        public PageProfilConnecter(string email)
        {
            InitializeComponent();
            userEmail = email;
            this.Load += PageProfilConnecter_Load;
        }

        private void PageProfilConnecter_Load(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    var cmd = new MySql.Data.MySqlClient.MySqlCommand(
                        "SELECT NomClient, PrenomClient, MailClient, DateNaissanceClient FROM Client WHERE MailClient=@Mail", conn);
                    cmd.Parameters.AddWithValue("@Mail", userEmail);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblNom.Text = reader.GetString("NomClient");
                            lblPrenom.Text = reader.GetString("PrenomClient");
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
            PageModifConnecter pageModif = new PageModifConnecter(userEmail);
            pageModif.Show();
            this.Close(); // Masquer le formulaire de profil
        }

       
    }
}
