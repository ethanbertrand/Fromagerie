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
    public partial class PAgeFromage : Form
    {
        
        

        public PAgeFromage(string nomFromageRecu)
        {
            InitializeComponent();
            fromages.Dock = DockStyle.Top;          // colle en haut, largeur de la fenêtre
            fromages.AutoSize = true;               // la hauteur s'adapte au contenu
            fromages.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            
            ChargerFromages(nomFromageRecu);
            InfoFromage(nomFromageRecu);

        }

        

        private void ChargerFromages(string nomFromageRecu)
        {
            Button btnFromageForm2 = new Button();
            btnFromageForm2.Text = nomFromageRecu;
            btnFromageForm2.Size = new Size(150, 40);
            fromages.Controls.Add(btnFromageForm2);

        }

        private void InfoFromage(string nomFromageRecu)
        {
            Label InfosF = new Label();
            InfosF.Width = 300;
            InfosF.Height = 200;
            InfosF.Location = new Point(780, 223);
            InfosF.Text = "Nom du fromage : " + nomFromageRecu + "\n" +
                          "Type de lait : " + "\n" +
                          "Pays d'origine : " + "\n" +
                          "Région : " + "\n";
            fromages.Controls.Add(InfosF);
        }



        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
