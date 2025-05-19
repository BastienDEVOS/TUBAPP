using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TUBAPP; // Assurez-vous que le bon espace de noms est utilisé pour les ressources

namespace TUBAPP
{
    internal partial class PageCompte : Form
    {
        private Utilisateur utilisateur;

        public PageCompte(Utilisateur user)
        {
            InitializeComponent();
            utilisateur = user;
        }
        private void PageCompte_Load(object sender, EventArgs e)
        {
            if (utilisateur.EstInvite)
            {
                lblTitre.Text = "Profil - Mode Invité";
                lblNom.Text = "Nom : -";
                lblPrenom.Text = "Prénom : -";
                lblEmail.Text = "Email : -";
                lblStatut.Text = "Statut : Invité";

                btnConnexion.Visible = true;
                btnCreation.Visible = true;
                btnModifierInfos.Visible = false;
                btnAdminPanel.Visible = false;
                //btnLogs.Visible = false;
            }
            else
            {
                lblTitre.Text = "Profil de " + utilisateur.Prenom;
                lblNom.Text = "Nom : " + utilisateur.Nom;
                lblPrenom.Text = "Prénom : " + utilisateur.Prenom;
                lblEmail.Text = "Email : " + utilisateur.Email;
                lblStatut.Text = utilisateur.EstAdmin ? "Statut : Administrateur" : "Statut : Utilisateur";

                btnConnexion.Visible = false;
                btnCreation.Visible = false;
                btnModifierInfos.Visible = true;
                btnAdminPanel.Visible = utilisateur.EstAdmin;
                //btnLogs.Visible = utilisateur.EstAdmin;
            }
        }
    }
}
