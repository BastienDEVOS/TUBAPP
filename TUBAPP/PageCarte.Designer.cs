namespace TUBAPP
{
    partial class PageCarte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageCarte));
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            picIconeContact = new PictureBox();
            pictureBox4 = new PictureBox();
            lblInfo = new Label();
            btnEstimation = new Button();
            lblRame = new Label();
            lblPosition = new Label();
            picBoxCarte = new PictureBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            BtnHome = new PictureBox();
            pictureBox5 = new PictureBox();
            btnAgrandirCarte = new Button();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxCarte).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(234, 99, 93);
            flowLayoutPanel1.Controls.Add(pictureBox3);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(picIconeContact);
            flowLayoutPanel1.Controls.Add(pictureBox4);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(446, 95);
            flowLayoutPanel1.TabIndex = 43;
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
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(132, 21);
            label2.Margin = new Padding(37, 0, 37, 0);
            label2.Name = "label2";
            label2.Size = new Size(189, 57);
            label2.TabIndex = 0;
            label2.Text = "TUBAPP";
            label2.TextAlign = ContentAlignment.TopCenter;
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
            picIconeContact.Click += picIconeContact_Click;
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
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblInfo.ForeColor = Color.Black;
            lblInfo.Location = new Point(13, 99);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(426, 54);
            lblInfo.TabIndex = 44;
            lblInfo.Text = "Information en direct";
            // 
            // btnEstimation
            // 
            btnEstimation.BackColor = Color.FromArgb(209, 66, 54);
            btnEstimation.FlatStyle = FlatStyle.Flat;
            btnEstimation.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEstimation.ForeColor = Color.White;
            btnEstimation.Location = new Point(74, 288);
            btnEstimation.Margin = new Padding(3, 4, 3, 4);
            btnEstimation.Name = "btnEstimation";
            btnEstimation.Size = new Size(316, 90);
            btnEstimation.TabIndex = 45;
            btnEstimation.Text = "Estimation de la capacité";
            btnEstimation.UseVisualStyleBackColor = false;
            btnEstimation.Click += btnConfirmer_Click;
            // 
            // lblRame
            // 
            lblRame.AutoSize = true;
            lblRame.Font = new Font("Segoe UI", 15F);
            lblRame.ForeColor = Color.Black;
            lblRame.Location = new Point(183, 153);
            lblRame.Name = "lblRame";
            lblRame.Size = new Size(98, 35);
            lblRame.TabIndex = 46;
            lblRame.Text = "Rame 2";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPosition.ForeColor = Color.Black;
            lblPosition.Location = new Point(95, 392);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(259, 32);
            lblPosition.TabIndex = 47;
            lblPosition.Text = "Ma position en direct";
            // 
            // picBoxCarte
            // 
            picBoxCarte.Image = (Image)resources.GetObject("picBoxCarte.Image");
            picBoxCarte.Location = new Point(47, 438);
            picBoxCarte.Name = "picBoxCarte";
            picBoxCarte.Size = new Size(354, 152);
            picBoxCarte.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxCarte.TabIndex = 48;
            picBoxCarte.TabStop = false;
            picBoxCarte.Click += picBoxCarte_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(234, 99, 93);
            flowLayoutPanel2.Controls.Add(pictureBox1);
            flowLayoutPanel2.Controls.Add(BtnHome);
            flowLayoutPanel2.Controls.Add(pictureBox5);
            flowLayoutPanel2.Location = new Point(2, 595);
            flowLayoutPanel2.Margin = new Padding(2);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(446, 65);
            flowLayoutPanel2.TabIndex = 53;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.GPSSelectionner;
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
            BtnHome.Click += BtnHome_Click;
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
            // 
            // btnAgrandirCarte
            // 
            btnAgrandirCarte.Location = new Point(323, 438);
            btnAgrandirCarte.Name = "btnAgrandirCarte";
            btnAgrandirCarte.Size = new Size(78, 40);
            btnAgrandirCarte.TabIndex = 54;
            btnAgrandirCarte.Text = "<>";
            btnAgrandirCarte.UseVisualStyleBackColor = true;
            btnAgrandirCarte.Click += button1_Click;
            // 
            // PageCarte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 659);
            Controls.Add(btnAgrandirCarte);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(picBoxCarte);
            Controls.Add(lblPosition);
            Controls.Add(lblRame);
            Controls.Add(btnEstimation);
            Controls.Add(lblInfo);
            Controls.Add(flowLayoutPanel1);
            Name = "PageCarte";
            Text = "PageCarte";
            Load += PageCarte_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxCarte).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox3;
        private Label label2;
        private PictureBox picIconeContact;
        private PictureBox pictureBox4;
        private Label lblInfo;
        private Button btnEstimation;
        private Label lblRame;
        private Label lblPosition;
        private PictureBox picBoxCarte;
        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox1;
        private PictureBox BtnHome;
        private PictureBox pictureBox5;
        private Button btnAgrandirCarte;
    }
}