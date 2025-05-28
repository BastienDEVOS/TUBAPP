using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Trajet
    {
        private int _idLigne;
        private int _idStationDepart;
        private int _idStationArrivee;
        private string TempsTrajet;

        public Trajet(int idLigne, int idStationDepart, int idStationArrivee, string tempsTrajet)
        {
            _idLigne = idLigne;
            _idStationDepart = idStationDepart;
            _idStationArrivee = idStationArrivee;
            TempsTrajet = tempsTrajet;
        }

        public Trajet()
        {
        }

        public int IdLigne
        {
            get { return _idLigne; }
            set { _idLigne = value; }
        }
        public int IdStationDepart
        {
            get { return _idStationDepart; }
            set { _idStationDepart = value; }
        }
        public int IdStationArrivee
        {
            get { return _idStationArrivee; }
            set { _idStationArrivee = value; }
        }
        public string TempsTrajets
        {
            get { return TempsTrajet; }
            set { TempsTrajet = value; }
        }
        
        //Methode
        public override string ToString()
        {
            return $"Ligne {IdLigne} : de Station {IdStationDepart} à {IdStationArrivee})";
        }
    }
}
