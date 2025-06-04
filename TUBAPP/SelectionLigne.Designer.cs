namespace TUBAPP
{
    partial class frmSelectionLigne
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
            panelHeader = new Panel();
            picLogo = new PictureBox();
            lblAppName = new Label();
            btnProfil = new PictureBox();
            lblTitre = new Label();
            panelMain = new Panel();
            lblStations = new Label();
            panelHoraire = new Panel();
            dtpDepartureTime = new DateTimePicker();
            lblHoraire = new Label();
            lstTrajets = new ListView();
            Ligne = new ColumnHeader();
            HeureDepart = new ColumnHeader();
            HeureArrive = new ColumnHeader();
            Durre = new ColumnHeader();
            btnRetour = new Button();
            colLigne = new ColumnHeader();
            colDuree = new ColumnHeader();
            panelNav = new Panel();
            btnCarte = new PictureBox();
            btnAccueil = new PictureBox();
            btnReseau = new PictureBox();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnProfil).BeginInit();
            panelMain.SuspendLayout();
            panelHoraire.SuspendLayout();
            panelNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCarte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAccueil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnReseau).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(236, 99, 92);
            panelHeader.Controls.Add(picLogo);
            panelHeader.Controls.Add(lblAppName);
            panelHeader.Controls.Add(btnProfil);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(2, 2, 2, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(449, 95);
            panelHeader.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(2, 2);
            picLogo.Margin = new Padding(2, 2, 2, 2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(91, 93);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(144, 26);
            lblAppName.Margin = new Padding(2, 0, 2, 0);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(189, 57);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "TUBAPP";
            // 
            // btnProfil
            // 
            btnProfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnProfil.Cursor = Cursors.Hand;
            btnProfil.Image = Properties.Resources.icone_profil;
            btnProfil.Location = new Point(350, 4);
            btnProfil.Margin = new Padding(2, 2, 2, 2);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(63, 91);
            btnProfil.SizeMode = PictureBoxSizeMode.Zoom;
            btnProfil.TabIndex = 2;
            btnProfil.TabStop = false;
            btnProfil.Click += btnProfil_Click;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitre.ForeColor = Color.FromArgb(33, 150, 243);
            lblTitre.Location = new Point(120, 23);
            lblTitre.Margin = new Padding(2, 0, 2, 0);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(242, 100);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Sélectionnez\nvotre ligne";
            lblTitre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(lblTitre);
            panelMain.Controls.Add(lblStations);
            panelMain.Controls.Add(panelHoraire);
            panelMain.Controls.Add(lstTrajets);
            panelMain.Controls.Add(btnRetour);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 95);
            panelMain.Margin = new Padding(2, 2, 2, 2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(449, 499);
            panelMain.TabIndex = 1;
            // 
            // lblStations
            // 
            lblStations.AutoEllipsis = true;
            lblStations.BackColor = Color.FromArgb(236, 99, 92);
            lblStations.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblStations.Location = new Point(30, 136);
            lblStations.Margin = new Padding(2, 0, 2, 0);
            lblStations.Name = "lblStations";
            lblStations.Size = new Size(258, 54);
            lblStations.TabIndex = 1;
            lblStations.Text = "Station 1 - Station 2";
            lblStations.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelHoraire
            // 
            panelHoraire.BackColor = Color.FromArgb(236, 99, 92);
            panelHoraire.Controls.Add(dtpDepartureTime);
            panelHoraire.Controls.Add(lblHoraire);
            panelHoraire.Location = new Point(296, 136);
            panelHoraire.Margin = new Padding(2, 2, 2, 2);
            panelHoraire.Name = "panelHoraire";
            panelHoraire.Size = new Size(123, 54);
            panelHoraire.TabIndex = 2;
            // 
            // dtpDepartureTime
            // 
            dtpDepartureTime.CustomFormat = "HH:mm";
            dtpDepartureTime.Format = DateTimePickerFormat.Custom;
            dtpDepartureTime.Location = new Point(0, 29);
            dtpDepartureTime.Margin = new Padding(2, 2, 2, 2);
            dtpDepartureTime.Name = "dtpDepartureTime";
            dtpDepartureTime.Size = new Size(123, 27);
            dtpDepartureTime.TabIndex = 1;
            // 
            // lblHoraire
            // 
            lblHoraire.AutoSize = true;
            lblHoraire.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHoraire.Location = new Point(0, 0);
            lblHoraire.Margin = new Padding(2, 0, 2, 0);
            lblHoraire.Name = "lblHoraire";
            lblHoraire.Size = new Size(94, 28);
            lblHoraire.TabIndex = 0;
            lblHoraire.Text = "Horaire :";
            // 
            // lstTrajets
            // 
            lstTrajets.BackColor = Color.FromArgb(236, 99, 92);
            lstTrajets.BorderStyle = BorderStyle.None;
            lstTrajets.Columns.AddRange(new ColumnHeader[] { Ligne, HeureDepart, HeureArrive, Durre });
            lstTrajets.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lstTrajets.FullRowSelect = true;
            lstTrajets.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lstTrajets.Location = new Point(30, 192);
            lstTrajets.Margin = new Padding(2, 2, 2, 2);
            lstTrajets.Name = "lstTrajets";
            lstTrajets.Size = new Size(389, 240);
            lstTrajets.TabIndex = 3;
            lstTrajets.UseCompatibleStateImageBehavior = false;
            lstTrajets.View = View.Details;
            lstTrajets.DrawColumnHeader += lstTrajets_DrawColumnHeader;
            lstTrajets.DrawItem += lstTrajets_DrawItem;
            lstTrajets.DrawSubItem += lstTrajets_DrawSubItem;
            // 
            // Ligne
            // 
            Ligne.Text = "Ligne";
            Ligne.Width = 105;
            // 
            // HeureDepart
            // 
            HeureDepart.Text = "Depart";
            HeureDepart.Width = 105;
            // 
            // HeureArrive
            // 
            HeureArrive.Text = "Arrive";
            HeureArrive.Width = 105;
            // 
            // Durre
            // 
            Durre.Text = "Durre";
            Durre.Width = 105;
            // 
            // btnRetour
            // 
            btnRetour.BackColor = Color.FromArgb(236, 99, 92);
            btnRetour.FlatStyle = FlatStyle.Flat;
            btnRetour.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnRetour.ForeColor = Color.White;
            btnRetour.Location = new Point(126, 437);
            btnRetour.Margin = new Padding(2, 2, 2, 2);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(224, 48);
            btnRetour.TabIndex = 4;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = false;
            btnRetour.Click += btnRetour_Click;
            // 
            // colLigne
            // 
            colLigne.Width = 280;
            // 
            // colDuree
            // 
            colDuree.Width = 120;
            // 
            // panelNav
            // 
            panelNav.BackColor = Color.FromArgb(236, 99, 92);
            panelNav.Controls.Add(btnCarte);
            panelNav.Controls.Add(btnAccueil);
            panelNav.Controls.Add(btnReseau);
            panelNav.Dock = DockStyle.Bottom;
            panelNav.Location = new Point(0, 594);
            panelNav.Margin = new Padding(2, 2, 2, 2);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(449, 65);
            panelNav.TabIndex = 2;
            // 
            // btnCarte
            // 
            btnCarte.Cursor = Cursors.Hand;
            btnCarte.Image = Properties.Resources.GPS;
            btnCarte.Location = new Point(70, 5);
            btnCarte.Margin = new Padding(2, 2, 2, 2);
            btnCarte.Name = "btnCarte";
            btnCarte.Size = new Size(45, 56);
            btnCarte.SizeMode = PictureBoxSizeMode.Zoom;
            btnCarte.TabIndex = 0;
            btnCarte.TabStop = false;
            btnCarte.Click += btnCarte_Click;
            // 
            // btnAccueil
            // 
            btnAccueil.Cursor = Cursors.Hand;
            btnAccueil.Image = Properties.Resources.homepng;
            btnAccueil.Location = new Point(186, 0);
            btnAccueil.Margin = new Padding(2, 2, 2, 2);
            btnAccueil.Name = "btnAccueil";
            btnAccueil.Size = new Size(79, 65);
            btnAccueil.SizeMode = PictureBoxSizeMode.Zoom;
            btnAccueil.TabIndex = 1;
            btnAccueil.TabStop = false;
            btnAccueil.Click += btnAccueil_Click;
            // 
            // btnReseau
            // 
            btnReseau.Cursor = Cursors.Hand;
            btnReseau.Image = Properties.Resources.network;
            btnReseau.Location = new Point(330, 3);
            btnReseau.Margin = new Padding(2, 2, 2, 2);
            btnReseau.Name = "btnReseau";
            btnReseau.Size = new Size(59, 58);
            btnReseau.SizeMode = PictureBoxSizeMode.Zoom;
            btnReseau.TabIndex = 2;
            btnReseau.TabStop = false;
            btnReseau.Click += btnReseau_Click;
            // 
            // frmSelectionLigne
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 659);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Controls.Add(panelNav);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSelectionLigne";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TUBAPP - Sélection Ligne";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnProfil).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelHoraire.ResumeLayout(false);
            panelHoraire.PerformLayout();
            panelNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCarte).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAccueil).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnReseau).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.PictureBox btnProfil;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblStations;
        private System.Windows.Forms.Panel panelHoraire;
        private System.Windows.Forms.Label lblHoraire;
        private System.Windows.Forms.ListView lstTrajets;
        private System.Windows.Forms.ColumnHeader colLigne;
        private System.Windows.Forms.ColumnHeader colDuree;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.PictureBox btnCarte;
        private System.Windows.Forms.PictureBox btnAccueil;
        private System.Windows.Forms.PictureBox btnReseau;
        private DateTimePicker dtpDepartureTime;
        private ColumnHeader Ligne;
        private ColumnHeader Durre;
        private ColumnHeader HeureDepart;
        private ColumnHeader HeureArrive;
    }
}
