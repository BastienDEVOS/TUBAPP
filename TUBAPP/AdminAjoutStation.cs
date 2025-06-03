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
    public partial class AdminAjoutStation : Form
    {
        public AdminAjoutStation()
        {
            InitializeComponent();

            List<Ligne> lignes = BD.GetLigne(); // récupère les lignes depuis la BD

            clbLigneDesservie.DataSource = lignes;
            clbLigneDesservie.DisplayMember = "Nom";
            clbLigneDesservie.ValueMember = "IdLigne";
            clbLigneDesservie.SelectedIndex = -1; // Aucune ligne sélectionnée par défaut

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
            // Gère l'exclusivité des cases à cocher si c'est une CheckBox
            if (sender is CheckBox cocher)
            {
                bool verifAccessibiliter = cocher.Checked;

                if (cocher == AccessibiliterOui)
                {
                    AccessibiliterNon.Checked = false;
                    AccessibiliterNon.Enabled = !verifAccessibiliter;
                }
                else if (cocher == AccessibiliterNon)
                {
                    AccessibiliterOui.Checked = false;
                    AccessibiliterOui.Enabled = !verifAccessibiliter;
                }
            }

            // Vérifie que tous les champs sont remplis
            bool tousRemplis =
                !string.IsNullOrWhiteSpace(txtNomStation.Text) &&
                !string.IsNullOrWhiteSpace(txtZoneStation.Text) &&
                (AccessibiliterOui.Checked || AccessibiliterNon.Checked) &&
                clbLigneDesservie.CheckedItems.Count > 0;

            btnAjouter.Enabled = tousRemplis;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            bool Correspondance = clbLigneDesservie.CheckedItems.Count > 1;
            int idstation = BD.AjoutStationBase( // On récupère l'ID de la station ajoutée
                txtNomStation.Text,
                txtZoneStation.Text,
                AccessibiliterOui.Checked,
                Correspondance
            );

            foreach (var item in clbLigneDesservie.CheckedItems)
            {
                Ligne ligne = (Ligne)item;
                BD.AjouterDesservie(ligne.IdLigne, idstation); // Ajoute les lignes sélectionnées comme desservies par la station ajoutée
            }

            MessageBox.Show("Station ajoutée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Réinitialisation des champs
            txtNomStation.Clear();
            txtZoneStation.Clear();
            AccessibiliterOui.Checked = false;
            AccessibiliterNon.Checked = false;
            clbLigneDesservie.ClearSelected(); // Désélectionne toutes les lignes dans la liste des lignes desservies
            foreach (int i in clbLigneDesservie.CheckedIndices)
            {
                clbLigneDesservie.SetItemChecked(i, false); // Décocher toutes les lignes
            }

            btnAjouter.Enabled = false; // Désactive le bouton après l'ajout
        }
    }
}
