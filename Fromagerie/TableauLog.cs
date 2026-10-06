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
    public partial class TableauLog : Form
    {
        public TableauLog()
        {
            InitializeComponent();
            LogTB.Dock = DockStyle.Top;          // colle en haut, largeur de la fenêtre
            LogTB.AutoSize = true;               // la hauteur s'adapte au contenu
            LogTB.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ChargerTableauLog();
        }

        private void LogTB_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChargerTableauLog()
        {
            DataTable dt = new DataTable();

            using (var connection = new MySqlConnection(Global.ConnectionString))
            using (var adapter = new MySqlDataAdapter("SELECT * FROM Log_utilisateur", connection))
            {
                adapter.Fill(dt); // ouvre et ferme la connexion automatiquement
            }

            LogTB.SuspendLayout();
            LogTB.Controls.Clear();
            LogTB.ColumnStyles.Clear();
            LogTB.RowStyles.Clear();

            LogTB.ColumnCount = dt.Columns.Count;
            LogTB.RowCount = dt.Rows.Count + 1; // en-tête + données

            LogTB.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            for (int c = 0; c < dt.Columns.Count; c++)
                LogTB.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / dt.Columns.Count));
            for (int r = 0; r < LogTB.RowCount; r++)
                LogTB.RowStyles.Add(new RowStyle(SizeType.AutoSize));

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
                LogTB.Controls.Add(lbl, c, 0);
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
                    LogTB.Controls.Add(lbl, c, r + 1);
                }
            }

            LogTB.ResumeLayout();
        }
    }
}
