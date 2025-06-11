namespace TUBAPP
{
    partial class frmMenuPricipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPricipal));
            InfoImportantes = new FlowLayoutPanel();
            label3 = new Label();
            btnVoirItineraire = new Button();
            label2 = new Label();
            label1 = new Label();
            cmbStationArrivee = new ComboBox();
            cmbStationDepart = new ComboBox();
            flpNavbarre = new FlowLayoutPanel();
            pictureBox4 = new PictureBox();
            lblTUBAPP = new Label();
            pictureBox5 = new PictureBox();
            picIconeContact = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            flpNavbarre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // InfoImportantes
            // 
            InfoImportantes.AutoScroll = true;
            InfoImportantes.BackColor = Color.White;
            InfoImportantes.FlowDirection = FlowDirection.TopDown;
            InfoImportantes.Location = new Point(58, 382);
            InfoImportantes.Name = "InfoImportantes";
            InfoImportantes.Size = new Size(319, 183);
            InfoImportantes.TabIndex = 21;
            InfoImportantes.WrapContents = false;
            InfoImportantes.Paint += InfoImportantes_Paint;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label3.Location = new Point(36, 335);
            label3.Name = "label3";
            label3.Size = new Size(376, 44);
            label3.TabIndex = 20;
            label3.Text = "Informations importantes";
            // 
            // btnVoirItineraire
            // 
            btnVoirItineraire.BackColor = SystemColors.ControlLight;
            btnVoirItineraire.Enabled = false;
            btnVoirItineraire.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnVoirItineraire.ForeColor = SystemColors.ControlText;
            btnVoirItineraire.Location = new Point(109, 268);
            btnVoirItineraire.Name = "btnVoirItineraire";
            btnVoirItineraire.Size = new Size(228, 38);
            btnVoirItineraire.TabIndex = 19;
            btnVoirItineraire.Text = "Voir les itinéraires";
            btnVoirItineraire.UseVisualStyleBackColor = false;
            btnVoirItineraire.Click += VoirItineraire_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.Location = new Point(96, 123);
            label2.Name = "label2";
            label2.Size = new Size(251, 31);
            label2.TabIndex = 18;
            label2.Text = "Station de départ :";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(96, 199);
            label1.Name = "label1";
            label1.Size = new Size(225, 31);
            label1.TabIndex = 17;
            label1.Text = "Station d'arrivée :";
            // 
            // cmbStationArrivee
            // 
            cmbStationArrivee.Anchor = AnchorStyles.Top;
            cmbStationArrivee.DropDownHeight = 200;
            cmbStationArrivee.FormattingEnabled = true;
            cmbStationArrivee.IntegralHeight = false;
            cmbStationArrivee.ItemHeight = 20;
            cmbStationArrivee.Location = new Point(96, 234);
            cmbStationArrivee.MaxDropDownItems = 100;
            cmbStationArrivee.Name = "cmbStationArrivee";
            cmbStationArrivee.Size = new Size(251, 28);
            cmbStationArrivee.TabIndex = 16;
            cmbStationArrivee.SelectedIndexChanged += MettreAJourBoutonItineraire;
            // 
            // cmbStationDepart
            // 
            cmbStationDepart.DropDownHeight = 200;
            cmbStationDepart.FormattingEnabled = true;
            cmbStationDepart.IntegralHeight = false;
            cmbStationDepart.Location = new Point(96, 157);
            cmbStationDepart.MaxDropDownItems = 100;
            cmbStationDepart.Name = "cmbStationDepart";
            cmbStationDepart.Size = new Size(251, 28);
            cmbStationDepart.TabIndex = 15;
            cmbStationDepart.SelectedIndexChanged += MettreAJourBoutonItineraire;
            // 
            // flpNavbarre
            // 
            flpNavbarre.BackColor = Color.FromArgb(234, 99, 93);
            flpNavbarre.Controls.Add(pictureBox4);
            flpNavbarre.Controls.Add(lblTUBAPP);
            flpNavbarre.Controls.Add(pictureBox5);
            flpNavbarre.Controls.Add(picIconeContact);
            flpNavbarre.Location = new Point(0, 0);
            flpNavbarre.Margin = new Padding(2);
            flpNavbarre.Name = "flpNavbarre";
            flpNavbarre.Size = new Size(446, 97);
            flpNavbarre.TabIndex = 14;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.logo1;
            pictureBox4.ImeMode = ImeMode.NoControl;
            pictureBox4.Location = new Point(2, 2);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(91, 93);
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
            lblTUBAPP.Location = new Point(132, 21);
            lblTUBAPP.Margin = new Padding(37, 0, 37, 0);
            lblTUBAPP.Name = "lblTUBAPP";
            lblTUBAPP.Size = new Size(189, 57);
            lblTUBAPP.TabIndex = 0;
            lblTUBAPP.Text = "TUBAPP";
            lblTUBAPP.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.icone_profil;
            pictureBox5.Location = new Point(361, 4);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(63, 91);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 30;
            pictureBox5.TabStop = false;
            pictureBox5.Click += picIconeContact_Click;
            // 
            // picIconeContact
            // 
            picIconeContact.Image = Properties.Resources.icone_profil;
            picIconeContact.Location = new Point(0, 99);
            picIconeContact.Margin = new Padding(0);
            picIconeContact.Name = "picIconeContact";
            picIconeContact.Size = new Size(93, 97);
            picIconeContact.SizeMode = PictureBoxSizeMode.Zoom;
            picIconeContact.TabIndex = 2;
            picIconeContact.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(234, 99, 93);
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(pictureBox2);
            flowLayoutPanel1.Controls.Add(pictureBox3);
            flowLayoutPanel1.Location = new Point(0, 594);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(446, 65);
            flowLayoutPanel1.TabIndex = 22;
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
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.homeSelectionnerpng;
            pictureBox2.Location = new Point(185, 0);
            pictureBox2.Margin = new Padding(55, 0, 35, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(79, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.network;
            pictureBox3.Location = new Point(329, 3);
            pictureBox3.Margin = new Padding(30, 3, 15, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(59, 58);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // frmMenuPricipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 659);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(InfoImportantes);
            Controls.Add(label3);
            Controls.Add(btnVoirItineraire);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbStationArrivee);
            Controls.Add(cmbStationDepart);
            Controls.Add(flpNavbarre);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMenuPricipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMenuPricipal";
            Load += frmMenuPricipal_Load;
            flpNavbarre.ResumeLayout(false);
            flpNavbarre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel InfoImportantes;
        private Label label3;
        private Button btnVoirItineraire;
        private Label label2;
        private Label label1;
        private ComboBox cmbStationArrivee;
        private ComboBox cmbStationDepart;
        private FlowLayoutPanel flpNavbarre;
        private Label lblTUBAPP;
        private PictureBox picIconeContact;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}