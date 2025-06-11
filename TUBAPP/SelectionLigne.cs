// Importation des bibliothèques nécessaires
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;

namespace TUBAPP
{
    public partial class frmSelectionLigne : Form
    {
        // Déclarations des champs privés pour stocker les données de la sélection
        private Station _stationDepart;
        private Station _stationArrivee;
        private TimeSpan _selectedDepartureTime;
        private List<Trajet> _trajets;
        private System.Windows.Forms.Timer _timer;

        // Constructeur du formulaire : initialise les stations et démarre le processus de recherche
        public frmSelectionLigne(Station stationDepart, Station stationArrivee)
        {
            InitializeComponent();

            _stationDepart = stationDepart;
            _stationArrivee = stationArrivee;

            lblTitre.Text = "Sélectionnez\nvotre ligne";
            lblTitre.ForeColor = Color.FromArgb(33, 150, 243);

            // Affiche les noms des stations
            SetStationLabelText($"{_stationDepart.Nom} - {_stationArrivee.Nom}");

            // Heure de départ sélectionnée : l'heure actuelle
            _selectedDepartureTime = DateTime.Now.TimeOfDay;

            // Mise en place d’un minuteur pour actualiser l’heure affichée
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000;
            _timer.Tick += Timer_Tick;
            _timer.Start();

            lblheure.Text = DateTime.Now.ToString("HH:mm");

            // Lancement de la recherche de trajets de manière asynchrone
            _ = LoadTrajetsAsync();
        }

        // Met à jour l’heure affichée chaque seconde
        private void Timer_Tick(object sender, EventArgs e)
        {
            lblheure.Text = DateTime.Now.ToString("HH:mm");
        }

        // Méthode principale de chargement des trajets avec algorithme de type Dijkstra
        private async Task LoadTrajetsAsync()
        {
            // Affichage d’un message pendant le chargement
            lstTrajets.Items.Clear();
            lstTrajets.Items.Add(new ListViewItem("Recherche de l'itinéraire..."));

            // Exécute le traitement dans un thread séparé
            var resultItems = await Task.Run(() =>
            {
                // 1. Récupération de tous les trajets et des lignes associées
                var allTrajets = BD.GetTrajet()
                    .Where(trajet => BD.GetLigneById(trajet.IdLigne) != null)
                    .ToList();

                // 2. Groupement des trajets par station de départ pour faciliter la recherche
                var trajetsByDepart = allTrajets
                    .GroupBy(t => t.IdStationDepart)
                    .ToDictionary(g => g.Key, g => g.ToList());

                // 3. Mise en cache des objets Ligne pour éviter des appels répétitifs à la base de données
                var ligneCache = allTrajets
                    .Select(t => t.IdLigne)
                    .Distinct()
                    .ToDictionary(id => id, id => BD.GetLigneById(id));

                // 4. Conversion des durées des trajets en TimeSpan
                var trajetDurations = allTrajets.ToDictionary(
                    t => t,
                    t => TimeSpan.TryParse(t.TempsTrajets, out var ts) ? ts : TimeSpan.Zero
                );

                // 5. Préchargement de tous les horaires pour chaque ligne/station/sens
                var allHoraires = BD.GetAllHoraires();
                var horairesDict = allHoraires
                    .GroupBy(h => (h.IdLigne, h.IdStation, h.Sens))
                    .ToDictionary(
                        g => g.Key,
                        g => g.Select(h => h.PassageTrain).OrderBy(t => t).ToList()
                    );

                // Méthode locale pour obtenir le prochain passage à une station donnée
                TimeSpan? GetNextPassage(int idLigne, int idStation, TimeSpan after, string sens)
                {
                    if (horairesDict.TryGetValue((idLigne, idStation, sens), out var horaires))
                    {
                        foreach (var passage in horaires)
                        {
                            if (passage >= after)
                                return passage;
                        }
                    }
                    return null;
                }

                // Initialisation de l’algorithme de Dijkstra
                var queue = new PriorityQueue<int, TimeSpan>();
                var arrivalTimes = new Dictionary<int, TimeSpan>();
                var previous = new Dictionary<int, (Trajet trajet, TimeSpan departureTime)?>();

                foreach (var trajet in allTrajets)
                {
                    arrivalTimes[trajet.IdStationDepart] = TimeSpan.MaxValue;
                    arrivalTimes[trajet.IdStationArrivee] = TimeSpan.MaxValue;
                }

                arrivalTimes[_stationDepart.IdStation] = _selectedDepartureTime;
                queue.Enqueue(_stationDepart.IdStation, _selectedDepartureTime);

                // Boucle principale de l’algorithme de Dijkstra
                while (queue.Count > 0)
                {
                    int current = queue.Dequeue();
                    TimeSpan currentTime = arrivalTimes[current];

                    // Arrêt si on a atteint la station d’arrivée
                    if (current == _stationArrivee.IdStation)
                        break;

                    // Aucun trajet disponible depuis cette station
                    if (!trajetsByDepart.TryGetValue(current, out var trajetsFromCurrent))
                        continue;

                    // Parcours des trajets possibles depuis la station actuelle
                    foreach (var trajet in trajetsFromCurrent)
                    {
                        if (!ligneCache.TryGetValue(trajet.IdLigne, out var Ligne) || Ligne == null)
                            continue;

                        // Sens fixé à "Aller" ici, à adapter selon contexte réel
                        string sens = "Aller";
                        TimeSpan? nextDeparture = GetNextPassage(trajet.IdLigne, trajet.IdStationDepart, currentTime, sens);
                        if (nextDeparture == null) continue;

                        TimeSpan trajetDuration = trajetDurations[trajet];
                        TimeSpan arrivalTime = nextDeparture.Value.Add(trajetDuration);
                        int neighbor = trajet.IdStationArrivee;

                        // Mise à jour si un trajet plus rapide est trouvé
                        if (arrivalTime < arrivalTimes[neighbor])
                        {
                            arrivalTimes[neighbor] = arrivalTime;
                            previous[neighbor] = (trajet, nextDeparture.Value);
                            queue.Enqueue(neighbor, arrivalTime);
                        }
                    }
                }

                // Reconstruction du chemin le plus court trouvé
                var path = new List<(Trajet trajet, TimeSpan departureTime, TimeSpan arrivalTime)>();
                int? step = _stationArrivee.IdStation;
                while (step != null && previous.ContainsKey(step.Value) && previous[step.Value] != null)
                {
                    var (trajet, depTime) = previous[step.Value].Value;
                    TimeSpan trajetDuration = trajetDurations[trajet];
                    TimeSpan arrTime = depTime.Add(trajetDuration);
                    path.Insert(0, (trajet, depTime, arrTime));
                    step = trajet.IdStationDepart;
                }

                string BuildStationLabel()
                {
                    if (path.Count == 0)
                        return $"{_stationDepart.Nom} - {_stationArrivee.Nom}";

                    List<string> parts = new List<string>();
                    // Départ
                    parts.Add(_stationDepart.Nom);

                    int? prevLigne = null;
                    for (int i = 0; i < path.Count; i++)
                    {
                        var (trajet, _, _) = path[i];
                        if (i > 0 && trajet.IdLigne != prevLigne)
                        {
                            // Changement de ligne à la station de départ de ce segment
                            string stationChangement = BD.GetStationById(trajet.IdStationDepart)?.Nom ?? $"Station {trajet.IdStationDepart}";
                            parts.Add($"(changement à {stationChangement})");

                        }
                        prevLigne = trajet.IdLigne;
                    }

                    // Arrivée
                    parts.Add(_stationArrivee.Nom);

                    return string.Join(" - ", parts);
                }
                var uniqueLigneIds = path.Select(p => p.trajet.IdLigne).Distinct().ToList();
                string ligne;
                if (uniqueLigneIds.Count == 1)
                {
                    var singleLigne = ligneCache[uniqueLigneIds[0]];
                    ligne = singleLigne != null ? singleLigne.Nom : $"Ligne {uniqueLigneIds[0]}";
                }
                else
                {
                    var ligneNames = uniqueLigneIds
                        .Select(id => ligneCache.ContainsKey(id) && ligneCache[id] != null ? ligneCache[id].Nom : $"Ligne {id}")
                        .ToList();
                    ligne = string.Join(" + ", ligneNames);
                }

                // Préparation de l’affichage du trajet dans la liste
                var items = new List<ListViewItem>();
                if (path.Count == 0)
                {
                    items.Add(new ListViewItem("Aucun trajet trouvé"));
                    // Mettre à jour le label même si aucun trajet trouvé
                    this.Invoke(new Action(() =>
                    {
                        SetStationLabelText($"{_stationDepart.Nom} - {_stationArrivee.Nom}");
                    }));
                    return items;
                }

                // Calcul des horaires et durée totale
                TimeSpan accumulatedSegmentTime = TimeSpan.Zero;
                TimeSpan? firstDeparture = path.FirstOrDefault().departureTime;
                foreach (var (trajet, depTime, arrTime) in path)
                {
                    accumulatedSegmentTime = accumulatedSegmentTime.Add(trajetDurations[trajet]);
                }

                string heureDepart = (firstDeparture ?? TimeSpan.Zero).ToString(@"hh\:mm");
                string heureArrivee = (firstDeparture ?? TimeSpan.Zero).Add(accumulatedSegmentTime).ToString(@"hh\:mm");
                string duree = accumulatedSegmentTime.TotalMinutes > 0 ? $"{accumulatedSegmentTime.TotalMinutes} min" : "Inconnu";
                string stationLabel = BuildStationLabel();
                this.Invoke(new Action(() =>
                {
                    SetStationLabelText(stationLabel);
                }));

                var lastItem = new ListViewItem(ligne);
                lastItem.SubItems.Add(heureDepart);
                lastItem.SubItems.Add(heureArrivee);
                lastItem.SubItems.Add(duree);
                items.Add(lastItem);

                return items;
            });

            // Mise à jour de la liste dans l’interface utilisateur
            lstTrajets.Items.Clear();
            lstTrajets.Items.AddRange(resultItems.ToArray());
        }

        // Ajuste dynamiquement la taille de police pour que le texte rentre dans le label
        private void SetStationLabelText(string text)
        {
            lblStations.Text = text;

            using (Graphics g = lblStations.CreateGraphics())
            {
                SizeF textSize = g.MeasureString(text, lblStations.Font);
                if (textSize.Width > lblStations.Width)
                {
                    float fontSize = lblStations.Font.Size;
                    while (textSize.Width > lblStations.Width && fontSize > 8)
                    {
                        fontSize -= 0.5f;
                        lblStations.Font = new Font(lblStations.Font.FontFamily, fontSize, lblStations.Font.Style);
                        textSize = g.MeasureString(text, lblStations.Font);
                    }
                }
            }
        }

        // Gestion du bouton retour
        private void btnRetour_Click(object sender, EventArgs e)
        {
            frmMenuPricipal menu = new frmMenuPricipal();
            menu.Show();
            this.Close();
        }

        // Affiche la carte
        private void btnCarte_Click(object sender, EventArgs e)
        {
            PageCarte page = new PageCarte();
            page.Show();
            this.Close();
        }

        // Retour à l’accueil
        private void btnAccueil_Click(object sender, EventArgs e)
        {
            frmMenuPricipal menu = new frmMenuPricipal();
            menu.Show();
            this.Close();
        }

        // Affichage de la page de profil selon le type d’utilisateur
        private void btnProfil_Click(object sender, EventArgs e)
        {
            Utilisateur? currentUser = SessionManager.CurrentUser;

            if (currentUser == null)
            {
                frmPageProfilInviter pageProfilInviter = new frmPageProfilInviter(new Utilisateur(true));
                pageProfilInviter.Show();
            }
            else if (currentUser.EstAdmin)
            {
                frmPageProfilAdmin pageProfilAdmin = new frmPageProfilAdmin();
                pageProfilAdmin.Show();
            }
            else
            {
                frmPageProfilConnecter pageProfilConnecter = new frmPageProfilConnecter(currentUser.Email);
                pageProfilConnecter.Show();
            }

            this.Close();
        }
    }
}
