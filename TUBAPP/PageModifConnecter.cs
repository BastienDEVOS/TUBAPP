using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;
using MySql.Data.MySqlClient;

namespace TUBAPP
{
    public partial class frmPageModifConnecter : Form
    {
        private string userEmail;

        public frmPageModifConnecter(string email)
        {
            InitializeComponent();

            List<Ligne> lignes = BD.GetLigne(); // récupère les lignes depuis la BD
            int ClientId = BD.GetIdClientByMail(email);

            lignes.Insert(0, new Ligne { IdLigne = -1, Nom = "-- Ligne favorite ? --" });
            cmbLigneFav.DataSource = lignes;
            cmbLigneFav.DisplayMember = "Nom";
            cmbLigneFav.ValueMember = "IdLigne";

            if (BD.GetLigneFavorite(ClientId) != -1)
            {
                cmbLigneFav.SelectedIndex = BD.GetLigneFavorite(ClientId);
            }
            else
            {
                cmbLigneFav.SelectedIndex = 0; 
            }
            
            userEmail = email;
        }


        private void PageModifConnecter_Load(object sender, EventArgs e)
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
                            txtNom.Text = reader.GetString("NomClient");
                            txtPrenom.Text = reader.GetString("PrenomClient");
                            txtEmail.Text = reader.GetString("MailClient");
                            dtpNaissance.Value = reader.GetDateTime("DateNaissanceClient");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement du profil : " + ex.Message);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Utilisateur? currentUser = SessionManager.CurrentUser;

            try
            {
                using (var conn = BD.GetConnection())
                {
                    var cmd = new MySql.Data.MySqlClient.MySqlCommand(
                        "UPDATE Client SET NomClient=@Nom, PrenomClient=@Prenom, DateNaissanceClient=@DateNaissance, MailClient=@NouvelMail WHERE MailClient=@Mail", conn);
                    cmd.Parameters.AddWithValue("@Nom", txtNom.Text);
                    cmd.Parameters.AddWithValue("@Prenom", txtPrenom.Text);
                    cmd.Parameters.AddWithValue("@DateNaissance", dtpNaissance.Value.Date);
                    cmd.Parameters.AddWithValue("@Mail", userEmail);
                    cmd.Parameters.AddWithValue("@NouvelMail", txtEmail.Text);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Profil mis à jour avec succès !");
                    else
                        MessageBox.Show("Aucune modification effectuée.");

                    if (cmbLigneFav.SelectedIndex != 0)
                    {
                        if (BD.GetLigneFavorite(BD.GetIdClientByMail(userEmail)) != -1)
                        {
                            BD.SupprimerLigneFavorite(BD.GetIdClientByMail(userEmail));
                        }
                        int ClientId = BD.GetIdClientByMail(userEmail);
                        BD.AjoutLigneFavorite(ClientId, (int)(cmbLigneFav.SelectedValue) -1);
                    }
                    

                    if (currentUser.EstAdmin)
                    {
                        frmPageProfilAdmin pageProfilAdmin = new frmPageProfilAdmin();
                        pageProfilAdmin.Show();

                    }
                    else
                    {
                        frmPageProfilConnecter pageProfilConnecter = new frmPageProfilConnecter(currentUser.Email);
                        pageProfilConnecter.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la mise à jour : " + ex.Message);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PageCarte page = new PageCarte();
            page.Show();
            this.Close();
        }

        private void btnAnnulModifier_Click(object sender, EventArgs e)
        {
            Utilisateur? currentUser = SessionManager.CurrentUser;

            if (currentUser.EstAdmin)
            {
                frmPageProfilAdmin pageProfilAdmin = new frmPageProfilAdmin();
                pageProfilAdmin.Show();
                this.Close();  

            }
            else
            {
                frmPageProfilConnecter pageProfilConnecter = new frmPageProfilConnecter(currentUser.Email);
                pageProfilConnecter.Show();
                this.Close();
            }
        }
    }
}
