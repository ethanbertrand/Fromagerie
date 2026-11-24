using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Fromagerie.FromagesPanierSauvegarde;

namespace Fromagerie
{
    public partial class Panier : Form
    {
        private object panierEnCours;
        private Label lblTotalPanier = new Label();

        public Panier()
        {
            InitializeComponent();
            cmdPanier.Dock = DockStyle.Top;
            cmdPanier.AutoSize = true;
            cmdPanier.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AfficherPanier(); // Recharge la liste mise à jour

        }

        private void AfficherPanier()
        {
            /*DataGridView TableauDuPanier = new DataGridView();
            TableauDuPanier.DataSource = null;
            TableauDuPanier.DataSource = panierEnCours;*/

            cmdPanier.Controls.Clear();
            foreach (var article in SessionPanier.Articles)
            {
                // Création d'un panneau pour chaque ligne du panier
                Panel ligne = new Panel
                {
                    Width = cmdPanier.Width - 25,
                    Height = 45,
                    BorderStyle = BorderStyle.FixedSingle
                };

                Label lblInfos = new Label
                {
                    Text = $"{article.nomDuFromage} | Poids total : {article.PoidsTotal} kg | {article.Total:C2}",
                    AutoSize = true,
                    Location = new Point(10, 14)
                };

                Button btnMoins = new Button
                {
                    Text = "-",
                    Width = 30,
                    Location = new Point(320, 10)
                };

                Label lblQte = new Label
                {
                    Text = article.Quantite.ToString(),
                    Width = 30,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Location = new Point(355, 14)
                };

                Button btnPlus = new Button
                {
                    Text = "+",
                    Width = 30,
                    Location = new Point(390, 10)
                };

                // Action bouton "-" : diminue la quantité ou supprime l'article à 0
                btnMoins.Click += (s, e) =>
                {
                    if (article.Quantite > 1)
                        article.Quantite--;
                    else
                        SessionPanier.Articles.Remove(article);

                    AfficherPanier(); // Rafraîchit l'affichage
                };

                // Action bouton "+" : augmente la quantité
                btnPlus.Click += (s, e) =>
                {
                    article.Quantite++;
                    AfficherPanier(); // Rafraîchit l'affichage
                };

                ligne.Controls.Add(lblInfos);
                ligne.Controls.Add(btnMoins);
                ligne.Controls.Add(lblQte);
                ligne.Controls.Add(btnPlus);

                cmdPanier.Controls.Add(ligne);
            }

            // Mettre à jour le total global du panier
            decimal totalGeneral = SessionPanier.Articles.Sum(a => a.Total);
            lblTotalPanier.Text = $"Total : {totalGeneral:C2}";


        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
