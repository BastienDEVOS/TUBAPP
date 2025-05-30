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
using ZstdSharp.Unsafe;

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

            txtTpsTrajet.Text = Trajet.TempsTrajets;
        }

        private void ModifierHorraire_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PageCarte page = new PageCarte();
            page.Show();
            this.Close();
        }
    }
}
