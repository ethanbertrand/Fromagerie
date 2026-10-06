using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fromagerie
{
    public partial class AjoutMouvement : Form
    {
        public AjoutMouvement()
        {
            InitializeComponent();
            RemplirCBCommande();
            RemplirCBDeplaceur();
            RemplirCBFromage();
            RemplirCBEmplacement1();
            RemplirCBEmplacement2();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            DateTime date = DateChoisir.Value;
            string quantite = QuantiteTB.Text;
            string id_1 = Convert.ToString(CommandeCB.SelectedValue);
            string id_2 = Convert.ToString(DeplaceurCB.SelectedValue);
            string id_3 = Convert.ToString(FromageCB.SelectedValue);
            string id_4 = Convert.ToString(EmplacementCB1.SelectedValue);
            string id_5 = Convert.ToString(EmplacementCB2.SelectedValue);
            using (MySqlConnection conn = new MySqlConnection(Global.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Poids FROM Fromage WHERE id = @id_3";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_3", id_3);
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            double poidsFromage = Convert.ToDouble(result);
                            double quantiteDouble = Convert.ToDouble(quantite);
                            if (quantiteDouble > poidsFromage)
                            {
                                MessageBox.Show("La quantité saisie dépasse le poids du fromage sélectionné.");
                                return; 
                            }
                        }
                    }
                    query = "INSERT INTO Mouvement(date_, quantite, id_1, id_2, id_3, id_4, id_5) VALUES (@Date, @Quantite, @id_1, @id_2, @id_3, @id_4, @id_5)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Date", date);
                        cmd.Parameters.AddWithValue("@Quantite", quantite);
                        cmd.Parameters.AddWithValue("@id_1", id_1);
                        cmd.Parameters.AddWithValue("@id_2", id_2);
                        cmd.Parameters.AddWithValue("@id_3", id_3);
                        cmd.Parameters.AddWithValue("@id_4", id_4);
                        cmd.Parameters.AddWithValue("@id_5", id_5);

                        int lignesAffectees = cmd.ExecuteNonQuery();

                        if (lignesAffectees > 0)
                        {
                            MessageBox.Show("Enregistrement ajouté avec succès !");
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void RemplirCBCommande()
        {
            using (MySqlConnection conn = new MySqlConnection(Global.ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT id FROM Commande";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        CommandeCB.DataSource = dt;
                        CommandeCB.DisplayMember = "id";  // ce qui s'affiche à l'utilisateur
                        CommandeCB.ValueMember = "id";     // la valeur réelle utilisée en interne
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }
        private void RemplirCBDeplaceur()
        {
            using (MySqlConnection conn = new MySqlConnection(Global.ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT id, nom FROM Utilisateur where id_1 = 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        DeplaceurCB.DataSource = dt;
                        DeplaceurCB.DisplayMember = "nom";  // ce qui s'affiche à l'utilisateur
                        DeplaceurCB.ValueMember = "id";     // la valeur réelle utilisée en interne
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }
        private void RemplirCBFromage()
        {
            using (MySqlConnection conn = new MySqlConnection(Global.ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT id, nom FROM Fromage";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);


                        FromageCB.DataSource = dt;
                        FromageCB.DisplayMember = "nom";  // ce qui s'affiche à l'utilisateur
                        FromageCB.ValueMember = "id";     // la valeur réelle utilisée en interne
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }
        private void RemplirCBEmplacement1()
        {
            using (MySqlConnection conn = new MySqlConnection(Global.ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT id, code FROM Emplacement";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        EmplacementCB1.DataSource = dt;
                        EmplacementCB1.DisplayMember = "code";  // ce qui s'affiche à l'utilisateur
                        EmplacementCB1.ValueMember = "id";     // la valeur réelle utilisée en interne
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }
        private void RemplirCBEmplacement2()
        {
            using (MySqlConnection conn = new MySqlConnection(Global.ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT id, code FROM Emplacement";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        EmplacementCB2.DataSource = dt;
                        EmplacementCB2.DisplayMember = "code";  // ce qui s'affiche à l'utilisateur
                        EmplacementCB2.ValueMember = "id";     // la valeur réelle utilisée en interne
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
