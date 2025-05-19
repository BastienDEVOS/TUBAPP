using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUBAPP
{
    internal class Utilisateur
    {
        public string? Nom { get; set; }
        public string? Prenom { get; set; }
        public string? Email { get; set; }
        public bool EstAdmin { get; set; }

        public bool EstInvite => string.IsNullOrEmpty(Nom);
    }
}
