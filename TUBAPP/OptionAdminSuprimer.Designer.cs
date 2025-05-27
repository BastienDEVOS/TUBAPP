namespace TUBAPP
{
    partial class frmOptionAdminSuprimer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptionAdminSuprimer));
            btnRetour = new Button();
            btnSuprimer = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            BtnHome = new PictureBox();
            pictureBox5 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            picIconeContact = new PictureBox();
            pictureBox4 = new PictureBox();
            pnlCard = new Panel();
            lblInvite = new Label();
            lblNomPrenom = new Label();
            llbMail = new LinkLabel();
            lblMailValue = new Label();
            llbNaissance = new LinkLabel();
            lblNaissanceValue = new Label();
            btnModifier = new Button();
            lblTitre = new Label();
            Ligne = new ComboBox();
            Station = new ComboBox();
            Horaire = new ComboBox();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnlCard.SuspendLayout();
            SuspendLayout();
            // 
            // btnRetour
            // 
            btnRetour.BackColor = Color.FromArgb(209, 66, 54);
            btnRetour.FlatStyle = FlatStyle.Flat;
            btnRetour.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRetour.ForeColor = Color.White;
            btnRetour.Location = new Point(187, 848);
            btnRetour.Margin = new Padding(5, 6, 5, 6);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(353, 74);
            btnRetour.TabIndex = 45;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = false;
            btnRetour.Click += btnRetour_Click;
            // 
            // btnSuprimer
            // 
            btnSuprimer.BackColor = Color.FromArgb(209, 66, 54);
            btnSuprimer.Enabled = false;
            btnSuprimer.FlatStyle = FlatStyle.Flat;
            btnSuprimer.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSuprimer.ForeColor = Color.White;
            btnSuprimer.Location = new Point(158, 750);
            btnSuprimer.Margin = new Padding(5, 6, 5, 6);
            btnSuprimer.Name = "btnSuprimer";
            btnSuprimer.Size = new Size(408, 85);
            btnSuprimer.TabIndex = 44;
            btnSuprimer.Text = "Suprimer";
            btnSuprimer.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(234, 99, 93);
            flowLayoutPanel2.Controls.Add(pictureBox1);
            flowLayoutPanel2.Controls.Add(BtnHome);
            flowLayoutPanel2.Controls.Add(pictureBox5);
            flowLayoutPanel2.Location = new Point(0, 950);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(725, 104);
            flowLayoutPanel2.TabIndex = 43;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.GPS;
            pictureBox1.Location = new Point(114, 8);
            pictureBox1.Margin = new Padding(114, 0, 24, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // BtnHome
            // 
            BtnHome.Image = Properties.Resources.homepng;
            BtnHome.Location = new Point(300, 0);
            BtnHome.Margin = new Padding(89, 0, 57, 0);
            BtnHome.Name = "BtnHome";
            BtnHome.Size = new Size(128, 104);
            BtnHome.SizeMode = PictureBoxSizeMode.Zoom;
            BtnHome.TabIndex = 3;
            BtnHome.TabStop = false;
            BtnHome.Click += BtnHome_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.network;
            pictureBox5.Location = new Point(534, 5);
            pictureBox5.Margin = new Padding(49, 5, 24, 8);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(96, 93);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(234, 99, 93);
            flowLayoutPanel1.Controls.Add(pictureBox3);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(picIconeContact);
            flowLayoutPanel1.Controls.Add(pictureBox4);
            flowLayoutPanel1.Location = new Point(0, -2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(725, 152);
            flowLayoutPanel1.TabIndex = 42;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.logo1;
            pictureBox3.ImeMode = ImeMode.NoControl;
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(148, 149);
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
            label1.Location = new Point(214, 34);
            label1.Margin = new Padding(60, 0, 60, 0);
            label1.Name = "label1";
            label1.Size = new Size(297, 89);
            label1.TabIndex = 0;
            label1.Text = "TUBAPP";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // picIconeContact
            // 
            picIconeContact.Image = Properties.Resources.IconeProfilSelectionner;
            picIconeContact.Location = new Point(576, 6);
            picIconeContact.Margin = new Padding(5, 6, 5, 6);
            picIconeContact.Name = "picIconeContact";
            picIconeContact.Size = new Size(102, 146);
            picIconeContact.SizeMode = PictureBoxSizeMode.Zoom;
            picIconeContact.TabIndex = 2;
            picIconeContact.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icone_profil;
            pictureBox4.ImeMode = ImeMode.NoControl;
            pictureBox4.Location = new Point(0, 158);
            pictureBox4.Margin = new Padding(0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(151, 149);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
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
            pnlCard.Location = new Point(104, 259);
            pnlCard.Margin = new Padding(5, 6, 5, 6);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(0, 0);
            pnlCard.TabIndex = 39;
            // 
            // lblInvite
            // 
            lblInvite.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblInvite.ForeColor = Color.FromArgb(234, 99, 93);
            lblInvite.Location = new Point(81, 2);
            lblInvite.Margin = new Padding(5, 0, 5, 0);
            lblInvite.Name = "lblInvite";
            lblInvite.Size = new Size(361, 74);
            lblInvite.TabIndex = 0;
            lblInvite.Text = "ADMIN";
            lblInvite.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomPrenom
            // 
            lblNomPrenom.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNomPrenom.Location = new Point(81, 75);
            lblNomPrenom.Margin = new Padding(5, 0, 5, 0);
            lblNomPrenom.Name = "lblNomPrenom";
            lblNomPrenom.Size = new Size(361, 43);
            lblNomPrenom.TabIndex = 1;
            lblNomPrenom.Text = "NOM Prénom";
            lblNomPrenom.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // llbMail
            // 
            llbMail.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            llbMail.LinkColor = Color.Black;
            llbMail.Location = new Point(63, 139);
            llbMail.Margin = new Padding(5, 0, 5, 0);
            llbMail.Name = "llbMail";
            llbMail.Size = new Size(167, 43);
            llbMail.TabIndex = 2;
            llbMail.TabStop = true;
            llbMail.Text = "Adresse mail :";
            // 
            // lblMailValue
            // 
            lblMailValue.Font = new Font("Segoe UI", 9F);
            lblMailValue.Location = new Point(231, 139);
            lblMailValue.Margin = new Padding(5, 0, 5, 0);
            lblMailValue.Name = "lblMailValue";
            lblMailValue.Size = new Size(156, 43);
            lblMailValue.TabIndex = 3;
            lblMailValue.Text = "Invité";
            // 
            // llbNaissance
            // 
            llbNaissance.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            llbNaissance.LinkColor = Color.Black;
            llbNaissance.Location = new Point(63, 192);
            llbNaissance.Margin = new Padding(5, 0, 5, 0);
            llbNaissance.Name = "llbNaissance";
            llbNaissance.Size = new Size(242, 43);
            llbNaissance.TabIndex = 4;
            llbNaissance.TabStop = true;
            llbNaissance.Text = "Date de naissance :";
            // 
            // lblNaissanceValue
            // 
            lblNaissanceValue.Font = new Font("Segoe UI", 9F);
            lblNaissanceValue.Location = new Point(63, 235);
            lblNaissanceValue.Margin = new Padding(5, 0, 5, 0);
            lblNaissanceValue.Name = "lblNaissanceValue";
            lblNaissanceValue.Size = new Size(323, 43);
            lblNaissanceValue.TabIndex = 5;
            lblNaissanceValue.Text = "Jours/Mois/Années";
            // 
            // btnModifier
            // 
            btnModifier.BackColor = Color.LightGray;
            btnModifier.FlatStyle = FlatStyle.Flat;
            btnModifier.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModifier.Location = new Point(146, 314);
            btnModifier.Margin = new Padding(5, 6, 5, 6);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(223, 64);
            btnModifier.TabIndex = 6;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = false;
            // 
            // lblTitre
            // 
            lblTitre.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitre.Location = new Point(49, 154);
            lblTitre.Margin = new Padding(5, 0, 5, 0);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(640, 182);
            lblTitre.TabIndex = 38;
            lblTitre.Text = "Option Administrateur Suprimer";
            lblTitre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Ligne
            // 
            Ligne.Font = new Font("Segoe UI", 15F);
            Ligne.FormattingEnabled = true;
            Ligne.Location = new Point(197, 384);
            Ligne.Margin = new Padding(5);
            Ligne.Name = "Ligne";
            Ligne.Size = new Size(322, 62);
            Ligne.TabIndex = 46;
            Ligne.Text = "Ligne";
            // 
            // Station
            // 
            Station.Font = new Font("Segoe UI", 15F);
            Station.FormattingEnabled = true;
            Station.Location = new Point(197, 494);
            Station.Margin = new Padding(5);
            Station.Name = "Station";
            Station.Size = new Size(322, 62);
            Station.TabIndex = 47;
            Station.Text = "Station";
            // 
            // Horaire
            // 
            Horaire.Font = new Font("Segoe UI", 15F);
            Horaire.FormattingEnabled = true;
            Horaire.Location = new Point(197, 608);
            Horaire.Margin = new Padding(5);
            Horaire.Name = "Horaire";
            Horaire.Size = new Size(322, 62);
            Horaire.TabIndex = 48;
            Horaire.Text = "Horaire";
            // 
            // frmOptionAdminSuprimer
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 1054);
            Controls.Add(Horaire);
            Controls.Add(Station);
            Controls.Add(Ligne);
            Controls.Add(btnRetour);
            Controls.Add(btnSuprimer);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pnlCard);
            Controls.Add(lblTitre);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "frmOptionAdminSuprimer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Option admin suprimer";
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnlCard.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnRetour;
        private Button btnSuprimer;
        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox1;
        private PictureBox BtnHome;
        private PictureBox pictureBox5;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox picIconeContact;
        private PictureBox pictureBox4;
        private Panel pnlCard;
        private Label lblInvite;
        private Label lblNomPrenom;
        private LinkLabel llbMail;
        private Label lblMailValue;
        private LinkLabel llbNaissance;
        private Label lblNaissanceValue;
        private Button btnModifier;
        private Label lblTitre;
        private ComboBox Ligne;
        private ComboBox Station;
        private ComboBox Horaire;
    }
}