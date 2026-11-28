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

        private DataGridView dataGridView1;
        private Button button1;
        private ComboBox idComamnde;
        private Button livrerlescommandes;
        private ComboBox NomLivreur;

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
        private Label pageTitle;
        private Label pageSubtitle;
        private Label roleBadgeLabel;
        private Label cardTitle;
        private Label actionTitle;
        private Label actionSubtitle;
        private Label selectOrderLabel;
        private Label selectLivreurLabel;

        private Button navInscription;
        private Button navVendeur;
        private Button navAnimal;
        private Button navLogs;
        private Button actifPrepareesBtn;
        private Button navLivraison;
        private Button navLivrees;

        #region Code généré par le Concepteur Windows Forms

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            idComamnde = new ComboBox();
            livrerlescommandes = new Button();
            NomLivreur = new ComboBox();
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
            actifPrepareesBtn = new Button();
            navLivraison = new Button();
            navLivrees = new Button();
            yellowLine = new Panel();
            mainPanel = new Panel();
            pageTitle = new Label();
            pageSubtitle = new Label();
            roleBadgeLabel = new Label();
            tableCard = new Panel();
            cardTitle = new Label();
            actionCard = new Panel();
            actionTitle = new Label();
            actionSubtitle = new Label();
            selectOrderLabel = new Label();
            selectLivreurLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            sidebar.SuspendLayout();
            mainPanel.SuspendLayout();
            tableCard.SuspendLayout();
            actionCard.SuspendLayout();
            SuspendLayout();
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
            dataGridView1.Location = new Point(24, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 36;
            dataGridView1.Size = new Size(874, 386);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.FromArgb(65, 103, 39);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(166, 192, 143);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(20, 852);
            button1.Name = "button1";
            button1.Size = new Size(276, 52);
            button1.TabIndex = 14;
            button1.Text = "←  Revenir sur la page livreur";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // idComamnde
            // 
            idComamnde.BackColor = Color.White;
            idComamnde.DropDownStyle = ComboBoxStyle.DropDownList;
            idComamnde.FlatStyle = FlatStyle.Flat;
            idComamnde.Font = new Font("Segoe UI", 11F);
            idComamnde.ForeColor = Color.FromArgb(35, 42, 32);
            idComamnde.FormattingEnabled = true;
            idComamnde.Location = new Point(24, 104);
            idComamnde.Name = "idComamnde";
            idComamnde.Size = new Size(180, 33);
            idComamnde.TabIndex = 3;
            // 
            // livrerlescommandes
            // 
            livrerlescommandes.BackColor = Color.FromArgb(92, 134, 48);
            livrerlescommandes.Cursor = Cursors.Hand;
            livrerlescommandes.FlatAppearance.BorderSize = 0;
            livrerlescommandes.FlatStyle = FlatStyle.Flat;
            livrerlescommandes.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            livrerlescommandes.ForeColor = Color.White;
            livrerlescommandes.Location = new Point(488, 99);
            livrerlescommandes.Name = "livrerlescommandes";
            livrerlescommandes.Size = new Size(210, 42);
            livrerlescommandes.TabIndex = 6;
            livrerlescommandes.Text = "🚚  Livrer commande";
            livrerlescommandes.UseVisualStyleBackColor = false;
            livrerlescommandes.Click += livrerlescommandes_Click;
            // 
            // NomLivreur
            // 
            NomLivreur.BackColor = Color.White;
            NomLivreur.DropDownStyle = ComboBoxStyle.DropDownList;
            NomLivreur.FlatStyle = FlatStyle.Flat;
            NomLivreur.Font = new Font("Segoe UI", 11F);
            NomLivreur.ForeColor = Color.FromArgb(35, 42, 32);
            NomLivreur.FormattingEnabled = true;
            NomLivreur.Location = new Point(224, 104);
            NomLivreur.Name = "NomLivreur";
            NomLivreur.Size = new Size(240, 33);
            NomLivreur.TabIndex = 5;
            NomLivreur.SelectedIndexChanged += livreurcommande_SelectedIndexChanged;
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
            sidebar.Controls.Add(actifPrepareesBtn);
            sidebar.Controls.Add(navLivraison);
            sidebar.Controls.Add(navLivrees);
            sidebar.Controls.Add(button1);
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(316, 924);
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
            logoSubtitle.Text = "Commandes préparées";
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
            gestionLabel.Location = new Point(22, 224);
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
            navVendeur.Location = new Point(20, 250);
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
            navAnimal.Location = new Point(20, 300);
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
            navLogs.Location = new Point(20, 350);
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
            commandesLabel.Location = new Point(22, 412);
            commandesLabel.Name = "commandesLabel";
            commandesLabel.Size = new Size(260, 20);
            commandesLabel.TabIndex = 10;
            commandesLabel.Text = "COMMANDES";
            // 
            // actifPrepareesBtn
            // 
            actifPrepareesBtn.BackColor = Color.White;
            actifPrepareesBtn.Cursor = Cursors.Hand;
            actifPrepareesBtn.FlatAppearance.BorderSize = 0;
            actifPrepareesBtn.FlatStyle = FlatStyle.Flat;
            actifPrepareesBtn.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            actifPrepareesBtn.ForeColor = Color.FromArgb(49, 83, 29);
            actifPrepareesBtn.Location = new Point(20, 440);
            actifPrepareesBtn.Name = "actifPrepareesBtn";
            actifPrepareesBtn.Padding = new Padding(14, 0, 0, 0);
            actifPrepareesBtn.Size = new Size(290, 46);
            actifPrepareesBtn.TabIndex = 11;
            actifPrepareesBtn.Text = "📦  Commandes préparées";
            actifPrepareesBtn.TextAlign = ContentAlignment.MiddleLeft;
            actifPrepareesBtn.UseVisualStyleBackColor = false;
            // 
            // navLivraison
            // 
            navLivraison.BackColor = Color.FromArgb(65, 103, 39);
            navLivraison.Cursor = Cursors.Hand;
            navLivraison.FlatAppearance.BorderSize = 0;
            navLivraison.FlatStyle = FlatStyle.Flat;
            navLivraison.Font = new Font("Segoe UI", 11.5F);
            navLivraison.ForeColor = Color.White;
            navLivraison.Location = new Point(20, 492);
            navLivraison.Name = "navLivraison";
            navLivraison.Padding = new Padding(14, 0, 0, 0);
            navLivraison.Size = new Size(276, 44);
            navLivraison.TabIndex = 12;
            navLivraison.Text = "🚚  En cours de livraison";
            navLivraison.TextAlign = ContentAlignment.MiddleLeft;
            navLivraison.UseVisualStyleBackColor = false;
            navLivraison.Click += navLivraison_Click;
            // 
            // navLivrees
            // 
            navLivrees.BackColor = Color.FromArgb(65, 103, 39);
            navLivrees.Cursor = Cursors.Hand;
            navLivrees.FlatAppearance.BorderSize = 0;
            navLivrees.FlatStyle = FlatStyle.Flat;
            navLivrees.Font = new Font("Segoe UI", 11.5F);
            navLivrees.ForeColor = Color.White;
            navLivrees.Location = new Point(20, 542);
            navLivrees.Name = "navLivrees";
            navLivrees.Padding = new Padding(14, 0, 0, 0);
            navLivrees.Size = new Size(276, 44);
            navLivrees.TabIndex = 13;
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
            yellowLine.Size = new Size(6, 924);
            yellowLine.TabIndex = 1;
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.BackColor = Color.FromArgb(250, 251, 249);
            mainPanel.Controls.Add(pageTitle);
            mainPanel.Controls.Add(pageSubtitle);
            mainPanel.Controls.Add(roleBadgeLabel);
            mainPanel.Controls.Add(tableCard);
            mainPanel.Controls.Add(actionCard);
            mainPanel.Location = new Point(322, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1007, 924);
            mainPanel.TabIndex = 2;
            // 
            // pageTitle
            // 
            pageTitle.BackColor = Color.Transparent;
            pageTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            pageTitle.ForeColor = Color.FromArgb(24, 28, 22);
            pageTitle.Location = new Point(44, 32);
            pageTitle.Name = "pageTitle";
            pageTitle.Size = new Size(620, 44);
            pageTitle.TabIndex = 0;
            pageTitle.Text = "Commandes préparées";
            // 
            // pageSubtitle
            // 
            pageSubtitle.BackColor = Color.Transparent;
            pageSubtitle.Font = new Font("Segoe UI", 11F);
            pageSubtitle.ForeColor = Color.FromArgb(100, 110, 98);
            pageSubtitle.Location = new Point(44, 78);
            pageSubtitle.Name = "pageSubtitle";
            pageSubtitle.Size = new Size(640, 24);
            pageSubtitle.TabIndex = 1;
            pageSubtitle.Text = "Consultez les commandes prêtes et attribuez-les à un livreur";
            // 
            // roleBadgeLabel
            // 
            roleBadgeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roleBadgeLabel.BackColor = Color.White;
            roleBadgeLabel.BorderStyle = BorderStyle.FixedSingle;
            roleBadgeLabel.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            roleBadgeLabel.ForeColor = Color.FromArgb(35, 42, 32);
            roleBadgeLabel.Location = new Point(794, 30);
            roleBadgeLabel.Name = "roleBadgeLabel";
            roleBadgeLabel.Size = new Size(172, 38);
            roleBadgeLabel.TabIndex = 2;
            roleBadgeLabel.Text = "🚚  Livreur";
            roleBadgeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableCard
            // 
            tableCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableCard.BackColor = Color.White;
            tableCard.BorderStyle = BorderStyle.FixedSingle;
            tableCard.Controls.Add(cardTitle);
            tableCard.Controls.Add(dataGridView1);
            tableCard.Location = new Point(44, 124);
            tableCard.Name = "tableCard";
            tableCard.Size = new Size(922, 488);
            tableCard.TabIndex = 3;
            // 
            // cardTitle
            // 
            cardTitle.BackColor = Color.Transparent;
            cardTitle.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            cardTitle.ForeColor = Color.FromArgb(24, 28, 22);
            cardTitle.Location = new Point(24, 18);
            cardTitle.Name = "cardTitle";
            cardTitle.Size = new Size(460, 26);
            cardTitle.TabIndex = 0;
            cardTitle.Text = "📦  Liste des commandes préparées";
            // 
            // actionCard
            // 
            actionCard.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            actionCard.BackColor = Color.White;
            actionCard.BorderStyle = BorderStyle.FixedSingle;
            actionCard.Controls.Add(actionTitle);
            actionCard.Controls.Add(actionSubtitle);
            actionCard.Controls.Add(selectOrderLabel);
            actionCard.Controls.Add(idComamnde);
            actionCard.Controls.Add(selectLivreurLabel);
            actionCard.Controls.Add(NomLivreur);
            actionCard.Controls.Add(livrerlescommandes);
            actionCard.Location = new Point(44, 632);
            actionCard.Name = "actionCard";
            actionCard.Size = new Size(922, 172);
            actionCard.TabIndex = 4;
            // 
            // actionTitle
            // 
            actionTitle.BackColor = Color.Transparent;
            actionTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            actionTitle.ForeColor = Color.FromArgb(24, 28, 22);
            actionTitle.Location = new Point(24, 18);
            actionTitle.Name = "actionTitle";
            actionTitle.Size = new Size(460, 26);
            actionTitle.TabIndex = 0;
            actionTitle.Text = "🚚  Mettre une commande en livraison";
            // 
            // actionSubtitle
            // 
            actionSubtitle.BackColor = Color.Transparent;
            actionSubtitle.Font = new Font("Segoe UI", 9.5F);
            actionSubtitle.ForeColor = Color.FromArgb(110, 120, 108);
            actionSubtitle.Location = new Point(24, 44);
            actionSubtitle.Name = "actionSubtitle";
            actionSubtitle.Size = new Size(640, 20);
            actionSubtitle.TabIndex = 1;
            actionSubtitle.Text = "Choisissez l'identifiant de la commande et le livreur puis passez la commande en livraison.";
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
            // selectLivreurLabel
            // 
            selectLivreurLabel.BackColor = Color.Transparent;
            selectLivreurLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            selectLivreurLabel.ForeColor = Color.FromArgb(35, 42, 32);
            selectLivreurLabel.Location = new Point(224, 78);
            selectLivreurLabel.Name = "selectLivreurLabel";
            selectLivreurLabel.Size = new Size(180, 22);
            selectLivreurLabel.TabIndex = 4;
            selectLivreurLabel.Text = "Livreur";
            // 
            // VueCommande
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1329, 924);
            Controls.Add(mainPanel);
            Controls.Add(yellowLine);
            Controls.Add(sidebar);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1050, 750);
            Name = "VueCommande";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vue des commandes";
            Load += VueCommande_Load;
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