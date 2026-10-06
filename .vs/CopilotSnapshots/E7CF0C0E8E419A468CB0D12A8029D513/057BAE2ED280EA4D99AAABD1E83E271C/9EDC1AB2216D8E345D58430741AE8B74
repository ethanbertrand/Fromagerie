using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fromagerie
{
    public partial class AjoutFromage : Form
    {
        private string connectionString = "Server=172.16.119.25;Database=fromagerie;Uid=mathias;Pwd=mathias;";

        public AjoutFromage()
        {
            InitializeComponent();
            RemplirCBProducteur();
            RemplirCBTypeFromage();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RemplirCBProducteur()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT id, nom FROM Producteur";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        ProducteurCB.DataSource = dt;
                        ProducteurCB.DisplayMember = "nom";  // ce qui s'affiche à l'utilisateur
                        ProducteurCB.ValueMember = "id";     // la valeur réelle utilisée en interne
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void RemplirCBTypeFromage()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT id, libelle FROM TypeFromage";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        TypeFromageCB.DataSource = dt;
                        TypeFromageCB.DisplayMember = "libelle";  // ce qui s'affiche à l'utilisateur
                        TypeFromageCB.ValueMember = "id";     // la valeur réelle utilisée en interne
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void TypeFromageCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string saisieNomFromage = NomFromageTB.Text;
            string saisiePoids = PoidsFromageTB.Text;
            string saisiePrix = PrixKGFromageTB.Text;
            string saisieProducteur = ProducteurCB.SelectedValue.ToString();
            string saisieTypeFromage = TypeFromageCB.SelectedValue.ToString();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Fromage(nom, Poids, prix_kg, id_1, id_2) VALUES (@Nom, @Poids, @Prix, @Type, @Producteur)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nom", saisieNomFromage);
                        cmd.Parameters.AddWithValue("@Poids", saisiePoids);
                        cmd.Parameters.AddWithValue("@Prix", saisiePrix);
                        cmd.Parameters.AddWithValue("@Producteur", saisieProducteur);
                        cmd.Parameters.AddWithValue("@Type", saisieTypeFromage);

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
