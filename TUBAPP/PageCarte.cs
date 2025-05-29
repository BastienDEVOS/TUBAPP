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
    public partial class PageCarte : Form
    {
        public PageCarte()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picBoxCarte_Click(object sender, EventArgs e)
        {

        }

        private void PageCarte_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                CartePleinEcran fenetre = new CartePleinEcran();
                fenetre.ShowDialog();
            }
        }

        private void picIconeContact_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmMenuPricipal FrmMenuPrincipal = new frmMenuPricipal();
            FrmMenuPrincipal.Show();

            this.Close();
        }
    }
}
