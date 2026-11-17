
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
                        SELECT
                            Commande.id AS IdCommande,
                            Commande.prix_total AS PrixTotal,
                            Fromage.nom AS NomFromage,
                            Achat.Quantite AS Quantite,
                            Client.nom AS Client,
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

                        LEFT JOIN TypeFromage
                            ON Fromage.id_2 = TypeFromage.id

                        LEFT JOIN Animal_type
                            ON Animal_type.id_type_fromage = TypeFromage.id

                        LEFT JOIN Animal
                            ON Animal.id = Animal_type.id_animal

                        WHERE Statut.id = 1

                        ORDER BY Commande.id;";

                    using (MySqlCommand cmd =
                        new MySqlCommand(query, conn))
                    {
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
                                        reader["Client"].ToString()
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
                                        ""
                                            : reader["Animal"].ToString(),
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
            int idVendeur = Convert.ToInt32(RoleVendeur.SelectedValue);

            using (MySqlConnection conn = new MySqlConnection(Global.ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = "UPDATE Commande SET id_statut=2, id_1=@idVendeur WHERE id=@idCommande";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idCommande", idCommande);
                        cmd.Parameters.AddWithValue("@idVendeur", idVendeur);

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

        private void button2_Click(object sender, EventArgs e)
        {
            PageVendeur page = new PageVendeur();
            page.Show();
            this.Hide();
        }
    }
}
