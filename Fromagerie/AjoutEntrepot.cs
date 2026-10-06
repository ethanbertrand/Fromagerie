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
    public partial class AjoutEntrepot : Form
    {

        public AjoutEntrepot()
        {
            InitializeComponent();
        }

        private void EnregistrerB_Click(object sender, EventArgs e)
        {
            string nom = NomTB.Text;
            string nbzone = NbZoneTB.Text;
            using (MySqlConnection conn = new MySqlConnection(Global.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Entrepot(nom, nombre_zone) VALUES (@Nom, @NbZone)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nom", nom);
                        cmd.Parameters.AddWithValue("@NbZone", nbzone);

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
