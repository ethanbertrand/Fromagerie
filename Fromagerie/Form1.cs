
using MySql.Data.MySqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Fromagerie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void TestMDP_Click(object sender, EventArgs e)
        {
            string saisieUtilisateur = NomTB.Text.Trim();
            string saisieMDP = mdp.Text;

            try
            {
                using (MySqlConnection conn =
                       new MySqlConnection(Global.ConnectionString))
                {
                    conn.Open();

                    int idUtilisateur;
                    string hashStocke;
                    string role;

                    string querySelect = @"
                        SELECT Utilisateur.id,
                               Utilisateur.mdp,
                               Role.libelle
                        FROM Utilisateur
                        LEFT JOIN Role
                            ON Role.id = Utilisateur.id_1
                        WHERE Utilisateur.nom = @Nom";

                    using (MySqlCommand cmdSelect =
                           new MySqlCommand(querySelect, conn))
                    {
                        cmdSelect.Parameters.AddWithValue(
                            "@Nom", saisieUtilisateur);

                        using (MySqlDataReader reader =
                               cmdSelect.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show(
                                    "Nom d'utilisateur ou mot de passe incorrect.");
                                return;
                            }
                            idUtilisateur = reader.GetInt32("id");
                            hashStocke = reader.GetString("mdp");
                            role = reader["libelle"].ToString();
                        }
                    }


                    if (!BCrypt.Net.BCrypt.Verify(saisieMDP, hashStocke))
                    {
                        MessageBox.Show(
                            "Nom d'utilisateur ou mot de passe incorrect.");
                        return;
                    }
                    Session.IdUtilisateur = idUtilisateur;
                    Session.NomUtilisateur = saisieUtilisateur;
                    Session.Role = role;
                    string queryLog = @"
                        INSERT INTO Log_utilisateur
                            (Date_, id_utilisateur)
                        VALUES
                            (@DateConnexion, @IdUtilisateur)";

                    using (MySqlCommand cmdLog =
                           new MySqlCommand(queryLog, conn))
                    {
                        cmdLog.Parameters.AddWithValue(
                            "@DateConnexion", DateTime.Now);

                        cmdLog.Parameters.AddWithValue(
                            "@IdUtilisateur", idUtilisateur);

                        cmdLog.ExecuteNonQuery();
                    }


                    if (role == "Vendeur")
                    {
                        PageVendeur page = new PageVendeur();
                        page.Show();
                        this.Hide();
                    }

                    else if (role == "Acheteur")
                    {
                        PageAjoutCommande page = new PageAjoutCommande();
                        page.Show();
                        this.Hide();
                    }
                    else if (role == "Admin")
                    {
                        PageAdmin page = new PageAdmin();
                        page.Show();
                        this.Hide();
                    }
                    else if (role == "Livreur")
                    {
                        PageLivreur page = new PageLivreur();
                        page.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Rôle non reconnu : " + role);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
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

        private void TableauFromageB_Click(object sender, EventArgs e)
        {
            Bouton("Fromagerie.TableauFromage");
        }


        private void InscripUserTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void InscripMDPUser_TextChanged(object sender, EventArgs e)
        {
            mdpinscription.PasswordChar = '•';
        }

        private void mdp_TextChanged(object sender, EventArgs e)
        {
            mdp.PasswordChar = '•';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (Inscription inscription = new Inscription())
            {
                inscription.ShowDialog();
            }

            this.Show();
        }

        private void brandLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
