
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Fromagerie
{
    public partial class logs : Form
    {
        public logs()
        {
            InitializeComponent();

            // Association de l'événement Load
            this.Load += logs_Load;
        }

        // Chargement du formulaire
        private void logs_Load(object sender, EventArgs e)
        {
            ChargerDonnees();
        }

        // Chargement des logs depuis MySQL
        private void ChargerDonnees()
        {
            try
            {
                using (MySqlConnection conn =
                    new MySqlConnection(Global.ConnectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT
                            Log_utilisateur.Date_  AS Date_de_Connexion,
                            Utilisateur.nom AS Utilisateur
                        FROM Log_utilisateur
                        INNER JOIN Utilisateur
                        ON Utilisateur.id =
                           Log_utilisateur.id_utilisateur
                        ORDER BY Log_utilisateur.Date_ DESC";

                    MySqlDataAdapter adapter =
                        new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    // Affichage des données
                    dataGridView1.DataSource = dt;

                    // Configuration du tableau
                    dataGridView1.Visible = true;

                    dataGridView1.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.Fill;

                    dataGridView1.ReadOnly = true;

                    dataGridView1.AllowUserToAddRows = false;

                    dataGridView1.AllowUserToDeleteRows = false;

                    dataGridView1.SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect;

                    dataGridView1.MultiSelect = false;

                    dataGridView1.RowHeadersVisible = false;

                    dataGridView1.AutoSizeRowsMode =
                        DataGridViewAutoSizeRowsMode.AllCells;

                    // Vérification des données
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show(
                            "Aucun historique trouvé.",
                            "Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erreur : " + ex.Message,
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Clic sur une cellule
        private void dataGridView1_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {

        }

        // Bouton retour vers PageAdmin
        private void button1_Click(object sender, EventArgs e)
        {
            PageAdmin page = new PageAdmin();
            page.Show();
            this.Hide();
        }
    }
}
