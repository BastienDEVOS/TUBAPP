using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUBAPP
{
    public partial class Recuperationmdp : Form
    {
        private bool isNouveauMdpVisible = false;
        private bool isConfirmerMdpVisible = false;

        public Recuperationmdp()
        {
            InitializeComponent();
        }

        // Cette méthode permet de mettre le mot de passe invisible
        private void btnVoirMdp_Click(object sender, EventArgs e)
        {
            isNouveauMdpVisible = !isNouveauMdpVisible;
            txtNouveauMdp.UseSystemPasswordChar = !isNouveauMdpVisible;
            pictureBox1.Image = isNouveauMdpVisible
                ? Properties.Resources.eye
                : Properties.Resources.eye_crossed;
        }

        private void btnVoirConfirmerMdp_Click(object sender, EventArgs e)
        {
            isConfirmerMdpVisible = !isConfirmerMdpVisible;
            txtConfirmerMdp.UseSystemPasswordChar = !isConfirmerMdpVisible;
            pictureBox2.Image = isConfirmerMdpVisible
                ? Properties.Resources.eye
                : Properties.Resources.eye_crossed;
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtCode.Text) ||
                string.IsNullOrWhiteSpace(txtNouveauMdp.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmerMdp.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtNouveauMdp.Text != txtConfirmerMdp.Text)
            {
                MessageBox.Show("Les mots de passe ne correspondent pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Mot de passe réinitialisé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            frmConnexion FrmConnexion = new frmConnexion();
            FrmConnexion.Show();

            this.Close();
        }

        private void lblTitre_Click(object sender, EventArgs e)
        {

        }

        private void Recuperationmdp_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
