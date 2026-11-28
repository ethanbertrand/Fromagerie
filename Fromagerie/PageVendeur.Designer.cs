namespace Fromagerie
{
    partial class PageVendeur
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
            labelVendeur = new Label();
            button1 = new Button();
            AjoutCommande = new Button();
            labelv = new Label();
            SuspendLayout();
            // 
            // labelVendeur
            // 
            labelVendeur.AutoSize = true;
            labelVendeur.Location = new Point(299, 95);
            labelVendeur.Name = "labelVendeur";
            labelVendeur.Size = new Size(0, 15);
            labelVendeur.TabIndex = 0;
            labelVendeur.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(328, 337);
            button1.Name = "button1";
            button1.Size = new Size(90, 23);
            button1.TabIndex = 1;
            button1.Text = "Déconnexion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AjoutCommande
            // 
            AjoutCommande.Location = new Point(285, 182);
            AjoutCommande.Name = "AjoutCommande";
            AjoutCommande.Size = new Size(166, 44);
            AjoutCommande.TabIndex = 3;
            AjoutCommande.Text = "Commandes non préparées";
            AjoutCommande.UseVisualStyleBackColor = true;
            AjoutCommande.Click += AjoutCommande_Click;
            // 
            // labelv
            // 
            labelv.AutoSize = true;
            labelv.Location = new Point(328, 73);
            labelv.Name = "labelv";
            labelv.RightToLeft = RightToLeft.Yes;
            labelv.Size = new Size(79, 15);
            labelv.TabIndex = 5;
            labelv.Text = "Page Vendeur";
            // 
            // PageVendeur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelv);
            Controls.Add(AjoutCommande);
            Controls.Add(button1);
            Controls.Add(labelVendeur);
            Name = "PageVendeur";
            Text = "PageVendeur";
            Load += PageVendeur_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelVendeur;
        private Button button1;
        private Button AjoutCommande;
        private Label labelv;
    }
}
