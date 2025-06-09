using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TUBAPP;
namespace TUBAPP
{
    public partial class PageCarte : Form
    {
        public PageCarte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                CartePleinEcran cartePleinEcran = new CartePleinEcran();
                cartePleinEcran.Show();
            }

        }

        private void picIconeContact_Click(object sender, EventArgs e)
        {
            Utilisateur? currentUser = SessionManager.CurrentUser;

            if (currentUser == null)
            {
                frmPageProfilInviter pageProfilInviter = new frmPageProfilInviter(new Utilisateur(true));
                pageProfilInviter.Show();
            }
            else if (currentUser.EstAdmin)
            {
                frmPageProfilAdmin pageProfilAdmin = new frmPageProfilAdmin();
                pageProfilAdmin.Show();
            }
            else
            {
                frmPageProfilConnecter pageProfilConnecter = new frmPageProfilConnecter(currentUser.Email);
                pageProfilConnecter.Show();
            }

            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmMenuPricipal FrmMenuPrincipal = new frmMenuPricipal();
            FrmMenuPrincipal.Show();

            this.Close();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            frmMenuPricipal FrmMenuPrincipal = new frmMenuPricipal();
            FrmMenuPrincipal.Show();

            this.Close();
        }

        private void lblRame_Click(object sender, EventArgs e)
        {

        }

        private void PageCarte_Load(object sender, EventArgs e)
        {

        }
    }
}
