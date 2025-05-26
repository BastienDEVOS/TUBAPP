using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUBAPP
{
    public static class ClassUtilitaire
    {
        public static void MettreBordArrondis(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            Rectangle bounds = control.ClientRectangle;
            int diameter = radius * 2;

            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90); // Haut-gauche
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90); // Haut-droit
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90); // Bas-droit
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90); // Bas-gauche
            path.CloseFigure();

            control.Region = new Region(path);
        }
    }
}
