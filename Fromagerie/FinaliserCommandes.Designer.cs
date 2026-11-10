namespace Fromagerie
{
    partial class FinaliserCommandes
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            RoleVendeur = new ComboBox();
            NumeroCommande = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(202, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(801, 375);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(512, 50);
            label1.Name = "label1";
            label1.Size = new Size(216, 15);
            label1.TabIndex = 1;
            label1.Text = "Tableau des commandes non préparées";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 552);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Vendeur";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(414, 552);
            label3.Name = "label3";
            label3.Size = new Size(145, 15);
            label3.TabIndex = 3;
            label3.Text = "Numéro de la Commande";
            // 
            // RoleVendeur
            // 
            RoleVendeur.FormattingEnabled = true;
            RoleVendeur.Location = new Point(212, 582);
            RoleVendeur.Name = "RoleVendeur";
            RoleVendeur.Size = new Size(121, 23);
            RoleVendeur.TabIndex = 4;
            RoleVendeur.SelectedIndexChanged += RoleVendeur_SelectedIndexChanged;
            // 
            // NumeroCommande
            // 
            NumeroCommande.FormattingEnabled = true;
            NumeroCommande.Location = new Point(414, 582);
            NumeroCommande.Name = "NumeroCommande";
            NumeroCommande.Size = new Size(134, 23);
            NumeroCommande.TabIndex = 5;
            NumeroCommande.SelectedIndexChanged += NumeroCommande_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(682, 552);
            button1.Name = "button1";
            button1.Size = new Size(134, 53);
            button1.TabIndex = 6;
            button1.Text = "Finaliser Commande";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(574, 738);
            button2.Name = "button2";
            button2.Size = new Size(188, 62);
            button2.TabIndex = 7;
            button2.Text = "Revenir sur le menu vendeur";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FinaliserCommandes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1498, 916);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(NumeroCommande);
            Controls.Add(RoleVendeur);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FinaliserCommandes";
            Text = "FinaliserCommandes";
            Load += FinaliserCommandes_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox RoleVendeur;
        private ComboBox NumeroCommande;
        private Button button1;
        private Button button2;
    }
}