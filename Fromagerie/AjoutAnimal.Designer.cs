namespace Fromagerie
{
    partial class AjoutAnimal
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
        private TextBox animal;
        private Button button1;
        private Button retouradmin;

        private Panel sidebar;
        private Panel yellowLine;
        private Panel mainPanel;
        private Panel animalCard;
        private Panel separator;

        private Label logo;
        private Label logoTitle;
        private Label logoSubtitle;
        private Label comptesLabel;
        private Label gestionLabel;
        private Label commandesLabel;
        private Label adminLabel;
        private Label cardTitle;
        private Label cardSubtitle;

        private Button navInscription;
        private Button navVendeur;
        private Button actifAnimalBtn;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutAnimal));
            label1 = new Label();
            animal = new TextBox();
            button1 = new Button();
            retouradmin = new Button();
            sidebar = new Panel();
            logo = new Label();
            logoTitle = new Label();
            logoSubtitle = new Label();
            separator = new Panel();
            comptesLabel = new Label();
            navInscription = new Button();
            gestionLabel = new Label();
            navVendeur = new Button();
            actifAnimalBtn = new Button();
            navLogs = new Button();
            commandesLabel = new Label();
            navLivraison = new Button();
            navLivrees = new Button();
            yellowLine = new Panel();
            mainPanel = new Panel();
            adminLabel = new Label();
            animalCard = new Panel();
            cardTitle = new Label();
            cardSubtitle = new Label();
            label2 = new Label();
            sidebar.SuspendLayout();
            mainPanel.SuspendLayout();
            animalCard.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(349, 349);
            label1.Name = "label1";
            label1.Size = new Size(560, 77);
            label1.TabIndex = 0;
            label1.Text = "Ajout Animal";
            // 
            // animal
            // 
            animal.BackColor = Color.White;
            animal.BorderStyle = BorderStyle.FixedSingle;
            animal.Font = new Font("Segoe UI", 12F);
            animal.ForeColor = Color.FromArgb(35, 42, 32);
            animal.Location = new Point(32, 108);
            animal.Margin = new Padding(3, 4, 3, 4);
            animal.Name = "animal";
            animal.PlaceholderText = "🐄   Libellé de l'animal (ex. Vache, Chèvre...)";
            animal.Size = new Size(436, 34);
            animal.TabIndex = 2;
            animal.TextChanged += animal_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(92, 134, 48);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(32, 174);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(436, 52);
            button1.TabIndex = 3;
            button1.Text = "🐄   Ajouter l'animal";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // retouradmin
            // 
            retouradmin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            retouradmin.BackColor = Color.FromArgb(65, 103, 39);
            retouradmin.Cursor = Cursors.Hand;
            retouradmin.FlatAppearance.BorderColor = Color.FromArgb(166, 192, 143);
            retouradmin.FlatStyle = FlatStyle.Flat;
            retouradmin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            retouradmin.ForeColor = Color.White;
            retouradmin.Location = new Point(20, 845);
            retouradmin.Name = "retouradmin";
            retouradmin.Size = new Size(276, 46);
            retouradmin.TabIndex = 13;
            retouradmin.Text = "←   Déconnexion";
            retouradmin.UseVisualStyleBackColor = false;
            retouradmin.Click += retouradmin_Click;
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
            sidebar.Controls.Add(actifAnimalBtn);
            sidebar.Controls.Add(navLogs);
            sidebar.Controls.Add(commandesLabel);
            sidebar.Controls.Add(navLivraison);
            sidebar.Controls.Add(navLivrees);
            sidebar.Controls.Add(retouradmin);
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
            logoTitle.Size = new Size(195, 61);
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
            // actifAnimalBtn
            // 
            actifAnimalBtn.BackColor = Color.White;
            actifAnimalBtn.Cursor = Cursors.Hand;
            actifAnimalBtn.FlatAppearance.BorderSize = 0;
            actifAnimalBtn.FlatStyle = FlatStyle.Flat;
            actifAnimalBtn.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            actifAnimalBtn.ForeColor = Color.FromArgb(49, 83, 29);
            actifAnimalBtn.Location = new Point(20, 310);
            actifAnimalBtn.Name = "actifAnimalBtn";
            actifAnimalBtn.Padding = new Padding(14, 0, 0, 0);
            actifAnimalBtn.Size = new Size(276, 46);
            actifAnimalBtn.TabIndex = 8;
            actifAnimalBtn.Text = "🐄  Ajouter Animal";
            actifAnimalBtn.TextAlign = ContentAlignment.MiddleLeft;
            actifAnimalBtn.UseVisualStyleBackColor = false;
            actifAnimalBtn.Click += actifAnimalBtn_Click;
            // 
            // navLogs
            // 
            navLogs.BackColor = Color.FromArgb(65, 103, 39);
            navLogs.Cursor = Cursors.Hand;
            navLogs.FlatAppearance.BorderSize = 0;
            navLogs.FlatStyle = FlatStyle.Flat;
            navLogs.Font = new Font("Segoe UI", 11.5F);
            navLogs.ForeColor = Color.White;
            navLogs.Location = new Point(20, 362);
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
            commandesLabel.Location = new Point(22, 424);
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
            navLivraison.Location = new Point(20, 452);
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
            yellowLine.Size = new Size(6, 918);
            yellowLine.TabIndex = 1;
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.BackColor = Color.FromArgb(250, 251, 249);
            mainPanel.BackgroundImage = (Image)resources.GetObject("mainPanel.BackgroundImage");
            mainPanel.Controls.Add(label2);
            mainPanel.Controls.Add(label1);
            mainPanel.Controls.Add(adminLabel);
            mainPanel.Controls.Add(animalCard);
            mainPanel.Location = new Point(322, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1213, 918);
            mainPanel.TabIndex = 2;
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
            // animalCard
            // 
            animalCard.BackColor = Color.White;
            animalCard.BorderStyle = BorderStyle.FixedSingle;
            animalCard.Controls.Add(cardTitle);
            animalCard.Controls.Add(cardSubtitle);
            animalCard.Controls.Add(animal);
            animalCard.Controls.Add(button1);
            animalCard.Location = new Point(239, 452);
            animalCard.Name = "animalCard";
            animalCard.Size = new Size(539, 304);
            animalCard.TabIndex = 3;
            // 
            // cardTitle
            // 
            cardTitle.BackColor = Color.Transparent;
            cardTitle.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            cardTitle.ForeColor = Color.FromArgb(24, 28, 22);
            cardTitle.Location = new Point(32, 28);
            cardTitle.Name = "cardTitle";
            cardTitle.Size = new Size(360, 28);
            cardTitle.TabIndex = 0;
            cardTitle.Text = "🐄  Nouvel animal";
            // 
            // cardSubtitle
            // 
            cardSubtitle.BackColor = Color.Transparent;
            cardSubtitle.Font = new Font("Segoe UI", 10F);
            cardSubtitle.ForeColor = Color.FromArgb(110, 120, 108);
            cardSubtitle.Location = new Point(32, 56);
            cardSubtitle.Name = "cardSubtitle";
            cardSubtitle.Size = new Size(430, 22);
            cardSubtitle.TabIndex = 1;
            cardSubtitle.Text = "Saisissez le libellé de l'animal à ajouter.";
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(232, 241, 211);
            label2.Font = new Font("Segoe UI Emoji", 30F);
            label2.Image = Properties.Resources.brandlogo;
            label2.Location = new Point(349, 32);
            label2.Name = "label2";
            label2.Size = new Size(260, 268);
            label2.TabIndex = 4;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AjoutAnimal
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1535, 918);
            Controls.Add(mainPanel);
            Controls.Add(yellowLine);
            Controls.Add(sidebar);
            Font = new Font("Segoe UI", 10F);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1100, 750);
            Name = "AjoutAnimal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AjoutAnimal";
            Load += AjoutAnimal_Load;
            sidebar.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            animalCard.ResumeLayout(false);
            animalCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
    }
}