namespace TUBAPP
{
    partial class AdminAjoutStation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAjoutStation));
            txtNomStation = new TextBox();
            btnRetour = new Button();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            lblTitre = new Label();
            picIconeContact = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            BtnHome = new PictureBox();
            pictureBox5 = new PictureBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAjouter = new Button();
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            AccessibiliterNon = new CheckBox();
            AccessibiliterOui = new CheckBox();
            label3 = new Label();
            txtZoneStation = new TextBox();
            lbl_LignesDesservie = new Label();
            clbLigneDesservie = new CheckedListBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNomStation
            // 
            txtNomStation.Location = new Point(10, 12);
            txtNomStation.Name = "txtNomStation";
            txtNomStation.PlaceholderText = "Nom de la station";
            txtNomStation.Size = new Size(282, 27);
            txtNomStation.TabIndex = 59;
            txtNomStation.TextChanged += Verif;
            // 
            // btnRetour
            // 
            btnRetour.BackColor = Color.FromArgb(209, 66, 54);
            btnRetour.FlatStyle = FlatStyle.Flat;
            btnRetour.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRetour.ForeColor = Color.White;
            btnRetour.Location = new Point(95, 513);
            btnRetour.Margin = new Padding(3, 4, 3, 4);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(257, 53);
            btnRetour.TabIndex = 57;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = false;
            btnRetour.Click += btnRetour_Click;
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
            // lblTitre
            // 
            lblTitre.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblTitre.Location = new Point(3, 66);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(325, 132);
            lblTitre.TabIndex = 31;
            lblTitre.Text = "Option Administrateur";
            lblTitre.TextAlign = ContentAlignment.MiddleCenter;
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
            flowLayoutPanel2.Controls.Add(lblTitre);
            flowLayoutPanel2.Location = new Point(0, 594);
            flowLayoutPanel2.Margin = new Padding(2);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(446, 65);
            flowLayoutPanel2.TabIndex = 56;
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
            flowLayoutPanel1.TabIndex = 55;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.FromArgb(209, 66, 54);
            btnAjouter.Enabled = false;
            btnAjouter.FlatStyle = FlatStyle.Flat;
            btnAjouter.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAjouter.ForeColor = Color.White;
            btnAjouter.Location = new Point(74, 452);
            btnAjouter.Margin = new Padding(3, 4, 3, 4);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(299, 53);
            btnAjouter.TabIndex = 60;
            btnAjouter.Text = "Ajouter la Station";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(AccessibiliterNon);
            panel1.Controls.Add(AccessibiliterOui);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtZoneStation);
            panel1.Controls.Add(lbl_LignesDesservie);
            panel1.Controls.Add(clbLigneDesservie);
            panel1.Controls.Add(txtNomStation);
            panel1.Location = new Point(66, 171);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 265);
            panel1.TabIndex = 63;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(229, 105);
            label9.Name = "label9";
            label9.Size = new Size(37, 20);
            label9.TabIndex = 69;
            label9.Text = "Non";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(157, 105);
            label8.Name = "label8";
            label8.Size = new Size(32, 20);
            label8.TabIndex = 68;
            label8.Text = "Oui";
            // 
            // AccessibiliterNon
            // 
            AccessibiliterNon.AutoSize = true;
            AccessibiliterNon.Location = new Point(272, 108);
            AccessibiliterNon.Name = "AccessibiliterNon";
            AccessibiliterNon.Size = new Size(18, 17);
            AccessibiliterNon.TabIndex = 67;
            AccessibiliterNon.UseVisualStyleBackColor = true;
            AccessibiliterNon.CheckedChanged += Verif;
            // 
            // AccessibiliterOui
            // 
            AccessibiliterOui.AutoSize = true;
            AccessibiliterOui.Location = new Point(195, 108);
            AccessibiliterOui.Name = "AccessibiliterOui";
            AccessibiliterOui.Size = new Size(18, 17);
            AccessibiliterOui.TabIndex = 66;
            AccessibiliterOui.TextAlign = ContentAlignment.MiddleRight;
            AccessibiliterOui.UseVisualStyleBackColor = true;
            AccessibiliterOui.CheckedChanged += Verif;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 105);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 65;
            label3.Text = "Accès PMR :";
            // 
            // txtZoneStation
            // 
            txtZoneStation.Location = new Point(13, 55);
            txtZoneStation.Name = "txtZoneStation";
            txtZoneStation.PlaceholderText = "Zone de facturation de la station";
            txtZoneStation.Size = new Size(277, 27);
            txtZoneStation.TabIndex = 64;
            txtZoneStation.TextChanged += Verif;
            // 
            // lbl_LignesDesservie
            // 
            lbl_LignesDesservie.AutoSize = true;
            lbl_LignesDesservie.Location = new Point(3, 143);
            lbl_LignesDesservie.Name = "lbl_LignesDesservie";
            lbl_LignesDesservie.Size = new Size(151, 20);
            lbl_LignesDesservie.TabIndex = 63;
            lbl_LignesDesservie.Text = "Ligne(s) Desservie(s) :";
            // 
            // clbLigneDesservie
            // 
            clbLigneDesservie.FormattingEnabled = true;
            clbLigneDesservie.Location = new Point(160, 143);
            clbLigneDesservie.Name = "clbLigneDesservie";
            clbLigneDesservie.Size = new Size(147, 114);
            clbLigneDesservie.TabIndex = 62;
            clbLigneDesservie.SelectedIndexChanged += Verif;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.Location = new Point(26, 77);
            label2.Name = "label2";
            label2.Size = new Size(394, 114);
            label2.TabIndex = 64;
            label2.Text = "Ajouter une Station";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AdminAjoutStation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 659);
            Controls.Add(btnAjouter);
            Controls.Add(btnRetour);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminAjoutStation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminAjoutStation";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtNomStation;
        private Button btnRetour;
        private PictureBox pictureBox3;
        private Label label1;
        private Label lblTitre;
        private PictureBox picIconeContact;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private PictureBox BtnHome;
        private PictureBox pictureBox5;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnAjouter;
        private Panel panel1;
        private Label lbl_LignesDesservie;
        private CheckedListBox clbLigneDesservie;
        private TextBox txtZoneStation;
        private Label label2;
        private Label label9;
        private Label label8;
        private CheckBox AccessibiliterNon;
        private CheckBox AccessibiliterOui;
        private Label label3;
    }
}