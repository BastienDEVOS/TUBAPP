using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Classes;

namespace TUBAPP
{
    public partial class frmSelectionLigne : Form
    {
        private Station _stationDepart;
        private Station _stationArrivee;
        private TimeSpan _selectedDepartureTime;
        private List<Trajet> _trajets;
        private System.Windows.Forms.Timer _timer;

        // Constructeur du formulaire de sélection de ligne
        public frmSelectionLigne(Station stationDepart, Station stationArrivee)
        {
            InitializeComponent(); // Initialise les composants graphiques du formulaire

            _stationDepart = stationDepart;
            _stationArrivee = stationArrivee;

            lblTitre.Text = "Sélectionnez\nvotre ligne"; // Texte du titre
            lblTitre.ForeColor = Color.FromArgb(33, 150, 243); // Couleur du titre (bleu)

            // Affiche les noms des stations dans le label, avec ajustement automatique de la taille de police
            SetStationLabelText($"{_stationDepart.Nom} - {_stationArrivee.Nom}");

            _selectedDepartureTime = DateTime.Now.TimeOfDay; // Heure actuelle comme heure de départ

            // Initialisation du timer pour mettre à jour l'heure chaque seconde
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000;
            _timer.Tick += Timer_Tick;
            _timer.Start();

            lblheure.Text = DateTime.Now.ToString("HH:mm"); // Affiche l'heure actuelle

            // Charge les trajets disponibles
            LoadTrajets();
        }

        // Met à jour l'heure affichée chaque seconde
        private void Timer_Tick(object sender, EventArgs e)
        {
            lblheure.Text = DateTime.Now.ToString("HH:mm");
        }

        // Charge les trajets disponibles et détermine le chemin optimal
        private void LoadTrajets()
        {
            // Récupère tous les trajets disponibles dont la ligne est valide
            var allTrajets = BD.GetTrajet()
                .Where(trajet =>
                {
                    var ligne = BD.GetLigneById(trajet.IdLigne); // Récupère la ligne associée
                    return ligne != null;
                })
                .ToList();

            // Initialisation de la file de priorité pour Dijkstra
            var queue = new PriorityQueue<int, TimeSpan>();
            var arrivalTimes = new Dictionary<int, TimeSpan>(); // Heure d'arrivée la plus rapide par station
            var previous = new Dictionary<int, (Trajet trajet, TimeSpan departureTime)?>();

            // Initialisation des heures d'arrivée à l'infini
            foreach (var trajet in allTrajets)
            {
                arrivalTimes[trajet.IdStationDepart] = TimeSpan.MaxValue;
                arrivalTimes[trajet.IdStationArrivee] = TimeSpan.MaxValue;
            }

            // Heure de départ de la station de départ
            arrivalTimes[_stationDepart.IdStation] = _selectedDepartureTime;
            queue.Enqueue(_stationDepart.IdStation, _selectedDepartureTime);

            // Algorithme de Dijkstra adapté aux horaires
            while (queue.Count > 0)
            {
                int current = queue.Dequeue();
                TimeSpan currentTime = arrivalTimes[current];

                // Si on est arrivé à destination, on arrête
                if (current == _stationArrivee.IdStation)
                    break;

                // Trajets disponibles à partir de la station actuelle
                var trajetsFromCurrent = allTrajets
                    .Where(t => t.IdStationDepart == current)
                    .ToList();

                foreach (var trajet in trajetsFromCurrent)
                {
                    var Ligne = BD.GetLigneById(trajet.IdLigne);
                    if (Ligne == null) continue;

                    // Détermine le sens (Aller ou Retour) en comparant les IDs
                    string sens = trajet.IdStationDepart < trajet.IdStationArrivee ? "Aller" : "Retour";

                    // Récupère la prochaine heure de passage à la station courante
                    TimeSpan? nextDeparture = BD.GetNextPassage(trajet.IdLigne, trajet.IdStationDepart, currentTime, sens);
                    if (nextDeparture == null) continue;

                    // Récupère la durée du trajet
                    int trajetMinutes = 0;
                    if (TimeSpan.TryParse(trajet.TempsTrajets, out var tspan))
                        trajetMinutes = (int)tspan.TotalMinutes;

                    // Calcule l'heure d'arrivée si on prend ce trajet
                    TimeSpan arrivalTime = nextDeparture.Value.Add(TimeSpan.FromMinutes(trajetMinutes));
                    int neighbor = trajet.IdStationArrivee;

                    // Si on trouve un meilleur chemin, on met à jour
                    if (arrivalTime < arrivalTimes[neighbor])
                    {
                        arrivalTimes[neighbor] = arrivalTime;
                        previous[neighbor] = (trajet, nextDeparture.Value);
                        queue.Enqueue(neighbor, arrivalTime);
                    }
                }
            }

            // Reconstitution du chemin optimal à partir des données "previous"
            var path = new List<(Trajet trajet, TimeSpan departureTime, TimeSpan arrivalTime)>();
            int? step = _stationArrivee.IdStation;

            while (step != null && previous.ContainsKey(step.Value) && previous[step.Value] != null)
            {
                var (trajet, depTime) = previous[step.Value].Value;

                int trajetMinutes = 0;
                if (TimeSpan.TryParse(trajet.TempsTrajets, out var tspan))
                    trajetMinutes = (int)tspan.TotalMinutes;

                TimeSpan arrTime = depTime.Add(TimeSpan.FromMinutes(trajetMinutes));
                path.Insert(0, (trajet, depTime, arrTime));
                step = trajet.IdStationDepart;
            }

            // Affichage des trajets dans la liste
            lstTrajets.Items.Clear();
            if (path.Count == 0)
            {
                // Aucun trajet trouvé
                var item = new ListViewItem("Aucun trajet trouvé");
                lstTrajets.Items.Add(item);
                return;
            }

            // Calcul de la durée totale
            TimeSpan accumulatedSegmentTime = TimeSpan.Zero;
            TimeSpan? firstDeparture = path.FirstOrDefault().departureTime;

            foreach (var (trajet, depTime, arrTime) in path)
            {
                TimeSpan segmentDuration = TimeSpan.Zero;
                TimeSpan.TryParse(trajet.TempsTrajets, out segmentDuration);
                accumulatedSegmentTime = accumulatedSegmentTime.Add(segmentDuration);
            }

            // Préparation de l'affichage
            var lastTrajet = path.Last();
            var ligneObj = BD.GetLigneById(lastTrajet.trajet.IdLigne);
            string ligne = ligneObj != null
                ? $"Ligne {lastTrajet.trajet.IdLigne}"
                : $"Ligne {lastTrajet.trajet.IdLigne}";
            string heureDepart = (firstDeparture ?? TimeSpan.Zero).ToString(@"hh\:mm");
            string heureArrivee = (firstDeparture ?? TimeSpan.Zero).Add(accumulatedSegmentTime).ToString(@"hh\:mm");
            string duree = accumulatedSegmentTime.TotalMinutes > 0 ? $"{accumulatedSegmentTime.TotalMinutes} min" : "Inconnu";

            // Ajout de l’élément final dans la liste
            var lastItem = new ListViewItem(ligne);
            lastItem.SubItems.Add(heureDepart);
            lastItem.SubItems.Add(heureArrivee);
            lastItem.SubItems.Add(duree);
            lstTrajets.Items.Add(lastItem);
        }

        // Ajuste dynamiquement la taille de police si le texte dépasse le label
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

        // Dessin personnalisé (non utilisé ici, mais peut être utile pour design avancé)
        private void lstTrajets_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e) { }

        private void lstTrajets_DrawItem(object sender, DrawListViewItemEventArgs e) { }

        // Dessin personnalisé d'un sous-élément (trajet) dans la liste
        private void lstTrajets_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            var g = e.Graphics;
            var bounds = e.Bounds;
            var isSelected = e.Item.Selected;

            // Dessine un rectangle arrondi de fond pour l’item
            var cardRect = new Rectangle(bounds.X + 2, bounds.Y + 4, bounds.Width - 4, bounds.Height - 8);
            using (var bgBrush = new SolidBrush(Color.White))
            using (var borderPen = new Pen(Color.FromArgb(236, 99, 92), 2))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.FillRoundedRectangle(bgBrush, cardRect, 15);
                g.DrawRoundedRectangle(borderPen, cardRect, 15);
            }

            // Styles de texte
            var textColor = Color.Black;
            var fontBold = new Font("Segoe UI", 11F, FontStyle.Bold);
            var fontRegular = new Font("Segoe UI", 10F, FontStyle.Regular);

            if (e.ColumnIndex == 0)
            {
                var parts = e.SubItem.Text.Split('\n');
                if (parts.Length == 2)
                {
                    // Affichage du nom de ligne sur deux lignes
                    g.DrawString(parts[0], fontBold, Brushes.Black, cardRect.X + 10, cardRect.Y + 4);
                    g.DrawString(parts[1], fontRegular, Brushes.Black, cardRect.X + 10, cardRect.Y + 28);
                }
                else
                {
                    g.DrawString(e.SubItem.Text, fontBold, Brushes.Black, cardRect.X + 10, cardRect.Y + 14);
                }
            }
            else if (e.ColumnIndex == 1)
            {
                // Alignement à droite pour l'heure
                var size = g.MeasureString(e.SubItem.Text, fontBold);
                g.DrawString(e.SubItem.Text, fontBold, Brushes.Black, cardRect.Right - size.Width - 10, cardRect.Y + 18);
            }
        }



        private void btnRetour_Click(object sender, EventArgs e)
        {
            frmMenuPricipal menu = new frmMenuPricipal();
            menu.Show();
            this.Close();
        }

        private void btnCarte_Click(object sender, EventArgs e)
        {
            PageCarte page = new PageCarte();
            page.Show();
            this.Close();
        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            frmMenuPricipal menu = new frmMenuPricipal();
            menu.Show();
            this.Close();
        }

        private void btnReseau_Click(object sender, EventArgs e)
        {
        }

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
