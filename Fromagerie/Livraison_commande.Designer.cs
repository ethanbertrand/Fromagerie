namespace Fromagerie
{
    partial class Livraison_commande
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
            dataGridView1 = new DataGridView();
            commandes_livreur = new Button();
            commande = new ComboBox();
            commande_livree = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(632, 74);
            label1.Name = "label1";
            label1.Size = new Size(186, 15);
            label1.TabIndex = 0;
            label1.Text = "Commandes en cours de livraison";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(346, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(715, 333);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // commandes_livreur
            // 
            commandes_livreur.Location = new Point(599, 604);
            commandes_livreur.Name = "commandes_livreur";
            commandes_livreur.Size = new Size(171, 37);
            commandes_livreur.TabIndex = 2;
            commandes_livreur.Text = "Retour au menu Livreur";
            commandes_livreur.UseVisualStyleBackColor = true;
            commandes_livreur.Click += button1_Click;
            // 
            // commande
            // 
            commande.FormattingEnabled = true;
            commande.Location = new Point(548, 515);
            commande.Name = "commande";
            commande.Size = new Size(121, 23);
            commande.TabIndex = 4;
            // 
            // commande_livree
            // 
            commande_livree.Location = new Point(741, 503);
            commande_livree.Name = "commande_livree";
            commande_livree.Size = new Size(131, 45);
            commande_livree.TabIndex = 5;
            commande_livree.Text = "Commande Livrée";
            commande_livree.UseVisualStyleBackColor = true;
            commande_livree.Click += commande_livree_Click;
            // 
            // Livraison_commande
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1451, 762);
            Controls.Add(commande_livree);
            Controls.Add(commande);
            Controls.Add(commandes_livreur);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Livraison_commande";
            Text = "Livraison_commande";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button commandes_livreur;
        private ComboBox commande;
        private Button commande_livree;
    }
}