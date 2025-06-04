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

        public frmSelectionLigne(Station stationDepart, Station stationArrivee)
        {
            InitializeComponent();

            _stationDepart = stationDepart;
            _stationArrivee = stationArrivee;

            lblTitre.Text = "Sélectionnez\nvotre ligne";
            lblTitre.ForeColor = Color.FromArgb(33, 150, 243);

            SetStationLabelText($"{_stationDepart.Nom} - {_stationArrivee.Nom}");
            _selectedDepartureTime = DateTime.Now.TimeOfDay;

            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000; 
            _timer.Tick += Timer_Tick;
            _timer.Start();
            lblheure.Text = DateTime.Now.ToString("HH:mm");


            LoadTrajets();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            lblheure.Text = DateTime.Now.ToString("HH:mm");
        }

        private void LoadTrajets()
        {
            var allTrajets = BD.GetTrajet()
                .Where(trajet =>
                {
                    var ligne = BD.GetLigneById(trajet.IdLigne); // Renamed variable to 'ligne'
                    return ligne != null;
                })
                .ToList();

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

            while (queue.Count > 0)
            {
                int current = queue.Dequeue();
                TimeSpan currentTime = arrivalTimes[current];

                if (current == _stationArrivee.IdStation)
                    break;

                var trajetsFromCurrent = allTrajets
                    .Where(t => t.IdStationDepart == current)
                    .ToList();

                foreach (var trajet in trajetsFromCurrent)
                {
                    var Ligne = BD.GetLigneById(trajet.IdLigne);
                    if (Ligne == null) continue;

                    string sens = trajet.IdStationDepart < trajet.IdStationArrivee ? "Aller" : "Retour";

                    TimeSpan? nextDeparture = BD.GetNextPassage(trajet.IdLigne, trajet.IdStationDepart, currentTime, sens);
                    if (nextDeparture == null) continue;

                    int trajetMinutes = 0;
                    if (TimeSpan.TryParse(trajet.TempsTrajets, out var tspan))
                        trajetMinutes = (int)tspan.TotalMinutes;

                    TimeSpan arrivalTime = nextDeparture.Value.Add(TimeSpan.FromMinutes(trajetMinutes));
                    int neighbor = trajet.IdStationArrivee;

                    if (arrivalTime < arrivalTimes[neighbor])
                    {
                        arrivalTimes[neighbor] = arrivalTime;
                        previous[neighbor] = (trajet, nextDeparture.Value);
                        queue.Enqueue(neighbor, arrivalTime);
                    }
                }
            }

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

            lstTrajets.Items.Clear();
            if (path.Count == 0)
            {
                var item = new ListViewItem("Aucun trajet trouvé");
                lstTrajets.Items.Add(item);
                return;
            }

            TimeSpan accumulatedSegmentTime = TimeSpan.Zero;
            TimeSpan? firstDeparture = path.FirstOrDefault().departureTime;

            foreach (var (trajet, depTime, arrTime) in path)
            {
                TimeSpan segmentDuration = TimeSpan.Zero;
                TimeSpan.TryParse(trajet.TempsTrajets, out segmentDuration);
                accumulatedSegmentTime = accumulatedSegmentTime.Add(segmentDuration);
            }

            var lastTrajet = path.Last();
            var ligneObj = BD.GetLigneById(lastTrajet.trajet.IdLigne);
            string ligne = ligneObj != null
               ? $"Ligne {lastTrajet.trajet.IdLigne}"
               : $"Ligne {lastTrajet.trajet.IdLigne}";
            string heureDepart = (firstDeparture ?? TimeSpan.Zero).ToString(@"hh\:mm");
            string heureArrivee = (firstDeparture ?? TimeSpan.Zero).Add(accumulatedSegmentTime).ToString(@"hh\:mm");
            string duree = accumulatedSegmentTime.TotalMinutes > 0 ? $"{accumulatedSegmentTime.TotalMinutes} min" : "Inconnu";

            var lastItem = new ListViewItem(ligne);
            lastItem.SubItems.Add(heureDepart);
            lastItem.SubItems.Add(heureArrivee);
            lastItem.SubItems.Add(duree);
            lstTrajets.Items.Add(lastItem);
        }


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
        private void lstTrajets_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
        }

        private void lstTrajets_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
        }

        private void lstTrajets_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            var g = e.Graphics;
            var bounds = e.Bounds;
            var isSelected = e.Item.Selected;

            var cardRect = new Rectangle(bounds.X + 2, bounds.Y + 4, bounds.Width - 4, bounds.Height - 8);
            using (var bgBrush = new SolidBrush(Color.White))
            using (var borderPen = new Pen(Color.FromArgb(236, 99, 92), 2))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.FillRoundedRectangle(bgBrush, cardRect, 15);
                g.DrawRoundedRectangle(borderPen, cardRect, 15);
            }

            var textColor = Color.Black;
            var fontBold = new Font("Segoe UI", 11F, FontStyle.Bold);
            var fontRegular = new Font("Segoe UI", 10F, FontStyle.Regular);

            if (e.ColumnIndex == 0)
            {
                var parts = e.SubItem.Text.Split('\n');
                if (parts.Length == 2)
                {
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
