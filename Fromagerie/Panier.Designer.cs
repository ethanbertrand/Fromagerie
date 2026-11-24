namespace Fromagerie
{
    partial class Panier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmdPanier = new FlowLayoutPanel();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            SuspendLayout();
            // 
            // cmdPanier
            // 
            cmdPanier.Location = new Point(12, 12);
            cmdPanier.Name = "cmdPanier";
            cmdPanier.Size = new Size(1080, 643);
            cmdPanier.TabIndex = 0;
            cmdPanier.Paint += flowLayoutPanel1_Paint;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // Panier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 667);
            Controls.Add(cmdPanier);
            Name = "Panier";
            Text = "Panier";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel cmdPanier;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}