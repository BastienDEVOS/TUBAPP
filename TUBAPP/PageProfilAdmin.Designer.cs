namespace TUBAPP
{
    partial class PageProfilAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageProfilAdmin));
            flowLayoutPanel2 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            BtnHome = new PictureBox();
            pictureBox5 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            picIconeContact = new PictureBox();
            pictureBox4 = new PictureBox();
            btnSeConnecter = new Button();
            btnCreerCompte = new Button();
            pnlCard = new Panel();
            lblInvite = new Label();
            lblNomPrenom = new Label();
            llbMail = new LinkLabel();
            lblMailValue = new Label();
            llbNaissance = new LinkLabel();
            lblNaissanceValue = new Label();
            btnModifier = new Button();
            lblTitre = new Label();
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
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(234, 99, 93);
            flowLayoutPanel2.Controls.Add(pictureBox1);
            flowLayoutPanel2.Controls.Add(BtnHome);
            flowLayoutPanel2.Controls.Add(pictureBox5);
            flowLayoutPanel2.Location = new Point(0, 742);
            flowLayoutPanel2.Margin = new Padding(2);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(558, 81);
            flowLayoutPanel2.TabIndex = 29;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.GPS;
            pictureBox1.Location = new Point(88, 6);
            pictureBox1.Margin = new Padding(88, 0, 19, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // BtnHome
            // 
            BtnHome.Image = Properties.Resources.homepng;
            BtnHome.Location = new Point(232, 0);
            BtnHome.Margin = new Padding(69, 0, 44, 0);
            BtnHome.Name = "BtnHome";
            BtnHome.Size = new Size(99, 81);
            BtnHome.SizeMode = PictureBoxSizeMode.Zoom;
            BtnHome.TabIndex = 3;
            BtnHome.TabStop = false;
            BtnHome.Click += pictureBox2_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.network;
            pictureBox5.Location = new Point(413, 4);
            pictureBox5.Margin = new Padding(38, 4, 19, 6);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(74, 72);
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
            flowLayoutPanel1.Location = new Point(0, -1);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(558, 119);
            flowLayoutPanel1.TabIndex = 28;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.logo1;
            pictureBox3.ImeMode = ImeMode.NoControl;
            pictureBox3.Location = new Point(2, 2);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(114, 116);
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
            label1.Location = new Point(164, 28);
            label1.Margin = new Padding(46, 0, 46, 0);
            label1.Name = "label1";
            label1.Size = new Size(223, 67);
            label1.TabIndex = 0;
            label1.Text = "TUBAPP";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // picIconeContact
            // 
            picIconeContact.Image = Properties.Resources.IconeProfilSelectionner;
            picIconeContact.Location = new Point(437, 5);
            picIconeContact.Margin = new Padding(4, 5, 4, 5);
            picIconeContact.Name = "picIconeContact";
            picIconeContact.Size = new Size(79, 114);
            picIconeContact.SizeMode = PictureBoxSizeMode.Zoom;
            picIconeContact.TabIndex = 2;
            picIconeContact.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icone_profil;
            pictureBox4.ImeMode = ImeMode.NoControl;
            pictureBox4.Location = new Point(0, 124);
            pictureBox4.Margin = new Padding(0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(116, 116);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // btnSeConnecter
            // 
            btnSeConnecter.BackColor = Color.FromArgb(209, 66, 54);
            btnSeConnecter.FlatStyle = FlatStyle.Flat;
            btnSeConnecter.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSeConnecter.ForeColor = Color.White;
            btnSeConnecter.Location = new Point(80, 655);
            btnSeConnecter.Margin = new Padding(4, 5, 4, 5);
            btnSeConnecter.Name = "btnSeConnecter";
            btnSeConnecter.Size = new Size(391, 66);
            btnSeConnecter.TabIndex = 27;
            btnSeConnecter.Text = "Se déconnecter";
            btnSeConnecter.UseVisualStyleBackColor = false;
            btnSeConnecter.Click += btnDeconnecter_Click;
            // 
            // btnCreerCompte
            // 
            btnCreerCompte.BackColor = Color.FromArgb(209, 66, 54);
            btnCreerCompte.FlatStyle = FlatStyle.Flat;
            btnCreerCompte.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCreerCompte.ForeColor = Color.White;
            btnCreerCompte.Location = new Point(80, 566);
            btnCreerCompte.Margin = new Padding(4, 5, 4, 5);
            btnCreerCompte.Name = "btnCreerCompte";
            btnCreerCompte.Size = new Size(391, 66);
            btnCreerCompte.TabIndex = 26;
            btnCreerCompte.Text = "Option Admin";
            btnCreerCompte.UseVisualStyleBackColor = false;
            btnCreerCompte.Click += btnCreerCompte_Click;
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
            pnlCard.Location = new Point(80, 202);
            pnlCard.Margin = new Padding(4, 5, 4, 5);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(391, 332);
            pnlCard.TabIndex = 25;
            // 
            // lblInvite
            // 
            lblInvite.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblInvite.ForeColor = Color.FromArgb(234, 99, 93);
            lblInvite.Location = new Point(62, 1);
            lblInvite.Margin = new Padding(4, 0, 4, 0);
            lblInvite.Name = "lblInvite";
            lblInvite.Size = new Size(278, 58);
            lblInvite.TabIndex = 0;
            lblInvite.Text = "ADMIN";
            lblInvite.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomPrenom
            // 
            lblNomPrenom.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNomPrenom.Location = new Point(62, 59);
            lblNomPrenom.Margin = new Padding(4, 0, 4, 0);
            lblNomPrenom.Name = "lblNomPrenom";
            lblNomPrenom.Size = new Size(278, 34);
            lblNomPrenom.TabIndex = 1;
            lblNomPrenom.Text = "NOM Prénom";
            lblNomPrenom.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // llbMail
            // 
            llbMail.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            llbMail.LinkColor = Color.Black;
            llbMail.Location = new Point(49, 109);
            llbMail.Margin = new Padding(4, 0, 4, 0);
            llbMail.Name = "llbMail";
            llbMail.Size = new Size(129, 34);
            llbMail.TabIndex = 2;
            llbMail.TabStop = true;
            llbMail.Text = "Adresse mail :";
            // 
            // lblMailValue
            // 
            lblMailValue.AutoSize = true;
            lblMailValue.Location = new Point(180, 109); // Adjust X as needed to align with "Adresse mail :"
            lblMailValue.Name = "lblMailValue";
            lblMailValue.Size = new Size(0, 13);
            // 
            // llbNaissance
            // 
            llbNaissance.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            llbNaissance.LinkColor = Color.Black;
            llbNaissance.Location = new Point(49, 150);
            llbNaissance.Margin = new Padding(4, 0, 4, 0);
            llbNaissance.Name = "llbNaissance";
            llbNaissance.Size = new Size(186, 34);
            llbNaissance.TabIndex = 4;
            llbNaissance.TabStop = true;
            llbNaissance.Text = "Date de naissance :";
            // 
            // lblNaissanceValue
            // 
            lblNaissanceValue.AutoSize = true;
            lblNaissanceValue.Location = new Point(235, 150); // Adjust X as needed to align with "Date de naissance :"
            lblNaissanceValue.Name = "lblNaissanceValue";
            lblNaissanceValue.Size = new Size(0, 13);
            // 
            // btnModifier
            // 
            btnModifier.BackColor = Color.LightGray;
            btnModifier.FlatStyle = FlatStyle.Flat;
            btnModifier.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModifier.Location = new Point(112, 245);
            btnModifier.Margin = new Padding(4, 5, 4, 5);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(171, 50);
            btnModifier.TabIndex = 6;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = false;
            // 
            // lblTitre
            // 
            lblTitre.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitre.Location = new Point(120, 131);
            lblTitre.Margin = new Padding(4, 0, 4, 0);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(306, 66);
            lblTitre.TabIndex = 24;
            lblTitre.Text = "Votre profil";
            lblTitre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PageProfilAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 824);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnSeConnecter);
            Controls.Add(btnCreerCompte);
            Controls.Add(pnlCard);
            Controls.Add(lblTitre);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "PageProfilAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PageProfilAdmin";
            Load += PageProfilAdmin_Load;
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

        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox1;
        private PictureBox BtnHome;
        private PictureBox pictureBox5;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox picIconeContact;
        private PictureBox pictureBox4;
        private Button btnSeConnecter;
        private Button btnCreerCompte;
        private Panel pnlCard;
        private Label lblInvite;
        private Label lblNomPrenom;
        private LinkLabel llbMail;
        private Label lblMailValue;
        private LinkLabel llbNaissance;
        private Label lblNaissanceValue;
        private Button btnModifier;
        private Label lblTitre;
    }
}