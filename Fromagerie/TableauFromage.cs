using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Fromagerie
{
    public partial class TableauFromage : Form
    {
        public TableauFromage()
        {
            InitializeComponent();
            fromagetb.Dock = DockStyle.Top;          // colle en haut, largeur de la fenêtre
            fromagetb.AutoSize = true;               // la hauteur s'adapte au contenu
            fromagetb.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ChargerTableauFromage();
        }

        private void ChargerTableauFromage()
        {
            DataTable dt = new DataTable();

            using (var connection = new MySqlConnection(Global.ConnectionString))
            using (var adapter = new MySqlDataAdapter("SELECT * FROM Fromage", connection))
            {
                adapter.Fill(dt); // ouvre et ferme la connexion automatiquement
            }

            fromagetb.SuspendLayout();
            fromagetb.Controls.Clear();
            fromagetb.ColumnStyles.Clear();
            fromagetb.RowStyles.Clear();

            fromagetb.ColumnCount = dt.Columns.Count;
            fromagetb.RowCount = dt.Rows.Count + 1; // en-tête + données

            fromagetb.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            for (int c = 0; c < dt.Columns.Count; c++)
                fromagetb.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / dt.Columns.Count));
            for (int r = 0; r < fromagetb.RowCount; r++)
                fromagetb.RowStyles.Add(new RowStyle(SizeType.AutoSize));

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
                fromagetb.Controls.Add(lbl, c, 0);
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
                    fromagetb.Controls.Add(lbl, c, r + 1);
                }
            }

            fromagetb.ResumeLayout();
        }
    }
}