using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUBAPP
{
    class SessionManager
    {
        public static Utilisateur? CurrentUser { get; set; }

        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}
