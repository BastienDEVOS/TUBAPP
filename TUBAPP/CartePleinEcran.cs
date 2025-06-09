using System;
using System.Drawing;
using System.Windows.Forms;

namespace TUBAPP
{
    public partial class CartePleinEcran : Form
    {
        private const float zoomStep = 0.1f;
        private float zoomFactor = 1.0f;

        private bool isDragging = false;
        private Point mouseStart;
        private Point imageStart;

        public CartePleinEcran(Form formAppelant)
        {
            InitializeComponent();

            PicBoxCartePleineEcran.SizeMode = PictureBoxSizeMode.Zoom;
            PicBoxCartePleineEcran.Dock = DockStyle.None;

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.Size = formAppelant.Size;
            this.Location = formAppelant.Location;

            PicBoxCartePleineEcran.Size = this.ClientSize;
            PicBoxCartePleineEcran.Location = new Point(0, 0);


           

            this.MouseWheel += CartePleinEcran_MouseWheel;

        }

        private void CartePleinEcran_MouseWheel(object sender, MouseEventArgs e)
        {
            if (PicBoxCartePleineEcran.Image == null)
                return;

            // dimensions de l'image actuelle
            int oldWidth = PicBoxCartePleineEcran.Width;
            int oldHeight = PicBoxCartePleineEcran.Height;

            // Position du curseur par rapport à l'image
            Point mousePos = e.Location;
            int relX = mousePos.X - PicBoxCartePleineEcran.Left;
            int relY = mousePos.Y - PicBoxCartePleineEcran.Top;
            float ratioX = (float)relX / oldWidth;
            float ratioY = (float)relY / oldHeight;

            // Zoom Avant / Zoom Arrière
            if (e.Delta > 0)
                zoomFactor += zoomStep;
            else if (e.Delta < 0 && zoomFactor > 1.0f)
                zoomFactor -= zoomStep;

            // Nouvelle taille
            int newWidth = (int)(this.ClientSize.Width * zoomFactor);
            int newHeight = (int)(this.ClientSize.Height * zoomFactor);
            PicBoxCartePleineEcran.Size = new Size(newWidth, newHeight);

            // Centrage par rapport à la souris
            int newLeft = mousePos.X - (int)(ratioX * newWidth);
            int newTop = mousePos.Y - (int)(ratioY * newHeight);
            PicBoxCartePleineEcran.Location = new Point(newLeft, newTop);

            // Si zoom à 1.0, on recentre
            if (zoomFactor <= 1.0f)
            {
                zoomFactor = 1.0f;
                PicBoxCartePleineEcran.Size = this.ClientSize;
                PicBoxCartePleineEcran.Location = new Point(0, 0);
            }
        }

        private void PicBoxCartePleineEcran_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && zoomFactor > 1.0f)
            {
                isDragging = true;
                mouseStart = e.Location;
                imageStart = PicBoxCartePleineEcran.Location;
                PicBoxCartePleineEcran.Cursor = Cursors.SizeAll;
            }
        }

        private void PicBoxCartePleineEcran_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int dx = e.X - mouseStart.X;
                int dy = e.Y - mouseStart.Y;

                PicBoxCartePleineEcran.Location = new Point(imageStart.X + dx, imageStart.Y + dy);
            }
        }

        private void PicBoxCartePleineEcran_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
                PicBoxCartePleineEcran.Cursor = Cursors.Default;
            }
        }

        private void PicBoxCartePleineEcran_Click(object sender, EventArgs e)
        {

        }

        private void BtnQuitter_click(object sender, EventArgs e)
        {
            this.Close();
            PageCarte page = new PageCarte();
            page.Show();

        }
    }
}
