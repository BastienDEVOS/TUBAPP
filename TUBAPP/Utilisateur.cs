using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUBAPP
{
    public class Utilisateur
    {
        public string? Nom { get; set; }
        public string? Prenom { get; set; }
        public string? Email { get; set; }
        public bool EstAdmin { get; set; }
        public bool EstInvite { get; private set; }
        public Utilisateur(bool estInvite = false)
        {
            EstInvite = estInvite;
        }
        public Utilisateur() { }
        public DateTime? DateNaissance { get; set; } // Added this property
    }
}
