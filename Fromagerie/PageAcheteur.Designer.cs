namespace Fromagerie
{
    partial class PageAjoutCommande
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
            histoire = new Button();
            deconnexion = new Button();
            label2 = new Label();
            labelBienvenue = new Label();
            livraison = new Button();
            livrer = new Button();
            SuspendLayout();
            // 
            // histoire
            // 
            histoire.Location = new Point(433, 91);
            histoire.Name = "histoire";
            histoire.Size = new Size(112, 23);
            histoire.TabIndex = 1;
            histoire.Text = "Notre histoire";
            histoire.UseVisualStyleBackColor = true;
            histoire.Click += button1_Click;
            // 
            // deconnexion
            // 
            deconnexion.Location = new Point(433, 593);
            deconnexion.Name = "deconnexion";
            deconnexion.Size = new Size(112, 23);
            deconnexion.TabIndex = 2;
            deconnexion.Text = "Déconnexion";
            deconnexion.UseVisualStyleBackColor = true;
            deconnexion.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 156);
            label2.Name = "label2";
            label2.Size = new Size(633, 15);
            label2.TabIndex = 3;
            label2.Text = "Vous avez le catalogue à dispositions avec le fromage ainsi que son prix au kilo. Vous n'avez juste qu'à faire votre choix !";
            label2.Click += label2_Click;
            // 
            // labelBienvenue
            // 
            labelBienvenue.AutoSize = true;
            labelBienvenue.Location = new Point(357, 54);
            labelBienvenue.Name = "labelBienvenue";
            labelBienvenue.Size = new Size(38, 15);
            labelBienvenue.TabIndex = 4;
            labelBienvenue.Text = "label3";
            labelBienvenue.Click += labelBienvenue_Click;
            // 
            // livraison
            // 
            livraison.Location = new Point(910, 277);
            livraison.Name = "livraison";
            livraison.Size = new Size(205, 50);
            livraison.TabIndex = 5;
            livraison.Text = "Commandes en cours de livraison";
            livraison.UseVisualStyleBackColor = true;
            livraison.Click += livraison_Click;
            // 
            // livrer
            // 
            livrer.Location = new Point(910, 360);
            livrer.Name = "livrer";
            livrer.Size = new Size(205, 50);
            livrer.TabIndex = 6;
            livrer.Text = "Commandes livrées";
            livrer.UseVisualStyleBackColor = true;
            livrer.Click += livrer_Click;
            // 
            // PageAjoutCommande
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 715);
            Controls.Add(livrer);
            Controls.Add(livraison);
            Controls.Add(labelBienvenue);
            Controls.Add(label2);
            Controls.Add(deconnexion);
            Controls.Add(histoire);
            Name = "PageAjoutCommande";
            Text = "PageAcheteur";
            Load += PageAjoutCommande_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button histoire;
        private Button deconnexion;
        private Label label2;
        private Label labelBienvenue;
        private Button livraison;
        private Button livrer;
    }
}