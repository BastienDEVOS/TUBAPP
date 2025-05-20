namespace TUBAPP
{
    partial class PageCompte
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
            btnConnexion = new Button();
            btnCreation = new Button();
            btnModifierInfos = new Button();
            btnAdminPanel = new Button();
            flpNavbarre = new FlowLayoutPanel();
            pictureBox4 = new PictureBox();
            lblTUBAPP = new Label();
            picIconeContact = new PictureBox();
            flpNavbarre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).BeginInit();
            SuspendLayout();
            // 
            // btnConnexion
            // 
            btnConnexion.Location = new Point(160, 200);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(181, 39);
            btnConnexion.TabIndex = 5;
            btnConnexion.Text = "Se connecter";
            // 
            // btnCreation
            // 
            btnCreation.Location = new Point(160, 245);
            btnCreation.Name = "btnCreation";
            btnCreation.Size = new Size(181, 38);
            btnCreation.TabIndex = 6;
            btnCreation.Text = "Créer un compte";
            // 
            // btnModifierInfos
            // 
            btnModifierInfos.Location = new Point(30, 230);
            btnModifierInfos.Name = "btnModifierInfos";
            btnModifierInfos.Size = new Size(75, 35);
            btnModifierInfos.TabIndex = 7;
            btnModifierInfos.Text = "Modifier mes infos";
            // 
            // btnAdminPanel
            // 
            btnAdminPanel.Location = new Point(160, 303);
            btnAdminPanel.Name = "btnAdminPanel";
            btnAdminPanel.Size = new Size(181, 38);
            btnAdminPanel.TabIndex = 8;
            btnAdminPanel.Text = "Gérer les utilisateurs";
            // 
            // flpNavbarre
            // 
            flpNavbarre.BackColor = Color.FromArgb(234, 99, 93);
            flpNavbarre.Controls.Add(pictureBox4);
            flpNavbarre.Controls.Add(lblTUBAPP);
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
            lblTUBAPP.Location = new Point(132, 20);
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
            picIconeContact.Location = new Point(0, 97);
            picIconeContact.Margin = new Padding(0);
            picIconeContact.Name = "picIconeContact";
            picIconeContact.Size = new Size(93, 97);
            picIconeContact.SizeMode = PictureBoxSizeMode.Zoom;
            picIconeContact.TabIndex = 2;
            picIconeContact.TabStop = false;
            // 
            // PageCompte
            // 
            ClientSize = new Size(446, 659);
            Controls.Add(flpNavbarre);
            Controls.Add(btnConnexion);
            Controls.Add(btnCreation);
            Controls.Add(btnModifierInfos);
            Controls.Add(btnAdminPanel);
            Name = "PageCompte";
            Text = "PageCompte";
            Load += PageCompte_Load;
            flpNavbarre.ResumeLayout(false);
            flpNavbarre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnConnexion;
        private Button btnCreation;
        private Button btnModifierInfos;
        private Button btnAdminPanel;
        private FlowLayoutPanel flpNavbarre;
        private PictureBox pictureBox4;
        private Label lblTUBAPP;
        private PictureBox picIconeContact;
        //private Button button1;

    }
}