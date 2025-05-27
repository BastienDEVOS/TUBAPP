namespace TUBAPP
{
    partial class frmSelectionLigne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectionLigne));
            flpNavbarre = new FlowLayoutPanel();
            pictureBox4 = new PictureBox();
            lblTUBAPP = new Label();
            pictureBox5 = new PictureBox();
            picIconeContact = new PictureBox();
            labelSelectionner = new Label();
            labeldepart = new Label();
            labelarrivee = new Label();
            cmb_StationArrivee = new ComboBox();
            cmb_StationDepart = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btn_retour = new Button();
            labelhoraire = new Label();
            cmb_Horaire1 = new ComboBox();
            cmb_Horaire2 = new ComboBox();
            p_InfosTrajet = new Panel();
            p_Station = new Panel();
            p_Horraire = new Panel();
            flpNavbarre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            p_InfosTrajet.SuspendLayout();
            p_Station.SuspendLayout();
            p_Horraire.SuspendLayout();
            SuspendLayout();
            // 
            // flpNavbarre
            // 
            flpNavbarre.BackColor = Color.FromArgb(234, 99, 93);
            flpNavbarre.Controls.Add(pictureBox4);
            flpNavbarre.Controls.Add(lblTUBAPP);
            flpNavbarre.Controls.Add(pictureBox5);
            flpNavbarre.Controls.Add(picIconeContact);
            flpNavbarre.Location = new Point(0, 0);
            flpNavbarre.Name = "flpNavbarre";
            flpNavbarre.Size = new Size(725, 155);
            flpNavbarre.TabIndex = 15;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.logo1;
            pictureBox4.ImeMode = ImeMode.NoControl;
            pictureBox4.Location = new Point(3, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(148, 149);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // lblTUBAPP
            // 
            lblTUBAPP.Anchor = AnchorStyles.None;
            lblTUBAPP.AutoSize = true;
            lblTUBAPP.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblTUBAPP.ForeColor = Color.White;
            lblTUBAPP.Location = new Point(214, 34);
            lblTUBAPP.Margin = new Padding(60, 0, 60, 0);
            lblTUBAPP.Name = "lblTUBAPP";
            lblTUBAPP.Size = new Size(297, 89);
            lblTUBAPP.TabIndex = 0;
            lblTUBAPP.Text = "TUBAPP";
            lblTUBAPP.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.icone_profil;
            pictureBox5.Location = new Point(576, 6);
            pictureBox5.Margin = new Padding(5, 6, 5, 6);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(102, 146);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 29;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // picIconeContact
            // 
            picIconeContact.Image = Properties.Resources.icone_profil;
            picIconeContact.Location = new Point(0, 158);
            picIconeContact.Margin = new Padding(0);
            picIconeContact.Name = "picIconeContact";
            picIconeContact.Size = new Size(151, 155);
            picIconeContact.SizeMode = PictureBoxSizeMode.Zoom;
            picIconeContact.TabIndex = 2;
            picIconeContact.TabStop = false;
            // 
            // labelSelectionner
            // 
            labelSelectionner.AutoSize = true;
            labelSelectionner.Font = new Font("Microsoft Sans Serif", 18F);
            labelSelectionner.ForeColor = SystemColors.MenuText;
            labelSelectionner.Location = new Point(80, 174);
            labelSelectionner.Margin = new Padding(5, 0, 5, 0);
            labelSelectionner.Name = "labelSelectionner";
            labelSelectionner.Size = new Size(565, 55);
            labelSelectionner.TabIndex = 16;
            labelSelectionner.Text = "Sélectionnez vos stations";
            labelSelectionner.Click += labelSelectionner_Click;
            // 
            // labeldepart
            // 
            labeldepart.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labeldepart.Location = new Point(5, 0);
            labeldepart.Margin = new Padding(5, 0, 5, 0);
            labeldepart.Name = "labeldepart";
            labeldepart.Size = new Size(263, 34);
            labeldepart.TabIndex = 22;
            labeldepart.Text = "Station de départ :";
            // 
            // labelarrivee
            // 
            labelarrivee.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelarrivee.Location = new Point(5, 88);
            labelarrivee.Margin = new Padding(5, 0, 5, 0);
            labelarrivee.Name = "labelarrivee";
            labelarrivee.Size = new Size(263, 35);
            labelarrivee.TabIndex = 21;
            labelarrivee.Text = "Station d'arrivée :";
            // 
            // cmb_StationArrivee
            // 
            cmb_StationArrivee.Anchor = AnchorStyles.Top;
            cmb_StationArrivee.BackColor = SystemColors.Menu;
            cmb_StationArrivee.FlatStyle = FlatStyle.Flat;
            cmb_StationArrivee.FormattingEnabled = true;
            cmb_StationArrivee.ItemHeight = 32;
            cmb_StationArrivee.Location = new Point(20, 128);
            cmb_StationArrivee.Margin = new Padding(5, 5, 5, 5);
            cmb_StationArrivee.Name = "cmb_StationArrivee";
            cmb_StationArrivee.Size = new Size(288, 40);
            cmb_StationArrivee.TabIndex = 20;
            // 
            // cmb_StationDepart
            // 
            cmb_StationDepart.BackColor = SystemColors.Menu;
            cmb_StationDepart.FlatStyle = FlatStyle.Flat;
            cmb_StationDepart.FormattingEnabled = true;
            cmb_StationDepart.Location = new Point(20, 38);
            cmb_StationDepart.Margin = new Padding(5, 5, 5, 5);
            cmb_StationDepart.Name = "cmb_StationDepart";
            cmb_StationDepart.Size = new Size(285, 40);
            cmb_StationDepart.TabIndex = 19;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(234, 99, 93);
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(pictureBox2);
            flowLayoutPanel1.Controls.Add(pictureBox3);
            flowLayoutPanel1.Location = new Point(-8, 952);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(748, 104);
            flowLayoutPanel1.TabIndex = 24;
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
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.homeSelectionnerpng;
            pictureBox2.Location = new Point(300, 0);
            pictureBox2.Margin = new Padding(89, 0, 57, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(128, 104);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.network;
            pictureBox3.Location = new Point(534, 5);
            pictureBox3.Margin = new Padding(49, 5, 24, 8);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(96, 93);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // btn_retour
            // 
            btn_retour.BackColor = Color.FromArgb(209, 66, 54);
            btn_retour.Font = new Font("Segoe UI", 15F);
            btn_retour.ForeColor = SystemColors.Control;
            btn_retour.ImeMode = ImeMode.NoControl;
            btn_retour.Location = new Point(91, 842);
            btn_retour.Name = "btn_retour";
            btn_retour.Size = new Size(522, 80);
            btn_retour.TabIndex = 25;
            btn_retour.Text = "Retour";
            btn_retour.UseVisualStyleBackColor = false;
            btn_retour.Click += btn_retour_Click;
            // 
            // labelhoraire
            // 
            labelhoraire.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelhoraire.Location = new Point(5, 0);
            labelhoraire.Margin = new Padding(5, 0, 5, 0);
            labelhoraire.Name = "labelhoraire";
            labelhoraire.Size = new Size(140, 34);
            labelhoraire.TabIndex = 26;
            labelhoraire.Text = "Horaire :";
            // 
            // cmb_Horaire1
            // 
            cmb_Horaire1.BackColor = SystemColors.Menu;
            cmb_Horaire1.FlatStyle = FlatStyle.Flat;
            cmb_Horaire1.FormattingEnabled = true;
            cmb_Horaire1.Location = new Point(13, 38);
            cmb_Horaire1.Margin = new Padding(5, 5, 5, 5);
            cmb_Horaire1.Name = "cmb_Horaire1";
            cmb_Horaire1.Size = new Size(196, 40);
            cmb_Horaire1.TabIndex = 27;
            // 
            // cmb_Horaire2
            // 
            cmb_Horaire2.BackColor = SystemColors.Menu;
            cmb_Horaire2.FlatStyle = FlatStyle.Flat;
            cmb_Horaire2.FormattingEnabled = true;
            cmb_Horaire2.Location = new Point(13, 128);
            cmb_Horaire2.Margin = new Padding(5, 5, 5, 5);
            cmb_Horaire2.Name = "cmb_Horaire2";
            cmb_Horaire2.Size = new Size(196, 40);
            cmb_Horaire2.TabIndex = 28;
            // 
            // p_InfosTrajet
            // 
            p_InfosTrajet.BackColor = Color.FromArgb(255, 128, 128);
            p_InfosTrajet.Controls.Add(p_Station);
            p_InfosTrajet.Controls.Add(p_Horraire);
            p_InfosTrajet.Location = new Point(57, 259);
            p_InfosTrajet.Margin = new Padding(5, 5, 5, 5);
            p_InfosTrajet.Name = "p_InfosTrajet";
            p_InfosTrajet.Size = new Size(603, 528);
            p_InfosTrajet.TabIndex = 29;
            p_InfosTrajet.Paint += panel1_Paint;
            // 
            // p_Station
            // 
            p_Station.BackColor = Color.White;
            p_Station.Controls.Add(labeldepart);
            p_Station.Controls.Add(cmb_StationDepart);
            p_Station.Controls.Add(cmb_StationArrivee);
            p_Station.Controls.Add(labelarrivee);
            p_Station.Location = new Point(5, 5);
            p_Station.Margin = new Padding(5, 5, 5, 5);
            p_Station.Name = "p_Station";
            p_Station.Size = new Size(328, 190);
            p_Station.TabIndex = 30;
            // 
            // p_Horraire
            // 
            p_Horraire.BackColor = Color.White;
            p_Horraire.Controls.Add(labelhoraire);
            p_Horraire.Controls.Add(cmb_Horaire2);
            p_Horraire.Controls.Add(cmb_Horaire1);
            p_Horraire.Location = new Point(366, 5);
            p_Horraire.Margin = new Padding(5, 5, 5, 5);
            p_Horraire.Name = "p_Horraire";
            p_Horraire.Size = new Size(229, 190);
            p_Horraire.TabIndex = 29;
            // 
            // frmSelectionLigne
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 1054);
            Controls.Add(btn_retour);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(labelSelectionner);
            Controls.Add(flpNavbarre);
            Controls.Add(p_InfosTrajet);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 5, 5, 5);
            Name = "frmSelectionLigne";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selection ligne";
            Load += SelectionLigne_Load;
            flpNavbarre.ResumeLayout(false);
            flpNavbarre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            p_InfosTrajet.ResumeLayout(false);
            p_Station.ResumeLayout(false);
            p_Horraire.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpNavbarre;
        private PictureBox pictureBox4;
        private Label lblTUBAPP;
        private PictureBox picIconeContact;
        private Label labelSelectionner;
        private Label labeldepart;
        private Label labelarrivee;
        private ComboBox cmb_StationArrivee;
        private ComboBox cmb_StationDepart;
        private ListBox listBoxStation;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btn_retour;
        private Label labelhoraire;
        private ComboBox cmb_Horaire1;
        private ComboBox cmb_Horaire2;
        private PictureBox pictureBox5;
        private Panel p_InfosTrajet;
        private Panel p_Horraire;
        private Panel p_Station;
    }
}