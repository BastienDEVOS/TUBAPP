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
            lblTUBAPP = new Label();
            picIconeContact = new PictureBox();
            lblBienvenue = new Label();
            btnRetour = new Button();
            txtIdentifiant = new TextBox();
            txtMDP = new TextBox();
            btnConnexion = new Button();
            llbMDPOublié = new LinkLabel();
            btn_retour = new Button();
            pictureBox1 = new PictureBox();
            flpNavbarre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flpNavbarre
            // 
            flpNavbarre.BackColor = Color.FromArgb(234, 99, 93);
            flpNavbarre.Controls.Add(pictureBox1);
            flpNavbarre.Controls.Add(lblTUBAPP);
            flpNavbarre.Controls.Add(picIconeContact);
            resources.ApplyResources(flpNavbarre, "flpNavbarre");
            flpNavbarre.Name = "flpNavbarre";
            // 
            // lblTUBAPP
            // 
            resources.ApplyResources(lblTUBAPP, "lblTUBAPP");
            lblTUBAPP.ForeColor = Color.White;
            lblTUBAPP.Name = "lblTUBAPP";
            // 
            // picIconeContact
            // 
            picIconeContact.Image = Properties.Resources.icone_profil;
            resources.ApplyResources(picIconeContact, "picIconeContact");
            picIconeContact.Name = "picIconeContact";
            picIconeContact.TabStop = false;
            // 
            // lblBienvenue
            // 
            resources.ApplyResources(lblBienvenue, "lblBienvenue");
            lblBienvenue.Name = "lblBienvenue";
            // 
            // btnRetour
            // 
            resources.ApplyResources(btnRetour, "btnRetour");
            btnRetour.Name = "btnRetour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.MouseClick += btnRetour_MouseClick;
            // 
            // txtIdentifiant
            // 
            resources.ApplyResources(txtIdentifiant, "txtIdentifiant");
            txtIdentifiant.Name = "txtIdentifiant";
            txtIdentifiant.TextChanged += txtIdentifiant_TextChanged;
            // 
            // txtMDP
            // 
            resources.ApplyResources(txtMDP, "txtMDP");
            txtMDP.Name = "txtMDP";
            // 
            // btnConnexion
            // 
            resources.ApplyResources(btnConnexion, "btnConnexion");
            btnConnexion.Name = "btnConnexion";
            btnConnexion.UseVisualStyleBackColor = true;
            btnConnexion.Click += btnConnexion_Click;
            // 
            // llbMDPOublié
            // 
            resources.ApplyResources(llbMDPOublié, "llbMDPOublié");
            llbMDPOublié.Name = "llbMDPOublié";
            llbMDPOublié.TabStop = true;
            // 
            // btn_retour
            // 
            resources.ApplyResources(btn_retour, "btn_retour");
            btn_retour.Name = "btn_retour";
            btn_retour.UseVisualStyleBackColor = true;
            btn_retour.MouseClick += btnRetour_MouseClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo1;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // frmConnexion
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btn_retour);
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
            Load += Form2_Load;
            flpNavbarre.ResumeLayout(false);
            flpNavbarre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button btn_retour;
        private PictureBox pictureBox1;
    }
}