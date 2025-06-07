namespace TUBAPP
{
    partial class CartePleinEcran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartePleinEcran));
            PicBoxCartePleineEcran = new PictureBox();
            btnQuitter = new Button();
            ((System.ComponentModel.ISupportInitialize)PicBoxCartePleineEcran).BeginInit();
            SuspendLayout();
            // 
            // PicBoxCartePleineEcran
            // 
            PicBoxCartePleineEcran.Dock = DockStyle.Fill;
            PicBoxCartePleineEcran.Image = Properties.Resources.plan_metro_londres;
            PicBoxCartePleineEcran.Location = new Point(0, 0);
            PicBoxCartePleineEcran.Name = "PicBoxCartePleineEcran";
            PicBoxCartePleineEcran.Size = new Size(446, 659);
            PicBoxCartePleineEcran.SizeMode = PictureBoxSizeMode.Zoom;
            PicBoxCartePleineEcran.TabIndex = 55;
            PicBoxCartePleineEcran.TabStop = false;
            PicBoxCartePleineEcran.Click += PicBoxCartePleineEcran_Click;
            // 
            // btnQuitter
            // 
            btnQuitter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnQuitter.Location = new Point(352, 0);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(94, 29);
            btnQuitter.TabIndex = 56;
            btnQuitter.Text = "<>";
            btnQuitter.UseVisualStyleBackColor = true;
            // 
            // CartePleinEcran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 659);
            Controls.Add(btnQuitter);
            Controls.Add(PicBoxCartePleineEcran);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CartePleinEcran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CartePleinEcran";
            ((System.ComponentModel.ISupportInitialize)PicBoxCartePleineEcran).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox PicBoxCartePleineEcran;
        private Button btnQuitter;
    }
}