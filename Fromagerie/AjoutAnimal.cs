using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fromagerie
{
    public partial class AjoutAnimal : Form
    {
        public AjoutAnimal()
        {
            InitializeComponent();
        }

        private void animal_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string libelle = animal.Text;
            using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(Global.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Animal(libelle) VALUES (@Libelle)";
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

        private void retouradmin_Click(object sender, EventArgs e)
        {
            Form1 page = new Form1();
            page.Show();
            this.Hide();
        }

        private void AjoutAnimal_Load(object sender, EventArgs e)
        {

        }

        private void actifAnimalBtn_Click(object sender, EventArgs e)
        {

        }

        private void navInscription_Click(object sender, EventArgs e)
        {
            PageAdmin page = new PageAdmin();
            page.Show();
            this.Hide();
        }

        private void navVendeur_Click(object sender, EventArgs e)
        {
            PageVendeur page = new PageVendeur();
            page.Show();
            this.Hide();
        }

        private void navLogs_Click(object sender, EventArgs e)
        {
            logs page = new logs();
            page.Show();
            this.Hide();
        }

        private void navLivraison_Click(object sender, EventArgs e)
        {
            Livraison_commande page = new Livraison_commande();
            page.Show();
            this.Hide();
        }

        private void navLivrees_Click(object sender, EventArgs e)
        {
            commandeslivrees page = new commandeslivrees();
            page.Show();
            this.Hide();
        }
    }
}
