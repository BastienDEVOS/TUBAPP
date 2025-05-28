namespace Classes
{
    public class Ligne
    {
        //propriétés de la classe Ligne
        private int _idLigne;
        private string _nom;
        private string _couleur;
        private int _Longueur;
        private string _Status;
        private string _frequence;
        private string _heurefin;
        private string _heuredebut;

        public Ligne(int idLigne, string nom, string couleur, int longueur, string status, string frequence, string heurefin, string heuredebut)
        {
            _idLigne = idLigne;
            _nom = nom;
            _couleur = couleur;
            _Longueur = longueur;
            _Status = status;
            _frequence = frequence;
            _heurefin = heurefin;
            _heuredebut = heuredebut;
        }

        public Ligne()
        {
        }

        //Accesseurs
        public int IdLigne
        {
            get { return _idLigne; }
            set { _idLigne = value; }
        }
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public string Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }
        public int Longueur
        {
            get { return _Longueur; }
            set { _Longueur = value; }
        }
        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public string Frequence
        {
            get { return _frequence; }
            set { _frequence = value; }
        }
        public string HeureFin
        {
            get { return _heurefin; }
            set { _heurefin = value; }
        }
        public string HeureDebut
        {
            get { return _heuredebut; }
            set { _heuredebut = value; }
        }

        //Methode
        public override string ToString()
        {
            return Nom;
        }
    }
}
