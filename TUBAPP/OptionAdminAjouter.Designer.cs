namespace TUBAPP
{
    partial class frmOptionAdminAjouter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptionAdminAjouter));
            flowLayoutPanel2 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            BtnHome = new PictureBox();
            pictureBox5 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            picIconeContact = new PictureBox();
            pictureBox4 = new PictureBox();
            btnAjoutStation = new Button();
            btnAjoutLigne = new Button();
            lblTitre = new Label();
            btnAjoutHoraire = new Button();
            btnRetour = new Button();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
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
            flowLayoutPanel2.TabIndex = 35;
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
            pictureBox1.Click += pictureBox1_Click;
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
            flowLayoutPanel1.TabIndex = 34;
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
            // btnAjoutStation
            // 
            btnAjoutStation.BackColor = Color.FromArgb(209, 66, 54);
            btnAjoutStation.FlatStyle = FlatStyle.Flat;
            btnAjoutStation.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAjoutStation.ForeColor = Color.White;
            btnAjoutStation.Location = new Point(64, 307);
            btnAjoutStation.Margin = new Padding(3, 4, 3, 4);
            btnAjoutStation.Name = "btnAjoutStation";
            btnAjoutStation.Size = new Size(313, 53);
            btnAjoutStation.TabIndex = 33;
            btnAjoutStation.Text = "Station";
            btnAjoutStation.UseVisualStyleBackColor = false;
            // 
            // btnAjoutLigne
            // 
            btnAjoutLigne.BackColor = Color.FromArgb(209, 66, 54);
            btnAjoutLigne.FlatStyle = FlatStyle.Flat;
            btnAjoutLigne.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAjoutLigne.ForeColor = Color.White;
            btnAjoutLigne.Location = new Point(64, 236);
            btnAjoutLigne.Margin = new Padding(3, 4, 3, 4);
            btnAjoutLigne.Name = "btnAjoutLigne";
            btnAjoutLigne.Size = new Size(313, 53);
            btnAjoutLigne.TabIndex = 32;
            btnAjoutLigne.Text = "Ligne";
            btnAjoutLigne.UseVisualStyleBackColor = false;
            // 
            // lblTitre
            // 
            lblTitre.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitre.Location = new Point(30, 98);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(394, 114);
            lblTitre.TabIndex = 39;
            lblTitre.Text = "Option Administrateur Ajouter\r\n";
            lblTitre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAjoutHoraire
            // 
            btnAjoutHoraire.BackColor = Color.FromArgb(209, 66, 54);
            btnAjoutHoraire.FlatStyle = FlatStyle.Flat;
            btnAjoutHoraire.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAjoutHoraire.ForeColor = Color.White;
            btnAjoutHoraire.Location = new Point(64, 380);
            btnAjoutHoraire.Margin = new Padding(3, 4, 3, 4);
            btnAjoutHoraire.Name = "btnAjoutHoraire";
            btnAjoutHoraire.Size = new Size(313, 53);
            btnAjoutHoraire.TabIndex = 40;
            btnAjoutHoraire.Text = "Horaire";
            btnAjoutHoraire.UseVisualStyleBackColor = false;
            // 
            // btnRetour
            // 
            btnRetour.BackColor = Color.FromArgb(209, 66, 54);
            btnRetour.FlatStyle = FlatStyle.Flat;
            btnRetour.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRetour.ForeColor = Color.White;
            btnRetour.Location = new Point(95, 501);
            btnRetour.Margin = new Padding(3, 4, 3, 4);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(257, 53);
            btnRetour.TabIndex = 41;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = false;
            btnRetour.Click += btnRetour_Click;
            // 
            // frmOptionAdminAjouter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 659);
            Controls.Add(btnRetour);
            Controls.Add(btnAjoutHoraire);
            Controls.Add(lblTitre);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnAjoutStation);
            Controls.Add(btnAjoutLigne);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmOptionAdminAjouter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Option admin ajouter";
            Load += OptionAdminAjouter_Load;
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
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
        private Button btnAjoutStation;
        private Button btnAjoutLigne;
        private Label lblTitre;
        private Button btnAjoutHoraire;
        private Button btnRetour;
    }
}