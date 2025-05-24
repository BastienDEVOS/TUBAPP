using MySql.Data.MySqlClient;

namespace TUBAPP
{
    public partial class PageProfilAdmin : Form
    {
        public PageProfilAdmin()
        {
            InitializeComponent();
        }

        private void PageProfilAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    var cmdClients = new MySqlCommand("SELECT COUNT(*) FROM Client", conn);
                    var cmdLignes = new MySqlCommand("SELECT COUNT(*) FROM Ligne", conn);
                    int clientCount = Convert.ToInt32(cmdClients.ExecuteScalar());
                    int ligneCount = Convert.ToInt32(cmdLignes.ExecuteScalar());
                    lblStats.Text = $"Clients: {clientCount} | Lignes: {ligneCount}"; // Add a Label named lblStats
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des statistiques : " + ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmMenuPricipal FrmMenuPrincipal = new frmMenuPricipal();
            FrmMenuPrincipal.Show();

            this.Close();
        }
    }
}
