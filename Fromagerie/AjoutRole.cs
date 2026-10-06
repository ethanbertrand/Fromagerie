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
    public partial class AjoutRole : Form
    {
        public AjoutRole()
        {
            InitializeComponent();
        }

        private void EnregistrerB_Click(object sender, EventArgs e)
        {
            string libelle = libelleRoleTB.Text;
            using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(Global.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Role(libelle) VALUES (@Libelle)";
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
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
