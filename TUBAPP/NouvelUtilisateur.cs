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
    public partial class frmNouvelUtilisateur : Form
    {
        bool verifMail = false;
        bool verifMdp = false;
        public frmNouvelUtilisateur()
        {
            InitializeComponent();
        }

        private void btn_Connecter_Click(object sender, EventArgs e)
        {
            frmMenuPricipal FrmMenuPrincipal = new frmMenuPricipal();
            FrmMenuPrincipal.Show();

            this.Close();
        }

        //verification de l'état des champs et permet la connection de l'utilisateur
        private void verif()
        {
            if (ConditionUtilisation.Checked == true && verifMail == true && verifMdp == true)
            {
                btn_Connecter.Enabled = true;
            }
            else
            {
                btn_Connecter.Enabled = false;
            }
        }

        private void ConditionUtilisation_Click(object sender, EventArgs e)
        {
            PopupCondition.Visible = true;
        }

        private void Accepter_Click(object sender, EventArgs e)
        {
            PopupCondition.Visible = false;
            ConditionUtilisation.Checked = true;
        }

        private void Refuser_Click(object sender, EventArgs e)
        {
            PopupCondition.Visible = false;
            ConditionUtilisation.Checked = false;
        }

        private void txtAdresseMail_TextChanged(object sender, EventArgs e)
        {
            if (txtAdresseMail.Text.Contains("@") && txtAdresseMail.Text.Contains("."))
            {
                msg_erreurMail.Visible = false;
                txtAdresseMail.BackColor = Color.LightGreen;
                verifMail = true;
                verif();
            }
            else
            {
                msg_erreurMail.Visible = true;
                txtAdresseMail.BackColor = Color.Red;
                verifMail = false;
                verif();
            }
        }

        private void txtMDP_TextChanged(object sender, EventArgs e)
        {
            verif();
        }

        private void txtConfirmMDP_TextChanged(object sender, EventArgs e)
        {
            if (txtMDP.Text == txtConfirmMDP.Text)
            {
                msg_erreurMdp.Visible = false;
                txtMDP.BackColor = Color.LightGreen;
                txtConfirmMDP.BackColor = Color.LightGreen;
                verifMdp = true;
                verif();
            }
            else
            {
                msg_erreurMdp.Visible = true;
                txtMDP.BackColor = Color.Red;
                txtConfirmMDP.BackColor = Color.Red;
                verifMdp = false;
                verif();
            }
        }

        private void ConditionUtilisation_CheckedChanged(object sender, EventArgs e)
        {
            verif();
        }

    }
}
