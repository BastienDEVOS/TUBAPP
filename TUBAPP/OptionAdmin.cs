namespace TUBAPP
{
    public partial class frmOptionAdmin : Form
    {
        public frmOptionAdmin()
        {
            InitializeComponent();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            frmMenuPricipal FrmMenuPrincipal = new frmMenuPricipal();
            FrmMenuPrincipal.Show();

            this.Close();
        }

        private void OptionAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            frmPageProfilAdmin pageProfilAdmin = new frmPageProfilAdmin();
            pageProfilAdmin.Show();
            this.Close();
        }

        private void btnOptionAdminAjout_Click(object sender, EventArgs e)
        {
            frmOptionAdminAjouter optionAdminAjouter = new frmOptionAdminAjouter();
            optionAdminAjouter.Show();
            this.Close();
        }

        private void btnOptionAdminModif_Click(object sender, EventArgs e)
        {
            frmOptionAdminModif optionAdminModif = new frmOptionAdminModif();
            optionAdminModif.Show();
            this.Close();
        }

        private void btnOptionAdminSupr_Click(object sender, EventArgs e)
        {
            frmOptionAdminSuprimer optionAdminSuprimer = new frmOptionAdminSuprimer();
            optionAdminSuprimer.Show();
            this.Close();
        }

        private void pbGps_Click(object sender, EventArgs e)
        {
            frmInfoLigne infoLigne = new frmInfoLigne();
            infoLigne.Show();
            this.Close();
        }
    }
}
