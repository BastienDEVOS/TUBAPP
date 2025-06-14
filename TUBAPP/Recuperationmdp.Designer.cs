﻿namespace TUBAPP
{
    partial class frmRecuperationmdp
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtNouveauMdp;
        private System.Windows.Forms.TextBox txtConfirmerMdp;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Button btnRetour;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecuperationmdp));
            lblTitre = new Label();
            txtEmail = new TextBox();
            txtCode = new TextBox();
            txtNouveauMdp = new TextBox();
            txtConfirmerMdp = new TextBox();
            btnConnexion = new Button();
            btnRetour = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitre.Location = new Point(93, 176);
            lblTitre.Margin = new Padding(5, 0, 5, 0);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(520, 131);
            lblTitre.TabIndex = 1;
            lblTitre.Text = "Récupération de\nMot de passe";
            lblTitre.TextAlign = ContentAlignment.MiddleCenter;
            lblTitre.Click += lblTitre_Click;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.ForeColor = Color.Gray;
            txtEmail.Location = new Point(104, 386);
            txtEmail.Margin = new Padding(5, 5, 5, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Adresse mail";
            txtEmail.Size = new Size(507, 50);
            txtEmail.TabIndex = 2;
            // 
            // txtCode
            // 
            txtCode.BackColor = Color.White;
            txtCode.BorderStyle = BorderStyle.FixedSingle;
            txtCode.Font = new Font("Segoe UI", 12F);
            txtCode.ForeColor = Color.Gray;
            txtCode.Location = new Point(104, 467);
            txtCode.Margin = new Padding(5, 5, 5, 5);
            txtCode.Name = "txtCode";
            txtCode.PlaceholderText = "Code de vérification";
            txtCode.Size = new Size(507, 50);
            txtCode.TabIndex = 3;
            // 
            // txtNouveauMdp
            // 
            txtNouveauMdp.BackColor = Color.White;
            txtNouveauMdp.BorderStyle = BorderStyle.FixedSingle;
            txtNouveauMdp.Font = new Font("Segoe UI", 12F);
            txtNouveauMdp.ForeColor = Color.Gray;
            txtNouveauMdp.Location = new Point(104, 547);
            txtNouveauMdp.Margin = new Padding(5, 5, 5, 5);
            txtNouveauMdp.Name = "txtNouveauMdp";
            txtNouveauMdp.PlaceholderText = "Nouveau Mot de passe";
            txtNouveauMdp.Size = new Size(338, 50);
            txtNouveauMdp.TabIndex = 4;
            txtNouveauMdp.UseSystemPasswordChar = true;
            // 
            // txtConfirmerMdp
            // 
            txtConfirmerMdp.BackColor = Color.White;
            txtConfirmerMdp.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmerMdp.Font = new Font("Segoe UI", 12F);
            txtConfirmerMdp.ForeColor = Color.Gray;
            txtConfirmerMdp.Location = new Point(104, 627);
            txtConfirmerMdp.Margin = new Padding(5, 5, 5, 5);
            txtConfirmerMdp.Name = "txtConfirmerMdp";
            txtConfirmerMdp.PlaceholderText = "Confirmation Mot de passe";
            txtConfirmerMdp.Size = new Size(338, 50);
            txtConfirmerMdp.TabIndex = 6;
            txtConfirmerMdp.UseSystemPasswordChar = true;
            // 
            // btnConnexion
            // 
            btnConnexion.BackColor = Color.FromArgb(209, 66, 54);
            btnConnexion.Cursor = Cursors.Hand;
            btnConnexion.FlatAppearance.BorderSize = 0;
            btnConnexion.FlatStyle = FlatStyle.Flat;
            btnConnexion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnConnexion.ForeColor = Color.White;
            btnConnexion.Location = new Point(104, 784);
            btnConnexion.Margin = new Padding(5, 5, 5, 5);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(509, 64);
            btnConnexion.TabIndex = 8;
            btnConnexion.Text = "Connexion";
            btnConnexion.UseVisualStyleBackColor = false;
            btnConnexion.Click += btnConnexion_Click;
            // 
            // btnRetour
            // 
            btnRetour.BackColor = Color.FromArgb(209, 66, 54);
            btnRetour.Cursor = Cursors.Hand;
            btnRetour.FlatAppearance.BorderSize = 0;
            btnRetour.FlatStyle = FlatStyle.Flat;
            btnRetour.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRetour.ForeColor = Color.White;
            btnRetour.Location = new Point(104, 890);
            btnRetour.Margin = new Padding(5, 5, 5, 5);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(509, 64);
            btnRetour.TabIndex = 9;
            btnRetour.Text = "RETOUR";
            btnRetour.UseVisualStyleBackColor = false;
            btnRetour.Click += btnRetour_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(234, 99, 93);
            flowLayoutPanel1.Controls.Add(pictureBox3);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(pictureBox4);
            flowLayoutPanel1.Location = new Point(2, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(725, 152);
            flowLayoutPanel1.TabIndex = 18;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.logo1;
            pictureBox3.ImeMode = ImeMode.NoControl;
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(148, 149);
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
            label1.Location = new Point(214, 33);
            label1.Margin = new Padding(60, 0, 60, 0);
            label1.Name = "label1";
            label1.Size = new Size(297, 89);
            label1.TabIndex = 0;
            label1.Text = "TUBAPP";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icone_profil;
            pictureBox4.ImeMode = ImeMode.NoControl;
            pictureBox4.Location = new Point(571, 0);
            pictureBox4.Margin = new Padding(0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(151, 149);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.eye_crossed;
            pictureBox2.Location = new Point(489, 627);
            pictureBox2.Margin = new Padding(5, 6, 5, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(102, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            pictureBox2.Click += btnVoirConfirmerMdp_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.eye_crossed;
            pictureBox1.Location = new Point(489, 547);
            pictureBox1.Margin = new Padding(5, 6, 5, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            pictureBox1.Click += btnVoirMdp_Click;
            // 
            // frmRecuperationmdp
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 1054);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lblTitre);
            Controls.Add(txtEmail);
            Controls.Add(txtCode);
            Controls.Add(txtNouveauMdp);
            Controls.Add(txtConfirmerMdp);
            Controls.Add(btnConnexion);
            Controls.Add(btnRetour);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 5, 5, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRecuperationmdp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Récupération du mot de passe";
            Load += Recuperationmdp_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
