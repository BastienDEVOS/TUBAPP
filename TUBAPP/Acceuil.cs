using MySql.Data.MySqlClient;

namespace TUBAPP
{
    public partial class frmAcceuil : Form
    {
        public frmAcceuil()
        {
            InitializeComponent();
        }

        private void frmAcceuil_Load(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    var cmd = new MySqlCommand("SELECT COUNT(*) FROM Client", conn);
                    int clientCount = Convert.ToInt32(cmd.ExecuteScalar());
                    this.Text = $"TUBAPP - {clientCount} clients inscrits";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la connexion à la base de données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConnexion_MouseClick(object sender, MouseEventArgs e)
        {
            frmConnexion FrmConnexion = new frmConnexion();
            FrmConnexion.Show();

            this.Hide();
        }

        private void btnNvCompt_Click(object sender, EventArgs e)
        {
            frmNouvelUtilisateur FrmNouvelUtilisateur = new frmNouvelUtilisateur();
            FrmNouvelUtilisateur.Show();

            this.Hide();
        }

        private void btnInvité_Click(object sender, EventArgs e)
        {
            frmMenuPricipal FrmMenuPrincipal = new frmMenuPricipal();
            FrmMenuPrincipal.Show();

            this.Hide();
        }

        private void picUndergroudLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
