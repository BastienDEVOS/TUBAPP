using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;

namespace TUBAPP
{
    public static class ClassUtilitaire
    {
        public static readonly Dictionary<string, Color> CouleursConnues = new Dictionary<string, Color>(StringComparer.OrdinalIgnoreCase)
        {
        { "rouge", Color.Red },
        { "marron", Color.Brown },
        { "jaune", Color.Gold },
        { "vert", Color.Green },
        { "bleu", Color.Blue },
        { "orange", Color.Orange },
        { "violet", Color.Purple },
        { "rose", Color.Pink },
        { "noir", Color.Black },
        { "gris", Color.Gray },
        { "blanc", Color.White },
        { "cyan", Color.Cyan },
        { "turquoise", Color.Turquoise },
        { "argent", Color.Silver },
        { "or", Color.Goldenrod }
    };

        public static Color ConvertirNomCouleur(string nom)
        {
            if (CouleursConnues.TryGetValue(nom, out Color couleur))
                return couleur;

            return Color.Gray; // couleur par défaut si inconnue
        }

        public static void ConfigurerComboBoxLignes(ComboBox comboBox)
        {
            comboBox.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.DrawItem += (s, e) =>
            {
                e.DrawBackground();

                // Index -1 = zone de sélection quand la ComboBox est fermée
                if (e.Index < 0)
                {
                    // Si un élément est sélectionné, on récupère son index
                    if (comboBox.SelectedIndex >= 0)
                    {
                        var item = (Classes.ComboBoxItem)comboBox.Items[comboBox.SelectedIndex];
                        DessinerItem(e, item, comboBox);
                    }
                    else
                    {
                        // pas d'item sélectionné, on peut afficher un texte vide ou placeholder
                        using (Brush textBrush = new SolidBrush(e.ForeColor))
                        {
                            e.Graphics.DrawString("Sélectionnez une ligne", e.Font, textBrush, e.Bounds.Left + 4, e.Bounds.Top + 2);
                        }
                    }
                }
                else
                {
                    var item = (Classes.ComboBoxItem)comboBox.Items[e.Index];
                    DessinerItem(e, item, comboBox);
                }

                e.DrawFocusRectangle();
            };
        }

        private static void DessinerItem(DrawItemEventArgs e, Classes.ComboBoxItem item, ComboBox comboBox)
        {
            Graphics g = e.Graphics;

            bool dessinerCercle = item.Color != Color.Empty;
            int circleDiameter = e.Bounds.Height - 6;
            int circleX = e.Bounds.Right - circleDiameter - 4;
            int circleY = e.Bounds.Top + (e.Bounds.Height - circleDiameter) / 2;

            if (dessinerCercle)
            {
                using (Brush brush = new SolidBrush(item.Color))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.FillEllipse(brush, circleX, circleY, circleDiameter, circleDiameter);
                    g.DrawEllipse(Pens.Black, circleX, circleY, circleDiameter, circleDiameter);
                }
            }

            using (Brush textBrush = new SolidBrush(e.ForeColor))
            {
                Rectangle textRect;
                if (dessinerCercle)
                    textRect = new Rectangle(e.Bounds.Left + 4, e.Bounds.Top, circleX - e.Bounds.Left - 8, e.Bounds.Height);
                else
                    textRect = new Rectangle(e.Bounds.Left + 4, e.Bounds.Top, e.Bounds.Width - 8, e.Bounds.Height);

                g.DrawString(item.Text, e.Font, textBrush, textRect);
            }
        }
    }
}
