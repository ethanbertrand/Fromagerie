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
    public partial class AjoutZone : Form
    {
        public AjoutZone()
        {
            InitializeComponent();
            RemplirCBEntrepot();
        }

        private void EnregistrerB_Click(object sender, EventArgs e)
        {
            string nom = nomTB.Text;
            string id_1 = EntrepotCB.SelectedValue.ToString();
            using (MySqlConnection conn = new MySqlConnection(Global.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Zone(nom, id_1) VALUES (@Nom, @id_1)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nom", nom);
                        cmd.Parameters.AddWithValue("@id_1", id_1);


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

        private void RemplirCBEntrepot()
        {
            using (MySqlConnection conn = new MySqlConnection(Global.ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT id, nom FROM Entrepot";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        EntrepotCB.DataSource = dt;
                        EntrepotCB.DisplayMember = "nom";  // ce qui s'affiche à l'utilisateur
                        EntrepotCB.ValueMember = "id";     // la valeur réelle utilisée en interne
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
