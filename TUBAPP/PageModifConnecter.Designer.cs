namespace TUBAPP
{
    partial class frmPageModifConnecter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPageModifConnecter));
            btnModifConfirmer = new Button();
            pnlCard = new Panel();
            txtPrenom = new TextBox();
            cmbLigneFav = new ComboBox();
            dtpNaissance = new DateTimePicker();
            llbPrenom = new LinkLabel();
            linkLabel2 = new LinkLabel();
            txtNom = new TextBox();
            txtEmail = new TextBox();
            linkLabel1 = new LinkLabel();
            lblInvite = new Label();
            llbMail = new LinkLabel();
            llbNaissance = new LinkLabel();
            btnAnnulModifier = new Button();
            lblTitre = new Label();
            label1 = new Label();
            picIconeContact = new PictureBox();
            pictureBox4 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            BtnHome = new PictureBox();
            pictureBox5 = new PictureBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnModifConfirmer
            // 
            btnModifConfirmer.BackColor = Color.FromArgb(209, 66, 54);
            btnModifConfirmer.FlatStyle = FlatStyle.Flat;
            btnModifConfirmer.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnModifConfirmer.ForeColor = Color.White;
            btnModifConfirmer.Location = new Point(64, 508);
            btnModifConfirmer.Margin = new Padding(3, 4, 3, 4);
            btnModifConfirmer.Name = "btnModifConfirmer";
            btnModifConfirmer.Size = new Size(313, 53);
            btnModifConfirmer.TabIndex = 32;
            btnModifConfirmer.Text = "Confirmer les modifications";
            btnModifConfirmer.UseVisualStyleBackColor = false;
            btnModifConfirmer.Click += btnModifier_Click;
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCard.Controls.Add(txtPrenom);
            pnlCard.Controls.Add(cmbLigneFav);
            pnlCard.Controls.Add(dtpNaissance);
            pnlCard.Controls.Add(llbPrenom);
            pnlCard.Controls.Add(linkLabel2);
            pnlCard.Controls.Add(txtNom);
            pnlCard.Controls.Add(txtEmail);
            pnlCard.Controls.Add(linkLabel1);
            pnlCard.Controls.Add(lblInvite);
            pnlCard.Controls.Add(llbMail);
            pnlCard.Controls.Add(llbNaissance);
            pnlCard.Controls.Add(btnAnnulModifier);
            pnlCard.Location = new Point(64, 163);
            pnlCard.Margin = new Padding(3, 4, 3, 4);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(313, 312);
            pnlCard.TabIndex = 31;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(103, 62);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(189, 27);
            txtPrenom.TabIndex = 11;
            // 
            // cmbLigneFav
            // 
            cmbLigneFav.FormattingEnabled = true;
            cmbLigneFav.Location = new Point(120, 203);
            cmbLigneFav.Name = "cmbLigneFav";
            cmbLigneFav.Size = new Size(172, 28);
            cmbLigneFav.TabIndex = 15;
            // 
            // dtpNaissance
            // 
            dtpNaissance.Location = new Point(141, 167);
            dtpNaissance.MaxDate = new DateTime(5000, 12, 31, 0, 0, 0, 0);
            dtpNaissance.MinDate = new DateTime(1800, 1, 1, 0, 0, 0, 0);
            dtpNaissance.Name = "dtpNaissance";
            dtpNaissance.Size = new Size(151, 27);
            dtpNaissance.TabIndex = 14;
            dtpNaissance.Value = new DateTime(2004, 1, 17, 0, 0, 0, 0);
            // 
            // llbPrenom
            // 
            llbPrenom.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            llbPrenom.LinkColor = Color.Black;
            llbPrenom.Location = new Point(5, 62);
            llbPrenom.Name = "llbPrenom";
            llbPrenom.Size = new Size(81, 27);
            llbPrenom.TabIndex = 13;
            llbPrenom.TabStop = true;
            llbPrenom.Text = "Prenom :";
            // 
            // linkLabel2
            // 
            linkLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(5, 95);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(81, 27);
            linkLabel2.TabIndex = 12;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Nom :";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(103, 95);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(189, 27);
            txtNom.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(114, 128);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(178, 27);
            txtEmail.TabIndex = 9;
            // 
            // linkLabel1
            // 
            linkLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(5, 203);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(112, 27);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Ligne Favorite :";
            // 
            // lblInvite
            // 
            lblInvite.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblInvite.ForeColor = Color.Fuchsia;
            lblInvite.Location = new Point(50, -5);
            lblInvite.Name = "lblInvite";
            lblInvite.Size = new Size(222, 46);
            lblInvite.TabIndex = 0;
            lblInvite.Text = "Modification";
            lblInvite.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // llbMail
            // 
            llbMail.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            llbMail.LinkColor = Color.Black;
            llbMail.Location = new Point(5, 131);
            llbMail.Name = "llbMail";
            llbMail.Size = new Size(103, 27);
            llbMail.TabIndex = 2;
            llbMail.TabStop = true;
            llbMail.Text = "Adresse mail :";
            // 
            // llbNaissance
            // 
            llbNaissance.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            llbNaissance.LinkColor = Color.Black;
            llbNaissance.Location = new Point(5, 167);
            llbNaissance.Name = "llbNaissance";
            llbNaissance.Size = new Size(149, 27);
            llbNaissance.TabIndex = 4;
            llbNaissance.TabStop = true;
            llbNaissance.Text = "Date de naissance :";
            // 
            // btnAnnulModifier
            // 
            btnAnnulModifier.BackColor = Color.LightGray;
            btnAnnulModifier.FlatStyle = FlatStyle.Flat;
            btnAnnulModifier.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAnnulModifier.Location = new Point(39, 257);
            btnAnnulModifier.Margin = new Padding(3, 4, 3, 4);
            btnAnnulModifier.Name = "btnAnnulModifier";
            btnAnnulModifier.Size = new Size(222, 40);
            btnAnnulModifier.TabIndex = 6;
            btnAnnulModifier.Text = "Annuler la modification";
            btnAnnulModifier.UseVisualStyleBackColor = false;
            btnAnnulModifier.Click += btnAnnulModifier_Click;
            // 
            // lblTitre
            // 
            lblTitre.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitre.Location = new Point(96, 106);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(245, 53);
            lblTitre.TabIndex = 30;
            lblTitre.Text = "Votre profil";
            lblTitre.TextAlign = ContentAlignment.MiddleCenter;
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
            // picIconeContact
            // 
            picIconeContact.Image = Properties.Resources.IconeProfilSelectionner;
            picIconeContact.Location = new Point(361, 4);
            picIconeContact.Margin = new Padding(3, 4, 3, 4);
            picIconeContact.Name = "picIconeContact";
            picIconeContact.Size = new Size(63, 91);
            picIconeContact.SizeMode = PictureBoxSizeMode.Zoom;
            picIconeContact.TabIndex = 2;
            picIconeContact.TabStop = false;
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
            flowLayoutPanel1.TabIndex = 33;
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
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.GPS;
            pictureBox1.Location = new Point(70, 5);
            pictureBox1.Margin = new Padding(70, 0, 15, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // BtnHome
            // 
            BtnHome.Image = Properties.Resources.homepng;
            BtnHome.Location = new Point(185, 0);
            BtnHome.Margin = new Padding(55, 0, 35, 0);
            BtnHome.Name = "BtnHome";
            BtnHome.Size = new Size(79, 65);
            BtnHome.SizeMode = PictureBoxSizeMode.Zoom;
            BtnHome.TabIndex = 3;
            BtnHome.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.network;
            pictureBox5.Location = new Point(329, 3);
            pictureBox5.Margin = new Padding(30, 3, 15, 5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(59, 58);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(234, 99, 93);
            flowLayoutPanel2.Controls.Add(pictureBox1);
            flowLayoutPanel2.Controls.Add(BtnHome);
            flowLayoutPanel2.Controls.Add(pictureBox5);
            flowLayoutPanel2.Location = new Point(0, 599);
            flowLayoutPanel2.Margin = new Padding(2);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(446, 65);
            flowLayoutPanel2.TabIndex = 34;
            // 
            // frmPageModifConnecter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 659);
            Controls.Add(btnModifConfirmer);
            Controls.Add(pnlCard);
            Controls.Add(lblTitre);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flowLayoutPanel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPageModifConnecter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Page modif connecter";
            Load += PageModifConnecter_Load;
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnModifConfirmer;
        private Panel pnlCard;
        private LinkLabel linkLabel1;
        private Label lblInvite;
        private LinkLabel llbMail;
        private LinkLabel llbNaissance;
        private Button btnAnnulModifier;
        private Label lblTitre;
        private Label label1;
        private PictureBox picIconeContact;
        private PictureBox pictureBox4;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox BtnHome;
        private PictureBox pictureBox5;
        private FlowLayoutPanel flowLayoutPanel2;
        private TextBox txtEmail;
        private TextBox txtNom;
        private TextBox txtPrenom;
        private LinkLabel llbPrenom;
        private LinkLabel linkLabel2;
        private DateTimePicker dtpNaissance;
        private ComboBox cmbLigneFav;
    }
}