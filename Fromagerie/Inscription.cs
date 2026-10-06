using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Fromagerie
{
    public partial class Inscription : Form
    {
        private string connectionString = "Server=172.16.119.25;Database=fromagerie;Uid=diane;Pwd=zouzou;";
        public Inscription()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InscripUserTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            string nom = InscripUserTb.Text;
            string mdp = BCrypt.Net.BCrypt.HashPassword(InscripMDPUser.Text, workFactor: 12);
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Utilisateur(nom, mdp, id_1) VALUES (@Nom, @mdp, 1)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nom", nom);
                        cmd.Parameters.AddWithValue("@mdp", mdp);

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

        private void signUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Connexion connexionForm = new Connexion();

            connexionForm.Show();
            this.Hide();
        }
    }
}
