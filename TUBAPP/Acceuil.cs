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
            BD.Connection();
            try
            {
                using (var conn = BD.GetConnection())
                {
                    ConnecterOui.Visible = true;
                }
            }
            catch (Exception ex)
            {
                ConnecterNon.Visible = true;
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

        private void btnInvite_Click(object sender, EventArgs e)
        {
            frmMenuPricipal FrmMenuPrincipal = new frmMenuPricipal();
            FrmMenuPrincipal.Show();

            this.Hide();
        }
    }
}
