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
    public partial class AjoutTypeFromage : Form
    {
        public AjoutTypeFromage()
        {
            InitializeComponent();
        }

        private void LibelleTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string libelle = LibelleTB.Text;
            using (MySqlConnection conn = new MySqlConnection(Global.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO TypeFromage(libelle) VALUES (@Libelle)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Libelle", libelle);
                   
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
