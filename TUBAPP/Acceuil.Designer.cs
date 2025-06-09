namespace TUBAPP
{
    partial class frmAcceuil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcceuil));
            btnInvité = new Button();
            btnNvCompt = new Button();
            btnConnexion = new Button();
            lblBienvenue = new Label();
            flpNavbarre = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            lblTUBAPP = new Label();
            picIconeContact = new PictureBox();
            Connecter = new Label();
            ConnecterNon = new Label();
            ConnecterOui = new Label();
            flpNavbarre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).BeginInit();
            SuspendLayout();
            // 
            // btnInvité
            // 
            btnInvité.BackColor = Color.FromArgb(209, 66, 54);
            resources.ApplyResources(btnInvité, "btnInvité");
            btnInvité.ForeColor = Color.White;
            btnInvité.Name = "btnInvité";
            btnInvité.UseVisualStyleBackColor = false;
            btnInvité.Click += btnInvite_Click;
            // 
            // btnNvCompt
            // 
            btnNvCompt.BackColor = Color.FromArgb(209, 66, 54);
            resources.ApplyResources(btnNvCompt, "btnNvCompt");
            btnNvCompt.ForeColor = Color.White;
            btnNvCompt.Name = "btnNvCompt";
            btnNvCompt.UseVisualStyleBackColor = false;
            btnNvCompt.Click += btnNvCompt_Click;
            // 
            // btnConnexion
            // 
            resources.ApplyResources(btnConnexion, "btnConnexion");
            btnConnexion.BackColor = Color.FromArgb(209, 66, 54);
            btnConnexion.ForeColor = Color.White;
            btnConnexion.Name = "btnConnexion";
            btnConnexion.UseVisualStyleBackColor = false;
            btnConnexion.MouseClick += btnConnexion_MouseClick;
            // 
            // lblBienvenue
            // 
            resources.ApplyResources(lblBienvenue, "lblBienvenue");
            lblBienvenue.Name = "lblBienvenue";
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
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
            // Connecter
            // 
            resources.ApplyResources(Connecter, "Connecter");
            Connecter.Name = "Connecter";
            // 
            // ConnecterNon
            // 
            resources.ApplyResources(ConnecterNon, "ConnecterNon");
            ConnecterNon.BackColor = Color.Red;
            ConnecterNon.Name = "ConnecterNon";
            // 
            // ConnecterOui
            // 
            resources.ApplyResources(ConnecterOui, "ConnecterOui");
            ConnecterOui.BackColor = Color.Lime;
            ConnecterOui.Name = "ConnecterOui";
            // 
            // frmAcceuil
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(ConnecterOui);
            Controls.Add(ConnecterNon);
            Controls.Add(Connecter);
            Controls.Add(flpNavbarre);
            Controls.Add(lblBienvenue);
            Controls.Add(btnConnexion);
            Controls.Add(btnNvCompt);
            Controls.Add(btnInvité);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAcceuil";
            Load += frmAcceuil_Load;
            flpNavbarre.ResumeLayout(false);
            flpNavbarre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInvité;
        private Button btnNvCompt;
        private Button btnConnexion;
        private Label lblBienvenue;
        private FlowLayoutPanel flpNavbarre;
        private Label lblTUBAPP;
        private PictureBox picIconeContact;
        private PictureBox pictureBox1;
        private Label Connecter;
        private Label ConnecterNon;
        private Label ConnecterOui;
    }
}
