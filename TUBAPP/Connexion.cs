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
    public partial class frmConnexion : Form
    {
        public frmConnexion()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtIdentifiant_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRetour_MouseClick(object sender, MouseEventArgs e)
        {
            frmAcceuil FrmAcceuil = new frmAcceuil();
            FrmAcceuil.Show();

            this.Hide();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            frmMenuPricipal FrmMenuPrincipal = new frmMenuPricipal();
            FrmMenuPrincipal.Show();

            this.Close();
        }
    }
}
