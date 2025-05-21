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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectionLigne));
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
            p_ = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            flpNavbarre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            p_.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            labelSelectionner.Font = new Font("Microsoft Sans Serif", 18F);
            labelSelectionner.ForeColor = SystemColors.MenuText;
            labelSelectionner.Location = new Point(49, 109);
            labelSelectionner.Name = "labelSelectionner";
            labelSelectionner.Size = new Size(352, 36);
            labelSelectionner.TabIndex = 16;
            labelSelectionner.Text = "Sélectionnez vos stations";
            labelSelectionner.Click += labelSelectionner_Click;
            // 
            // labeldepart
            // 
            labeldepart.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labeldepart.Location = new Point(3, 0);
            labeldepart.Name = "labeldepart";
            labeldepart.Size = new Size(162, 21);
            labeldepart.TabIndex = 22;
            labeldepart.Text = "Station de départ :";
            // 
            // labelarrivee
            // 
            labelarrivee.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelarrivee.Location = new Point(3, 55);
            labelarrivee.Name = "labelarrivee";
            labelarrivee.Size = new Size(162, 22);
            labelarrivee.TabIndex = 21;
            labelarrivee.Text = "Station d'arrivée :";
            // 
            // cmb_StationArrivee
            // 
            cmb_StationArrivee.Anchor = AnchorStyles.Top;
            cmb_StationArrivee.FormattingEnabled = true;
            cmb_StationArrivee.ItemHeight = 20;
            cmb_StationArrivee.Location = new Point(12, 80);
            cmb_StationArrivee.Name = "cmb_StationArrivee";
            cmb_StationArrivee.Size = new Size(179, 28);
            cmb_StationArrivee.TabIndex = 20;
            // 
            // cmb_StationDepart
            // 
            cmb_StationDepart.FormattingEnabled = true;
            cmb_StationDepart.Location = new Point(12, 24);
            cmb_StationDepart.Name = "cmb_StationDepart";
            cmb_StationDepart.Size = new Size(177, 28);
            cmb_StationDepart.TabIndex = 19;
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
            labelhoraire.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelhoraire.Location = new Point(3, 0);
            labelhoraire.Name = "labelhoraire";
            labelhoraire.Size = new Size(86, 21);
            labelhoraire.TabIndex = 26;
            labelhoraire.Text = "Horaire :";
            // 
            // cmb_Horaire1
            // 
            cmb_Horaire1.FormattingEnabled = true;
            cmb_Horaire1.Location = new Point(8, 24);
            cmb_Horaire1.Name = "cmb_Horaire1";
            cmb_Horaire1.Size = new Size(122, 28);
            cmb_Horaire1.TabIndex = 27;
            // 
            // cmb_Horaire2
            // 
            cmb_Horaire2.FormattingEnabled = true;
            cmb_Horaire2.Location = new Point(8, 80);
            cmb_Horaire2.Name = "cmb_Horaire2";
            cmb_Horaire2.Size = new Size(122, 28);
            cmb_Horaire2.TabIndex = 28;
            // 
            // p_
            // 
            p_.BackColor = Color.FromArgb(255, 128, 128);
            p_.Controls.Add(panel2);
            p_.Controls.Add(panel1);
            p_.Location = new Point(35, 162);
            p_.Name = "p_";
            p_.Size = new Size(371, 330);
            p_.TabIndex = 29;
            p_.Paint += panel1_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(labelhoraire);
            panel1.Controls.Add(cmb_Horaire2);
            panel1.Controls.Add(cmb_Horaire1);
            panel1.Location = new Point(225, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(141, 119);
            panel1.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(labeldepart);
            panel2.Controls.Add(cmb_StationDepart);
            panel2.Controls.Add(cmb_StationArrivee);
            panel2.Controls.Add(labelarrivee);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(202, 119);
            panel2.TabIndex = 30;
            // 
            // SelectionLigne
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 659);
            Controls.Add(btn_retour);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(labelSelectionner);
            Controls.Add(flpNavbarre);
            Controls.Add(p_);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SelectionLigne";
            Text = "SelectionLigne";
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
            p_.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
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
        private Panel p_;
        private Panel panel1;
        private Panel panel2;
    }
}