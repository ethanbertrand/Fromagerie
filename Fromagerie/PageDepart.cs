using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fromagerie
{
    public partial class PageDepart : Form
    {
        public PageDepart()
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

        private void PsignIn__btn_Click(object sender, EventArgs e)
        {
            Bouton("Fromagerie.Inscription");
        }

        private void PsignUp_btn_Click(object sender, EventArgs e)
        {
            Bouton("Fromagerie.Connexion");
        }
    }
}
