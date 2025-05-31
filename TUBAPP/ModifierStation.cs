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
    public partial class ModifierStation : Form
    {
        private Station StationModifier;
        public ModifierStation(Station Station)
        {
            InitializeComponent();
            this.StationModifier = Station;

            // Initialisation des champs avec les données de la station à modifier
            txtNom.Text = Station.Nom;
            if (Station.Accessibilite.ToString() == "True")
            {
                AccessibiliterOui.Checked = true;
            }
            else
            {
                AccessibiliterNon.Checked = true;
            }

            List<Ligne> lignes = BD.GetLigne(); // récupère les lignes depuis la BD

            // Ajoute une ligne "par défaut" tout en haut de la liste
            lignes.Insert(0, new Ligne { IdLigne = -1, Nom = "-- Sélectionner une ligne --" });

            cbLigne.DataSource = lignes;
            cbLigne.DisplayMember = "IdEtNom";
            cbLigne.ValueMember = "IdLigne";
            cbLigne.SelectedIndex = 0; // force la sélection par défaut

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
    }
}
