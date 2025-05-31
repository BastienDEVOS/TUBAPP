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
    public partial class AdminAjoutStation : Form
    {
        public AdminAjoutStation()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PageCarte page = new PageCarte();
            page.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            frmOptionAdminAjouter page = new frmOptionAdminAjouter();
            page.Show();
            this.Close();
        }
    }
}
