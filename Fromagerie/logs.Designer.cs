namespace Fromagerie
{
    partial class logs
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

        private DataGridView dataGridView1;
        private Button button1;

        private Panel sidebar;
        private Panel yellowLine;
        private Panel mainPanel;
        private Panel tableCard;
        private Panel separator;

        private Label logo;
        private Label logoTitle;
        private Label logoSubtitle;
        private Label comptesLabel;
        private Label gestionLabel;
        private Label commandesLabel;
        private Label pageTitle;
        private Label pageSubtitle;
        private Label adminLabel;

        private Button navInscription;
        private Button navVendeur;
        private Button navAnimal;
        private Button navLogs;
        private Button navLivraison;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logs));
            dataGridView1 = new DataGridView();
            button1 = new Button();
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
            navLivraison = new Button();
            navLivrees = new Button();
            yellowLine = new Panel();
            mainPanel = new Panel();
            pageTitle = new Label();
            pageSubtitle = new Label();
            adminLabel = new Label();
            tableCard = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            sidebar.SuspendLayout();
            mainPanel.SuspendLayout();
            tableCard.SuspendLayout();
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
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(12, 0, 12, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(65, 103, 39);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 44;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(35, 42, 32);
            dataGridViewCellStyle3.Padding = new Padding(12, 0, 12, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(232, 241, 211);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(49, 83, 29);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(234, 238, 231);
            dataGridView1.Location = new Point(28, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 38;
            dataGridView1.Size = new Size(1061, 571);
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
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(20, 845);
            button1.Name = "button1";
            button1.Size = new Size(276, 46);
            button1.TabIndex = 13;
            button1.Text = "←   Déconnexion";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            sidebar.Controls.Add(navLivraison);
            sidebar.Controls.Add(navLivrees);
            sidebar.Controls.Add(button1);
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(316, 918);
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
            logoTitle.Size = new Size(195, 63);
            logoTitle.TabIndex = 1;
            logoTitle.Text = "Eure-et-Loir\nFromage";
            logoTitle.Click += logoTitle_Click;
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
            logoSubtitle.Text = "Espace administrateur";
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
            navInscription.Location = new Point(20, 170);
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
            navLogs.BackColor = Color.White;
            navLogs.Cursor = Cursors.Hand;
            navLogs.FlatAppearance.BorderSize = 0;
            navLogs.FlatStyle = FlatStyle.Flat;
            navLogs.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            navLogs.ForeColor = Color.FromArgb(49, 83, 29);
            navLogs.Location = new Point(20, 360);
            navLogs.Name = "navLogs";
            navLogs.Padding = new Padding(14, 0, 0, 0);
            navLogs.Size = new Size(276, 46);
            navLogs.TabIndex = 9;
            navLogs.Text = "📄  Afficher les logs";
            navLogs.TextAlign = ContentAlignment.MiddleLeft;
            navLogs.UseVisualStyleBackColor = false;
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
            // navLivraison
            // 
            navLivraison.BackColor = Color.FromArgb(65, 103, 39);
            navLivraison.Cursor = Cursors.Hand;
            navLivraison.FlatAppearance.BorderSize = 0;
            navLivraison.FlatStyle = FlatStyle.Flat;
            navLivraison.Font = new Font("Segoe UI", 11.5F);
            navLivraison.ForeColor = Color.White;
            navLivraison.Location = new Point(20, 450);
            navLivraison.Name = "navLivraison";
            navLivraison.Padding = new Padding(14, 0, 0, 0);
            navLivraison.Size = new Size(276, 44);
            navLivraison.TabIndex = 11;
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
            navLivrees.Location = new Point(20, 500);
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
            yellowLine.Size = new Size(6, 918);
            yellowLine.TabIndex = 1;
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.BackColor = Color.FromArgb(250, 251, 249);
            mainPanel.BackgroundImage = (Image)resources.GetObject("mainPanel.BackgroundImage");
            mainPanel.Controls.Add(pageTitle);
            mainPanel.Controls.Add(pageSubtitle);
            mainPanel.Controls.Add(adminLabel);
            mainPanel.Controls.Add(tableCard);
            mainPanel.Location = new Point(322, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1213, 918);
            mainPanel.TabIndex = 2;
            // 
            // pageTitle
            // 
            pageTitle.BackColor = Color.Transparent;
            pageTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            pageTitle.ForeColor = Color.White;
            pageTitle.Location = new Point(48, 36);
            pageTitle.Name = "pageTitle";
            pageTitle.Size = new Size(560, 44);
            pageTitle.TabIndex = 0;
            pageTitle.Text = "Historique des connexions";
            pageTitle.Click += pageTitle_Click;
            // 
            // pageSubtitle
            // 
            pageSubtitle.BackColor = Color.Transparent;
            pageSubtitle.Font = new Font("Segoe UI", 11.5F);
            pageSubtitle.ForeColor = Color.White;
            pageSubtitle.Location = new Point(59, 98);
            pageSubtitle.Name = "pageSubtitle";
            pageSubtitle.Size = new Size(620, 24);
            pageSubtitle.TabIndex = 1;
            pageSubtitle.Text = "Consultez les de connexion";
            // 
            // adminLabel
            // 
            adminLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            adminLabel.BackColor = Color.White;
            adminLabel.BorderStyle = BorderStyle.FixedSingle;
            adminLabel.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            adminLabel.ForeColor = Color.FromArgb(35, 42, 32);
            adminLabel.Location = new Point(1017, 32);
            adminLabel.Name = "adminLabel";
            adminLabel.Size = new Size(148, 38);
            adminLabel.TabIndex = 2;
            adminLabel.Text = "👤  Administrateur";
            adminLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableCard
            // 
            tableCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableCard.BackColor = Color.White;
            tableCard.BorderStyle = BorderStyle.FixedSingle;
            tableCard.Controls.Add(dataGridView1);
            tableCard.Location = new Point(48, 160);
            tableCard.Name = "tableCard";
            tableCard.Size = new Size(1117, 687);
            tableCard.TabIndex = 3;
            // 
            // logs
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1535, 918);
            Controls.Add(mainPanel);
            Controls.Add(yellowLine);
            Controls.Add(sidebar);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1100, 750);
            Name = "logs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Historique des connexions - Eure-et-Loir Fromage";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            sidebar.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            tableCard.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}