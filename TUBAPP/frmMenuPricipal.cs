using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TUBAPP; // Assurez-vous que le bon espace de noms est utilisé pour les ressources

namespace TUBAPP
{
    public partial class frmMenuPricipal : Form
    {
        public frmMenuPricipal()
        {
            InitializeComponent();
        }

        private void VoirItineraire_Click(object sender, EventArgs e)
        {

        }

        private void IconeProfil_Click(object sender, EventArgs e)
        {
            Utilisateur user = new Utilisateur
            {
                Nom = "Martin",
                Prenom = "Julie",
                Email = "julie@exemple.com",
                EstAdmin = false
            };

            // Ouvrir la page de profil
            PageCompte pageCompte = new PageCompte(user);
            pageCompte.Show();
        }
    }
}
