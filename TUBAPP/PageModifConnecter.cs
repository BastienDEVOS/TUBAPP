using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TUBAPP
{
    public partial class frmPageModifConnecter : Form
    {
        private string userEmail;

        public frmPageModifConnecter(string email)
        {
            InitializeComponent();
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


        private void lblNomPrenom_Click(object sender, EventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = BD.GetConnection())
                {
                    var cmd = new MySql.Data.MySqlClient.MySqlCommand(
                        "UPDATE Client SET NomClient=@Nom, PrenomClient=@Prenom, DateNaissanceClient=@DateNaissance WHERE MailClient=@Mail", conn);
                    cmd.Parameters.AddWithValue("@Nom", txtNom.Text);
                    cmd.Parameters.AddWithValue("@Prenom", txtPrenom.Text);
                    cmd.Parameters.AddWithValue("@DateNaissance", dtpNaissance.Value.Date);
                    cmd.Parameters.AddWithValue("@Mail", userEmail);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Profil mis à jour avec succès !");
                    else
                        MessageBox.Show("Aucune modification effectuée.");

                    frmPageProfilConnecter pageProfil = new frmPageProfilConnecter(userEmail);
                    pageProfil.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la mise à jour : " + ex.Message);
            }
        }



        private void llbPrenom_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
