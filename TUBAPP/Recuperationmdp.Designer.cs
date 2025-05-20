namespace TUBAPP
{
    partial class Recuperationmdp
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.FlowLayoutPanel flpNavbarre;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblTUBAPP;
        private System.Windows.Forms.PictureBox picIconeContact;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtNouveauMdp;
        private System.Windows.Forms.TextBox txtConfirmerMdp;
        private System.Windows.Forms.Button btnVoirMdp;
        private System.Windows.Forms.Button btnVoirConfirmerMdp;
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
            flpNavbarre = new FlowLayoutPanel();
            pictureBoxLogo = new PictureBox();
            lblTUBAPP = new Label();
            picIconeContact = new PictureBox();
            lblTitre = new Label();
            txtEmail = new TextBox();
            txtCode = new TextBox();
            txtNouveauMdp = new TextBox();
            txtConfirmerMdp = new TextBox();
            btnVoirMdp = new Button();
            btnVoirConfirmerMdp = new Button();
            btnConnexion = new Button();
            btnRetour = new Button();
            flpNavbarre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).BeginInit();
            SuspendLayout();
            // 
            // flpNavbarre
            // 
            flpNavbarre.BackColor = Color.FromArgb(234, 99, 93);
            flpNavbarre.Controls.Add(pictureBoxLogo);
            flpNavbarre.Controls.Add(lblTUBAPP);
            flpNavbarre.Controls.Add(picIconeContact);
            flpNavbarre.Location = new Point(0, 0);
            flpNavbarre.Margin = new Padding(4, 4, 4, 4);
            flpNavbarre.Name = "flpNavbarre";
            flpNavbarre.Size = new Size(445, 75);
            flpNavbarre.TabIndex = 0;
            flpNavbarre.WrapContents = false;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.logo;
            pictureBoxLogo.Location = new Point(6, 6);
            pictureBoxLogo.Margin = new Padding(6, 6, 6, 6);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(62, 62);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // lblTUBAPP
            // 
            lblTUBAPP.AutoSize = true;
            lblTUBAPP.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTUBAPP.ForeColor = Color.White;
            lblTUBAPP.Location = new Point(78, 0);
            lblTUBAPP.Margin = new Padding(4, 0, 4, 0);
            lblTUBAPP.Name = "lblTUBAPP";
            lblTUBAPP.Padding = new Padding(12, 19, 12, 0);
            lblTUBAPP.Size = new Size(149, 57);
            lblTUBAPP.TabIndex = 1;
            lblTUBAPP.Text = "TUBAPP";
            lblTUBAPP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // picIconeContact
            // 
            picIconeContact.Image = Properties.Resources.icone_profil;
            picIconeContact.Location = new Point(381, 12);
            picIconeContact.Margin = new Padding(150, 12, 0, 0);
            picIconeContact.Name = "picIconeContact";
            picIconeContact.Size = new Size(50, 50);
            picIconeContact.SizeMode = PictureBoxSizeMode.Zoom;
            picIconeContact.TabIndex = 2;
            picIconeContact.TabStop = false;
            // 
            // lblTitre
            // 
            lblTitre.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitre.Location = new Point(13, 90);
            lblTitre.Margin = new Padding(4, 0, 4, 0);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(400, 102);
            lblTitre.TabIndex = 1;
            lblTitre.Text = "Récupération de\nMot de passe";
            lblTitre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.ForeColor = Color.Gray;
            txtEmail.Location = new Point(61, 209);
            txtEmail.Margin = new Padding(4, 4, 4, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Adresse mail";
            txtEmail.Size = new Size(312, 39);
            txtEmail.TabIndex = 2;
            // 
            // txtCode
            // 
            txtCode.BackColor = Color.White;
            txtCode.BorderStyle = BorderStyle.FixedSingle;
            txtCode.Font = new Font("Segoe UI", 12F);
            txtCode.ForeColor = Color.Gray;
            txtCode.Location = new Point(61, 280);
            txtCode.Margin = new Padding(4, 4, 4, 4);
            txtCode.Name = "txtCode";
            txtCode.PlaceholderText = "Code de vérification";
            txtCode.Size = new Size(312, 39);
            txtCode.TabIndex = 3;
            // 
            // txtNouveauMdp
            // 
            txtNouveauMdp.BackColor = Color.White;
            txtNouveauMdp.BorderStyle = BorderStyle.FixedSingle;
            txtNouveauMdp.Font = new Font("Segoe UI", 12F);
            txtNouveauMdp.ForeColor = Color.Gray;
            txtNouveauMdp.Location = new Point(61, 350);
            txtNouveauMdp.Margin = new Padding(4, 4, 4, 4);
            txtNouveauMdp.Name = "txtNouveauMdp";
            txtNouveauMdp.PlaceholderText = "Nouveau Mot de passe";
            txtNouveauMdp.Size = new Size(312, 39);
            txtNouveauMdp.TabIndex = 4;
            txtNouveauMdp.UseSystemPasswordChar = true;
            // 
            // txtConfirmerMdp
            // 
            txtConfirmerMdp.BackColor = Color.White;
            txtConfirmerMdp.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmerMdp.Font = new Font("Segoe UI", 12F);
            txtConfirmerMdp.ForeColor = Color.Gray;
            txtConfirmerMdp.Location = new Point(61, 428);
            txtConfirmerMdp.Margin = new Padding(4, 4, 4, 4);
            txtConfirmerMdp.Name = "txtConfirmerMdp";
            txtConfirmerMdp.PlaceholderText = "Confirmation Mot de passe";
            txtConfirmerMdp.Size = new Size(312, 39);
            txtConfirmerMdp.TabIndex = 6;
            txtConfirmerMdp.UseSystemPasswordChar = true;
            // 
            // btnVoirMdp
            // 
            btnVoirMdp.FlatAppearance.BorderSize = 0;
            btnVoirMdp.FlatStyle = FlatStyle.Flat;
            btnVoirMdp.Location = new Point(312, 300);
            btnVoirMdp.Margin = new Padding(4, 4, 4, 4);
            btnVoirMdp.Name = "btnVoirMdp";
            btnVoirMdp.Size = new Size(44, 42);
            btnVoirMdp.TabIndex = 5;
            btnVoirMdp.Click += btnVoirMdp_Click;
            // 
            // btnVoirConfirmerMdp
            // 
            btnVoirConfirmerMdp.FlatAppearance.BorderSize = 0;
            btnVoirConfirmerMdp.FlatStyle = FlatStyle.Flat;
            btnVoirConfirmerMdp.Location = new Point(312, 362);
            btnVoirConfirmerMdp.Margin = new Padding(4, 4, 4, 4);
            btnVoirConfirmerMdp.Name = "btnVoirConfirmerMdp";
            btnVoirConfirmerMdp.Size = new Size(44, 42);
            btnVoirConfirmerMdp.TabIndex = 7;
            btnVoirConfirmerMdp.Click += btnVoirConfirmerMdp_Click;
            // 
            // btnConnexion
            // 
            btnConnexion.BackColor = Color.FromArgb(209, 66, 54);
            btnConnexion.Cursor = Cursors.Hand;
            btnConnexion.FlatAppearance.BorderSize = 0;
            btnConnexion.FlatStyle = FlatStyle.Flat;
            btnConnexion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnConnexion.ForeColor = Color.White;
            btnConnexion.Location = new Point(61, 486);
            btnConnexion.Margin = new Padding(4, 4, 4, 4);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(312, 50);
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
            btnRetour.Location = new Point(61, 569);
            btnRetour.Margin = new Padding(4, 4, 4, 4);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(312, 50);
            btnRetour.TabIndex = 9;
            btnRetour.Text = "RETOUR";
            btnRetour.UseVisualStyleBackColor = false;
            btnRetour.Click += btnRetour_Click;
            // 
            // Recuperationmdp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 632);
            Controls.Add(flpNavbarre);
            Controls.Add(lblTitre);
            Controls.Add(txtEmail);
            Controls.Add(txtCode);
            Controls.Add(txtNouveauMdp);
            Controls.Add(btnVoirMdp);
            Controls.Add(txtConfirmerMdp);
            Controls.Add(btnVoirConfirmerMdp);
            Controls.Add(btnConnexion);
            Controls.Add(btnRetour);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Recuperationmdp";
            Text = "Récupération du mot de passe";
            flpNavbarre.ResumeLayout(false);
            flpNavbarre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
