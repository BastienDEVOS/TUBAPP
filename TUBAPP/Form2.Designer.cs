namespace TUBAPP
{
    partial class frmConnexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnexion));
            flpNavbarre = new FlowLayoutPanel();
            picUndergroudLogo = new PictureBox();
            lblTUBAPP = new Label();
            picIconeContact = new PictureBox();
            lblBienvenue = new Label();
            btnRetour = new Button();
            txtIdentifiant = new TextBox();
            txtMDP = new TextBox();
            btnConnexion = new Button();
            llbMDPOublié = new LinkLabel();
            flpNavbarre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUndergroudLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).BeginInit();
            SuspendLayout();
            // 
            // flpNavbarre
            // 
            flpNavbarre.BackColor = Color.FromArgb(234, 99, 93);
            flpNavbarre.Controls.Add(picUndergroudLogo);
            flpNavbarre.Controls.Add(lblTUBAPP);
            flpNavbarre.Controls.Add(picIconeContact);
            flpNavbarre.Location = new Point(0, 0);
            flpNavbarre.Name = "flpNavbarre";
            flpNavbarre.Size = new Size(725, 152);
            flpNavbarre.TabIndex = 5;
            // 
            // picUndergroudLogo
            // 
            picUndergroudLogo.Image = (Image)resources.GetObject("picUndergroudLogo.Image");
            picUndergroudLogo.Location = new Point(0, 0);
            picUndergroudLogo.Margin = new Padding(0);
            picUndergroudLogo.Name = "picUndergroudLogo";
            picUndergroudLogo.Size = new Size(154, 149);
            picUndergroudLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picUndergroudLogo.TabIndex = 1;
            picUndergroudLogo.TabStop = false;
            // 
            // lblTUBAPP
            // 
            lblTUBAPP.Anchor = AnchorStyles.None;
            lblTUBAPP.AutoSize = true;
            lblTUBAPP.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblTUBAPP.ForeColor = Color.White;
            lblTUBAPP.Location = new Point(214, 30);
            lblTUBAPP.Margin = new Padding(60, 0, 60, 0);
            lblTUBAPP.Name = "lblTUBAPP";
            lblTUBAPP.Size = new Size(297, 89);
            lblTUBAPP.TabIndex = 0;
            lblTUBAPP.Text = "TUBAPP";
            lblTUBAPP.TextAlign = ContentAlignment.TopCenter;
            // 
            // picIconeContact
            // 
            picIconeContact.Image = Properties.Resources.icone_profil;
            picIconeContact.Location = new Point(571, 0);
            picIconeContact.Margin = new Padding(0);
            picIconeContact.Name = "picIconeContact";
            picIconeContact.Size = new Size(151, 149);
            picIconeContact.SizeMode = PictureBoxSizeMode.Zoom;
            picIconeContact.TabIndex = 2;
            picIconeContact.TabStop = false;
            // 
            // lblBienvenue
            // 
            lblBienvenue.AutoSize = true;
            lblBienvenue.Font = new Font("Segoe UI", 34.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenue.Location = new Point(82, 269);
            lblBienvenue.Name = "lblBienvenue";
            lblBienvenue.Size = new Size(519, 124);
            lblBienvenue.TabIndex = 6;
            lblBienvenue.Text = "Connexion";
            // 
            // btnRetour
            // 
            btnRetour.Font = new Font("Segoe UI", 15F);
            btnRetour.Location = new Point(82, 1185);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(522, 80);
            btnRetour.TabIndex = 7;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.MouseClick += btnRetour_MouseClick;
            // 
            // txtIdentifiant
            // 
            txtIdentifiant.Font = new Font("Segoe UI", 15F);
            txtIdentifiant.Location = new Point(85, 497);
            txtIdentifiant.Name = "txtIdentifiant";
            txtIdentifiant.PlaceholderText = "Identifaint";
            txtIdentifiant.Size = new Size(522, 61);
            txtIdentifiant.TabIndex = 8;
            txtIdentifiant.TextChanged += txtIdentifiant_TextChanged;
            // 
            // txtMDP
            // 
            txtMDP.Font = new Font("Segoe UI", 15F);
            txtMDP.Location = new Point(82, 640);
            txtMDP.Name = "txtMDP";
            txtMDP.PlaceholderText = "Mot de passe";
            txtMDP.Size = new Size(525, 61);
            txtMDP.TabIndex = 9;
            // 
            // btnConnexion
            // 
            btnConnexion.Font = new Font("Segoe UI", 15F);
            btnConnexion.Location = new Point(85, 817);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(522, 80);
            btnConnexion.TabIndex = 10;
            btnConnexion.Text = "Connexion";
            btnConnexion.UseVisualStyleBackColor = true;
            // 
            // llbMDPOublié
            // 
            llbMDPOublié.AutoSize = true;
            llbMDPOublié.Location = new Point(82, 706);
            llbMDPOublié.Name = "llbMDPOublié";
            llbMDPOublié.Size = new Size(250, 32);
            llbMDPOublié.TabIndex = 11;
            llbMDPOublié.TabStop = true;
            llbMDPOublié.Text = "Mot de passe oublié ?";
            // 
            // frmConnexion
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(724, 1429);
            Controls.Add(llbMDPOublié);
            Controls.Add(btnConnexion);
            Controls.Add(txtMDP);
            Controls.Add(txtIdentifiant);
            Controls.Add(btnRetour);
            Controls.Add(lblBienvenue);
            Controls.Add(flpNavbarre);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmConnexion";
            Text = "TUBAPP";
            Load += Form2_Load;
            flpNavbarre.ResumeLayout(false);
            flpNavbarre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUndergroudLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpNavbarre;
        private PictureBox picUndergroudLogo;
        private Label lblTUBAPP;
        private PictureBox picIconeContact;
        private Label lblBienvenue;
        private Button btnRetour;
        private TextBox txtIdentifiant;
        private TextBox txtMDP;
        private Button btnConnexion;
        private LinkLabel llbMDPOublié;
    }
}