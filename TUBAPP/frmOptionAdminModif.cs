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

            Station.DataSource = stations;
            Station.DisplayMember = "Nom";
            Station.ValueMember = "IdStation";
            Station.SelectedIndex = 0;

            // === LIGNE avec élément par défaut ===
            List<Ligne> lignes = BD.GetLigne(); // récupère les lignes depuis la BD

            // Ajoute une ligne "par défaut" tout en haut de la liste
            lignes.Insert(0, new Ligne { IdLigne = -1, Nom = "-- Sélectionner une ligne --" });

            Ligne.DataSource = lignes;
            Ligne.DisplayMember = "Nom";
            Ligne.ValueMember = "IdLigne";
            Ligne.SelectedIndex = 0; // force la sélection par défaut

            // === TRAJET avec élément par défaut ===
            List<Trajet> trajets = BD.GetTrajet(); // récupère les trajets depuis la BD
            Trajets.DataSource = null;
            Trajets.Items.Clear();
            Trajets.Items.Add("-- Sélectionner un Trajet --");
            Trajets.Items.AddRange(trajets.ToArray());
            Trajets.SelectedIndex = 0;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PageCarte page = new PageCarte();
            page.Show();
            this.Close();
        }
    }
}
