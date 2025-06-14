﻿using System;
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
    internal partial class frmPageProfilInviter : Form
    {
        private readonly Utilisateur utilisateur;

        public frmPageProfilInviter(Utilisateur user)
        {
            InitializeComponent();
            utilisateur = user ?? throw new ArgumentNullException(nameof(user));
            this.Load += PageCompte_Load;
        }

        private void PageCompte_Load(object sender, EventArgs e)
        {
            //// Always set the title
            //lblTitre.Text = "Votre profil";

            //if (utilisateur.EstInvite)
            //{
            //    lblInvite.Text = "INVITER";
            //    lblNomPrenom.Text = "NOM Prénom";
            //    lblMailValue.Text = "Invité";
            //    lblNaissanceValue.Text = "Jours/Mois/Années";
            //    //btnModifier.Visible = false; // Hide modifier for guest
            //}
            //else
            //{
            //    lblInvite.Text = utilisateur.EstAdmin ? "ADMINISTRATEUR" : "UTILISATEUR";
            //    lblNomPrenom.Text = $"{utilisateur.Nom} {utilisateur.Prenom}";
            //    lblMailValue.Text = utilisateur.Email;
            //    lblNaissanceValue.Text = utilisateur.DateNaissance?.ToString("dd/MM/yyyy") ?? "Non renseignée";
            //    //btnModifier.Visible = true;
            //}
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmMenuPricipal FrmMenuPrincipal = new frmMenuPricipal();
            FrmMenuPrincipal.Show();

            this.Close();
        }

        private void btnCreerCompte_Click(object sender, EventArgs e)
        {
            frmNouvelUtilisateur FrmNouvelUtilisateur = new frmNouvelUtilisateur();
            FrmNouvelUtilisateur.Show();

            this.Close();
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            frmConnexion FrmConnexion = new frmConnexion();
            FrmConnexion.Show();

            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PageCarte page = new PageCarte();
            page.Show();
            this.Close();
        }
    }
}