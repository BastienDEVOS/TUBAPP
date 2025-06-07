using MySql.Data.MySqlClient;
using System.Data;
using Classes;

namespace TUBAPP
{
    public partial class frmInfoLigne : Form
    {
        public frmInfoLigne()
        {
            InitializeComponent();
            ClassUtilitaire.ConfigurerComboBoxLignes(cmb_Ligne); // Configure la comboBox des lignes
            cmb_Ligne.SelectedIndexChanged += cmb_Ligne_SelectedIndexChanged;
        }

            private void InfoLigne_Load(object sender, EventArgs e)
            {
                try
                {
                    using (var conn = BD.GetConnection())
                    {
                    // Récupère les lignes (id, nom, couleur) depuis la BDD
                    var cmd = new MySqlCommand("SELECT IdLigne, NomLigne, Couleur FROM Ligne", conn);
                        var reader = cmd.ExecuteReader();

                        cmb_Ligne.Items.Clear();

                        cmb_Ligne.Items.Add(new Classes.ComboBoxItem
                        {
                            Text = "-- Sélectionner une ligne --",
                            Value = -1,
                            Color = Color.Empty // Couleur par défaut
                        });

                        while (reader.Read())
                        {
                            string nomLigne = reader["NomLigne"].ToString();
                            string nomCouleur = reader["Couleur"].ToString();

                            cmb_Ligne.Items.Add(new Classes.ComboBoxItem
                            {
                                Text = nomLigne,
                                Value = reader["IdLigne"],
                                Color = ClassUtilitaire.ConvertirNomCouleur(nomCouleur)
                            });
                        }
                        if (cmb_Ligne.Items.Count > 0)
                        {
                            cmb_Ligne.SelectedIndex = 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur chargement lignes : " + ex.Message);
                }
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.WrapContents = false; // Empêche le retour automatique
            }


        private void picIconeContact_Click(object sender, EventArgs e)
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

        private void BtnHome_Click(object sender, EventArgs e)
        {
            frmMenuPricipal menuPrincipal = new frmMenuPricipal();
            menuPrincipal.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PageCarte page = new PageCarte();
            page.Show();
            this.Close();
        }

        private void cmb_Ligne_SelectedIndexChanged(object sender, EventArgs e)  // Gère l'affichage des stations selon la ligne sélectionnée
        {
            if (cmb_Ligne.SelectedIndex == -1) return;

            if (cmb_Ligne.SelectedItem is Classes.ComboBoxItem selectedItem)
            {
                if (Convert.ToInt32(selectedItem.Value) == -1)
                {
                    // Premier élément, pas de ligne sélectionnée => on vide les stations
                    flowLayoutPanel3.Controls.Clear();
                    return;
                }

                int idLigne = Convert.ToInt32(selectedItem.Value);

                try
                {
                    using (var conn = BD.GetConnection())
                    {
                        if (conn.State != ConnectionState.Open)
                            conn.Open();
                        // Récupère les stations associées à la ligne
                        string query = @"
                        SELECT S.NomStation, S.IdStation, COUNT(D2.IdLigne) AS NbLignes
                        FROM Desservie D
                        JOIN Station S ON S.IdStation = D.IdStation
                        JOIN Desservie D2 ON D2.IdStation = S.IdStation
                        WHERE D.IdLigne = @idLigne
                        GROUP BY S.IdStation, S.NomStation";

                        using (var cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@idLigne", idLigne);

                            using (var reader = cmd.ExecuteReader())
                            {
                                flowLayoutPanel3.Controls.Clear();
                                // Affiche chaque station sous forme de label
                                while (reader.Read())
                                {

                                    string nomStation = reader.GetString("NomStation");
                                    int nbLignes = reader.GetInt32("NbLignes");

                                    var label = new Label
                                    {
                                        AutoSize = true,
                                        Padding = new Padding(5),
                                        Font = new Font("Segoe UI", 10, nbLignes > 1 ? FontStyle.Bold : FontStyle.Regular),
                                        Text = nomStation

                                    };
                                    flowLayoutPanel3.Controls.Add(label);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur chargement stations : " + ex.Message);
                }
            }
        }
    }
}
