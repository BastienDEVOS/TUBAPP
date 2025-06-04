using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }   // peut être int, string, etc.
        public Color Color { get; set; }

        public override string ToString() => Text;
    }
}
