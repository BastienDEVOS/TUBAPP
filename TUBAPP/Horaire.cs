using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUBAPP
{
    public class Horaire
    {
        public int IdLigne { get; set; }
        public int IdStation { get; set; }
        public string Sens { get; set; } = string.Empty;
        public TimeSpan PassageTrain { get; set; }

        public Horaire() { }

        public Horaire(int idLigne, int idStation, string sens, TimeSpan passageTrain)
        {
            IdLigne = idLigne;
            IdStation = idStation;
            Sens = sens;
            PassageTrain = passageTrain;
        }

        public override string ToString()
        {
            return $"Ligne: {IdLigne}, Station: {IdStation}, Sens: {Sens}, Passage: {PassageTrain}";
        }
    }

}
