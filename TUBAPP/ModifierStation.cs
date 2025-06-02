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
using Mysqlx.Crud;

namespace TUBAPP
{
    public partial class ModifierStation : Form
    {
        private Station StationModifier;
        public ModifierStation(Station Station)
        {
            InitializeComponent();
            this.StationModifier = Station;

            // Initialisation des champs avec les données de la station à modifier
            txtNom.Text = Station.Nom;
            txt_Zone.Text = Station.Zone.ToString();
            if (Station.Accessibilite.ToString() == "True")
            {
                AccessibiliterOui.Checked = true;
                AccessibiliterNon.Enabled = false; // Désactive l'option non si la station est accessible en PMR
            }
            else
            {
                AccessibiliterNon.Checked = true;
                AccessibiliterOui.Enabled = false; // Désactive l'option oui si la station n'est pas accessible en PMR
            }

            List<Ligne> lignes = BD.GetLigne(); // récupère les lignes depuis la BD
            List<Desservie> desservies = BD.LigneDesservie(Station.IdStation); // récupère les lignes desservant la station

            clb_ligne.DataSource = lignes;
            clb_ligne.DisplayMember = "IdEtNom";
            clb_ligne.ValueMember = "IdLigne";


            // Coche les lignes desservies par la station
            for (int i = 0; i < clb_ligne.Items.Count; i++)
            {
                var ligne = (Ligne)clb_ligne.Items[i];
                bool estDesservie = desservies.Any(d => d.IdLigne == ligne.IdLigne);

                if (estDesservie)
                {
                    clb_ligne.SetItemChecked(i, true);
                }
            }


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PageCarte page = new PageCarte();
            page.Show();
            this.Close();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            frmOptionAdminModif optionAdminModifier = new frmOptionAdminModif();
            optionAdminModifier.Show();
            this.Close();
        }

        private void Accessibiliter_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox Cocher = (CheckBox)sender;
            bool Verif = Cocher.Checked;
            // Active ou désactive les boutons en fonction de la sélection
            if (Cocher == AccessibiliterOui)
            {
                AccessibiliterNon.Enabled = !Verif; // Désactive l'option non si l'option oui est cochée
            }
            else if (Cocher == AccessibiliterNon)
            {
                AccessibiliterOui.Enabled = !Verif; // Désactive l'option oui si l'option non est cochée
            }
        }

        private void ConfirmeModif_Click(object sender, EventArgs e)
        {
            bool Correspondance = clb_ligne.CheckedItems.Count > 1;
            BD.ModifierStation(StationModifier.IdStation, txtNom.Text,txt_Zone.Text, AccessibiliterOui.Checked, Correspondance); // Met à jour les informations de la station
            BD.suprimerDesservieParStation(StationModifier.IdStation); // Supprime les lignes desservant la station avant de les réajouter

            foreach (var item in clb_ligne.CheckedItems)
            {
                Ligne ligne = (Ligne)item;
                BD.AjouterDesservie(ligne.IdLigne, StationModifier.IdStation); // Ajoute les lignes sélectionnées comme desservies par la station
            }

            frmOptionAdminModif optionAdminModifier = new frmOptionAdminModif();
            optionAdminModifier.Show();
            this.Close();
        }
    }
}
