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
            flpNavbarre = new FlowLayoutPanel();
            picUndergroudLogo = new PictureBox();
            lblTUBAPP = new Label();
            picIconeContact = new PictureBox();
            lblBienvenue = new Label();
            button1 = new Button();
            button2 = new Button();
            checkBox1 = new CheckBox();
            txtAdresseMail = new TextBox();
            txtMDP = new TextBox();
            txtConfirmMDP = new TextBox();
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
            flpNavbarre.TabIndex = 6;
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
            lblBienvenue.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblBienvenue.Location = new Point(34, 269);
            lblBienvenue.Name = "lblBienvenue";
            lblBienvenue.Size = new Size(656, 93);
            lblBienvenue.TabIndex = 7;
            lblBienvenue.Text = "Nouvel Uitilisateur";
            // 
            // button1
            // 
            button1.Location = new Point(270, 1003);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(292, 1145);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 9;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(34, 734);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(159, 36);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtAdresseMail
            // 
            txtAdresseMail.Font = new Font("Segoe UI", 15F);
            txtAdresseMail.Location = new Point(34, 447);
            txtAdresseMail.Name = "txtAdresseMail";
            txtAdresseMail.PlaceholderText = "Adresse mail";
            txtAdresseMail.Size = new Size(656, 61);
            txtAdresseMail.TabIndex = 11;
            // 
            // txtMDP
            // 
            txtMDP.Font = new Font("Segoe UI", 15F);
            txtMDP.Location = new Point(34, 545);
            txtMDP.Name = "txtMDP";
            txtMDP.PlaceholderText = "Mot de passe";
            txtMDP.Size = new Size(656, 61);
            txtMDP.TabIndex = 12;
            // 
            // txtConfirmMDP
            // 
            txtConfirmMDP.Font = new Font("Segoe UI", 15F);
            txtConfirmMDP.Location = new Point(34, 643);
            txtConfirmMDP.Name = "txtConfirmMDP";
            txtConfirmMDP.PlaceholderText = "Confirmer le mot de passe";
            txtConfirmMDP.Size = new Size(656, 61);
            txtConfirmMDP.TabIndex = 13;
            // 
            // frmNouvelUtilisateur
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 1429);
            Controls.Add(txtConfirmMDP);
            Controls.Add(txtMDP);
            Controls.Add(txtAdresseMail);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblBienvenue);
            Controls.Add(flpNavbarre);
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

        private FlowLayoutPanel flpNavbarre;
        private PictureBox picUndergroudLogo;
        private Label lblTUBAPP;
        private PictureBox picIconeContact;
        private Label lblBienvenue;
        private Button button1;
        private Button button2;
        private CheckBox checkBox1;
        private TextBox txtAdresseMail;
        private TextBox txtMDP;
        private TextBox txtConfirmMDP;
    }
}