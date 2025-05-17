namespace TUBAPP
{
    partial class frmNouvelUtilisateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNouvelUtilisateur));
            button2 = new Button();
            btn_Connecter = new Button();
            Btn_Retour = new Button();
            txtConfirmMDP = new TextBox();
            txtMDP = new TextBox();
            txtAdresseMail = new TextBox();
            checkBox1 = new CheckBox();
            lblBienvenue = new Label();
            flpNavbarre = new FlowLayoutPanel();
            picUndergroudLogo = new PictureBox();
            lblTUBAPP = new Label();
            picIconeContact = new PictureBox();
            flpNavbarre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUndergroudLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btn_Connecter
            // 
            resources.ApplyResources(btn_Connecter, "btn_Connecter");
            btn_Connecter.Name = "btn_Connecter";
            btn_Connecter.UseVisualStyleBackColor = true;
            btn_Connecter.Click += btn_Connecter_Click;
            // 
            // Btn_Retour
            // 
            resources.ApplyResources(Btn_Retour, "Btn_Retour");
            Btn_Retour.Name = "Btn_Retour";
            Btn_Retour.UseVisualStyleBackColor = true;
            // 
            // txtConfirmMDP
            // 
            resources.ApplyResources(txtConfirmMDP, "txtConfirmMDP");
            txtConfirmMDP.Name = "txtConfirmMDP";
            // 
            // txtMDP
            // 
            resources.ApplyResources(txtMDP, "txtMDP");
            txtMDP.Name = "txtMDP";
            // 
            // txtAdresseMail
            // 
            resources.ApplyResources(txtAdresseMail, "txtAdresseMail");
            txtAdresseMail.Name = "txtAdresseMail";
            // 
            // checkBox1
            // 
            resources.ApplyResources(checkBox1, "checkBox1");
            checkBox1.Name = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblBienvenue
            // 
            resources.ApplyResources(lblBienvenue, "lblBienvenue");
            lblBienvenue.Name = "lblBienvenue";
            // 
            // flpNavbarre
            // 
            flpNavbarre.BackColor = Color.FromArgb(234, 99, 93);
            flpNavbarre.Controls.Add(picUndergroudLogo);
            flpNavbarre.Controls.Add(lblTUBAPP);
            flpNavbarre.Controls.Add(picIconeContact);
            resources.ApplyResources(flpNavbarre, "flpNavbarre");
            flpNavbarre.Name = "flpNavbarre";
            // 
            // picUndergroudLogo
            // 
            resources.ApplyResources(picUndergroudLogo, "picUndergroudLogo");
            picUndergroudLogo.Name = "picUndergroudLogo";
            picUndergroudLogo.TabStop = false;
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
            // frmNouvelUtilisateur
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_Connecter);
            Controls.Add(Btn_Retour);
            Controls.Add(txtConfirmMDP);
            Controls.Add(txtMDP);
            Controls.Add(txtAdresseMail);
            Controls.Add(checkBox1);
            Controls.Add(lblBienvenue);
            Controls.Add(flpNavbarre);
            Controls.Add(button2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNouvelUtilisateur";
            flpNavbarre.ResumeLayout(false);
            flpNavbarre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUndergroudLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button btn_Connecter;
        private Button Btn_Retour;
        private TextBox txtConfirmMDP;
        private TextBox txtMDP;
        private TextBox txtAdresseMail;
        private CheckBox checkBox1;
        private Label lblBienvenue;
        private FlowLayoutPanel flpNavbarre;
        private PictureBox picUndergroudLogo;
        private Label lblTUBAPP;
        private PictureBox picIconeContact;
    }
}