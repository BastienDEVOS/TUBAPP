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

namespace TUBAPP
{
    public partial class ModifierLigne : Form
    {
        private Ligne LigneModifier;
        public ModifierLigne(Ligne Ligne)
        {
            InitializeComponent();
            this.LigneModifier = Ligne;
            // Initialisation des champs avec les données de la ligne à modifier
            txtNom.Text = Ligne.Nom;
            txtCouleur.Text = Ligne.Couleur;
            txtLongueur.Text = Ligne.Longueur.ToString();
            txtStatus.Text = Ligne.Status;
            txtFrequence.Text = Ligne.Frequence;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            frmOptionAdminModif optionAdminModifier = new frmOptionAdminModif();
            optionAdminModifier.Show();
            this.Close();
        }

        private void ModifierLigne_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PageCarte page = new PageCarte();
            page.Show();
            this.Close();
        }
    }
}
