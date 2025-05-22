namespace TUBAPP
{
    public partial class OptionAdmin : Form
    {
        public OptionAdmin()
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
            PageProfilAdmin pageProfilAdmin = new PageProfilAdmin();
            pageProfilAdmin.Show();
            this.Close();
        }

        private void btnOptionAdminAjout_Click(object sender, EventArgs e)
        {
            OptionAdminAjouter optionAdminAjouter = new OptionAdminAjouter();
            optionAdminAjouter.Show();
            this.Close();
        }

        private void btnOptionAdminModif_Click(object sender, EventArgs e)
        {
            OptionAdminModif optionAdminModif = new OptionAdminModif();
            optionAdminModif.Show();
            this.Close();
        }

        private void btnOptionAdminSupr_Click(object sender, EventArgs e)
        {
            OptionAdminSuprimer optionAdminSuprimer = new OptionAdminSuprimer();
            optionAdminSuprimer.Show();
            this.Close();
        }

        private void pbGps_Click(object sender, EventArgs e)
        {
            InfoLigne infoLigne = new InfoLigne();
            infoLigne.Show();
            this.Close();
        }
    }
}
