using MySql.Data.MySqlClient;
using System.Data;
namespace Fromagerie
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=172.16.119.25;Database=fromagerie;Uid=mathias;Pwd=mathias;";
        public Form1()
        {
            InitializeComponent();
            RemplirCBRole();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = InscripUserTb.Text;
            string mdp = BCrypt.Net.BCrypt.HashPassword(InscripMDPUser.Text, workFactor: 12);
            string role = RoleCB.SelectedValue.ToString();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
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

        private void envoiepage_Click(object sender, EventArgs e)
        {
            Bouton("Fromagerie.AjoutFromage");
        }

        private void AjoutAchatB_Click(object sender, EventArgs e)
        {
            Bouton("Fromagerie.AjoutAchat");
        }

        private void AjoutCommande_Click(object sender, EventArgs e)
        {
            Bouton("Fromagerie.AjoutCommande");
        }

        private void AjoutRoleB_Click(object sender, EventArgs e)
        {
            Bouton("Fromagerie.AjoutRole");
        }

        private void RoleCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void RemplirCBRole()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
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
                        RoleCB.DisplayMember = "libelle";  // ce qui s'affiche à l'utilisateur
                        RoleCB.ValueMember = "id";     // la valeur réelle utilisée en interne
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void AjoutTypeFromageB_Click(object sender, EventArgs e)
        {
            Bouton("Fromagerie.AjoutTypeFromage");
        }

        private void Bouton(string formName)
        {
            Type formType = Type.GetType(formName);
            if (formType == null)
            {
                MessageBox.Show($"Formulaire introuvable : {formName}");
                return;
            }

            this.Hide();
            using (Form f2 = (Form)Activator.CreateInstance(formType))
            {
                f2.ShowDialog();
            }
            this.Show();

        }

        private void AjoutProducteur_Click(object sender, EventArgs e)
        {
            Bouton("Fromagerie.AjoutProducteur");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bouton("Fromagerie.AjoutPermission");
        }

        private void AjoutPermissionDesRolesB_Click(object sender, EventArgs e)
        {
            Bouton("Fromagerie.AjoutPermissionDesRoles");
        }

        private void AjoutEntrepotB_Click(object sender, EventArgs e)
        {
            Bouton("Fromagerie.AjoutEntrepot");
        }

        private void AjoutZoneB_Click(object sender, EventArgs e)
        {
            Bouton("Fromagerie.AjoutZone");
        }

        private void AjoutEmplacementB_Click(object sender, EventArgs e)
        {
            Bouton("Fromagerie.AjoutEmplacement");
        }

        private void AjoutMouvementB_Click(object sender, EventArgs e)
        {
            Bouton("Fromagerie.AjoutMouvement");
        }
    }
}