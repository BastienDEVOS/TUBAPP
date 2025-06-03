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
    public partial class frmOptionAdminAjouter : Form
    {
        public frmOptionAdminAjouter()
        {
            InitializeComponent();
        }

        private void OptionAdminAjouter_Load(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            frmOptionAdmin optionAdmin = new frmOptionAdmin();
            optionAdmin.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PageCarte page = new PageCarte();
            page.Show();
            this.Close();
        }

        private void btnAjoutLigne_Click(object sender, EventArgs e)
        {
            AdminAjoutLigne page = new AdminAjoutLigne();
            page.Show();
            this.Close();
        }

        private void btnAjoutStation_Click(object sender, EventArgs e)
        {
            AdminAjoutStation page = new AdminAjoutStation();
            page.Show();
            this.Close();
        }

        private void btnAjoutTrajet_Click(object sender, EventArgs e)
        {
            AdminAjoutTrajet page = new AdminAjoutTrajet();
            page.Show();
            this.Close();
        }
    }
}
