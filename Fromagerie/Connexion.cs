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

    public partial class Connexion : Form
    {
        private string connectionString = "Server=172.16.119.25;Database=fromagerie;Uid=diane;Pwd=zouzou;";
        public Connexion()
        {
            InitializeComponent();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {

            string saisieUtilisateur = UserTb.Text;
            string saisieMDP = CPwd.Text;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT mdp FROM Utilisateur WHERE nom = @Nom";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nom", saisieUtilisateur);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string hashStocke = reader.GetString("mdp");

                                bool motDePasseValide = BCrypt.Net.BCrypt.Verify(saisieMDP, hashStocke);

                                if (motDePasseValide)
                                {
                                    MessageBox.Show("Vous pouvez vous connecter !");
                                }
                                else
                                {
                                    MessageBox.Show("Nom d'utilisateur ou Mot de passe incorrect.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nom d'utilisateur ou Mot de passe incorrect.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Inscription inscriptionForm = new Inscription();
            inscriptionForm.Show();
            this.Hide();
        }
    }
}
