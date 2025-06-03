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
    public partial class AdminAjoutTrajet : Form
    {
        public AdminAjoutTrajet()
        {
            InitializeComponent();

            List<Ligne> lignes = BD.GetLigne(); // récupère les lignes depuis la BD
            lignes.Insert(0, new Ligne { IdLigne = -1, Nom = "-- Sélectionner une ligne --" });


            cmbLigne.DataSource = lignes;
            cmbLigne.DisplayMember = "Nom";
            cmbLigne.ValueMember = "IdLigne";
            cmbLigne.SelectedIndex = 0; // force la sélection par défaut

            List<Station> stationsDepart = BD.GetStation(); // récupère les stations depuis la BD
            List<Station> stationsArrivee = BD.GetStation();
            stationsArrivee.Insert(0, new Station { IdStation = -1, Nom = "-- Sélectionner une station --" });
            stationsDepart.Insert(0, new Station { IdStation = -1, Nom = "-- Sélectionner une station de départ --" });

            cmbStationDepart.DataSource = stationsDepart;
            cmbStationDepart.DisplayMember = "Nom";
            cmbStationDepart.ValueMember = "IdStation";
            cmbStationDepart.SelectedIndex = 0; // force la sélection par défaut

            cmbStationArriver.DataSource = stationsArrivee;
            cmbStationArriver.DisplayMember = "Nom";
            cmbStationArriver.ValueMember = "IdStation";
            cmbStationArriver.SelectedIndex = 0; // force la sélection par défaut
        }


        private void btnRetour_Click(object sender, EventArgs e)
        {
            frmOptionAdminAjouter page = new frmOptionAdminAjouter();
            page.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PageCarte page = new PageCarte();
            page.Show();
            this.Close();
        }

        private void Verif(object sender, EventArgs e)
        {
            bool tousRemplis =
                cmbLigne.SelectedIndex > 0 && // Vérifie que la ligne est sélectionnée
                cmbStationDepart.SelectedIndex > 0 && // Vérifie que la station de départ est sélectionnée
                cmbStationArriver.SelectedIndex > 0 && // Vérifie que la station d'arrivée est sélectionnée
                cmbStationDepart.SelectedIndex != cmbStationArriver.SelectedIndex && // Vérifie que les stations de départ et d'arrivée sont différentes
                dtpTempsTrajet.Value.TimeOfDay != TimeSpan.Zero;

            btnAjouter.Enabled = tousRemplis;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            BD.AjoutTrajetBase(
                (int)cmbLigne.SelectedValue, // Récupère l'ID de la ligne sélectionnée
                (int)cmbStationDepart.SelectedValue, // Récupère l'ID de la station de départ sélectionnée
                (int)cmbStationArriver.SelectedValue, // Récupère l'ID de la station d'arrivée sélectionnée
                dtpTempsTrajet.Value.TimeOfDay // Récupère le temps de trajet sélectionné
            );

            MessageBox.Show("Trajet ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Réinitialisation des champs
            cmbLigne.SelectedIndex = 0; // Réinitialise la sélection de la ligne
            cmbStationDepart.SelectedIndex = 0; // Réinitialise la sélection de la station de départ
            cmbStationArriver.SelectedIndex = 0; // Réinitialise la sélection de la station d'arrivée
            dtpTempsTrajet.Value = DateTime.Today; // Réinitialise le temps de trajet

            btnAjouter.Enabled = false; // Désactive le bouton après l'ajout
        }
    }
}
