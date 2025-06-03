namespace TUBAPP
{
    partial class AdminAjoutTrajet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAjoutTrajet));
            btnRetour = new Button();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            lblTitre = new Label();
            picIconeContact = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            BtnHome = new PictureBox();
            pictureBox5 = new PictureBox();
            btnAjouter = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dtpTempsTrajet = new DateTimePicker();
            cmbLigne = new ComboBox();
            lblArrivé = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cmbStationDepart = new ComboBox();
            cmbStationArriver = new ComboBox();
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
            // btnRetour
            // 
            btnRetour.BackColor = Color.FromArgb(209, 66, 54);
            btnRetour.FlatStyle = FlatStyle.Flat;
            btnRetour.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRetour.ForeColor = Color.White;
            btnRetour.Location = new Point(95, 523);
            btnRetour.Margin = new Padding(3, 4, 3, 4);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(257, 53);
            btnRetour.TabIndex = 65;
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
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.FromArgb(209, 66, 54);
            btnAjouter.Enabled = false;
            btnAjouter.FlatStyle = FlatStyle.Flat;
            btnAjouter.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAjouter.ForeColor = Color.White;
            btnAjouter.Location = new Point(83, 451);
            btnAjouter.Margin = new Padding(3, 4, 3, 4);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(281, 53);
            btnAjouter.TabIndex = 68;
            btnAjouter.Text = "Ajouter la Station";
            btnAjouter.UseVisualStyleBackColor = false;
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
            flowLayoutPanel2.TabIndex = 64;
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
            flowLayoutPanel1.TabIndex = 63;
            // 
            // dtpTempsTrajet
            // 
            dtpTempsTrajet.CustomFormat = "HH:mm";
            dtpTempsTrajet.Format = DateTimePickerFormat.Custom;
            dtpTempsTrajet.Location = new Point(131, 222);
            dtpTempsTrajet.MaxDate = new DateTime(3000, 12, 31, 0, 0, 0, 0);
            dtpTempsTrajet.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            dtpTempsTrajet.Name = "dtpTempsTrajet";
            dtpTempsTrajet.ShowUpDown = true;
            dtpTempsTrajet.Size = new Size(163, 27);
            dtpTempsTrajet.TabIndex = 70;
            dtpTempsTrajet.Value = new DateTime(2025, 5, 31, 17, 5, 0, 0);
            // 
            // cmbLigne
            // 
            cmbLigne.FormattingEnabled = true;
            cmbLigne.Location = new Point(13, 44);
            cmbLigne.Name = "cmbLigne";
            cmbLigne.Size = new Size(281, 28);
            cmbLigne.TabIndex = 71;
            cmbLigne.Text = "Choix de la ligne";
            cmbLigne.SelectedIndexChanged += cmbLigne_SelectedIndexChanged;
            // 
            // lblArrivé
            // 
            lblArrivé.AutoSize = true;
            lblArrivé.Location = new Point(13, 222);
            lblArrivé.Name = "lblArrivé";
            lblArrivé.Size = new Size(112, 20);
            lblArrivé.TabIndex = 73;
            lblArrivé.Text = "Temps de trajet";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cmbStationDepart);
            panel1.Controls.Add(cmbStationArriver);
            panel1.Controls.Add(dtpTempsTrajet);
            panel1.Controls.Add(lblArrivé);
            panel1.Controls.Add(cmbLigne);
            panel1.Location = new Point(70, 164);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 266);
            panel1.TabIndex = 74;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 21);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 78;
            label5.Text = "Ligne concernée";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 87);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 77;
            label4.Text = "Station de départ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 149);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 76;
            label3.Text = "Station d'arriver";
            // 
            // cmbStationDepart
            // 
            cmbStationDepart.FormattingEnabled = true;
            cmbStationDepart.Location = new Point(13, 110);
            cmbStationDepart.Name = "cmbStationDepart";
            cmbStationDepart.Size = new Size(281, 28);
            cmbStationDepart.TabIndex = 75;
            cmbStationDepart.Text = "Choix de la Station de départ";
            // 
            // cmbStationArriver
            // 
            cmbStationArriver.FormattingEnabled = true;
            cmbStationArriver.Location = new Point(13, 172);
            cmbStationArriver.Name = "cmbStationArriver";
            cmbStationArriver.Size = new Size(281, 28);
            cmbStationArriver.TabIndex = 74;
            cmbStationArriver.Text = "Choix de la station d'arriver";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.Location = new Point(26, 68);
            label2.Name = "label2";
            label2.Size = new Size(394, 114);
            label2.TabIndex = 75;
            label2.Text = "Ajouter un Trajet";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AdminAjoutTrajet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 659);
            Controls.Add(btnRetour);
            Controls.Add(btnAjouter);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(66, 265);
            Name = "AdminAjoutTrajet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminAjoutHoraire";
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
        private Button btnRetour;
        private PictureBox pictureBox3;
        private Label label1;
        private Label lblTitre;
        private PictureBox picIconeContact;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private PictureBox BtnHome;
        private PictureBox pictureBox5;
        private Button btnAjouter;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private DateTimePicker dtpTempsTrajet;
        private ComboBox cmbLigne;
        private Label lblArrivé;
        private Panel panel1;
        private ComboBox cmbStationDepart;
        private ComboBox cmbStationArriver;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}