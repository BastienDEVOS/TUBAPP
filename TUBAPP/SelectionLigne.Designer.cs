namespace TUBAPP
{
    partial class SelectionLigne
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
            flpNavbarre = new FlowLayoutPanel();
            pictureBox4 = new PictureBox();
            lblTUBAPP = new Label();
            picIconeContact = new PictureBox();
            labelSelectionner = new Label();
            labeldepart = new Label();
            labelarrivee = new Label();
            StationArrivee = new ComboBox();
            StationDepart = new ComboBox();
            listBoxStation = new ListBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btn_retour = new Button();
            labelhoraire = new Label();
            comboBoxHoraire1 = new ComboBox();
            comboBoxHoraire2 = new ComboBox();
            pictureBox5 = new PictureBox();
            flpNavbarre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
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
            flpNavbarre.Margin = new Padding(2);
            flpNavbarre.Name = "flpNavbarre";
            flpNavbarre.Size = new Size(446, 97);
            flpNavbarre.TabIndex = 15;
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
            // labelSelectionner
            // 
            labelSelectionner.AutoSize = true;
            labelSelectionner.Font = new Font("Rockwell Nova", 18F);
            labelSelectionner.ForeColor = SystemColors.MenuText;
            labelSelectionner.Location = new Point(30, 121);
            labelSelectionner.Name = "labelSelectionner";
            labelSelectionner.Size = new Size(389, 38);
            labelSelectionner.TabIndex = 16;
            labelSelectionner.Text = "Sélectionnez vos stations";
            labelSelectionner.Click += labelSelectionner_Click;
            // 
            // labeldepart
            // 
            labeldepart.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            labeldepart.Location = new Point(30, 175);
            labeldepart.Name = "labeldepart";
            labeldepart.Size = new Size(251, 31);
            labeldepart.TabIndex = 22;
            labeldepart.Text = "Station de départ :";
            // 
            // labelarrivee
            // 
            labelarrivee.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            labelarrivee.Location = new Point(30, 240);
            labelarrivee.Name = "labelarrivee";
            labelarrivee.Size = new Size(225, 31);
            labelarrivee.TabIndex = 21;
            labelarrivee.Text = "Station d'arrivée :";
            // 
            // StationArrivee
            // 
            StationArrivee.Anchor = AnchorStyles.Top;
            StationArrivee.FormattingEnabled = true;
            StationArrivee.ItemHeight = 20;
            StationArrivee.Location = new Point(30, 275);
            StationArrivee.Name = "StationArrivee";
            StationArrivee.Size = new Size(251, 28);
            StationArrivee.TabIndex = 20;
            // 
            // StationDepart
            // 
            StationDepart.FormattingEnabled = true;
            StationDepart.Location = new Point(30, 209);
            StationDepart.Name = "StationDepart";
            StationDepart.Size = new Size(251, 28);
            StationDepart.TabIndex = 19;
            // 
            // listBoxStation
            // 
            listBoxStation.FormattingEnabled = true;
            listBoxStation.Location = new Point(41, 321);
            listBoxStation.Name = "listBoxStation";
            listBoxStation.Size = new Size(360, 184);
            listBoxStation.TabIndex = 23;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(234, 99, 93);
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(pictureBox2);
            flowLayoutPanel1.Controls.Add(pictureBox3);
            flowLayoutPanel1.Location = new Point(2, 595);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(446, 65);
            flowLayoutPanel1.TabIndex = 24;
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
            // 
            // btn_retour
            // 
            btn_retour.BackColor = Color.FromArgb(209, 66, 54);
            btn_retour.Font = new Font("Segoe UI", 15F);
            btn_retour.ForeColor = SystemColors.Control;
            btn_retour.ImeMode = ImeMode.NoControl;
            btn_retour.Location = new Point(56, 526);
            btn_retour.Margin = new Padding(2);
            btn_retour.Name = "btn_retour";
            btn_retour.Size = new Size(321, 50);
            btn_retour.TabIndex = 25;
            btn_retour.Text = "Retour";
            btn_retour.UseVisualStyleBackColor = false;
            // 
            // labelhoraire
            // 
            labelhoraire.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            labelhoraire.Location = new Point(304, 175);
            labelhoraire.Name = "labelhoraire";
            labelhoraire.Size = new Size(142, 31);
            labelhoraire.TabIndex = 26;
            labelhoraire.Text = "Horaire :";
            // 
            // comboBoxHoraire1
            // 
            comboBoxHoraire1.FormattingEnabled = true;
            comboBoxHoraire1.Location = new Point(304, 209);
            comboBoxHoraire1.Name = "comboBoxHoraire1";
            comboBoxHoraire1.Size = new Size(115, 28);
            comboBoxHoraire1.TabIndex = 27;
            // 
            // comboBoxHoraire2
            // 
            comboBoxHoraire2.FormattingEnabled = true;
            comboBoxHoraire2.Location = new Point(304, 275);
            comboBoxHoraire2.Name = "comboBoxHoraire2";
            comboBoxHoraire2.Size = new Size(115, 28);
            comboBoxHoraire2.TabIndex = 28;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.icone_profil;
            pictureBox5.Location = new Point(361, 4);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(63, 91);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 29;
            pictureBox5.TabStop = false;
            // 
            // SelectionLigne
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 659);
            Controls.Add(comboBoxHoraire2);
            Controls.Add(comboBoxHoraire1);
            Controls.Add(labelhoraire);
            Controls.Add(btn_retour);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(listBoxStation);
            Controls.Add(labeldepart);
            Controls.Add(labelarrivee);
            Controls.Add(StationArrivee);
            Controls.Add(StationDepart);
            Controls.Add(labelSelectionner);
            Controls.Add(flpNavbarre);
            Name = "SelectionLigne";
            Text = "SelectionLigne";
            Load += SelectionLigne_Load;
            flpNavbarre.ResumeLayout(false);
            flpNavbarre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
        private ComboBox StationArrivee;
        private ComboBox StationDepart;
        private ListBox listBoxStation;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btn_retour;
        private Label labelhoraire;
        private ComboBox comboBoxHoraire1;
        private ComboBox comboBoxHoraire2;
        private PictureBox pictureBox5;
    }
}