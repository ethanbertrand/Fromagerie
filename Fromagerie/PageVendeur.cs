using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fromagerie
{
    public partial class PageVendeur : Form
    {
        public PageVendeur()
        {
            InitializeComponent();
        }

        private void PageVendeur_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 page = new Form1();
            page.Show();
            this.Hide();
        }

        private void AjoutCommande_Click(object sender, EventArgs e)
        {
            FinaliserCommandes page = new FinaliserCommandes();
            page.Show();
            this.Hide();
        }

        private void VoirCommande_Click(object sender, EventArgs e)
        {
            VueCommande page = new VueCommande();
            page.Show();
            this.Hide();
        }

        private void pageadmin_Click(object sender, EventArgs e)
        {

        }

        
    }
}
