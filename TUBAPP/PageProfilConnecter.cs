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
    public partial class PageProfilConnecter : Form
    {
        public PageProfilConnecter()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmMenuPricipal FrmMenuPrincipal = new frmMenuPricipal();
            FrmMenuPrincipal.Show();

            this.Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            PageModifConnecter pageModif = new PageModifConnecter();
            pageModif.Show();
            this.Close(); // Masquer le formulaire de profil
        }
    }
}
