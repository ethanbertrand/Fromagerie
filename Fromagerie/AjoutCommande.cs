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
    public partial class AjoutCommande : Form
    {

        public AjoutCommande()
        {
            InitializeComponent();
            RemplirCBVendeur();
            RemplirCBAcheteur();
        }

        private void VendeurCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AcheteurCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RemplirCBVendeur()
        {
            using (MySqlConnection conn = new MySqlConnection(Global.ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT id, nom FROM Utilisateur where id_1 = 2";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        VendeurCB.DataSource = dt;
                        VendeurCB.DisplayMember = "nom";  // ce qui s'affiche à l'utilisateur
                        VendeurCB.ValueMember = "id";     // la valeur réelle utilisée en interne
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void RemplirCBAcheteur()
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

                        AcheteurCB.DataSource = dt;
                        AcheteurCB.DisplayMember = "nom";  // ce qui s'affiche à l'utilisateur
                        AcheteurCB.ValueMember = "id";     // la valeur réelle utilisée en interne
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
            string prix = PrixTB.Text;
            string vendeur = VendeurCB.SelectedValue.ToString();
            string acheteur = AcheteurCB.SelectedValue.ToString();
            using (MySqlConnection conn = new MySqlConnection(Global.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Commande(prix_total, id_1, id_2) VALUES (@Prix, @Vendeur, @Acheteur)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Prix", prix);
                        cmd.Parameters.AddWithValue("@Vendeur", vendeur);
                        cmd.Parameters.AddWithValue("@Acheteur", acheteur);

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
    }
}
