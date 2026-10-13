using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fromagerie
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void Bouton(string formName)
        {
            Type formType = Type.GetType(formName);
            if (formType == null)
            {
                MessageBox.Show($"Formulaire introuvable : {formName}");
                return;
            }

            this.Hide();
            using (Form f2 = (Form)Activator.CreateInstance(formType))
            {
                f2.ShowDialog();
            }
            this.Show();

        }

        private void signInLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Bouton("Fromagerie.Inscription");
        }
    }
}
