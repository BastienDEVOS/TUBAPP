using System.Runtime;
using System.Windows.Forms;

namespace TUBAPP
{
    partial class PageProfilInviter
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageProfilInviter));
            picIconeContact = new PictureBox();
            lblTitre = new Label();
            pnlCard = new Panel();
            lblInvite = new Label();
            btnCreerCompte = new Button();
            btnSeConnecter = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            BtnHome = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picIconeContact).BeginInit();
            pnlCard.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // picIconeContact
            // 
            picIconeContact.Image = Properties.Resources.IconeProfilSelectionner;
            picIconeContact.Location = new Point(437, 5);
            picIconeContact.Margin = new Padding(4, 5, 4, 5);
            picIconeContact.Name = "picIconeContact";
            picIconeContact.Size = new Size(79, 114);
            picIconeContact.SizeMode = PictureBoxSizeMode.Zoom;
            picIconeContact.TabIndex = 2;
            picIconeContact.TabStop = false;
            picIconeContact.Click += picIconeContact_Click;
            // 
            // lblTitre
            // 
            lblTitre.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitre.Location = new Point(133, 133);
            lblTitre.Margin = new Padding(4, 0, 4, 0);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(306, 66);
            lblTitre.TabIndex = 1;
            lblTitre.Text = "Votre profil";
            lblTitre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCard.Controls.Add(lblInvite);
            pnlCard.Location = new Point(80, 204);
            pnlCard.Margin = new Padding(4, 5, 4, 5);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(391, 332);
            pnlCard.TabIndex = 2;
            // 
            // lblInvite
            // 
            lblInvite.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblInvite.ForeColor = Color.FromArgb(0, 192, 192);
            lblInvite.Location = new Point(52, 70);
            lblInvite.Margin = new Padding(4, 0, 4, 0);
            lblInvite.Name = "lblInvite";
            lblInvite.Size = new Size(278, 60);
            lblInvite.TabIndex = 0;
            lblInvite.Text = "INVITER";
            lblInvite.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCreerCompte
            // 
            btnCreerCompte.BackColor = Color.FromArgb(209, 66, 54);
            btnCreerCompte.FlatStyle = FlatStyle.Flat;
            btnCreerCompte.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCreerCompte.ForeColor = Color.White;
            btnCreerCompte.Location = new Point(80, 568);
            btnCreerCompte.Margin = new Padding(4, 5, 4, 5);
            btnCreerCompte.Name = "btnCreerCompte";
            btnCreerCompte.Size = new Size(391, 66);
            btnCreerCompte.TabIndex = 3;
            btnCreerCompte.Text = "Créer un compte";
            btnCreerCompte.UseVisualStyleBackColor = false;
            // 
            // btnSeConnecter
            // 
            btnSeConnecter.BackColor = Color.FromArgb(209, 66, 54);
            btnSeConnecter.FlatStyle = FlatStyle.Flat;
            btnSeConnecter.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSeConnecter.ForeColor = Color.White;
            btnSeConnecter.Location = new Point(80, 656);
            btnSeConnecter.Margin = new Padding(4, 5, 4, 5);
            btnSeConnecter.Name = "btnSeConnecter";
            btnSeConnecter.Size = new Size(391, 66);
            btnSeConnecter.TabIndex = 4;
            btnSeConnecter.Text = "Se connecter";
            btnSeConnecter.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(234, 99, 93);
            flowLayoutPanel1.Controls.Add(pictureBox3);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(picIconeContact);
            flowLayoutPanel1.Controls.Add(pictureBox4);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(558, 119);
            flowLayoutPanel1.TabIndex = 17;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.logo1;
            pictureBox3.ImeMode = ImeMode.NoControl;
            pictureBox3.Location = new Point(2, 2);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(114, 116);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(164, 28);
            label1.Margin = new Padding(46, 0, 46, 0);
            label1.Name = "label1";
            label1.Size = new Size(223, 67);
            label1.TabIndex = 0;
            label1.Text = "TUBAPP";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icone_profil;
            pictureBox4.ImeMode = ImeMode.NoControl;
            pictureBox4.Location = new Point(0, 124);
            pictureBox4.Margin = new Padding(0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(116, 116);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(234, 99, 93);
            flowLayoutPanel2.Controls.Add(pictureBox1);
            flowLayoutPanel2.Controls.Add(BtnHome);
            flowLayoutPanel2.Controls.Add(pictureBox5);
            flowLayoutPanel2.Location = new Point(0, 744);
            flowLayoutPanel2.Margin = new Padding(2);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(558, 81);
            flowLayoutPanel2.TabIndex = 23;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.GPS;
            pictureBox1.Location = new Point(88, 6);
            pictureBox1.Margin = new Padding(88, 0, 19, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // BtnHome
            // 
            BtnHome.Image = Properties.Resources.homepng;
            BtnHome.Location = new Point(232, 0);
            BtnHome.Margin = new Padding(69, 0, 44, 0);
            BtnHome.Name = "BtnHome";
            BtnHome.Size = new Size(99, 81);
            BtnHome.SizeMode = PictureBoxSizeMode.Zoom;
            BtnHome.TabIndex = 3;
            BtnHome.TabStop = false;
            BtnHome.Click += pictureBox2_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.network;
            pictureBox5.Location = new Point(413, 4);
            pictureBox5.Margin = new Padding(38, 4, 19, 6);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(74, 72);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // PageProfilInviter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(558, 824);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnSeConnecter);
            Controls.Add(btnCreerCompte);
            Controls.Add(pnlCard);
            Controls.Add(lblTitre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PageProfilInviter";
            StartPosition = FormStartPosition.CenterScreen;
            Load += PageCompte_Load_1;
            ((System.ComponentModel.ISupportInitialize)picIconeContact).EndInit();
            pnlCard.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        // Helper for rounded corners
        internal static class NativeMethods
        {
            [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
            public static extern IntPtr CreateRoundRectRgn(
                int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        }

#endregion
        private System.Windows.Forms.PictureBox picIconeContact;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblInvite;
        private System.Windows.Forms.Button btnCreerCompte;
        private System.Windows.Forms.Button btnSeConnecter;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBox4;
        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox1;
        private PictureBox BtnHome;
        private PictureBox pictureBox5;
    }
}
