namespace Classes
{
    public class Station
    {
        //Propriétés de la classe Station
        private int _idStation;
        private string _nom;
        private string _zone;
        private bool _accessibilite;
        private bool Correspondance;

        //Constructeur de la classe Station
        public Station(int idStation, string nom, string zone, bool accessibilite, bool correspondance)
        {
            _idStation = idStation;
            _nom = nom;
            _zone = zone;
            _accessibilite = accessibilite;
            Correspondance = correspondance;
        }

        //Accesseurs
        public int IdStation
        {
            get { return _idStation; }
            set { _idStation = value; }
        }
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public string Zone
        {
            get { return _zone; }
            set { _zone = value; }
        }

        public bool Accessibilite
        {
            get { return _accessibilite; }
            set { _accessibilite = value; }
        }

        public bool CorrespondanceStation
        {
            get { return Correspondance; }
            set { Correspondance = value; }
        }

        //Méthode 
    }
}
