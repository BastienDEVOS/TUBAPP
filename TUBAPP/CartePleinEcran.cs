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
using static System.Net.Mime.MediaTypeNames;

namespace TUBAPP
{
    public partial class CartePleinEcran : Form
    {

        public CartePleinEcran()
        {
            InitializeComponent();

            PicBoxCartePleineEcran.SizeMode = PictureBoxSizeMode.Zoom;
            PicBoxCartePleineEcran.Dock = DockStyle.Fill;

            // Mode plein écran
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            // Bouton Quitter
            btnQuitter.Text = "Quitter";
            btnQuitter.Click += (s, e) => this.Close();
            btnQuitter.BringToFront(); // S'assurer qu’il n’est pas caché par l’image





        }

        private void CartePleinEcran_Load(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {

        }

        private void PicBoxCartePleineEcran_Click(object sender, EventArgs e)
        {

        }
    }
}
