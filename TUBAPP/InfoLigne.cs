using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUBAPP
{
    public partial class InfoLigne : Form
    {
        public InfoLigne()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void picIconeContact_Click(object sender, EventArgs e)
        {
            PageProfilAdmin pageProfilAdmin = new PageProfilAdmin();
            pageProfilAdmin.Show();
            this.Close();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            frmMenuPricipal menuPrincipal = new frmMenuPricipal();
            menuPrincipal.Show();
            this.Close();
        }
    }
}
