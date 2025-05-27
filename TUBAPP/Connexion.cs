using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUBAPP
{
    public partial class frmConnexion : Form
    {
        public frmConnexion()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtIdentifiant_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRetour_MouseClick(object sender, MouseEventArgs e)
        {
            frmAcceuil FrmAcceuil = new frmAcceuil();
            FrmAcceuil.Show();

            this.Close();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string email = txtIdentifiant.Text.Trim();
            string password = txtMDP.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var conn = BD.GetConnection())
                {
                    var cmd = new MySql.Data.MySqlClient.MySqlCommand(
                        "SELECT COUNT(*) FROM Client WHERE MailClient = @Email AND MotDePasse = @Password", conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (userCount > 0)
                    {
                        var userCmd = new MySql.Data.MySqlClient.MySqlCommand(
                            "SELECT NomClient, PrenomClient, MailClient, DateNaissanceClient, StatutsClient FROM Client WHERE MailClient = @Email", conn);
                        userCmd.Parameters.AddWithValue("@Email", email);
                        using (var reader = userCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var user = new Utilisateur
                                {
                                    Nom = reader["NomClient"].ToString(),
                                    Prenom = reader["PrenomClient"].ToString(),
                                    Email = reader["MailClient"].ToString(),
                                    DateNaissance = reader["DateNaissanceClient"] as DateTime?,
                                    EstAdmin = reader["StatutsClient"].ToString() == "Admin"
                                };
                                SessionManager.CurrentUser = user;
                            }
                        }

                        frmMenuPricipal FrmMenuPrincipal = new frmMenuPricipal();
                        FrmMenuPrincipal.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Identifiants invalides.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion à la base de données: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnMdpOublie_Click(object sender, EventArgs e)
        {
            Recuperationmdp recuperationForm = new Recuperationmdp();
            recuperationForm.Show();
            this.Hide();
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {

        }
    }
}
