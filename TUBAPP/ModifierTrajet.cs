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
using ZstdSharp.Unsafe;

namespace TUBAPP
{
    public partial class ModifierTrajet : Form
    {
        private Trajet TrajetModifier;
        public ModifierTrajet(Trajet Trajet)
        {
            InitializeComponent();
            this.TrajetModifier = Trajet;
            // Initialisation des champs avec les données du trajet à modifier  

            List<Ligne> lignes = BD.GetLigne(); // récupère les lignes depuis la BD

            // Ajoute une ligne "par défaut" tout en haut de la liste
            lignes.Insert(0, new Ligne { IdLigne = -1, Nom = "-- Sélectionner une ligne --" });

            cbLigne.DataSource = lignes;
            cbLigne.DisplayMember = "Nom";
            cbLigne.ValueMember = "IdLigne";
            cbLigne.SelectedIndex = Trajet.IdLigne; // force la sélection par défaut

            List<Station> stations = BD.GetStation(); // récupère les stations depuis la BD

            // Ajoute une station "par défaut" tout en haut de la liste
            stations.Insert(0, new Station { IdStation = -1, Nom = "-- Sélectionner une station --" });

            cbStationDepart.DataSource = stations;
            cbStationDepart.DisplayMember = "Nom";
            cbStationDepart.ValueMember = "IdStation";
            cbStationDepart.SelectedIndex = Trajet.IdStationDepart; // force la sélection par défaut

            cbStationArrivee.DataSource = stations;
            cbStationArrivee.DisplayMember = "Nom";
            cbStationArrivee.ValueMember = "IdStation";
            cbStationArrivee.SelectedIndex = Trajet.IdStationArrivee; // force la sélection par défaut

            txtTpsTrajet.Text = Trajet.TempsTrajets;
        }

        private void ModifierHorraire_Load(object sender, EventArgs e)
        {

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
