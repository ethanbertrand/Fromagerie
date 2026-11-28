
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Fromagerie
{
    public partial class commandeslivrees : Form
    {
        public commandeslivrees()
        {
            InitializeComponent();
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
                            Fromage.nom AS NomFromage,
                            Achat.Quantite AS Quantite,
                            Client.nom AS Client,
                            Vendeur.nom AS Vendeur,
                            Livreur.nom AS Livreur,
                            Animal.libelle AS Animal

                        FROM Commande

                        INNER JOIN Statut
                            ON Statut.id = Commande.id_statut

                        LEFT JOIN Achat
                            ON Achat.id = Commande.id

                        LEFT JOIN Fromage
                            ON Fromage.id = Achat.id_1

                        LEFT JOIN Utilisateur AS Client
                            ON Client.id = Commande.id_2

                        LEFT JOIN Utilisateur AS Vendeur
                            ON Vendeur.id = Commande.id_1

                        LEFT JOIN Utilisateur AS Livreur
                            ON Livreur.id = Commande.id_livreur

                        LEFT JOIN TypeFromage
                            ON Fromage.id_2 = TypeFromage.id

                        LEFT JOIN Animal_type
                            ON Animal_type.id_type_fromage = TypeFromage.id

                        LEFT JOIN Animal
                            ON Animal.id = Animal_type.id_animal

                        WHERE Statut.id = 4";

                    if (Session.Role == "Acheteur")
                    {
                        query += " AND Commande.id_2 = @IdUtilisateur";
                    }

                    query += " ORDER BY Commande.id;";

                    using (MySqlCommand cmd =
                        new MySqlCommand(query, conn))
                    {
                        if (Session.Role == "Acheteur")
                        {
                            cmd.Parameters.AddWithValue(
                                "@IdUtilisateur",
                                Session.IdUtilisateur);
                        }

                        using (MySqlDataReader reader =
                            cmd.ExecuteReader())
                        {
                            dataGridView1.Rows.Clear();
                            dataGridView1.Columns.Clear();

                            dataGridView1.Columns.Add("IdCommande", "ID commande");
                            dataGridView1.Columns.Add("PrixTotal", "Prix total");
                            dataGridView1.Columns.Add("Fromage", "Fromage");
                            dataGridView1.Columns.Add("Quantite", "Quantité");
                            dataGridView1.Columns.Add("Type de lait", "Type de lait");
                            dataGridView1.Columns.Add("Client", "Client");
                            dataGridView1.Columns.Add("Vendeur", "Vendeur");
                            dataGridView1.Columns.Add("Livreur", "Livreur");

                            dataGridView1.AutoSizeColumnsMode =
                                DataGridViewAutoSizeColumnsMode.Fill;

                            dataGridView1.ReadOnly = true;
                            dataGridView1.AllowUserToAddRows = false;

                            dataGridView1.SelectionMode =
                                DataGridViewSelectionMode.FullRowSelect;

                            int derniereCommande = -1;

                            while (reader.Read())
                            {
                                int idCommande =
                                    Convert.ToInt32(reader["IdCommande"]);

                                if (idCommande != derniereCommande)
                                {
                                    decimal prix =
                                        Convert.ToDecimal(reader["PrixTotal"]);

                                    int index = dataGridView1.Rows.Add(
                                        idCommande,
                                        prix.ToString("0.00") + " €",
                                        "",
                                        "",
                                        "",
                                        reader["Client"].ToString(),
                                        reader["Vendeur"].ToString(),
                                        reader["Livreur"].ToString()
                                    );

                                    dataGridView1.Rows[index]
                                        .DefaultCellStyle.Font =
                                        new Font(dataGridView1.Font, FontStyle.Bold);

                                    dataGridView1.Rows[index]
                                        .DefaultCellStyle.BackColor =
                                        Color.LightBlue;

                                    derniereCommande = idCommande;
                                }

                                if (reader["NomFromage"] != DBNull.Value)
                                {
                                    int index = dataGridView1.Rows.Add(
                                        "",
                                        "",
                                        reader["NomFromage"].ToString(),
                                        reader["Quantite"].ToString(),
                                        reader["Animal"] == DBNull.Value ?
                                        "" : reader["Animal"].ToString(),
                                        "",
                                        ""
                                    );

                                    dataGridView1.Rows[index]
                                        .DefaultCellStyle.BackColor =
                                        Color.LightYellow;
                                }
                            }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void retouradmin_Click(object sender, EventArgs e)
        {
            PageAjoutCommande page = new PageAjoutCommande();
            page.Show();
            this.Hide();
        }

        private void commandeslivrees_Load(object sender, EventArgs e)
        {

        }
    }
}
