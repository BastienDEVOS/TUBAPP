using Classes;
using MySql.Data.MySqlClient;

namespace TUBAPP
{
    public partial class frmOptionAdminModif : Form
    {
        public frmOptionAdminModif()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            frmOptionAdmin optionAdmin = new frmOptionAdmin();
            optionAdmin.Show();
            this.Close();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            frmMenuPricipal frmMenuPricipal = new frmMenuPricipal();
            frmMenuPricipal.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmInfoLigne infoLigne = new frmInfoLigne();
            infoLigne.Show();
            this.Close();

        }

        private void frmOptionAdminModif_Load(object sender, EventArgs e)
        {
            BD.GetConnection();

            // === STATION avec élément par défaut ===
            List<Station> stations = BD.GetStation();
            stations.Insert(0, new Station { IdStation = -1, Nom = "-- Sélectionner une station --" });

            cbStation.DataSource = stations;
            cbStation.DisplayMember = "Nom";
            cbStation.ValueMember = "IdStation";
            cbStation.SelectedIndex = 0;

            // === LIGNE avec élément par défaut ===
            List<Ligne> lignes = BD.GetLigne(); // récupère les lignes depuis la BD

            // Ajoute une ligne "par défaut" tout en haut de la liste
            lignes.Insert(0, new Ligne { IdLigne = -1, Nom = "-- Sélectionner une ligne --" });

            cbLigne.DataSource = lignes;
            cbLigne.DisplayMember = "Nom";
            cbLigne.ValueMember = "IdLigne";
            cbLigne.SelectedIndex = 0; // force la sélection par défaut

            // === TRAJET avec élément par défaut ===
            List<Trajet> trajets = BD.GetTrajet(); // récupère les trajets depuis la BD
            cbTrajet.DataSource = null;
            cbTrajet.Items.Clear();
            cbTrajet.Items.Add("-- Sélectionner un Trajet --");
            cbTrajet.Items.AddRange(trajets.ToArray());
            cbTrajet.SelectedIndex = 0;
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

            if (cbLigne.SelectedIndex != 0) nbSelections++;
            if (cbStation.SelectedIndex != 0) nbSelections++;
            if (cbTrajet.SelectedIndex != 0) nbSelections++;

            // Active le bouton uniquement si une seule sélection est faite
            btnModif.Enabled = (nbSelections == 1);

            // Gestion dynamique des ComboBox : une seule active à la fois
            if (nbSelections == 0)
            {
                // Si rien n’est sélectionné, toutes les ComboBox sont activées
                cbLigne.Enabled = true;
                cbStation.Enabled = true;
                cbTrajet.Enabled = true;
            }
            else if (nbSelections == 1)
            {
                // Si une est sélectionnée, on désactive les deux autres
                cbLigne.Enabled = (cbLigne.SelectedIndex != 0);
                cbStation.Enabled = (cbStation.SelectedIndex != 0);
                cbTrajet.Enabled = (cbTrajet.SelectedIndex != 0);
            }
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            if (cbLigne.SelectedIndex != 0)
            {
                Ligne Ligne = (Ligne)cbLigne.SelectedItem;
                ModifierLigne modifLigne = new ModifierLigne(Ligne);
                modifLigne.Show();
                this.Close();
            }
            else if (cbStation.SelectedIndex != 0)
            {
                Station Station = (Station)cbStation.SelectedItem;
                ModifierStation modifStation = new ModifierStation(Station);
                modifStation.Show();
                this.Close();
            }
            else if (cbTrajet.SelectedIndex != 0)
            {
                Trajet Trajet = (Trajet)cbTrajet.SelectedItem;
                ModifierTrajet modifTrajet = new ModifierTrajet(Trajet);
                modifTrajet.Show();
                this.Close();
            }
        }
    }
}
