using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Desservie
    {
        //propriétés de la classe Desservie
        private int _idLigne;
        private int _idStation;

        //Constructeur de la classe Desservie
        public Desservie(int idLigne, int idStation)
        {
            _idLigne = idLigne;
            _idStation = idStation;
        }

        public Desservie()
        {
        }

        //Accesseurs de la classe Desservie
        public int IdLigne
        {
            get { return _idLigne; }
            set { _idLigne = value; }
        }
        public int IdStation
        {
            get { return _idStation; }
            set { _idStation = value; }
        }

        //Méthode
    }
}
