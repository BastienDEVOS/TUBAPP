using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace TUBAPP
{
    public partial class frmInfoLigne : Form
    {
        public frmInfoLigne()
        {
            InitializeComponent();
            cmb_Ligne.SelectedIndexChanged += cmb_Ligne_SelectedIndexChanged;
        }

        private void InfoLigne_Load(object sender, EventArgs e)
        {
            try
            {
                using (var conn = BD.GetConnection())
                {
                    

                    var cmd = new MySqlCommand("SELECT IdLigne, NomLigne FROM Ligne", conn);
                    var reader = cmd.ExecuteReader();

                    cmb_Ligne.Items.Clear();

                    while (reader.Read())
                    {
                        cmb_Ligne.Items.Add(new ComboBoxItem
                        {
                            Text = reader["NomLigne"].ToString(),
                            Value = reader["IdLigne"]
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur chargement lignes : " + ex.Message);
            }
        }





        private void label4_Click(object sender, EventArgs e)
        {

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

        private void cmb_Ligne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Ligne.SelectedItem is ComboBoxItem selectedItem)
            {
                int idLigne = Convert.ToInt32(selectedItem.Value);

                try
                {
                    using (var conn = BD.GetConnection())
                    {
                        if (conn.State != ConnectionState.Open)
                            conn.Open();

                        string query = @"
                    SELECT S.NomStation
                    FROM Desservie D
                    JOIN Station S ON S.IdStation = D.IdStation
                    WHERE D.IdLigne = @idLigne";

                        var cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@idLigne", idLigne);

                        var reader = cmd.ExecuteReader();

                        flowLayoutPanel3.Controls.Clear();

                        while (reader.Read())
                        {
                            var label = new Label
                            {
                                AutoSize = true,
                                Padding = new Padding(5),
                                Font = new Font("Segoe UI", 10),
                                Text = reader.GetString("NomStation")
                            };
                            flowLayoutPanel3.Controls.Add(label);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur chargement stations : " + ex.Message);
                }
            }
        }





        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
