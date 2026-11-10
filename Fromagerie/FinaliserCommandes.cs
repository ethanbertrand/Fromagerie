
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Fromagerie
{
    public partial class FinaliserCommandes : Form
    {
        public FinaliserCommandes()
        {
            InitializeComponent();
            RemplirCBid();
            RemplirCBCommande();


            // Chargement automatique
            this.Load += FinaliserCommandes_Load;
        }

        // Chargement du formulaire
        private void FinaliserCommandes_Load(object sender, EventArgs e)
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

                    string query = @"
                        SELECT Commande.id,Commande.prix_total
                        From Commande 
                        Inner Join Statut 
                        On Statut.id= Commande.id_statut
                        WHERE Statut.id = 1";

                    MySqlDataAdapter adapter =
                        new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

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

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show(
                            "Aucune commande trouvée.",
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

        private void RemplirCBid()
        {
            using (MySqlConnection conn = new MySqlConnection(Global.ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT Commande.id From Commande WHERE Commande.id_statut = 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        NumeroCommande.DataSource = dt;
                        NumeroCommande.DisplayMember = "id";
                        NumeroCommande.ValueMember = "id";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void FinaliserCommandes_Load_1(object sender, EventArgs e)
        {

        }

        private void RemplirCBCommande()
        {
            using (MySqlConnection conn = new MySqlConnection(Global.ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT Utilisateur.id,Utilisateur.nom\r\nFROM Utilisateur\r\nINNER JOIN Role\r\nOn Role.id = Utilisateur.id_1\r\nWHERE Role.id = 2;";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        RoleVendeur.DataSource = dt;
                        RoleVendeur.DisplayMember = "nom";
                        RoleVendeur.ValueMember = "id";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void RoleVendeur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NumeroCommande_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idCommande = Convert.ToInt32(NumeroCommande.SelectedValue);

            using (MySqlConnection conn = new MySqlConnection(Global.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "Update Commande SET id_statut=2 WHERE id = @idCommande";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idCommande", idCommande);


                        int lignesAffectees = cmd.ExecuteNonQuery();

                        if (lignesAffectees > 0)
                        {
                            MessageBox.Show("Commande finalisée avec succès !");
                            ChargerDonnees();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PageVendeur page = new PageVendeur();
            page.Show();
            this.Hide();
        }
    }
}
