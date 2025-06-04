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

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string email = txtIdentifiant.Text.Trim();
            string password = txtMDP.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var conn = BD.GetConnection())
                {
                    if (BD.AuthentifierUtilisateur(email, password, conn))
                    {
                        frmMenuPricipal FrmMenuPrincipal = new frmMenuPricipal();
                        FrmMenuPrincipal.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Email ou mot de passe incorrect.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion à la base de données: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnMdpOublie_Click(object sender, EventArgs e)
        {
            frmRecuperationmdp recuperationForm = new frmRecuperationmdp();
            recuperationForm.Show();
            this.Hide();
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            frmAcceuil FrmAcceuil = new frmAcceuil();
            FrmAcceuil.Show();

            this.Close();
        }
    }
}
