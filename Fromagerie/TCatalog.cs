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
    public partial class TCatalog : Form
    {
        public TCatalog()
        {
            InitializeComponent();
            catalog.Dock = DockStyle.Top;          // colle en haut, largeur de la fenêtre
            catalog.AutoSize = true;               // la hauteur s'adapte au contenu
            catalog.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ChargerTypesFromages();
            
        }

        private void ChargerTypesFromages()
        {
            DataTable dt = new DataTable();

            using (var connection = new MySqlConnection(Global.ConnectionString))
            using (var adapter = new MySqlDataAdapter("SELECT nom, Poids FROM Fromage", connection))
            {
                adapter.Fill(dt); // ouvre et ferme la connexion automatiquement
            }

            catalog.SuspendLayout();
            catalog.Controls.Clear();
            

            foreach (DataRow row in dt.Rows)
            {
                var btn = new Button
                {
                    Text = $"{row["nom"]} - {row["Poids"]} g", 
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    Padding = new Padding(10, 5, 10, 5),
                    Margin = new Padding(5),
                    Tag = row["nom"] 
                };
                btn.Click += BoutonFromage_Click;
                catalog.Controls.Add(btn);
            }

            catalog.ResumeLayout();
        }

        private void BoutonFromage_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            string nom = btn.Tag.ToString();
        }

       

        private void TCatalog_Load(object sender, EventArgs e)
        {

        }

        private void catalog_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
