using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fromagerie
{
    public partial class PageLivreur : Form
    {
        public PageLivreur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VueCommande page = new VueCommande();
            page.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Livraison_commande page = new Livraison_commande();
            page.Show();
            this.Hide();
        }

        private void deconnexion_Click(object sender, EventArgs e)
        {
            Form1 page = new Form1();
            page.Show();
            this.Close();
        }
    }
}
