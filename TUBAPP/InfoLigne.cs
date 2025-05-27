using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace TUBAPP
{
    public partial class InfoLigne : Form
    {
        public InfoLigne()
        {
            InitializeComponent();
        }

        private void InfoLigne_Load(object sender, EventArgs e)
        {
            try
            {
                using (var conn = BD.GetConnection())
                {
                    var cmd = new MySqlCommand("SELECT * FROM Ligne", conn);
                    var adapter = new MySqlDataAdapter(cmd);
                    var table = new DataTable();
                    adapter.Fill(table);

                    flowLayoutPanel3.Controls.Clear();

                    foreach (DataRow row in table.Rows)
                    {
                        var label = new Label
                        {
                            AutoSize = true,
                            Padding = new Padding(5),
                            Text = string.Join(" | ", row.ItemArray.Select(item => item.ToString()))
                        };
                        flowLayoutPanel3.Controls.Add(label);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des lignes : " + ex.Message);
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
                PageProfilInviter pageProfilInviter = new PageProfilInviter(new Utilisateur(true));
                pageProfilInviter.Show();
            }
            else if (currentUser.EstAdmin)
            {
                PageProfilAdmin pageProfilAdmin = new PageProfilAdmin();
                pageProfilAdmin.Show();
            }
            else
            {
                PageProfilConnecter pageProfilConnecter = new PageProfilConnecter(currentUser.Email);
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
    }
}
