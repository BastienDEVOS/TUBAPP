using System.Runtime;
using System.Windows.Forms;

namespace TUBAPP
{
    partial class PageCompte
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.flpNavbarre = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblTUBAPP = new System.Windows.Forms.Label();
            this.picIconeContact = new System.Windows.Forms.PictureBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblInvite = new System.Windows.Forms.Label();
            this.lblNomPrenom = new System.Windows.Forms.Label();
            this.llbMail = new System.Windows.Forms.LinkLabel();
            this.lblMailValue = new System.Windows.Forms.Label();
            this.llbNaissance = new System.Windows.Forms.LinkLabel();
            this.lblNaissanceValue = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnCreerCompte = new System.Windows.Forms.Button();
            this.btnSeConnecter = new System.Windows.Forms.Button();
            this.pnlBottomNav = new System.Windows.Forms.Panel();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.picAccount = new System.Windows.Forms.PictureBox();
            this.picSettings = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconeContact)).BeginInit();
            this.pnlCard.SuspendLayout();
            this.pnlBottomNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // flpNavbarre
            // 
            this.flpNavbarre.BackColor = System.Drawing.Color.FromArgb(234, 99, 93);
            this.flpNavbarre.Controls.Add(this.pictureBoxLogo);
            this.flpNavbarre.Controls.Add(this.lblTUBAPP);
            this.flpNavbarre.Controls.Add(this.picIconeContact);
            this.flpNavbarre.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpNavbarre.Location = new System.Drawing.Point(0, 0);
            this.flpNavbarre.Name = "flpNavbarre";
            this.flpNavbarre.Size = new System.Drawing.Size(214, 48);
            this.flpNavbarre.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::TUBAPP.Properties.Resources.logo1;
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lblTUBAPP
            // 
            this.lblTUBAPP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTUBAPP.ForeColor = System.Drawing.Color.White;
            this.lblTUBAPP.Location = new System.Drawing.Point(49, 10);
            this.lblTUBAPP.Name = "lblTUBAPP";
            this.lblTUBAPP.Size = new System.Drawing.Size(90, 28);
            this.lblTUBAPP.TabIndex = 1;
            this.lblTUBAPP.Text = "TUBAPP";
            this.lblTUBAPP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picIconeContact
            // 
            this.picIconeContact.Image = global::TUBAPP.Properties.Resources.icone_profil;
            this.picIconeContact.Location = new System.Drawing.Point(145, 3);
            this.picIconeContact.Name = "picIconeContact";
            this.picIconeContact.Size = new System.Drawing.Size(40, 40);
            this.picIconeContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIconeContact.TabIndex = 2;
            this.picIconeContact.TabStop = false;
            // 
            // lblTitre
            // 
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitre.Location = new System.Drawing.Point(0, 55);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(214, 40);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Votre profil";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard.Controls.Add(this.lblInvite);
            this.pnlCard.Controls.Add(this.lblNomPrenom);
            this.pnlCard.Controls.Add(this.llbMail);
            this.pnlCard.Controls.Add(this.lblMailValue);
            this.pnlCard.Controls.Add(this.llbNaissance);
            this.pnlCard.Controls.Add(this.lblNaissanceValue);
            this.pnlCard.Controls.Add(this.btnModifier);
            this.pnlCard.Location = new System.Drawing.Point(10, 100);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(194, 200);
            this.pnlCard.TabIndex = 2;
            // Rounded corners
            this.pnlCard.Region = System.Drawing.Region.FromHrgn(
                NativeMethods.CreateRoundRectRgn(0, 0, pnlCard.Width, pnlCard.Height, 20, 20)
            );
            // 
            // lblInvite
            // 
            this.lblInvite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInvite.ForeColor = System.Drawing.Color.FromArgb(234, 99, 93);
            this.lblInvite.Location = new System.Drawing.Point(0, 10);
            this.lblInvite.Name = "lblInvite";
            this.lblInvite.Size = new System.Drawing.Size(194, 20);
            this.lblInvite.TabIndex = 0;
            this.lblInvite.Text = "INVITER";
            this.lblInvite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomPrenom
            // 
            this.lblNomPrenom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomPrenom.Location = new System.Drawing.Point(0, 35);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(194, 20);
            this.lblNomPrenom.TabIndex = 1;
            this.lblNomPrenom.Text = "NOM Prénom";
            this.lblNomPrenom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // llbMail
            // 
            this.llbMail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.llbMail.LinkColor = System.Drawing.Color.Black;
            this.llbMail.Location = new System.Drawing.Point(10, 60);
            this.llbMail.Name = "llbMail";
            this.llbMail.Size = new System.Drawing.Size(90, 20);
            this.llbMail.TabIndex = 2;
            this.llbMail.TabStop = true;
            this.llbMail.Text = "Adresse mail :";
            // 
            // lblMailValue
            // 
            this.lblMailValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMailValue.Location = new System.Drawing.Point(100, 60);
            this.lblMailValue.Name = "lblMailValue";
            this.lblMailValue.Size = new System.Drawing.Size(84, 20);
            this.lblMailValue.TabIndex = 3;
            this.lblMailValue.Text = "Invité";
            // 
            // llbNaissance
            // 
            this.llbNaissance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.llbNaissance.LinkColor = System.Drawing.Color.Black;
            this.llbNaissance.Location = new System.Drawing.Point(10, 85);
            this.llbNaissance.Name = "llbNaissance";
            this.llbNaissance.Size = new System.Drawing.Size(130, 20);
            this.llbNaissance.TabIndex = 4;
            this.llbNaissance.TabStop = true;
            this.llbNaissance.Text = "Date de naissance :";
            // 
            // lblNaissanceValue
            // 
            this.lblNaissanceValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNaissanceValue.Location = new System.Drawing.Point(10, 105);
            this.lblNaissanceValue.Name = "lblNaissanceValue";
            this.lblNaissanceValue.Size = new System.Drawing.Size(174, 20);
            this.lblNaissanceValue.TabIndex = 5;
            this.lblNaissanceValue.Text = "Jours/Mois/Années";
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.LightGray;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModifier.Location = new System.Drawing.Point(37, 145);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(120, 30);
            this.btnModifier.TabIndex = 6;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            // 
            // btnCreerCompte
            // 
            this.btnCreerCompte.BackColor = System.Drawing.Color.FromArgb(209, 66, 54);
            this.btnCreerCompte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreerCompte.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreerCompte.ForeColor = System.Drawing.Color.White;
            this.btnCreerCompte.Location = new System.Drawing.Point(10, 315);
            this.btnCreerCompte.Name = "btnCreerCompte";
            this.btnCreerCompte.Size = new System.Drawing.Size(194, 40);
            this.btnCreerCompte.TabIndex = 3;
            this.btnCreerCompte.Text = "Créer un compte";
            this.btnCreerCompte.UseVisualStyleBackColor = false;
            this.btnCreerCompte.Region = System.Drawing.Region.FromHrgn(
                NativeMethods.CreateRoundRectRgn(0, 0, btnCreerCompte.Width, btnCreerCompte.Height, 20, 20)
            );
            // 
            // btnSeConnecter
            // 
            this.btnSeConnecter.BackColor = System.Drawing.Color.FromArgb(209, 66, 54);
            this.btnSeConnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeConnecter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSeConnecter.ForeColor = System.Drawing.Color.White;
            this.btnSeConnecter.Location = new System.Drawing.Point(10, 360);
            this.btnSeConnecter.Name = "btnSeConnecter";
            this.btnSeConnecter.Size = new System.Drawing.Size(194, 40);
            this.btnSeConnecter.TabIndex = 4;
            this.btnSeConnecter.Text = "Se connecter";
            this.btnSeConnecter.UseVisualStyleBackColor = false;
            this.btnSeConnecter.Region = System.Drawing.Region.FromHrgn(
                NativeMethods.CreateRoundRectRgn(0, 0, btnSeConnecter.Width, btnSeConnecter.Height, 20, 20)
            );
            // 
            // pnlBottomNav
            // 
            this.pnlBottomNav.BackColor = System.Drawing.Color.White;
            this.pnlBottomNav.Controls.Add(this.picHome);
            this.pnlBottomNav.Controls.Add(this.picAccount);
            this.pnlBottomNav.Controls.Add(this.picSettings);
            this.pnlBottomNav.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomNav.Location = new System.Drawing.Point(0, 413);
            this.pnlBottomNav.Name = "pnlBottomNav";
            this.pnlBottomNav.Size = new System.Drawing.Size(214, 50);
            this.pnlBottomNav.TabIndex = 5;
            // 
            // picHome
            // 
            this.picHome.Image = global::TUBAPP.Properties.Resources.GPS;
            this.picHome.Location = new System.Drawing.Point(20, 5);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(32, 32);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHome.TabIndex = 0;
            this.picHome.TabStop = false;
            // 
            // picAccount
            // 
            this.picAccount.Image = global::TUBAPP.Properties.Resources.homepng;
            this.picAccount.Location = new System.Drawing.Point(91, 5);
            this.picAccount.Name = "picAccount";
            this.picAccount.Size = new System.Drawing.Size(32, 32);
            this.picAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAccount.TabIndex = 1;
            this.picAccount.TabStop = false;
            // 
            // picSettings
            // 
            this.picSettings.Image = global::TUBAPP.Properties.Resources.network;
            this.picSettings.Location = new System.Drawing.Point(162, 5);
            this.picSettings.Name = "picSettings";
            this.picSettings.Size = new System.Drawing.Size(32, 32);
            this.picSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSettings.TabIndex = 2;
            this.picSettings.TabStop = false;
            // 
            // PageCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(214, 463);
            this.Controls.Add(this.pnlBottomNav);
            this.Controls.Add(this.btnSeConnecter);
            this.Controls.Add(this.btnCreerCompte);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.flpNavbarre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PageCompte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconeContact)).EndInit();
            this.pnlCard.ResumeLayout(false);
            this.pnlBottomNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSettings)).EndInit();
            this.ResumeLayout(false);
        }

        // Helper for rounded corners
        internal static class NativeMethods
        {
            [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
            public static extern IntPtr CreateRoundRectRgn(
                int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpNavbarre;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblTUBAPP;
        private System.Windows.Forms.PictureBox picIconeContact;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblInvite;
        private System.Windows.Forms.Label lblNomPrenom;
        private System.Windows.Forms.LinkLabel llbMail;
        private System.Windows.Forms.Label lblMailValue;
        private System.Windows.Forms.LinkLabel llbNaissance;
        private System.Windows.Forms.Label lblNaissanceValue;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnCreerCompte;
        private System.Windows.Forms.Button btnSeConnecter;
        private System.Windows.Forms.Panel pnlBottomNav;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.PictureBox picAccount;
        private System.Windows.Forms.PictureBox picSettings;
    }
}
