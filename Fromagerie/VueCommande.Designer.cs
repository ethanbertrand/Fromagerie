namespace Fromagerie
{
    partial class VueCommande
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Forms

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            button1 = new Button();
            idComamnde = new ComboBox();
            livrerlescommandes = new Button();
            NomLivreur = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Location = new Point(157, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(961, 471);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(507, 723);
            button1.Name = "button1";
            button1.Size = new Size(169, 31);
            button1.TabIndex = 1;
            button1.Text = "Revenir sur la page livreur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // idComamnde
            // 
            idComamnde.FormattingEnabled = true;
            idComamnde.Location = new Point(211, 629);
            idComamnde.Name = "idComamnde";
            idComamnde.Size = new Size(121, 23);
            idComamnde.TabIndex = 3;
            // 
            // livrerlescommandes
            // 
            livrerlescommandes.Location = new Point(581, 618);
            livrerlescommandes.Name = "livrerlescommandes";
            livrerlescommandes.Size = new Size(148, 43);
            livrerlescommandes.TabIndex = 4;
            livrerlescommandes.Text = "Livrer commande";
            livrerlescommandes.UseVisualStyleBackColor = true;
            livrerlescommandes.Click += livrerlescommandes_Click;
            // 
            // NomLivreur
            // 
            NomLivreur.FormattingEnabled = true;
            NomLivreur.Location = new Point(396, 629);
            NomLivreur.Name = "NomLivreur";
            NomLivreur.Size = new Size(121, 23);
            NomLivreur.TabIndex = 5;
            NomLivreur.SelectedIndexChanged += livreurcommande_SelectedIndexChanged;
            // 
            // VueCommande
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 924);
            Controls.Add(NomLivreur);
            Controls.Add(livrerlescommandes);
            Controls.Add(idComamnde);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "VueCommande";
            Text = "Vue des commandes";
            Load += VueCommande_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private ComboBox idComamnde;
        private Button livrerlescommandes;
        private ComboBox NomLivreur;
    }
}
