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
    public partial class AjoutEmplacement : Form
    {
        private string connectionString = "Server=172.16.119.25;Database=fromagerie;Uid=mathias;Pwd=mathias;";

        public AjoutEmplacement()
        {
            InitializeComponent();
            RemplirCBRole();
        }

        private void ZoneCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RemplirCBRole()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT id, nom FROM Zone";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        ZoneCB.DataSource = dt;
                        ZoneCB.DisplayMember = "nom";  // ce qui s'affiche à l'utilisateur
                        ZoneCB.ValueMember = "id";     // la valeur réelle utilisée en interne
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void EnregistrerB_Click(object sender, EventArgs e)
        {
            string nom = CodeTB.Text;
            string capa = CapaciteMaxTB.Text;
            string zone = ZoneCB.SelectedValue.ToString();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Emplacement(code, CapaciteMax, id_1) VALUES (@Nom, @capa, @zone)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nom", nom);
                        cmd.Parameters.AddWithValue("@capa", capa);
                        cmd.Parameters.AddWithValue("@zone", zone);

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
