using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Fromagerie
{
    public partial class VueCommande : Form
    {
        public VueCommande()
        {
            InitializeComponent();
        }

        // Chargement du formulaire
        private void VueCommande_Load(object sender, EventArgs e)
        {
            ChargerDonnees();
        }

        // Chargement des commandes depuis MySQL
        private void ChargerDonnees()
        {
            try
            {
                using (MySqlConnection conn =
                    new MySqlConnection(Global.ConnectionString))
                {
                    conn.Open();

                    string query = "select Utilisateur.nom as Client, Achat.Quantite,Commande.prix_total, Fromage.nom as Fromage,Producteur.Nom As Producteur\nFROM Utilisateur\nINNER JOIN Commande\nON Utilisateur.id = Commande.id_2\nINNER JOIN Achat \nON Commande.id = Achat.id\nINNER JOIN Fromage\nON Achat.id_1= Fromage.id\nINNER JOIN Producteur\nON Fromage.id_2 = Producteur.id;";

                    MySqlDataAdapter adapter =
                        new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;

                    dataGridView1.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.Fill;

                    dataGridView1.ReadOnly = true;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect;
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

        private void button1_Click(object sender, EventArgs e)
        {
            PageVendeur page = new PageVendeur();
            page.Show();
            this.Hide();
        }
    }
}
