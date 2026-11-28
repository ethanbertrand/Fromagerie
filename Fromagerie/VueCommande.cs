using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Fromagerie
{
    public partial class VueCommande : Form
    {
        public VueCommande()
        {
            InitializeComponent();

            RemplirCBCommande();
            RemplirCBLivreur();

            this.Load += VueCommande_Load;
        }

        private void VueCommande_Load(object sender, EventArgs e)
        {
            ChargerDonnees();
        }

        // Charger les commandes dans le DataGridView
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
                            Vendeur.nom AS Vendeur,
                            Client.nom AS Client,
                            Animal.libelle AS Animal
                        FROM Commande
                        INNER JOIN Statut
                            ON Statut.id = Commande.id_statut
                        LEFT JOIN Achat
                            ON Achat.id = Commande.id
                        LEFT JOIN Fromage
                            ON Fromage.id = Achat.id_1
                        LEFT JOIN Utilisateur AS Vendeur
                            ON Vendeur.id = Commande.id_1
                        LEFT JOIN Utilisateur AS Client
                            ON Client.id = Commande.id_2
                        LEFT JOIN TypeFromage
                            ON Fromage.id_2 = TypeFromage.id
                        LEFT JOIN Animal_type
                            ON Animal_type.id_type_fromage = TypeFromage.id
                        LEFT JOIN Animal
                            ON Animal.id = Animal_type.id_animal
                        WHERE Statut.id = 2
                        ORDER BY Commande.id;";

                    using (MySqlCommand cmd =
                        new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();

                        dataGridView1.Columns.Add("IdCommande", "ID commande");
                        dataGridView1.Columns.Add("PrixTotal", "Prix total");
                        dataGridView1.Columns.Add("Fromage", "Fromage");
                        dataGridView1.Columns.Add("Quantite", "Quantité");
                        dataGridView1.Columns.Add("Type de lait", "Type de lait");
                        dataGridView1.Columns.Add("Vendeur", "Vendeur");
                        dataGridView1.Columns.Add("Client", "Client");

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
                                    reader["Vendeur"].ToString(),
                                    reader["Client"].ToString()
                                );

                                dataGridView1.Rows[index].DefaultCellStyle.Font =
                                    new Font(dataGridView1.Font, FontStyle.Bold);

                                dataGridView1.Rows[index].DefaultCellStyle.BackColor =
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
                                    reader["Animal"] == DBNull.Value
                                        ? ""
                                        : reader["Animal"].ToString(),
                                    "",
                                    ""
                                );

                                dataGridView1.Rows[index].DefaultCellStyle.BackColor =
                                    Color.LightYellow;
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
                    MessageBoxIcon.Error
                );
            }
        }


        private void RemplirCBCommande()
        {
            using (MySqlConnection conn =
                new MySqlConnection(Global.ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                        SELECT id
                        FROM Commande
                        WHERE id_statut = 2;";

                    using (MySqlCommand cmd =
                        new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter =
                        new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        idComamnde.DataSource = dt;
                        idComamnde.DisplayMember = "id";
                        idComamnde.ValueMember = "id";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }


        private void RemplirCBLivreur()
        {
            using (MySqlConnection conn =
                new MySqlConnection(Global.ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                        SELECT Utilisateur.id, Utilisateur.nom
                        FROM Utilisateur
                        INNER JOIN Role
                            ON Role.id = Utilisateur.id_1
                        WHERE Role.id = 3;";

                    using (MySqlCommand cmd =
                        new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter =
                        new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        NomLivreur.DataSource = dt;
                        NomLivreur.DisplayMember = "nom";
                        NomLivreur.ValueMember = "id";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }


        private void livrerlescommandes_Click(object sender, EventArgs e)
        {
            if (idComamnde.SelectedValue == null ||
                NomLivreur.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner une commande et un livreur.");
                return;
            }

            int idCommande = Convert.ToInt32(idComamnde.SelectedValue);
            int idLivreur = Convert.ToInt32(NomLivreur.SelectedValue);

            using (MySqlConnection conn =
                new MySqlConnection(Global.ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                        UPDATE Commande
                        SET id_statut = 3,
                            id_livreur = @idLivreur
                        WHERE id = @idCommande
                        AND id_statut = 2;";

                    using (MySqlCommand cmd =
                        new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idLivreur", idLivreur);
                        cmd.Parameters.AddWithValue("@idCommande", idCommande);

                        int lignesAffectees = cmd.ExecuteNonQuery();

                        if (lignesAffectees > 0)
                        {
                            MessageBox.Show(
                                "Commande attribuée au livreur avec succès !"
                            );

                            ChargerDonnees();
                            RemplirCBCommande();
                        }
                        else
                        {
                            MessageBox.Show("Aucune commande modifiée.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            PageLivreur page = new PageLivreur();
            page.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
        }

        private void livreurcommande_SelectedIndexChanged(
            object sender, EventArgs e)
        {
        }

        private void navLivraison_Click(object sender, EventArgs e)
        {
            Livraison_commande page = new Livraison_commande();
            page.Show();
            this.Hide();
        }

        private void navLivrees_Click(object sender, EventArgs e)
        {
            commandeslivrees page = new commandeslivrees();
            page.Show();
            this.Hide();
        }

        private void navLogs_Click(object sender, EventArgs e)
        {
            logs page = new logs();
            page.Show();
            this.Hide();
        }

        private void navAnimal_Click(object sender, EventArgs e)
        {
            AjoutAnimal page = new AjoutAnimal();
            page.Show();
            this.Hide();

        }

        private void navVendeur_Click(object sender, EventArgs e)
        {
            PageVendeur page = new PageVendeur();
            page.Show();
            this.Hide();
        }

        private void navInscription_Click(object sender, EventArgs e)
        {
            PageAdmin page = new PageAdmin();
            page.Show();
            this.Hide();
        }
    }
}