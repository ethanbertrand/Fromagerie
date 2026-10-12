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
            ChargerTableauFromage();
        }

        private void ChargerTableauFromage()
        {
            DataTable dt = new DataTable();

            using (var connection = new MySqlConnection(Global.ConnectionString))
            using (var adapter = new MySqlDataAdapter("SELECT nom, Poids FROM Fromage", connection))
            {
                adapter.Fill(dt); // ouvre et ferme la connexion automatiquement
            }

            catalog.SuspendLayout();
            catalog.Controls.Clear();
            catalog.ColumnStyles.Clear();
            catalog.RowStyles.Clear();

            catalog.ColumnCount = dt.Columns.Count;
            catalog.RowCount = dt.Rows.Count + 1; // en-tête + données

            catalog.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            for (int c = 0; c < dt.Columns.Count; c++)
                catalog.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / dt.Columns.Count));
            for (int r = 0; r < catalog.RowCount; r++)
                catalog.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            // En-têtes : noms des champs
            for (int c = 0; c < dt.Columns.Count; c++)
            {
                var lbl = new Label
                {
                    Text = dt.Columns[c].ColumnName,
                    Font = new Font(Font, FontStyle.Bold),
                    AutoSize = true,
                    Anchor = AnchorStyles.Left
                };
                catalog.Controls.Add(lbl, c, 0);
            }

            // Lignes de la table
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    var lbl = new Label
                    {
                        Text = dt.Rows[r][c]?.ToString(),
                        AutoSize = true,
                        Anchor = AnchorStyles.Left
                    };
                    catalog.Controls.Add(lbl, c, r + 1);
                }
            }

            catalog.ResumeLayout();
        }

        private void TCatalog_Load(object sender, EventArgs e)
        {

        }

        private void catalog_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
