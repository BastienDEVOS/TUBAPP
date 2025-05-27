using MySql.Data.MySqlClient;

namespace TUBAPP
{
    public partial class frmOptionAdminSuprimer : Form
    {
        public frmOptionAdminSuprimer()
        {
            InitializeComponent();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int idLigne = int.Parse(Ligne.Text);

            try
            {
                using (var conn = BD.GetConnection())
                {
                    var cmd = new MySqlCommand("DELETE FROM Ligne WHERE IdLigne=@IdLigne", conn);
                    cmd.Parameters.AddWithValue("@IdLigne", idLigne);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ligne supprimée avec succès !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression : " + ex.Message);
            }
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
    }
}
