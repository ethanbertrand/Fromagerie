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
    public partial class AjoutProducteur : Form
    {
        public AjoutProducteur()
        {
            InitializeComponent();
        }

        private void EnregistrezB_Click(object sender, EventArgs e)
        {
            string nom = NomTB.Text;
            string Telephone = TelephoneTB.Text;
            string adresse = AdresseTB.Text;
            using (MySqlConnection conn = new MySqlConnection(Global.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Producteur(Nom, Telephone, Adresse) VALUES (@Nom, @Telephone, @Adresse)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nom", nom);
                        cmd.Parameters.AddWithValue("@Telephone", Telephone);
                        cmd.Parameters.AddWithValue("@Adresse", adresse);

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
