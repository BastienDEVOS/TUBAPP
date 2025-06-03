using Classes;
using MySql.Data.MySqlClient;

namespace TUBAPP
{
    public partial class frmOptionAdminSuprimer : Form
    {
        public frmOptionAdminSuprimer()
        {
            InitializeComponent();
        }

        private void RechargementDuFormulaire()
        {
            frmOptionAdminSuprimer Recharge = new frmOptionAdminSuprimer();
            Recharge.Show();
            this.Close();
        }

        private void frmOptionAdminSuppr_Load(object sender, EventArgs e)
        {
            BD.GetConnection();

            // === STATION avec élément par défaut ===
            List<Station> stations = BD.GetStation();
            stations.Insert(0, new Station { IdStation = -1, Nom = "-- Sélectionner une station --" });

            cmbStation.DataSource = stations;
            cmbStation.DisplayMember = "Nom";
            cmbStation.ValueMember = "IdStation";
            cmbStation.SelectedIndex = 0;

            // === LIGNE avec élément par défaut ===
            List<Ligne> lignes = BD.GetLigne(); // récupère les lignes depuis la BD

            // Ajoute une ligne "par défaut" tout en haut de la liste
            lignes.Insert(0, new Ligne { IdLigne = -1, Nom = "-- Sélectionner une ligne --" });

            cmbLigne.DataSource = lignes;
            cmbLigne.DisplayMember = "Nom";
            cmbLigne.ValueMember = "IdLigne";
            cmbLigne.SelectedIndex = 0; // force la sélection par défaut

            // === TRAJET avec élément par défaut ===
            List<Trajet> trajets = BD.GetTrajet(); // récupère les trajets depuis la BD
            cmbTrajet.DataSource = null;
            cmbTrajet.Items.Clear();
            cmbTrajet.Items.Add("-- Sélectionner un Trajet --");
            cmbTrajet.Items.AddRange(trajets.ToArray());
            cmbTrajet.SelectedIndex = 0;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            frmOptionAdmin FrmOptionAdmin = new frmOptionAdmin();
            FrmOptionAdmin.Show();
            this.Close();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            frmMenuPricipal FrmMenuPrincipal = new frmMenuPricipal();
            FrmMenuPrincipal.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmInfoLigne FrmInfoLigne = new frmInfoLigne();
            FrmInfoLigne.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PageCarte page = new PageCarte();
            page.Show();
            this.Close();
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Détermine combien de ComboBox sont sélectionnées (≠ 0)
            int nbSelections = 0;

            if (cmbLigne.SelectedIndex != 0) nbSelections++;
            if (cmbStation.SelectedIndex != 0) nbSelections++;
            if (cmbTrajet.SelectedIndex != 0) nbSelections++;

            // Active le bouton uniquement si une seule sélection sélectionner
            btnSuprimer.Enabled = (nbSelections == 1);

            // Gestion dynamique des ComboBox : une seule active à la fois
            if (nbSelections == 0)
            {
                // Si rien n’est sélectionné, toutes les ComboBox sont activées
                cmbLigne.Enabled = true;
                cmbStation.Enabled = true;
                cmbTrajet.Enabled = true;
            }
            else if (nbSelections == 1)
            {
                // Si une est sélectionnée, on désactive les deux autres
                cmbLigne.Enabled = (cmbLigne.SelectedIndex != 0);
                cmbStation.Enabled = (cmbStation.SelectedIndex != 0);
                cmbTrajet.Enabled = (cmbTrajet.SelectedIndex != 0);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (cmbLigne.SelectedIndex != 0)
            {
                var result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette ligne ? Cela supprimera également tous les trajets, les stations desservies associées et les lignes favorites des clients.",
                                             "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int idLigne = (int)cmbLigne.SelectedValue;
                    BD.SupprimerLigne(idLigne);
                    MessageBox.Show("La ligne a été supprimée avec succès.");
                    RechargementDuFormulaire();
                    
                }
            }
            else if (cmbStation.SelectedIndex != 0)
            {
                var result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette station ? Cela supprimera également tous les trajets et les liaisons associées.",
                                             "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int idStation = (int)cmbStation.SelectedValue;
                    BD.SupprimerStation(idStation);
                    MessageBox.Show("La station a été supprimée avec succès.");
                    RechargementDuFormulaire();
                }
            }
            else if (cmbTrajet.SelectedIndex != 0)
            {
                var result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce trajet ?",
                                             "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Trajet trajet = (Trajet)cmbTrajet.SelectedItem;
                    BD.SupprimerTrajet(trajet.IdLigne, trajet.IdStationDepart, trajet.IdStationArrivee);
                    MessageBox.Show("Le trajet a été supprimé avec succès.");
                    RechargementDuFormulaire();
                }
            }
        }
    }
}
