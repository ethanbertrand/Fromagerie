using MySql.Data.MySqlClient;
namespace Fromagerie
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=172.16.119.25;Database=fromagerie;Uid=mathias;Pwd=mathias;";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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



        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Connexion réussie !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void TestMDP_Click(object sender, EventArgs e)
        {
            string saisieUtilisateur = NomTB.Text;
            string saisieMDP = mdp.Text; 

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT mdp FROM Utilisateur WHERE nom = @Nom";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nom", saisieUtilisateur);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string hashStocke = reader.GetString("mdp");

                                bool motDePasseValide = BCrypt.Net.BCrypt.Verify(saisieMDP, hashStocke);

                                if (motDePasseValide)
                                {
                                    MessageBox.Show("Vous pouvez vous connecter !");
                                }
                                else
                                {
                                    MessageBox.Show("Nom d'utilisateur ou Mot de passe incorrect.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nom d'utilisateur ou Mot de passe incorrect.");
                            }
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
