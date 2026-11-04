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
            label1 = new Label();
            button1 = new Button();
            ModifierCommande = new Button();
            AjoutCommande = new Button();
            VoirCommande = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(299, 95);
            label1.Name = "label1";
            label1.Size = new Size(174, 15);
            label1.TabIndex = 0;
            label1.Text = "Bienvenue sur la page vendeur!!";
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
            // ModifierCommande
            // 
            ModifierCommande.Location = new Point(423, 153);
            ModifierCommande.Name = "ModifierCommande";
            ModifierCommande.Size = new Size(135, 44);
            ModifierCommande.TabIndex = 2;
            ModifierCommande.Text = "Modifier Commande";
            ModifierCommande.UseVisualStyleBackColor = true;
            // 
            // AjoutCommande
            // 
            AjoutCommande.Location = new Point(210, 153);
            AjoutCommande.Name = "AjoutCommande";
            AjoutCommande.Size = new Size(124, 44);
            AjoutCommande.TabIndex = 3;
            AjoutCommande.Text = "Ajout Commande";
            AjoutCommande.UseVisualStyleBackColor = true;
            AjoutCommande.Click += AjoutCommande_Click;
            // 
            // VoirCommande
            // 
            VoirCommande.Location = new Point(312, 244);
            VoirCommande.Name = "VoirCommande";
            VoirCommande.Size = new Size(124, 44);
            VoirCommande.TabIndex = 4;
            VoirCommande.Text = "Voir les commandes";
            VoirCommande.UseVisualStyleBackColor = true;
            VoirCommande.Click += VoirCommande_Click;
            // 
            // PageVendeur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(VoirCommande);
            Controls.Add(AjoutCommande);
            Controls.Add(ModifierCommande);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "PageVendeur";
            Text = "PageVendeur";
            Load += PageVendeur_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button ModifierCommande;
        private Button AjoutCommande;
        private Button VoirCommande;
    }
}
