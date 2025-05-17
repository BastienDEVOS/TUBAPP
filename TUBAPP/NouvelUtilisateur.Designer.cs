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
            ConditionUtilisation = new CheckBox();
            lblBienvenue = new Label();
            flpNavbarre = new FlowLayoutPanel();
            picUndergroudLogo = new PictureBox();
            lblTUBAPP = new Label();
            picIconeContact = new PictureBox();
            PopupCondition = new Panel();
            Refuser = new Button();
            Accepter = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            msg_erreurMail = new Label();
            msg_erreurMdp = new Label();
            flpNavbarre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUndergroudLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).BeginInit();
            PopupCondition.SuspendLayout();
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
            txtConfirmMDP.TextChanged += txtConfirmMDP_TextChanged;
            // 
            // txtMDP
            // 
            resources.ApplyResources(txtMDP, "txtMDP");
            txtMDP.Name = "txtMDP";
            txtMDP.TextChanged += txtMDP_TextChanged;
            // 
            // txtAdresseMail
            // 
            resources.ApplyResources(txtAdresseMail, "txtAdresseMail");
            txtAdresseMail.Name = "txtAdresseMail";
            txtAdresseMail.TextChanged += txtAdresseMail_TextChanged;
            // 
            // ConditionUtilisation
            // 
            resources.ApplyResources(ConditionUtilisation, "ConditionUtilisation");
            ConditionUtilisation.ForeColor = SystemColors.HotTrack;
            ConditionUtilisation.Name = "ConditionUtilisation";
            ConditionUtilisation.UseVisualStyleBackColor = true;
            ConditionUtilisation.CheckedChanged += ConditionUtilisation_CheckedChanged;
            ConditionUtilisation.Click += ConditionUtilisation_Click;
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
            // PopupCondition
            // 
            PopupCondition.BorderStyle = BorderStyle.Fixed3D;
            PopupCondition.Controls.Add(Refuser);
            PopupCondition.Controls.Add(Accepter);
            PopupCondition.Controls.Add(richTextBox1);
            PopupCondition.Controls.Add(label1);
            resources.ApplyResources(PopupCondition, "PopupCondition");
            PopupCondition.Name = "PopupCondition";
            // 
            // Refuser
            // 
            Refuser.BackColor = Color.Red;
            resources.ApplyResources(Refuser, "Refuser");
            Refuser.Name = "Refuser";
            Refuser.UseVisualStyleBackColor = false;
            Refuser.Click += Refuser_Click;
            // 
            // Accepter
            // 
            Accepter.BackColor = Color.Lime;
            resources.ApplyResources(Accepter, "Accepter");
            Accepter.Name = "Accepter";
            Accepter.UseVisualStyleBackColor = false;
            Accepter.Click += Accepter_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Red;
            richTextBox1.ForeColor = Color.White;
            resources.ApplyResources(richTextBox1, "richTextBox1");
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // msg_erreurMail
            // 
            resources.ApplyResources(msg_erreurMail, "msg_erreurMail");
            msg_erreurMail.BackColor = Color.Red;
            msg_erreurMail.Name = "msg_erreurMail";
            // 
            // msg_erreurMdp
            // 
            resources.ApplyResources(msg_erreurMdp, "msg_erreurMdp");
            msg_erreurMdp.BackColor = Color.Red;
            msg_erreurMdp.Name = "msg_erreurMdp";
            // 
            // frmNouvelUtilisateur
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PopupCondition);
            Controls.Add(btn_Connecter);
            Controls.Add(Btn_Retour);
            Controls.Add(txtConfirmMDP);
            Controls.Add(txtMDP);
            Controls.Add(txtAdresseMail);
            Controls.Add(ConditionUtilisation);
            Controls.Add(lblBienvenue);
            Controls.Add(flpNavbarre);
            Controls.Add(button2);
            Controls.Add(msg_erreurMail);
            Controls.Add(msg_erreurMdp);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNouvelUtilisateur";
            flpNavbarre.ResumeLayout(false);
            flpNavbarre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUndergroudLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).EndInit();
            PopupCondition.ResumeLayout(false);
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
        private CheckBox ConditionUtilisation;
        private Label lblBienvenue;
        private FlowLayoutPanel flpNavbarre;
        private PictureBox picUndergroudLogo;
        private Label lblTUBAPP;
        private PictureBox picIconeContact;
        private Panel PopupCondition;
        private Button Refuser;
        private Button Accepter;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label msg_erreurMail;
        private Label msg_erreurMdp;
    }
}