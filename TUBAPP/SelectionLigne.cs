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
using Classes;

namespace TUBAPP
{
    public partial class frmSelectionLigne : Form
    {
        public frmSelectionLigne(Station StationDepart, Station StationArrivee)
        {
            InitializeComponent();

            // récupère les stations depuis la BD
            List<Station> stationsDepart = BD.GetStation(); 
            List<Station> stationsArrivee = BD.GetStation();

            cmb_StationDepart.DataSource = stationsDepart;
            cmb_StationDepart.DisplayMember = "Nom";
            cmb_StationDepart.ValueMember = "IdStation";
            cmb_StationDepart.SelectedIndex = (StationDepart.IdStation) -1; // force la sélection par défaut

            cmb_StationArrivee.DataSource = stationsArrivee;
            cmb_StationArrivee.DisplayMember = "Nom";
            cmb_StationArrivee.ValueMember = "IdStation";
            cmb_StationArrivee.SelectedIndex = (StationArrivee.IdStation) -1; // force la sélection par défaut
        }

        private void labelSelectionner_Click(object sender, EventArgs e)
        {

        }

        private void SelectionLigne_Load(object sender, EventArgs e)
        {
            ClassUtilitaire.MettreBordArrondis(p_InfosTrajet, 20);
            ClassUtilitaire.MettreBordArrondis(p_Horraire, 20);
            ClassUtilitaire.MettreBordArrondis(p_Station, 20);
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

        private void btn_retour_Click(object sender, EventArgs e)
        {
            frmMenuPricipal FrmMenuPrincipal = new frmMenuPricipal();
            FrmMenuPrincipal.Show();
            this.Close(); // Ferme le formulaire actuel
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmInfoLigne infoLigne = new frmInfoLigne();
            infoLigne.Show();
            this.Close(); // Masquer le formulaire actuel
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmMenuPricipal FrmMenuPrincipal = new frmMenuPricipal();
            FrmMenuPrincipal.Show();
            this.Close(); // Ferme le formulaire actuel
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PageCarte page = new PageCarte();
            page.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
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
    }
}
