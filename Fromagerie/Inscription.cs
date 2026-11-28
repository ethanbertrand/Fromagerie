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
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }

        private void uneinscription_Click(object sender, EventArgs e)
        {
            string nom = EmailTB.Text.Trim();
            string motDePasse = mdpinscription.Text;

            if (string.IsNullOrWhiteSpace(nom) ||
                string.IsNullOrWhiteSpace(motDePasse))
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
                return;
            }

            string mdp = BCrypt.Net.BCrypt.HashPassword(
                motDePasse, workFactor: 12);

            using (MySqlConnection conn =
                   new MySqlConnection(Global.ConnectionString))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmdVerif =
                           new MySqlCommand("VerifierUtilisateur", conn))
                    {
                        cmdVerif.CommandType = CommandType.StoredProcedure;

                        cmdVerif.Parameters.AddWithValue("@p_nom", nom);

                        cmdVerif.ExecuteNonQuery();
                    }


                    string query = @"
                INSERT INTO Utilisateur(nom, mdp, id_1)
                VALUES (@Nom, @mdp, 1)";

                    using (MySqlCommand cmd =
                           new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nom", nom);
                        cmd.Parameters.AddWithValue("@mdp", mdp);

                        int lignesAffectees = cmd.ExecuteNonQuery();

                        if (lignesAffectees > 0)
                        {
                            MessageBox.Show(
                                "Enregistrement ajouté avec succès !");

                            EmailTB.Clear();
                            mdpinscription.Clear();
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    if (ex.SqlState == "45000")
                    {
                        MessageBox.Show(
                            "Ce nom d'utilisateur existe déjà !");
                    }
                    else if (ex.Number == 1062)
                    {
                        MessageBox.Show(
                            "Ce nom d'utilisateur existe déjà !");
                    }
                    else
                    {
                        MessageBox.Show("Inscription refusée : " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            mdpinscription.PasswordChar = '•';
        }

        private void welcomeTitle_Click(object sender, EventArgs e)
        {

        }

        private void EmailTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void LienConnexion_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (Form1 connexion = new Form1())
            {
                connexion.ShowDialog();
            }

            this.Close();
        }
    }
}
