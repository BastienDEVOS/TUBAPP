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
            picIconeContact = new PictureBox();
            lblTitre = new Label();
            pnlCard = new Panel();
            lblInvite = new Label();
            lblNomPrenom = new Label();
            llbMail = new LinkLabel();
            lblMailValue = new Label();
            llbNaissance = new LinkLabel();
            lblNaissanceValue = new Label();
            btnModifier = new Button();
            btnCreerCompte = new Button();
            btnSeConnecter = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).BeginInit();
            pnlCard.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // picIconeContact
            // 
            picIconeContact.Image = Properties.Resources.icone_profil;
            picIconeContact.Location = new Point(361, 4);
            picIconeContact.Margin = new Padding(3, 4, 3, 4);
            picIconeContact.Name = "picIconeContact";
            picIconeContact.Size = new Size(63, 91);
            picIconeContact.SizeMode = PictureBoxSizeMode.Zoom;
            picIconeContact.TabIndex = 2;
            picIconeContact.TabStop = false;
            picIconeContact.Click += picIconeContact_Click;
            // 
            // lblTitre
            // 
            lblTitre.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitre.Location = new Point(96, 106);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(245, 53);
            lblTitre.TabIndex = 1;
            lblTitre.Text = "Votre profil";
            lblTitre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCard.Controls.Add(lblInvite);
            pnlCard.Controls.Add(lblNomPrenom);
            pnlCard.Controls.Add(llbMail);
            pnlCard.Controls.Add(lblMailValue);
            pnlCard.Controls.Add(llbNaissance);
            pnlCard.Controls.Add(lblNaissanceValue);
            pnlCard.Controls.Add(btnModifier);
            pnlCard.Location = new Point(64, 163);
            pnlCard.Margin = new Padding(3, 4, 3, 4);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(313, 266);
            pnlCard.TabIndex = 2;
            // 
            // lblInvite
            // 
            lblInvite.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblInvite.ForeColor = Color.FromArgb(234, 99, 93);
            lblInvite.Location = new Point(50, 20);
            lblInvite.Name = "lblInvite";
            lblInvite.Size = new Size(222, 27);
            lblInvite.TabIndex = 0;
            lblInvite.Text = "INVITER";
            lblInvite.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomPrenom
            // 
            lblNomPrenom.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNomPrenom.Location = new Point(50, 47);
            lblNomPrenom.Name = "lblNomPrenom";
            lblNomPrenom.Size = new Size(222, 27);
            lblNomPrenom.TabIndex = 1;
            lblNomPrenom.Text = "NOM Prénom";
            lblNomPrenom.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // llbMail
            // 
            llbMail.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            llbMail.LinkColor = Color.Black;
            llbMail.Location = new Point(39, 87);
            llbMail.Name = "llbMail";
            llbMail.Size = new Size(103, 27);
            llbMail.TabIndex = 2;
            llbMail.TabStop = true;
            llbMail.Text = "Adresse mail :";
            // 
            // lblMailValue
            // 
            lblMailValue.Font = new Font("Segoe UI", 9F);
            lblMailValue.Location = new Point(142, 87);
            lblMailValue.Name = "lblMailValue";
            lblMailValue.Size = new Size(96, 27);
            lblMailValue.TabIndex = 3;
            lblMailValue.Text = "Invité";
            // 
            // llbNaissance
            // 
            llbNaissance.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            llbNaissance.LinkColor = Color.Black;
            llbNaissance.Location = new Point(39, 120);
            llbNaissance.Name = "llbNaissance";
            llbNaissance.Size = new Size(149, 27);
            llbNaissance.TabIndex = 4;
            llbNaissance.TabStop = true;
            llbNaissance.Text = "Date de naissance :";
            // 
            // lblNaissanceValue
            // 
            lblNaissanceValue.Font = new Font("Segoe UI", 9F);
            lblNaissanceValue.Location = new Point(39, 147);
            lblNaissanceValue.Name = "lblNaissanceValue";
            lblNaissanceValue.Size = new Size(199, 27);
            lblNaissanceValue.TabIndex = 5;
            lblNaissanceValue.Text = "Jours/Mois/Années";
            // 
            // btnModifier
            // 
            btnModifier.BackColor = Color.LightGray;
            btnModifier.FlatStyle = FlatStyle.Flat;
            btnModifier.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModifier.Location = new Point(90, 196);
            btnModifier.Margin = new Padding(3, 4, 3, 4);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(137, 40);
            btnModifier.TabIndex = 6;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = false;
            // 
            // btnCreerCompte
            // 
            btnCreerCompte.BackColor = Color.FromArgb(209, 66, 54);
            btnCreerCompte.FlatStyle = FlatStyle.Flat;
            btnCreerCompte.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCreerCompte.ForeColor = Color.White;
            btnCreerCompte.Location = new Point(64, 450);
            btnCreerCompte.Margin = new Padding(3, 4, 3, 4);
            btnCreerCompte.Name = "btnCreerCompte";
            btnCreerCompte.Size = new Size(313, 53);
            btnCreerCompte.TabIndex = 3;
            btnCreerCompte.Text = "Créer un compte";
            btnCreerCompte.UseVisualStyleBackColor = false;
            // 
            // btnSeConnecter
            // 
            btnSeConnecter.BackColor = Color.FromArgb(209, 66, 54);
            btnSeConnecter.FlatStyle = FlatStyle.Flat;
            btnSeConnecter.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSeConnecter.ForeColor = Color.White;
            btnSeConnecter.Location = new Point(64, 521);
            btnSeConnecter.Margin = new Padding(3, 4, 3, 4);
            btnSeConnecter.Name = "btnSeConnecter";
            btnSeConnecter.Size = new Size(313, 53);
            btnSeConnecter.TabIndex = 4;
            btnSeConnecter.Text = "Se connecter";
            btnSeConnecter.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(234, 99, 93);
            flowLayoutPanel1.Controls.Add(pictureBox3);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(picIconeContact);
            flowLayoutPanel1.Controls.Add(pictureBox4);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(446, 95);
            flowLayoutPanel1.TabIndex = 17;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.logo1;
            pictureBox3.ImeMode = ImeMode.NoControl;
            pictureBox3.Location = new Point(2, 2);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(91, 93);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(132, 21);
            label1.Margin = new Padding(37, 0, 37, 0);
            label1.Name = "label1";
            label1.Size = new Size(189, 57);
            label1.TabIndex = 0;
            label1.Text = "TUBAPP";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icone_profil;
            pictureBox4.ImeMode = ImeMode.NoControl;
            pictureBox4.Location = new Point(0, 99);
            pictureBox4.Margin = new Padding(0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(93, 93);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // PageCompte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(446, 659);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnSeConnecter);
            Controls.Add(btnCreerCompte);
            Controls.Add(pnlCard);
            Controls.Add(lblTitre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PageCompte";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)picIconeContact).EndInit();
            pnlCard.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        // Helper for rounded corners
        internal static class NativeMethods
        {
            [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
            public static extern IntPtr CreateRoundRectRgn(
                int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        }

#endregion
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
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBox4;
    }
}
