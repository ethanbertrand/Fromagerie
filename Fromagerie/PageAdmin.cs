using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Fromagerie
{
    public partial class PageAdmin : Form
    {
        public PageAdmin()
        {
            InitializeComponent();
            RemplirVendeur();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string nom = Inscriptionvendeur.Text;
            string motDePasse = UnInscripMDPUser.Text;

            if (string.IsNullOrWhiteSpace(nom) ||
                string.IsNullOrWhiteSpace(motDePasse) ||
                RoleCB.SelectedValue == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
                return;
            }


            string mdp = BCrypt.Net.BCrypt.HashPassword(
                motDePasse, workFactor: 12);


            int role = Convert.ToInt32(RoleCB.SelectedValue);

            using (MySqlConnection conn = new MySqlConnection(Global.ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO Utilisateur(nom, mdp, id_1) VALUES (@Nom, @mdp, @role)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nom", nom);
                        cmd.Parameters.AddWithValue("@mdp", mdp);
                        cmd.Parameters.AddWithValue("@role", role);

                        int lignesAffectees = cmd.ExecuteNonQuery();

                        if (lignesAffectees > 0)
                        {
                            MessageBox.Show("Vendeur ajouté avec succès !");


                            Inscriptionvendeur.Clear();
                            UnInscripMDPUser.Clear();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }


        private void RemplirVendeur()
        {
            using (MySqlConnection conn = new MySqlConnection(Global.ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT id, libelle FROM Role";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        adapter.Fill(dt);

                        RoleCB.DataSource = dt;
                        RoleCB.DisplayMember = "libelle";
                        RoleCB.ValueMember = "id";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des rôles : " + ex.Message);
                }
            }
        }

        private void PageAdmin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UnInscripMDPUser.PasswordChar = '•';
        }

        private void RoleCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form1 page = new Form1();
            page.Show();
            this.Close();
        }


        private void pagevendeur_Click(object sender, EventArgs e)
        {
            PageVendeur page = new PageVendeur();
            page.Show();
            this.Close();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            AjoutAnimal page = new AjoutAnimal();
            page.Show();
            this.Close();
        }


        private void afficherlogs_Click(object sender, EventArgs e)
        {
            logs page = new logs();
            page.Show();
            this.Close();
        }

        private void livraison__Click(object sender, EventArgs e)
        {
            Livraison_commande page = new Livraison_commande();
            page.Show();
            this.Close();
        }

        private void livrees_Click(object sender, EventArgs e)
        {
            commandeslivrees page = new commandeslivrees();
            page.Show();
            this.Close();
        }
    }
}