using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;

namespace TUBAPP
{
    public partial class frmMenuPricipal : Form
    {
        public frmMenuPricipal()
        {
            InitializeComponent();
            BD.Connection();

            // récupère les stations depuis la BD
            List<Station> stationsDepart = BD.GetStation();
            List<Station> stationsArrivee = BD.GetStation();


            // Ajoute une station "par défaut" tout en haut de la liste
            stationsDepart.Insert(0, new Station { IdStation = -1, Nom = "-- Sélectionner une station --" });
            stationsArrivee.Insert(0, new Station { IdStation = -1, Nom = "-- Sélectionner une station --" });

            cmbStationDepart.DataSource = stationsDepart;
            cmbStationDepart.DisplayMember = "Nom";
            cmbStationDepart.ValueMember = "IdStation";
            cmbStationDepart.SelectedIndex = 0; // force la sélection par défaut

            cmbStationArrivee.DataSource = stationsArrivee;
            cmbStationArrivee.DisplayMember = "Nom";
            cmbStationArrivee.ValueMember = "IdStation";
            cmbStationArrivee.SelectedIndex = 0; // force la sélection par défaut


        }

        private void VoirItineraire_Click(object sender, EventArgs e)
        {
            Station StationDepart = (Station)cmbStationDepart.SelectedItem;
            Station StationArrivee = (Station)cmbStationArrivee.SelectedItem;
            frmSelectionLigne selectionLigne = new frmSelectionLigne(StationDepart, StationArrivee);
            selectionLigne.Show();
            this.Close();
        }

        private void picIconeContact_Click(object sender, EventArgs e)
        {
            Utilisateur? currentUser = SessionManager.CurrentUser;

            if (currentUser == null)
            {
                frmPageProfilInviter pageProfilInviter = new frmPageProfilInviter(new Utilisateur(true));
                pageProfilInviter.Show();
            }
            else if (currentUser.EstAdmin)
            {
                frmPageProfilAdmin pageProfilAdmin = new frmPageProfilAdmin();
                pageProfilAdmin.Show();
            }
            else
            {
                frmPageProfilConnecter pageProfilConnecter = new frmPageProfilConnecter(currentUser.Email);
                pageProfilConnecter.Show();
            }

            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmInfoLigne infoLigne = new frmInfoLigne();
            infoLigne.Show();

            this.Hide(); // Masquer le formulaire principal
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PageCarte page = new PageCarte();
            page.Show();
            this.Close();
        }

        private void MettreAJourBoutonItineraire(object sender, EventArgs e)
        {
            bool selectionsValides =
                cmbStationDepart.SelectedIndex > 0 &&
                cmbStationArrivee.SelectedIndex > 0 &&
                cmbStationDepart.SelectedIndex != cmbStationArrivee.SelectedIndex;

            btnVoirItineraire.Enabled = selectionsValides;
        }

        private void AfficherInfosImportantes()
        {
            InfoImportantes.Controls.Clear(); // Vide le panneau avant ajout

            List<string> infos = new List<string>
            {
                "Bakerloo : En travaux",
                "Kenton : Retards possibles",
                "Waterloo : Hors Service"
            };

            foreach (string info in infos)
            {
                Label lblInfo = new Label();
                lblInfo.Text = info;
                lblInfo.AutoSize = true;
                lblInfo.Font = new Font("Segoe UI", 13, FontStyle.Bold);
                lblInfo.ForeColor = Color.DarkRed;
                lblInfo.Margin = new Padding(5);

                InfoImportantes.Controls.Add(lblInfo);
            }
        }
        private void frmMenuPricipal_Load(object sender, EventArgs e)
        {
            AfficherInfosImportantes();
        }

        private void InfoImportantes_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
