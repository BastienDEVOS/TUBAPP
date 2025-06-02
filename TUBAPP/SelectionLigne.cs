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
        private List<Trajet> _trajets;

        public frmSelectionLigne(Station stationDepart, Station stationArrivee)
        {
            InitializeComponent();

            _stationDepart = stationDepart;
            _stationArrivee = stationArrivee;

            lblTitre.Text = "Sélectionnez\nvotre ligne";
            lblTitre.ForeColor = Color.FromArgb(33, 150, 243);

            lblStations.Text = $"{_stationDepart.Nom} - {_stationArrivee.Nom}";

            LoadTrajets();
        }

        private void LoadTrajets()
        {
            var allTrajets = BD.GetTrajet();
            var graph = new Dictionary<int, List<Trajet>>();

            foreach (var trajet in allTrajets)
            {
                if (!graph.ContainsKey(trajet.IdStationDepart))
                    graph[trajet.IdStationDepart] = new List<Trajet>();
                graph[trajet.IdStationDepart].Add(trajet);
            }

            var distances = new Dictionary<int, int>();
            var previous = new Dictionary<int, Trajet?>();
            var visited = new HashSet<int>();
            var queue = new PriorityQueue<int, int>();

            foreach (var trajet in allTrajets)
            {
                distances[trajet.IdStationDepart] = int.MaxValue;
                distances[trajet.IdStationArrivee] = int.MaxValue;
            }
            distances[_stationDepart.IdStation] = 0;
            queue.Enqueue(_stationDepart.IdStation, 0);

            while (queue.Count > 0)
            {
                int current = queue.Dequeue();
                if (visited.Contains(current))
                    continue;
                visited.Add(current);

                if (!graph.ContainsKey(current))
                    continue;

                foreach (var trajet in graph[current])
                {
                    int neighbor = trajet.IdStationArrivee;
                    int trajetMinutes = int.TryParse(trajet.TempsTrajets, out int t) ? t : 0;
                    int newDist = distances[current] + trajetMinutes;

                    if (newDist < distances[neighbor])
                    {
                        distances[neighbor] = newDist;
                        previous[neighbor] = trajet;
                        queue.Enqueue(neighbor, newDist);
                    }
                }
            }

            var path = new List<Trajet>();
            int? step = _stationArrivee.IdStation;
            while (step != null && previous.ContainsKey(step.Value))
            {
                var trajet = previous[step.Value];
                if (trajet == null)
                    break;
                path.Insert(0, trajet);
                step = trajet.IdStationDepart;
            }

            lstTrajets.Items.Clear();
            if (path.Count == 0)
            {
                var item = new ListViewItem("Aucun trajet trouvé");
                lstTrajets.Items.Add(item);
                return;
            }

            foreach (var trajet in path)
            {
                var ligneObj = BD.GetLigneById(trajet.IdLigne);
                string ligne = ligneObj != null
                    ? $"Ligne {trajet.IdLigne}\n{ligneObj.HeureDebut:HH\\:mm} - {ligneObj.HeureFin:HH\\:mm}"
                    : $"Ligne {trajet.IdLigne}\nHeures inconnues";
                string duree = $"{trajet.TempsTrajets}min";
                var item = new ListViewItem(ligne);
                item.SubItems.Add(duree);
                lstTrajets.Items.Add(item);
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
