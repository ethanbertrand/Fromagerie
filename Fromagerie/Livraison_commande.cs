using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Fromagerie
{
    public partial class Livraison_commande : Form
    {
        public Livraison_commande()
        {
            InitializeComponent();
            RemplirCBid();
            

            this.Load += Livraison_commande_Load;
        }

        private void Livraison_commande_Load(object sender, EventArgs e)
        {
            ChargerDonnees();
        }

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
                            Commande.id AS IdCommande,
                            Commande.prix_total AS PrixTotal,
                            Vendeur.nom AS Vendeur,
                            Client.nom AS Client,
                            Livreur.nom AS Livreur

                        FROM Commande

                        INNER JOIN Statut
                            ON Statut.id = Commande.id_statut

                        LEFT JOIN Achat
                            ON Achat.id = Commande.id

                        LEFT JOIN Utilisateur AS Client
                            ON Client.id = Commande.id_2
                        
                        LEFT JOIN Utilisateur AS Vendeur
                            ON Vendeur.id = Commande.id_1

                        LEFT JOIN Utilisateur AS Livreur
                            ON Livreur.id = Commande.id_livreur

                        WHERE Statut.id = 3

                        GROUP BY Commande.id;";

                    using (MySqlCommand cmd =
                        new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();

                        dataGridView1.Columns.Add("IdCommande", "ID commande");
                        dataGridView1.Columns.Add("PrixTotal", "Prix total");
                        dataGridView1.Columns.Add("Client", "Client");
                        dataGridView1.Columns.Add("Vendeur", "Vendeur");
                        dataGridView1.Columns.Add("Livreur", "Livreur");

                        dataGridView1.AutoSizeColumnsMode =
                            DataGridViewAutoSizeColumnsMode.Fill;

                        dataGridView1.ReadOnly = true;
                        dataGridView1.AllowUserToAddRows = false;

                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(
                                reader["IdCommande"],
                                reader["PrixTotal"] + " €",
                                reader["Client"].ToString(),
                                reader["Vendeur"].ToString(),
                                reader["Livreur"].ToString()
                            );
                        }
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

        private void dataGridView1_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PageLivreur page = new PageLivreur();
            page.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void RemplirCBid()
        {
            using (MySqlConnection conn = new MySqlConnection(Global.ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT Commande.id From Commande WHERE Commande.id_statut = 3";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        commande.DataSource = dt;
                        commande.DisplayMember = "id";
                        commande.ValueMember = "id";
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

       

        private void commande_livree_Click(object sender, EventArgs e)
        {
            int idCommande = Convert.ToInt32(commande.SelectedValue);
            

            using (MySqlConnection conn = new MySqlConnection(Global.ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = "UPDATE Commande SET id_statut=4 WHERE id=@idCommande";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idCommande", idCommande);
                        

                        int lignesAffectees = cmd.ExecuteNonQuery();

                        if (lignesAffectees > 0)
                        {
                            MessageBox.Show("Commande finalisée avec succès !");
                            ChargerDonnees();
                            RemplirCBid();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }
    }
}