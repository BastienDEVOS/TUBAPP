using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;

namespace TUBAPP
{
    public partial class ModifierStation : Form
    {
        private Station StationModifier;
        public ModifierStation(Station Station)
        {
            InitializeComponent();
            this.StationModifier = Station;

            // Initialisation des champs avec les données de la station à modifier
            txtNom.Text = Station.Nom;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PageCarte page = new PageCarte();
            page.Show();
            this.Close();
        }
    }
}
