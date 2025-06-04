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

        public static bool AuthentifierUtilisateur(string email, string password, MySqlConnection conn)
        {
            var cmd = new MySqlCommand(
                "SELECT COUNT(*) FROM Client WHERE MailClient = @Email AND MotDePasse = @Password", conn);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);

            int userCount = Convert.ToInt32(cmd.ExecuteScalar());

            if (userCount > 0)
            {
                var userCmd = new MySqlCommand(
                    "SELECT NomClient, PrenomClient, MailClient, DateNaissanceClient, StatutsClient FROM Client WHERE MailClient = @Email", conn);
                userCmd.Parameters.AddWithValue("@Email", email);

                using (var reader = userCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var user = new Utilisateur
                        {
                            Nom = reader["NomClient"].ToString(),
                            Prenom = reader["PrenomClient"].ToString(),
                            Email = reader["MailClient"].ToString(),
                            DateNaissance = reader["DateNaissanceClient"] as DateTime?,
                            EstAdmin = reader["StatutsClient"].ToString() == "Admin"
                        };

                        SessionManager.CurrentUser = user;
                        return true;
                    }
                }
            }

            return false;
        }



        #region AjoutDonnée
        /// <summary>
        /// Ajoute une station à la base de données.
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Nom"></param>
        /// <param name="Zone"></param>
        /// <param name="Accessibilite"></param>
        /// <param name="Correspondance"></param>
        public static int AjoutStationBase(string Nom, string Zone, bool Accessibilite, bool Correspondance)
        {
            string reSQL = $"INSERT INTO Station(NomStation, Zone, Correspondance, Accessibilite) VALUES ('{Nom}', '{Zone}', {Accessibilite}, {Correspondance}); SELECT LAST_INSERT_ID();"; //On insert la station et récupère l'ID de la dernière insertion
            MySqlCommand cmd = new MySqlCommand(reSQL, Conn);

            int idStation = Convert.ToInt32(cmd.ExecuteScalar());
            return idStation;
        }

        public static void AjouterDesservie(int idLigne, int idStation)
        {
            string reSQL = "INSERT INTO Desservie (IdLigne, IdStation) VALUES (@IdLigne, @IdStation)";
            MySqlCommand cmd = new MySqlCommand(reSQL, Conn);
            cmd.Parameters.AddWithValue("@IdLigne", idLigne);
            cmd.Parameters.AddWithValue("@IdStation", idStation);
            cmd.ExecuteNonQuery();
        }

        public static void AjoutTrajetBase(int idLigne, int idStationDepart, int idStationArrivee, TimeSpan tempsTrajets)
        {
            string reSQL = "INSERT INTO Trajet (IdLigne, IdStation, IdStation_1, TempsTrajet) VALUES (@IdLigne, @IdStationDepart, @IdStationArrivee, @TempsTrajets)";
            MySqlCommand cmd = new MySqlCommand(reSQL, Conn);
            cmd.Parameters.AddWithValue("@IdLigne", idLigne);
            cmd.Parameters.AddWithValue("@IdStationDepart", idStationDepart);
            cmd.Parameters.AddWithValue("@IdStationArrivee", idStationArrivee);
            cmd.Parameters.AddWithValue("@TempsTrajets", tempsTrajets);
            cmd.ExecuteNonQuery();
        }

        public static void AjoutLigneBase(string nom, string couleur, int longueur, string status, TimeSpan frequence, TimeSpan heureFin, TimeSpan heureDebut)
        {
            string reSQL = "INSERT INTO Ligne (NomLigne, Couleur, Longueur, Status, Frequence, HeureDebut ,HeureFin) VALUES (@NomLigne, @Couleur, @Longueur, @Status, @Frequence, @HeureDebut, @HeureFin)";
            MySqlCommand cmd = new MySqlCommand(reSQL, Conn);
            cmd.Parameters.AddWithValue("@NomLigne", nom);
            cmd.Parameters.AddWithValue("@Couleur", couleur);
            cmd.Parameters.AddWithValue("@Longueur", longueur);
            cmd.Parameters.AddWithValue("@Status", status);
            cmd.Parameters.AddWithValue("@Frequence", frequence);
            cmd.Parameters.AddWithValue("@HeureFin", heureFin);
            cmd.Parameters.AddWithValue("@HeureDebut", heureDebut);
            cmd.ExecuteNonQuery();
        }

        public static void AjoutUtilisateurBase(string nom, string prenom, string email, string motDePasse, string StatusClient, DateTime DateNaissance)
        {
            string reSQL = "INSERT INTO Client (NomClient, PrenomClient, MailClient, MotDePasse, StatutsClient, DateNaissanceClient) VALUES (@Nom, @Prenom, @Email, @MotDePasse, @StatusClient, @DateNaissance)";
            MySqlCommand cmd = new MySqlCommand(reSQL, Conn);
            cmd.Parameters.AddWithValue("@Nom", nom);
            cmd.Parameters.AddWithValue("@Prenom", prenom);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@MotDePasse", motDePasse);
            cmd.Parameters.AddWithValue("@StatusClient", StatusClient);
            cmd.Parameters.AddWithValue("@DateNaissance", DateNaissance);
            cmd.ExecuteNonQuery();
        }

        #endregion


        #region GetDonnee
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
                        Status = reader.GetString("Status"),
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
                        Status = reader.GetString("Status"),
                        Frequence = reader.GetTimeSpan("Frequence").ToString(@"hh\:mm"),
                        HeureFin = reader.GetTimeSpan("HeureFin").ToString(@"hh\:mm"),
                        HeureDebut = reader.GetTimeSpan("HeureDebut").ToString(@"hh\:mm"),
                    };
                }
            }
            return null;
        }

        

        public static List<Horaire> GetHorairesForStationAndLigne(int idLigne, int idStation, string sens)
        {
            List<Horaire> horaires = new List<Horaire>();
            string reSQL = "SELECT * FROM Horaire WHERE IdLigne = @IdLigne AND IdStation = @IdStation AND SensCirculation = @SensCirculation";
            MySqlCommand cmd = new MySqlCommand(reSQL, Conn);
            cmd.Parameters.AddWithValue("@IdLigne", idLigne);
            cmd.Parameters.AddWithValue("@IdStation", idStation);
            cmd.Parameters.AddWithValue("@SensCirculation", sens);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Horaire h = new Horaire
                    {
                        IdLigne = reader.GetInt32("IdLigne"),
                        IdStation = reader.GetInt32("IdStation"),
                        Sens = reader.GetString("SensCirculation"),
                        PassageTrain = reader.GetTimeSpan("PassageTrain")
                    };
                    horaires.Add(h);
                }
            }
            return horaires;
        }


        public static TimeSpan? GetNextPassage(int idLigne, int idStation, TimeSpan afterTime, string sens)
        {
            var horaires = GetHorairesForStationAndLigne(idLigne, idStation, sens);
            return horaires
                .Where(h => h.PassageTrain > afterTime)
                .OrderBy(h => h.PassageTrain)
                .Select(h => h.PassageTrain)
                .FirstOrDefault();
        }

        public static List<string> GetStatusLignes()
        {
            List<string> status = new List<string>();

            // S'assurer que la connexion est ouverte
            MySqlConnection conn = GetConnection();

            string query = "SELECT NomLigne, Status FROM Ligne";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string nom = reader.GetString(0);
                    string statut = reader.GetString(1);
                    status.Add($"{nom} : {statut}");
                }
            }

            return status;
        }

        #endregion

        public static List<Desservie> LigneDesservie(int idStation)
        {
            string reSQL = "Select IdLigne, IdStation FROM Desservie WHERE IdStation = @idStation;";
            MySqlCommand cmd = new MySqlCommand(reSQL, Conn);
            cmd.Parameters.AddWithValue("@idStation", idStation);

            List<Desservie> desservies = new List<Desservie>();

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Desservie d = new Desservie()
                    {
                        IdLigne = reader.GetInt32("IdLigne"),
                        IdStation = reader.GetInt32("IdStation"),
                    };
                    desservies.Add(d);
                }
            }
            return desservies;
        }

        #region ModifierDonnee

        public static void ModifierStation(int idStation, string nom, string zone, bool accessibilite, bool correspondance)
        {
            string reSQL = "UPDATE Station SET NomStation = @Nom, Zone = @Zone, Accessibilite = @Accessibilite, Correspondance = @Correspondance WHERE IdStation = @IdStation";
            MySqlCommand cmd = new MySqlCommand(reSQL, Conn);
            cmd.Parameters.AddWithValue("@IdStation", idStation);
            cmd.Parameters.AddWithValue("@Nom", nom);
            cmd.Parameters.AddWithValue("@Zone", zone);
            cmd.Parameters.AddWithValue("@Accessibilite", accessibilite);
            cmd.Parameters.AddWithValue("@Correspondance", correspondance);
            int rowsAffected = cmd.ExecuteNonQuery();
        }

        public static void ModifierLigne(int idLigne, string nom, string couleur, int longueur, string status, string frequence, string heureFin, string heureDebut)
        {
            string reSQL = "UPDATE Ligne SET NomLigne = @Nom, Couleur = @Couleur, Longueur = @Longueur, Status = @Status, Frequence = @Frequence, HeureFin = @HeureFin, HeureDebut = @HeureDebut WHERE IdLigne = @IdLigne";
            MySqlCommand cmd = new MySqlCommand(reSQL, Conn);
            cmd.Parameters.AddWithValue("@IdLigne", idLigne);
            cmd.Parameters.AddWithValue("@Nom", nom);
            cmd.Parameters.AddWithValue("@Couleur", couleur);
            cmd.Parameters.AddWithValue("@Longueur", longueur);
            cmd.Parameters.AddWithValue("@Status", status);
            cmd.Parameters.AddWithValue("@Frequence", frequence);
            cmd.Parameters.AddWithValue("@HeureFin", heureFin);
            cmd.Parameters.AddWithValue("@HeureDebut", heureDebut);
            int rowsAffected = cmd.ExecuteNonQuery();
        }

        public static void ModifierTrajet(int idLigne, int idStationDepart, int idStationArrivee, string tempsTrajets)
        {
            string reSQL = "UPDATE Trajet SET IdStation = @IdStationDepart, IdStation_1 = @IdStationArrivee, TempsTrajet = @TempsTrajets WHERE IdLigne = @IdLigne AND IdStation = @IdStationDepart AND IdStation_1 = @IdStationArrivee";
            MySqlCommand cmd = new MySqlCommand(reSQL, Conn);
            cmd.Parameters.AddWithValue("@IdLigne", idLigne);
            cmd.Parameters.AddWithValue("@IdStationDepart", idStationDepart);
            cmd.Parameters.AddWithValue("@IdStationArrivee", idStationArrivee);
            cmd.Parameters.AddWithValue("@TempsTrajets", tempsTrajets);
            int rowsAffected = cmd.ExecuteNonQuery();
        }

        #endregion

        #region SupprimerDonnee
        public static void suprimerDesservieParStation(int idStation)
        {
            string reSQL = "DELETE FROM Desservie WHERE IdStation = @IdStation";
            MySqlCommand cmd = new MySqlCommand(reSQL, Conn);
            cmd.Parameters.AddWithValue("@IdStation", idStation);
            cmd.ExecuteNonQuery();
        }


        /// Supprime une station et toutes les données associées à cette station.  
        public static void SupprimerStation(int idStation)
        {
            var cmd = Conn.CreateCommand();

            cmd.CommandText = @"
            DELETE FROM Trajet WHERE IdStation = @id OR IdStation_1 = @id;
            DELETE FROM Desservie WHERE IdStation = @id;
            DELETE FROM Station WHERE IdStation = @id;
        ";

            cmd.Parameters.AddWithValue("@id", idStation);
            cmd.ExecuteNonQuery();
        }

        /// Supprime une ligne et toutes les données associés
        public static void SupprimerLigne(int idLigne)
        {
            var cmd = Conn.CreateCommand();

            cmd.CommandText = @"
            DELETE FROM Trajet WHERE IdLigne = @id;
            DELETE FROM Desservie WHERE IdLigne = @id;
            DELETE FROM Ligne_Favorite WHERE IdLigne = @id;
            DELETE FROM Ligne WHERE IdLigne = @id;
        ";

            cmd.Parameters.AddWithValue("@id", idLigne);
            cmd.ExecuteNonQuery();
        }

        //Supprime un trajet spécifique
        public static void SupprimerTrajet(int idLigne, int idStationDepart, int idStationArrivee)
        {
            string reSQL = "DELETE FROM Trajet WHERE IdLigne = @IdLigne AND IdStation = @IdStationDepart AND IdStation_1 = @IdStationArrivee";
            MySqlCommand cmd = new MySqlCommand(reSQL, Conn);
            cmd.Parameters.AddWithValue("@IdLigne", idLigne);
            cmd.Parameters.AddWithValue("@IdStationDepart", idStationDepart);
            cmd.Parameters.AddWithValue("@IdStationArrivee", idStationArrivee);
            cmd.ExecuteNonQuery();
        }

        #endregion
        
    }
}
