using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TUBAPP
{
    public partial class AdminAjoutLigne : Form
    {
        public AdminAjoutLigne()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PageCarte page = new PageCarte();
            page.Show();
            this.Close();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            frmOptionAdminAjouter page = new frmOptionAdminAjouter();
            page.Show();
            this.Close();
        }

        private void Verif(object sender, EventArgs e)
        {
            bool tousRemplis =
            !string.IsNullOrWhiteSpace(txtNomLigne.Text) &&
            !string.IsNullOrWhiteSpace(txtCouleur.Text) &&
            !string.IsNullOrWhiteSpace(txtLongueurLigne.Text) &&
            dtpFrequence.Value.TimeOfDay != TimeSpan.Zero &&
            !string.IsNullOrWhiteSpace(txtStatusLigne.Text);

            btnAjouter.Enabled = tousRemplis;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            BD.AjoutLigneBase(
                txtNomLigne.Text,
                txtCouleur.Text,
                int.Parse(txtLongueurLigne.Text), //Conversion de string à int
                txtStatusLigne.Text,
                dtpFrequence.Value.TimeOfDay,
                dtpHeureDebut.Value.TimeOfDay,
                dtpHeureFin.Value.TimeOfDay
            );

            MessageBox.Show("Ligne ajoutée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Réinitialisation des champs
            txtNomLigne.Clear();
            txtCouleur.Clear();
            txtLongueurLigne.Clear();
            txtStatusLigne.Clear();

            dtpFrequence.Value = DateTime.Today;
            dtpHeureDebut.Value = DateTime.Today;
            dtpHeureFin.Value = DateTime.Today;

            btnAjouter.Enabled = false; // Désactive le bouton après l'ajout
        }
    }
}
