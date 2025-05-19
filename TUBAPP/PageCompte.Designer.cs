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
            lblTitre = new Label();
            lblNom = new Label();
            lblPrenom = new Label();
            lblEmail = new Label();
            lblStatut = new Label();
            btnConnexion = new Button();
            btnCreation = new Button();
            btnModifierInfos = new Button();
            btnAdminPanel = new Button();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitre.Location = new Point(30, 20);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(300, 30);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Profil";
            // 
            // lblNom
            // 
            lblNom.Location = new Point(30, 70);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(300, 20);
            lblNom.TabIndex = 1;
            // 
            // lblPrenom
            // 
            lblPrenom.Location = new Point(30, 100);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(300, 20);
            lblPrenom.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(30, 130);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(300, 20);
            lblEmail.TabIndex = 3;
            // 
            // lblStatut
            // 
            lblStatut.Location = new Point(30, 160);
            lblStatut.Name = "lblStatut";
            lblStatut.Size = new Size(300, 20);
            lblStatut.TabIndex = 4;
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
            // PageCompte
            // 
            ClientSize = new Size(509, 683);
            Controls.Add(lblTitre);
            Controls.Add(lblNom);
            Controls.Add(lblPrenom);
            Controls.Add(lblEmail);
            Controls.Add(lblStatut);
            Controls.Add(btnConnexion);
            Controls.Add(btnCreation);
            Controls.Add(btnModifierInfos);
            Controls.Add(btnAdminPanel);
            Name = "PageCompte";
            Text = "PageCompte";
            Load += PageCompte_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitre;
        private Label lblPrenom;
        private Label lblNom;
        private Label lblStatut;
        private Label lblEmail;
        private Button btnConnexion;
        private Button btnCreation;
        private Button btnModifierInfos;
        private Button btnAdminPanel;
        //private Button button1;

    }
}