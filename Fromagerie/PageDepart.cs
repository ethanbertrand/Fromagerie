using Fromagerie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

Application.Run(new PageDepart());

namespace Fromagerie
{
    public partial class PageDepart : Form
    {
        public PageDepart()
        {
            InitializeComponent();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            Inscription inscriptionForm = new Inscription();
            inscriptionForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connexion connexionForm = new Connexion();
            
            connexionForm.Show();
            this.Hide();
        }
    }
}
