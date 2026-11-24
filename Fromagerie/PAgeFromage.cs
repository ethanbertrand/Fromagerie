using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static Fromagerie.FromagesPanierSauvegarde;

namespace Fromagerie
{
    public partial class PAgeFromage : Form
    {
        NumericUpDown quantite = new NumericUpDown();
        private List<FromagesPanierSauvegarde> panierEnCours = new List<FromagesPanierSauvegarde>();
        private string nomFromage;
        private decimal prix_kg;
        private object numericUpDownQuantite;

        public int IdFromage { get; private set; }
        public decimal Poids { get; private set; }


        public PAgeFromage(string nomFromageRecu)
        {
            InitializeComponent();
            fromages.Dock = DockStyle.Top;          // colle en haut, largeur de la fenêtre
            fromages.AutoSize = true;               // la hauteur s'adapte au contenu
            fromages.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            
            ChargerFromages(nomFromageRecu);
            InfoFromage(nomFromageRecu);
            BtnAjtAuPanier(nomFromageRecu);
            //BtnAjtPanier_Click(nomFromageRecu);

        }

        

        private void ChargerFromages(string nomFromageRecu)
        {
            Button btnFromageForm2 = new Button();
            btnFromageForm2.Text = nomFromageRecu;
            /*btnFromageForm2.Size = new Size(200, 60);*/
            fromages.Controls.Add(btnFromageForm2);

        }

        private void InfoFromage(string nomFromageRecu)
        {
            Label InfosF = new Label();
            InfosF.Width = 300;
            InfosF.Height = 200;
            InfosF.Location = new Point(780, 223);
            //NumericUpDown quantite = new NumericUpDown();

            quantite.Minimum = 1;
            quantite.Value = 1;
            quantite.Size = new Size(100, 20);
            quantite.Location = new Point(780, 340);
            InfosF.Text = "Nom du fromage : " + nomFromageRecu + "\n" +
                          "Type de lait : " + "\n" +
                          "Pays d'origine : " + "\n" +
                          "Région : " + "\n" +
                          "Quantité : " + "\n";

            

            fromages.Controls.Add(InfosF);
            fromages.Controls.Add(quantite);
            

        }

        private void BtnAjtAuPanier(string nomFromageRecu)
        {
            Button btnPanier = new Button();
            btnPanier.Text = "Ajouter au panier";
            btnPanier.Size = new Size(150, 30);
            btnPanier.Location = new Point(850, 300);
            btnPanier.Click += (s, e) => BtnAjtPanier_Click(nomFromageRecu);
            fromages.Controls.Add(btnPanier);

        }

        private void BtnAjtPanier_Click(string nomFromageRecu)
        {
          


            SessionPanier.AjouterOuAugmenter(new FromagesPanierSauvegarde
            {
                IdFromage = this.IdFromage,
                nomDuFromage = this.nomFromage,
                Poids = this.Poids,
                prix_kg = this.prix_kg,
                Quantite = (int)quantite.Value // ou 1 par défaut
            });

            // Ouvrir le formulaire Panier
            Panier Panier = new Panier();
            Panier.Show();
            this.Hide();
        }




        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
