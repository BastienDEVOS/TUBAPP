using System;
using System.Diagnostics.CodeAnalysis;
using MySql.Data.MySqlClient;
using Classes;
using Google.Protobuf.WellKnownTypes;
using Mysqlx.Crud;
using System.Data;

namespace TUBAPP
{
    public static class BD
    {
        private static MySqlConnection? Conn;
        public static bool Connection()
        {
            string serveur = "10.1.139.236";
            string login = "c2";
            string mdp = "mdp";
            string bd = "basec2";
            string chaineConnexion = $"server={serveur};uid ={login};pwd={mdp};database={bd}";
            Conn = new MySqlConnection(chaineConnexion);
            try
            {
                Conn.Open();
                Console.WriteLine("Connection réussi");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur de connection");
                return false;
            }
        }

        public static bool Deconecter()
        {
            try
            {
                if (Conn?.State == System.Data.ConnectionState.Open)
                {
                    Conn.Close();
                    Conn.Dispose();
                    Console.WriteLine("Déconection réussi");
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur de déconnexion");
                return false;
            }
        }

        /// <summary>
        /// Gets the current open connection, or opens it if needed.
        /// </summary>
        public static MySqlConnection GetConnection()
        {
            if (Conn == null || Conn.State != System.Data.ConnectionState.Open)
            {
                if (!Connection())
                    throw new InvalidOperationException("Unable to open database connection.");
            }
            return Conn!;
        }

        /// <summary>
        /// Ajoute une station à la base de données.
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Nom"></param>
        /// <param name="Zone"></param>
        /// <param name="Accessibilite"></param>
        /// <param name="Correspondance"></param>
        public static void AjoutStationBase(int Id, string Nom, string Zone, bool Accessibilite, bool Correspondance)
        {
            string reSQL = $"INSERT INTO Station(NomStation, Zone, Correspondance, Accessibilite) VALUES ({Id}, '{Nom}', '{Zone}', {Accessibilite}, {Correspondance})";
            MySqlCommand cmd = new MySqlCommand(reSQL, Conn);
            cmd.ExecuteNonQuery();
        }

        public static List<Station> GetStation()
        {
            List<Station> stations = new List<Station>();
            string reSQL = "SELECT * FROM Station";

            MySqlConnection conn = GetConnection();

            if (conn == null)
                throw new InvalidOperationException("Connexion non initialisée. Appelle BD.Connection() avant.");

            if (conn.State != ConnectionState.Open)
                conn.Open(); 

            MySqlCommand cmd = new MySqlCommand(reSQL, Conn);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Station s = new Station
                    {
                        IdStation = reader.GetInt32("IdStation"),
                        Nom = reader.GetString("NomStation"),
                        Zone = reader.GetString("Zone"),
                        Accessibilite = reader.GetBoolean("Accessibilite"),
                        CorrespondanceStation = reader.GetBoolean("Correspondance")
                    };
                    stations.Add(s);
                }
            }
            return stations;
        }

        public static List<Ligne> GetLigne()
        {
            List<Ligne> lignes = new List<Ligne>();
            string reSQL = "SELECT * FROM Ligne";
            MySqlCommand cmd = new MySqlCommand(reSQL, Conn);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Ligne l = new Ligne
                    {
                        IdLigne = reader.GetInt32("IdLigne"),
                        Nom = reader.GetString("NomLigne"),
                        Couleur = reader.GetString("Couleur"),
                        Longueur = reader.GetInt32("Longueur"),
                        Status = reader.GetString("Statuts"),
                        Frequence = reader.GetTimeSpan("Frequence").ToString(@"hh\:mm"),
                        HeureFin = reader.GetTimeSpan("HeureFin").ToString(@"hh\:mm"),
                        HeureDebut = reader.GetTimeSpan("HeureDebut").ToString(@"hh\:mm"),
                    };
                    lignes.Add(l);
                }
            }
            return lignes;
        }

        public static List<Trajet> GetTrajet()
        {
            List<Trajet> trajets = new List<Trajet>();

            string reSQL = "SELECT * FROM Trajet";
            MySqlCommand cmd = new MySqlCommand(reSQL, Conn);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Trajet t = new Trajet
                    {
                        IdLigne = reader.GetInt32("IdLigne"),
                        IdStationDepart = reader.GetInt32("IdStation"),
                        IdStationArrivee = reader.GetInt32("IdStation_1"),
                        TempsTrajets = reader.GetTimeSpan("TempsTrajet").ToString(@"hh\:mm"),
                    };

                    trajets.Add(t);
                }
            }

            return trajets;
        }
        public static Ligne? GetLigneById(int idLigne)
        {
            string reSQL = "SELECT * FROM Ligne WHERE IdLigne = @IdLigne";
            MySqlCommand cmd = new MySqlCommand(reSQL, Conn);
            cmd.Parameters.AddWithValue("@IdLigne", idLigne);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    return new Ligne
                    {
                        IdLigne = reader.GetInt32("IdLigne"),
                        Nom = reader.GetString("NomLigne"),
                        Couleur = reader.GetString("Couleur"),
                        Longueur = reader.GetInt32("Longueur"),
                        Status = reader.GetString("Statuts"),
                        Frequence = reader.GetTimeSpan("Frequence").ToString(@"hh\:mm"),
                        HeureFin = reader.GetTimeSpan("HeureFin").ToString(@"hh\:mm"),
                        HeureDebut = reader.GetTimeSpan("HeureDebut").ToString(@"hh\:mm"),
                    };
                }
            }
            return null;
        }
    }
}
