using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fromagerie
{
    public partial class Histoire : Form
    {
        public Histoire()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PageAcheteur page = new PageAcheteur();
            page.Show();
            this.Hide();
        }
    }
}
