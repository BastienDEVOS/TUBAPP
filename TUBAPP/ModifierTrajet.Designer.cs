namespace TUBAPP
{
    partial class ModifierTrajet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierTrajet));
            btnRetour = new Button();
            btnModif = new Button();
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
            panel1 = new Panel();
            txtTpsTrajet = new TextBox();
            label4 = new Label();
            cbLigne = new ComboBox();
            cbStationDepart = new ComboBox();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            cbStationArrivee = new ComboBox();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnlCard.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRetour
            // 
            btnRetour.BackColor = Color.FromArgb(209, 66, 54);
            btnRetour.FlatStyle = FlatStyle.Flat;
            btnRetour.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRetour.ForeColor = Color.White;
            btnRetour.Location = new Point(115, 530);
            btnRetour.Margin = new Padding(3, 4, 3, 4);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(217, 46);
            btnRetour.TabIndex = 63;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = false;
            btnRetour.Click += btnRetour_Click;
            // 
            // btnModif
            // 
            btnModif.BackColor = Color.FromArgb(209, 66, 54);
            btnModif.Enabled = false;
            btnModif.FlatStyle = FlatStyle.Flat;
            btnModif.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnModif.ForeColor = Color.White;
            btnModif.Location = new Point(95, 469);
            btnModif.Margin = new Padding(3, 4, 3, 4);
            btnModif.Name = "btnModif";
            btnModif.Size = new Size(251, 53);
            btnModif.TabIndex = 62;
            btnModif.Text = "Modifier";
            btnModif.UseVisualStyleBackColor = false;
            btnModif.Click += btnModif_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(234, 99, 93);
            flowLayoutPanel2.Controls.Add(pictureBox1);
            flowLayoutPanel2.Controls.Add(BtnHome);
            flowLayoutPanel2.Controls.Add(pictureBox5);
            flowLayoutPanel2.Location = new Point(0, 594);
            flowLayoutPanel2.Margin = new Padding(2);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(446, 65);
            flowLayoutPanel2.TabIndex = 61;
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
            flowLayoutPanel1.Size = new Size(446, 95);
            flowLayoutPanel1.TabIndex = 60;
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
            pnlCard.Location = new Point(64, 162);
            pnlCard.Margin = new Padding(3, 4, 3, 4);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(0, 0);
            pnlCard.TabIndex = 59;
            // 
            // lblInvite
            // 
            lblInvite.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblInvite.ForeColor = Color.FromArgb(234, 99, 93);
            lblInvite.Location = new Point(50, 1);
            lblInvite.Name = "lblInvite";
            lblInvite.Size = new Size(222, 46);
            lblInvite.TabIndex = 0;
            lblInvite.Text = "ADMIN";
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
            // lblTitre
            // 
            lblTitre.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitre.Location = new Point(26, 83);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(394, 114);
            lblTitre.TabIndex = 58;
            lblTitre.Text = "Modifier Trajet";
            lblTitre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtTpsTrajet);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cbLigne);
            panel1.Controls.Add(cbStationDepart);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cbStationArrivee);
            panel1.Location = new Point(67, 181);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 229);
            panel1.TabIndex = 65;
            // 
            // txtTpsTrajet
            // 
            txtTpsTrajet.Location = new Point(138, 165);
            txtTpsTrajet.Name = "txtTpsTrajet";
            txtTpsTrajet.Size = new Size(156, 27);
            txtTpsTrajet.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 168);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 24;
            label4.Text = "Temps de trajet";
            // 
            // cbLigne
            // 
            cbLigne.FormattingEnabled = true;
            cbLigne.Location = new Point(139, 18);
            cbLigne.Name = "cbLigne";
            cbLigne.Size = new Size(156, 28);
            cbLigne.TabIndex = 23;
            // 
            // cbStationDepart
            // 
            cbStationDepart.FormattingEnabled = true;
            cbStationDepart.Location = new Point(138, 65);
            cbStationDepart.Name = "cbStationDepart";
            cbStationDepart.Size = new Size(156, 28);
            cbStationDepart.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 118);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 21;
            label6.Text = "Station arrivée";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 68);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 18;
            label3.Text = "Station départ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 21);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 17;
            label2.Text = "Ligne concernée";
            // 
            // cbStationArrivee
            // 
            cbStationArrivee.FormattingEnabled = true;
            cbStationArrivee.Location = new Point(139, 118);
            cbStationArrivee.Name = "cbStationArrivee";
            cbStationArrivee.Size = new Size(156, 28);
            cbStationArrivee.TabIndex = 15;
            // 
            // ModifierTrajet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 659);
            Controls.Add(panel1);
            Controls.Add(btnRetour);
            Controls.Add(btnModif);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pnlCard);
            Controls.Add(lblTitre);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ModifierTrajet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModifierTrajet";
            Load += ModifierHorraire_Load;
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnRetour;
        private Button btnModif;
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
        private Panel panel1;
        private Label label6;
        private Label label3;
        private Label label2;
        private ComboBox cbStationArrivee;
        private TextBox txtTpsTrajet;
        private Label label4;
        private ComboBox cbLigne;
        private ComboBox cbStationDepart;
    }
}