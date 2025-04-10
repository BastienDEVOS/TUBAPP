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
            picUndergroudLogo = new PictureBox();
            lblTUBAPP = new Label();
            picIconeContact = new PictureBox();
            flpNavbarre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUndergroudLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).BeginInit();
            SuspendLayout();
            // 
            // btnInvité
            // 
            btnInvité.BackColor = Color.FromArgb(209, 66, 54);
            btnInvité.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnInvité.ForeColor = Color.White;
            btnInvité.Location = new Point(82, 929);
            btnInvité.Name = "btnInvité";
            btnInvité.Size = new Size(561, 91);
            btnInvité.TabIndex = 0;
            btnInvité.Text = "Invité";
            btnInvité.UseVisualStyleBackColor = false;
            // 
            // btnNvCompt
            // 
            btnNvCompt.BackColor = Color.FromArgb(209, 66, 54);
            btnNvCompt.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnNvCompt.ForeColor = Color.White;
            btnNvCompt.Location = new Point(82, 757);
            btnNvCompt.Name = "btnNvCompt";
            btnNvCompt.Size = new Size(561, 91);
            btnNvCompt.TabIndex = 1;
            btnNvCompt.Text = "Nouveau compte";
            btnNvCompt.UseVisualStyleBackColor = false;
            // 
            // btnConnexion
            // 
            btnConnexion.BackColor = Color.FromArgb(209, 66, 54);
            btnConnexion.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnConnexion.ForeColor = Color.White;
            btnConnexion.Location = new Point(82, 569);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(561, 91);
            btnConnexion.TabIndex = 2;
            btnConnexion.Text = "Connexion";
            btnConnexion.UseVisualStyleBackColor = false;
            btnConnexion.Click += btnConnexion_Click;
            // 
            // lblBienvenue
            // 
            lblBienvenue.AutoSize = true;
            lblBienvenue.Font = new Font("Segoe UI", 34.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenue.Location = new Point(82, 269);
            lblBienvenue.Name = "lblBienvenue";
            lblBienvenue.Size = new Size(561, 124);
            lblBienvenue.TabIndex = 3;
            lblBienvenue.Text = "Bienvenue !";
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
            flpNavbarre.TabIndex = 4;
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
            // frmAcceuil
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 1429);
            Controls.Add(flpNavbarre);
            Controls.Add(lblBienvenue);
            Controls.Add(btnConnexion);
            Controls.Add(btnNvCompt);
            Controls.Add(btnInvité);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAcceuil";
            Text = "TUBAPP";
            flpNavbarre.ResumeLayout(false);
            flpNavbarre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUndergroudLogo).EndInit();
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
        private PictureBox picUndergroudLogo;
        private PictureBox picIconeContact;
    }
}
