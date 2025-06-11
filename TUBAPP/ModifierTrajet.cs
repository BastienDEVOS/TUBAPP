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
using Mysqlx.Crud;
using ZstdSharp.Unsafe;
using static System.Windows.Forms.LinkLabel;

namespace TUBAPP
{
    public partial class ModifierTrajet : Form
    {
        private Trajet TrajetModifier;
        public ModifierTrajet(Trajet Trajet)
        {
            InitializeComponent();
            this.TrajetModifier = Trajet;
            // Initialisation des champs avec les données du trajet à modifier  

            List<Ligne> lignes = BD.GetLigne(); // récupère les lignes depuis la BD

            cbLigne.DataSource = lignes;
            cbLigne.DisplayMember = "Nom";
            cbLigne.ValueMember = "IdLigne";
            cbLigne.SelectedValue = Trajet.IdLigne; // force la sélection par défaut

            List<Station> stationsDepart = BD.GetStation(); // récupère les stations depuis la BD
            List<Station> stationsArrivee = BD.GetStation();

            cbStationDepart.DataSource = stationsDepart;
            cbStationDepart.DisplayMember = "Nom";
            cbStationDepart.ValueMember = "IdStation";
            cbStationDepart.SelectedValue = Trajet.IdStationDepart; // force la sélection par défaut

            cbStationArrivee.DataSource = stationsArrivee;
            cbStationArrivee.DisplayMember = "Nom";
            cbStationArrivee.ValueMember = "IdStation";
            cbStationArrivee.SelectedValue = Trajet.IdStationArrivee; // force la sélection par défaut

            dtp_TempsTrajet.Text = Trajet.TempsTrajets;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PageCarte page = new PageCarte();
            page.Show();
            this.Close();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            frmOptionAdminModif optionAdminModifier = new frmOptionAdminModif();
            optionAdminModifier.Show();
            this.Close();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            BD.SupprimerTrajet(TrajetModifier.IdLigne, TrajetModifier.IdStationDepart, TrajetModifier.IdStationArrivee);
            BD.AjoutTrajetBase((int)cbLigne.SelectedValue, (int)cbStationDepart.SelectedValue, (int)cbStationArrivee.SelectedValue, dtp_TempsTrajet.Value.TimeOfDay);
            frmOptionAdminModif optionAdminModifier = new frmOptionAdminModif();
            optionAdminModifier.Show();
            this.Close();
        }
    }
}
