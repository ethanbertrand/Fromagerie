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

        private Label label1;
        private DataGridView dataGridView1;
        private Button commandes_livreur;
        private ComboBox commande;
        private Button commande_livree;

        private Panel sidebar;
        private Panel yellowLine;
        private Panel mainPanel;
        private Panel tableCard;
        private Panel actionCard;
        private Panel separator;

        private Label logo;
        private Label logoTitle;
        private Label logoSubtitle;
        private Label comptesLabel;
        private Label gestionLabel;
        private Label commandesLabel;
        private Label pageSubtitle;
        private Label roleBadgeLabel;
        private Label cardTitle;
        private Label actionTitle;
        private Label actionSubtitle;
        private Label selectOrderLabel;

        private Button navInscription;
        private Button navVendeur;
        private Button navAnimal;
        private Button navLogs;
        private Button actifLivraisonBtn;
        private Button navLivrees;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Livraison_commande));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            commandes_livreur = new Button();
            commande = new ComboBox();
            commande_livree = new Button();
            sidebar = new Panel();
            logo = new Label();
            logoTitle = new Label();
            logoSubtitle = new Label();
            separator = new Panel();
            comptesLabel = new Label();
            navInscription = new Button();
            gestionLabel = new Label();
            navVendeur = new Button();
            navAnimal = new Button();
            navLogs = new Button();
            commandesLabel = new Label();
            actifLivraisonBtn = new Button();
            navLivrees = new Button();
            yellowLine = new Panel();
            mainPanel = new Panel();
            pageSubtitle = new Label();
            roleBadgeLabel = new Label();
            tableCard = new Panel();
            cardTitle = new Label();
            actionCard = new Panel();
            actionTitle = new Label();
            actionSubtitle = new Label();
            selectOrderLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            sidebar.SuspendLayout();
            mainPanel.SuspendLayout();
            tableCard.SuspendLayout();
            actionCard.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(24, 28, 22);
            label1.Location = new Point(48, 32);
            label1.Name = "label1";
            label1.Size = new Size(669, 44);
            label1.TabIndex = 0;
            label1.Text = "Commandes en cours de livraison";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 246);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(65, 103, 39);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(65, 103, 39);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 42;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(35, 42, 32);
            dataGridViewCellStyle3.Padding = new Padding(10, 0, 10, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(232, 241, 211);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(49, 83, 29);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(234, 238, 231);
            dataGridView1.Location = new Point(24, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 36;
            dataGridView1.Size = new Size(1134, 455);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // commandes_livreur
            // 
            commandes_livreur.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            commandes_livreur.BackColor = Color.FromArgb(65, 103, 39);
            commandes_livreur.Cursor = Cursors.Hand;
            commandes_livreur.FlatAppearance.BorderColor = Color.FromArgb(166, 192, 143);
            commandes_livreur.FlatStyle = FlatStyle.Flat;
            commandes_livreur.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            commandes_livreur.ForeColor = Color.White;
            commandes_livreur.Location = new Point(20, 895);
            commandes_livreur.Name = "commandes_livreur";
            commandes_livreur.Size = new Size(276, 52);
            commandes_livreur.TabIndex = 13;
            commandes_livreur.Text = "←  Retour au menu Livreur";
            commandes_livreur.UseVisualStyleBackColor = false;
            commandes_livreur.Click += button1_Click;
            // 
            // commande
            // 
            commande.BackColor = Color.White;
            commande.DropDownStyle = ComboBoxStyle.DropDownList;
            commande.FlatStyle = FlatStyle.Flat;
            commande.Font = new Font("Segoe UI", 11.5F);
            commande.ForeColor = Color.FromArgb(35, 42, 32);
            commande.FormattingEnabled = true;
            commande.Location = new Point(24, 104);
            commande.Name = "commande";
            commande.Size = new Size(220, 33);
            commande.TabIndex = 4;
            commande.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // commande_livree
            // 
            commande_livree.BackColor = Color.FromArgb(92, 134, 48);
            commande_livree.Cursor = Cursors.Hand;
            commande_livree.FlatAppearance.BorderSize = 0;
            commande_livree.FlatStyle = FlatStyle.Flat;
            commande_livree.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            commande_livree.ForeColor = Color.White;
            commande_livree.Location = new Point(264, 99);
            commande_livree.Name = "commande_livree";
            commande_livree.Size = new Size(220, 44);
            commande_livree.TabIndex = 5;
            commande_livree.Text = "✔  Commande Livrée";
            commande_livree.UseVisualStyleBackColor = false;
            commande_livree.Click += commande_livree_Click;
            // 
            // sidebar
            // 
            sidebar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            sidebar.BackColor = Color.FromArgb(65, 103, 39);
            sidebar.Controls.Add(logo);
            sidebar.Controls.Add(logoTitle);
            sidebar.Controls.Add(logoSubtitle);
            sidebar.Controls.Add(separator);
            sidebar.Controls.Add(comptesLabel);
            sidebar.Controls.Add(navInscription);
            sidebar.Controls.Add(gestionLabel);
            sidebar.Controls.Add(navVendeur);
            sidebar.Controls.Add(navAnimal);
            sidebar.Controls.Add(navLogs);
            sidebar.Controls.Add(commandesLabel);
            sidebar.Controls.Add(actifLivraisonBtn);
            sidebar.Controls.Add(navLivrees);
            sidebar.Controls.Add(commandes_livreur);
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(316, 977);
            sidebar.TabIndex = 0;
            // 
            // logo
            // 
            logo.BackColor = Color.FromArgb(232, 241, 211);
            logo.Font = new Font("Segoe UI Emoji", 30F);
            logo.Location = new Point(22, 22);
            logo.Name = "logo";
            logo.Size = new Size(68, 68);
            logo.TabIndex = 0;
            logo.Text = "🧀";
            logo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logoTitle
            // 
            logoTitle.BackColor = Color.Transparent;
            logoTitle.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            logoTitle.ForeColor = Color.White;
            logoTitle.Location = new Point(104, 9);
            logoTitle.Name = "logoTitle";
            logoTitle.Size = new Size(195, 67);
            logoTitle.TabIndex = 1;
            logoTitle.Text = "Eure-et-Loir\nFromage";
            // 
            // logoSubtitle
            // 
            logoSubtitle.BackColor = Color.Transparent;
            logoSubtitle.Font = new Font("Segoe UI", 9.5F);
            logoSubtitle.ForeColor = Color.FromArgb(196, 218, 177);
            logoSubtitle.Location = new Point(104, 72);
            logoSubtitle.Name = "logoSubtitle";
            logoSubtitle.Size = new Size(195, 22);
            logoSubtitle.TabIndex = 2;
            logoSubtitle.Text = "Suivi des livraisons";
            // 
            // separator
            // 
            separator.BackColor = Color.FromArgb(120, 151, 99);
            separator.Location = new Point(20, 112);
            separator.Name = "separator";
            separator.Size = new Size(276, 1);
            separator.TabIndex = 3;
            // 
            // comptesLabel
            // 
            comptesLabel.BackColor = Color.Transparent;
            comptesLabel.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            comptesLabel.ForeColor = Color.FromArgb(182, 206, 162);
            comptesLabel.Location = new Point(22, 132);
            comptesLabel.Name = "comptesLabel";
            comptesLabel.Size = new Size(260, 20);
            comptesLabel.TabIndex = 4;
            comptesLabel.Text = "COMPTES";
            // 
            // navInscription
            // 
            navInscription.BackColor = Color.FromArgb(65, 103, 39);
            navInscription.Cursor = Cursors.Hand;
            navInscription.FlatAppearance.BorderSize = 0;
            navInscription.FlatStyle = FlatStyle.Flat;
            navInscription.Font = new Font("Segoe UI", 11.5F);
            navInscription.ForeColor = Color.White;
            navInscription.Location = new Point(20, 160);
            navInscription.Name = "navInscription";
            navInscription.Padding = new Padding(14, 0, 0, 0);
            navInscription.Size = new Size(276, 44);
            navInscription.TabIndex = 5;
            navInscription.Text = "👤+  Inscription utilisateur";
            navInscription.TextAlign = ContentAlignment.MiddleLeft;
            navInscription.UseVisualStyleBackColor = false;
            navInscription.Click += navInscription_Click;
            // 
            // gestionLabel
            // 
            gestionLabel.BackColor = Color.Transparent;
            gestionLabel.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            gestionLabel.ForeColor = Color.FromArgb(182, 206, 162);
            gestionLabel.Location = new Point(22, 232);
            gestionLabel.Name = "gestionLabel";
            gestionLabel.Size = new Size(260, 20);
            gestionLabel.TabIndex = 6;
            gestionLabel.Text = "GESTION";
            // 
            // navVendeur
            // 
            navVendeur.BackColor = Color.FromArgb(65, 103, 39);
            navVendeur.Cursor = Cursors.Hand;
            navVendeur.FlatAppearance.BorderSize = 0;
            navVendeur.FlatStyle = FlatStyle.Flat;
            navVendeur.Font = new Font("Segoe UI", 11.5F);
            navVendeur.ForeColor = Color.White;
            navVendeur.Location = new Point(20, 260);
            navVendeur.Name = "navVendeur";
            navVendeur.Padding = new Padding(14, 0, 0, 0);
            navVendeur.Size = new Size(276, 44);
            navVendeur.TabIndex = 7;
            navVendeur.Text = "🏪  Page Vendeur";
            navVendeur.TextAlign = ContentAlignment.MiddleLeft;
            navVendeur.UseVisualStyleBackColor = false;
            navVendeur.Click += navVendeur_Click;
            // 
            // navAnimal
            // 
            navAnimal.BackColor = Color.FromArgb(65, 103, 39);
            navAnimal.Cursor = Cursors.Hand;
            navAnimal.FlatAppearance.BorderSize = 0;
            navAnimal.FlatStyle = FlatStyle.Flat;
            navAnimal.Font = new Font("Segoe UI", 11.5F);
            navAnimal.ForeColor = Color.White;
            navAnimal.Location = new Point(20, 310);
            navAnimal.Name = "navAnimal";
            navAnimal.Padding = new Padding(14, 0, 0, 0);
            navAnimal.Size = new Size(276, 44);
            navAnimal.TabIndex = 8;
            navAnimal.Text = "🐄  Ajouter Animal";
            navAnimal.TextAlign = ContentAlignment.MiddleLeft;
            navAnimal.UseVisualStyleBackColor = false;
            navAnimal.Click += navAnimal_Click;
            // 
            // navLogs
            // 
            navLogs.BackColor = Color.FromArgb(65, 103, 39);
            navLogs.Cursor = Cursors.Hand;
            navLogs.FlatAppearance.BorderSize = 0;
            navLogs.FlatStyle = FlatStyle.Flat;
            navLogs.Font = new Font("Segoe UI", 11.5F);
            navLogs.ForeColor = Color.White;
            navLogs.Location = new Point(20, 360);
            navLogs.Name = "navLogs";
            navLogs.Padding = new Padding(14, 0, 0, 0);
            navLogs.Size = new Size(276, 44);
            navLogs.TabIndex = 9;
            navLogs.Text = "📄  Afficher les logs";
            navLogs.TextAlign = ContentAlignment.MiddleLeft;
            navLogs.UseVisualStyleBackColor = false;
            navLogs.Click += navLogs_Click;
            // 
            // commandesLabel
            // 
            commandesLabel.BackColor = Color.Transparent;
            commandesLabel.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            commandesLabel.ForeColor = Color.FromArgb(182, 206, 162);
            commandesLabel.Location = new Point(22, 422);
            commandesLabel.Name = "commandesLabel";
            commandesLabel.Size = new Size(260, 20);
            commandesLabel.TabIndex = 10;
            commandesLabel.Text = "COMMANDES";
            // 
            // actifLivraisonBtn
            // 
            actifLivraisonBtn.BackColor = Color.White;
            actifLivraisonBtn.Cursor = Cursors.Hand;
            actifLivraisonBtn.FlatAppearance.BorderSize = 0;
            actifLivraisonBtn.FlatStyle = FlatStyle.Flat;
            actifLivraisonBtn.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            actifLivraisonBtn.ForeColor = Color.FromArgb(49, 83, 29);
            actifLivraisonBtn.Location = new Point(20, 450);
            actifLivraisonBtn.Name = "actifLivraisonBtn";
            actifLivraisonBtn.Padding = new Padding(14, 0, 0, 0);
            actifLivraisonBtn.Size = new Size(276, 46);
            actifLivraisonBtn.TabIndex = 11;
            actifLivraisonBtn.Text = "🚚  En cours de livraison";
            actifLivraisonBtn.TextAlign = ContentAlignment.MiddleLeft;
            actifLivraisonBtn.UseVisualStyleBackColor = false;
            // 
            // navLivrees
            // 
            navLivrees.BackColor = Color.FromArgb(65, 103, 39);
            navLivrees.Cursor = Cursors.Hand;
            navLivrees.FlatAppearance.BorderSize = 0;
            navLivrees.FlatStyle = FlatStyle.Flat;
            navLivrees.Font = new Font("Segoe UI", 11.5F);
            navLivrees.ForeColor = Color.White;
            navLivrees.Location = new Point(20, 502);
            navLivrees.Name = "navLivrees";
            navLivrees.Padding = new Padding(14, 0, 0, 0);
            navLivrees.Size = new Size(276, 44);
            navLivrees.TabIndex = 12;
            navLivrees.Text = "✔  Commandes livrées";
            navLivrees.TextAlign = ContentAlignment.MiddleLeft;
            navLivrees.UseVisualStyleBackColor = false;
            navLivrees.Click += navLivrees_Click;
            // 
            // yellowLine
            // 
            yellowLine.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            yellowLine.BackColor = Color.FromArgb(241, 187, 30);
            yellowLine.Location = new Point(316, 0);
            yellowLine.Name = "yellowLine";
            yellowLine.Size = new Size(6, 977);
            yellowLine.TabIndex = 1;
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.BackColor = Color.FromArgb(250, 251, 249);
            mainPanel.BackgroundImage = (Image)resources.GetObject("mainPanel.BackgroundImage");
            mainPanel.Controls.Add(label1);
            mainPanel.Controls.Add(pageSubtitle);
            mainPanel.Controls.Add(roleBadgeLabel);
            mainPanel.Controls.Add(tableCard);
            mainPanel.Controls.Add(actionCard);
            mainPanel.Location = new Point(322, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1256, 977);
            mainPanel.TabIndex = 2;
            // 
            // pageSubtitle
            // 
            pageSubtitle.BackColor = Color.Transparent;
            pageSubtitle.Font = new Font("Segoe UI", 11.5F);
            pageSubtitle.ForeColor = Color.FromArgb(100, 110, 98);
            pageSubtitle.Location = new Point(48, 82);
            pageSubtitle.Name = "pageSubtitle";
            pageSubtitle.Size = new Size(650, 24);
            pageSubtitle.TabIndex = 1;
            pageSubtitle.Text = "Suivez les livraisons actives et marquez une commande comme livrée";
            // 
            // roleBadgeLabel
            // 
            roleBadgeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roleBadgeLabel.BackColor = Color.White;
            roleBadgeLabel.BorderStyle = BorderStyle.FixedSingle;
            roleBadgeLabel.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            roleBadgeLabel.ForeColor = Color.FromArgb(35, 42, 32);
            roleBadgeLabel.Location = new Point(1062, 32);
            roleBadgeLabel.Name = "roleBadgeLabel";
            roleBadgeLabel.Size = new Size(148, 38);
            roleBadgeLabel.TabIndex = 2;
            roleBadgeLabel.Text = "🚚  Livraison";
            roleBadgeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableCard
            // 
            tableCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableCard.BackColor = Color.White;
            tableCard.BorderStyle = BorderStyle.FixedSingle;
            tableCard.Controls.Add(cardTitle);
            tableCard.Controls.Add(dataGridView1);
            tableCard.Location = new Point(48, 132);
            tableCard.Name = "tableCard";
            tableCard.Size = new Size(1182, 558);
            tableCard.TabIndex = 3;
            // 
            // cardTitle
            // 
            cardTitle.BackColor = Color.Transparent;
            cardTitle.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            cardTitle.ForeColor = Color.FromArgb(24, 28, 22);
            cardTitle.Location = new Point(24, 20);
            cardTitle.Name = "cardTitle";
            cardTitle.Size = new Size(460, 26);
            cardTitle.TabIndex = 0;
            cardTitle.Text = "📋  Commandes à livrer";
            // 
            // actionCard
            // 
            actionCard.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            actionCard.BackColor = Color.White;
            actionCard.BorderStyle = BorderStyle.FixedSingle;
            actionCard.Controls.Add(actionTitle);
            actionCard.Controls.Add(actionSubtitle);
            actionCard.Controls.Add(selectOrderLabel);
            actionCard.Controls.Add(commande);
            actionCard.Controls.Add(commande_livree);
            actionCard.Location = new Point(48, 706);
            actionCard.Name = "actionCard";
            actionCard.Size = new Size(1182, 168);
            actionCard.TabIndex = 4;
            // 
            // actionTitle
            // 
            actionTitle.BackColor = Color.Transparent;
            actionTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            actionTitle.ForeColor = Color.FromArgb(24, 28, 22);
            actionTitle.Location = new Point(24, 18);
            actionTitle.Name = "actionTitle";
            actionTitle.Size = new Size(420, 26);
            actionTitle.TabIndex = 0;
            actionTitle.Text = "✔  Valider une livraison";
            // 
            // actionSubtitle
            // 
            actionSubtitle.BackColor = Color.Transparent;
            actionSubtitle.Font = new Font("Segoe UI", 9.5F);
            actionSubtitle.ForeColor = Color.FromArgb(110, 120, 108);
            actionSubtitle.Location = new Point(24, 44);
            actionSubtitle.Name = "actionSubtitle";
            actionSubtitle.Size = new Size(560, 20);
            actionSubtitle.TabIndex = 1;
            actionSubtitle.Text = "Sélectionnez l'identifiant de la commande puis confirmez sa livraison.";
            // 
            // selectOrderLabel
            // 
            selectOrderLabel.BackColor = Color.Transparent;
            selectOrderLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            selectOrderLabel.ForeColor = Color.FromArgb(35, 42, 32);
            selectOrderLabel.Location = new Point(24, 78);
            selectOrderLabel.Name = "selectOrderLabel";
            selectOrderLabel.Size = new Size(180, 22);
            selectOrderLabel.TabIndex = 2;
            selectOrderLabel.Text = "N° de commande";
            // 
            // Livraison_commande
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1578, 977);
            Controls.Add(mainPanel);
            Controls.Add(yellowLine);
            Controls.Add(sidebar);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1100, 750);
            Name = "Livraison_commande";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Livraison_commande";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            sidebar.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            tableCard.ResumeLayout(false);
            actionCard.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}