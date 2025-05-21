using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUBAPP
{
    public partial class SelectionLigne : Form
    {
        public SelectionLigne()
        {
            InitializeComponent();
        }

        private void labelSelectionner_Click(object sender, EventArgs e)
        {

        }

        private void SelectionLigne_Load(object sender, EventArgs e)
        {
            ClassUtilitaire.MettreBordArrondis(p_InfosTrajet, 20);
            ClassUtilitaire.MettreBordArrondis(p_Horraire, 20);
            ClassUtilitaire.MettreBordArrondis(p_Station, 20);
            ClassUtilitaire.MettreBordArrondis(cmb_StationDepart, 20);
            ClassUtilitaire.MettreBordArrondis(cmb_StationArrivee, 20);
            ClassUtilitaire.MettreBordArrondis(cmb_Horaire1, 20);
            ClassUtilitaire.MettreBordArrondis(cmb_Horaire2, 20);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Création d'un stylo noir avec une épaisseur de 2 pixels
            Pen pen = new Pen(Color.Black, 5);

            // Dessine une ligne de (x1=10, y1=10) à (x2=200, y2=10)
            e.Graphics.DrawLine(pen, 0, 140, 464, 140);
            e.Graphics.DrawLine(pen, 215, 0, 215, 140);

            // Libération des ressources du stylo
            pen.Dispose();
        }
    }
}
