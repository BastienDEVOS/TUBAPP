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
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmMenuPricipal FrmMenuPrincipal = new frmMenuPricipal();
            FrmMenuPrincipal.Show();

            this.Close();
        }
    }
}
