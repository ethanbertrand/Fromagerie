namespace Fromagerie
{
    partial class PageAdmin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private Label label1;
        private Button Inscription;
        private TextBox Inscriptionvendeur;
        private TextBox UnInscripMDPUser;
        private ComboBox RoleCB;
        private Button button2;
        private Button pagevendeur;
        private Button unajoutanimal;
        private Button afficherlogs;
        private Button livrees;
        private Button livraison_;

        private Panel sidebar;
        private Panel mainPanel;
        private Panel inscriptionPanel;
        private Panel yellowLine;

        private Label logoTitle;
        private Label logoSubtitle;
        private Label comptesLabel;
        private Label gestionLabel;
        private Label commandesLabel;
        private Label adminLabel;
        private Label logo;
        private Panel separator;
        private Button inscrire;
        private Button togglePasswordBtn;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageAdmin));
            label1 = new Label();
            adminLabel = new Label();
            inscriptionPanel = new Panel();
            Inscriptionvendeur = new TextBox();
            UnInscripMDPUser = new TextBox();
            togglePasswordBtn = new Button();
            RoleCB = new ComboBox();
            inscrire = new Button();
            Inscription = new Button();
            button2 = new Button();
            pagevendeur = new Button();
            unajoutanimal = new Button();
            afficherlogs = new Button();
            livrees = new Button();
            livraison_ = new Button();
            sidebar = new Panel();
            logoTitle = new Label();
            logoSubtitle = new Label();
            separator = new Panel();
            comptesLabel = new Label();
            gestionLabel = new Label();
            commandesLabel = new Label();
            logo = new Label();
            mainPanel = new Panel();
            yellowLine = new Panel();
            inscriptionPanel.SuspendLayout();
            sidebar.SuspendLayout();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(24, 28, 22);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(151, 42);
            label1.Name = "label1";
            label1.Size = new Size(436, 79);
            label1.TabIndex = 0;
            label1.Text = "Inscription utilisateur";
            // 
            // adminLabel
            // 
            adminLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            adminLabel.BackColor = Color.White;
            adminLabel.BorderStyle = BorderStyle.FixedSingle;
            adminLabel.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            adminLabel.ForeColor = Color.FromArgb(35, 42, 32);
            adminLabel.Location = new Point(995, 32);
            adminLabel.Name = "adminLabel";
            adminLabel.Size = new Size(148, 38);
            adminLabel.TabIndex = 2;
            adminLabel.Text = "👤  Administrateur";
            adminLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inscriptionPanel
            // 
            inscriptionPanel.BackColor = Color.White;
            inscriptionPanel.BorderStyle = BorderStyle.FixedSingle;
            inscriptionPanel.Controls.Add(label1);
            inscriptionPanel.Controls.Add(Inscriptionvendeur);
            inscriptionPanel.Controls.Add(UnInscripMDPUser);
            inscriptionPanel.Controls.Add(togglePasswordBtn);
            inscriptionPanel.Controls.Add(RoleCB);
            inscriptionPanel.Controls.Add(inscrire);
            inscriptionPanel.Location = new Point(175, 339);
            inscriptionPanel.Name = "inscriptionPanel";
            inscriptionPanel.Size = new Size(751, 532);
            inscriptionPanel.TabIndex = 3;
            inscriptionPanel.Paint += inscriptionPanel_Paint;
            // 
            // Inscriptionvendeur
            // 
            Inscriptionvendeur.BackColor = Color.White;
            Inscriptionvendeur.BorderStyle = BorderStyle.FixedSingle;
            Inscriptionvendeur.Font = new Font("Segoe UI", 11.5F);
            Inscriptionvendeur.ForeColor = Color.FromArgb(35, 42, 32);
            Inscriptionvendeur.Location = new Point(151, 186);
            Inscriptionvendeur.Name = "Inscriptionvendeur";
            Inscriptionvendeur.PlaceholderText = "📧   Identifiant";
            Inscriptionvendeur.Size = new Size(436, 33);
            Inscriptionvendeur.TabIndex = 2;
            // 
            // UnInscripMDPUser
            // 
            UnInscripMDPUser.BackColor = Color.White;
            UnInscripMDPUser.BorderStyle = BorderStyle.FixedSingle;
            UnInscripMDPUser.Font = new Font("Segoe UI", 11.5F);
            UnInscripMDPUser.ForeColor = Color.FromArgb(35, 42, 32);
            UnInscripMDPUser.Location = new Point(151, 264);
            UnInscripMDPUser.Name = "UnInscripMDPUser";
            UnInscripMDPUser.PasswordChar = '•';
            UnInscripMDPUser.PlaceholderText = "🔒   Mot de passe";
            UnInscripMDPUser.Size = new Size(398, 33);
            UnInscripMDPUser.TabIndex = 3;
            // 
            // togglePasswordBtn
            // 
            togglePasswordBtn.BackColor = Color.White;
            togglePasswordBtn.Cursor = Cursors.Hand;
            togglePasswordBtn.FlatAppearance.BorderColor = Color.FromArgb(123, 123, 123);
            togglePasswordBtn.FlatStyle = FlatStyle.Flat;
            togglePasswordBtn.Font = new Font("Segoe UI Emoji", 10F);
            togglePasswordBtn.ForeColor = Color.FromArgb(90, 95, 90);
            togglePasswordBtn.Location = new Point(548, 264);
            togglePasswordBtn.Name = "togglePasswordBtn";
            togglePasswordBtn.Size = new Size(39, 33);
            togglePasswordBtn.TabIndex = 14;
            togglePasswordBtn.Text = "👁";
            togglePasswordBtn.UseVisualStyleBackColor = false;
            togglePasswordBtn.Click += togglePasswordBtn_Click;
            // 
            // RoleCB
            // 
            RoleCB.BackColor = Color.White;
            RoleCB.DropDownStyle = ComboBoxStyle.DropDownList;
            RoleCB.FlatStyle = FlatStyle.Flat;
            RoleCB.Font = new Font("Segoe UI", 11.5F);
            RoleCB.ForeColor = Color.FromArgb(35, 42, 32);
            RoleCB.Location = new Point(151, 357);
            RoleCB.Name = "RoleCB";
            RoleCB.Size = new Size(436, 33);
            RoleCB.TabIndex = 4;
            // 
            // inscrire
            // 
            inscrire.BackColor = Color.FromArgb(92, 134, 48);
            inscrire.Cursor = Cursors.Hand;
            inscrire.FlatAppearance.BorderSize = 0;
            inscrire.FlatStyle = FlatStyle.Flat;
            inscrire.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            inscrire.ForeColor = Color.White;
            inscrire.Location = new Point(151, 448);
            inscrire.Name = "inscrire";
            inscrire.Size = new Size(436, 52);
            inscrire.TabIndex = 5;
            inscrire.Text = "👤+   Inscrire l'utilisateur";
            inscrire.UseVisualStyleBackColor = false;
            inscrire.Click += inscrire_Click;
            // 
            // Inscription
            // 
            Inscription.BackColor = Color.White;
            Inscription.Cursor = Cursors.Hand;
            Inscription.FlatAppearance.BorderSize = 0;
            Inscription.FlatStyle = FlatStyle.Flat;
            Inscription.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            Inscription.ForeColor = Color.FromArgb(49, 83, 29);
            Inscription.Location = new Point(20, 169);
            Inscription.Name = "Inscription";
            Inscription.Padding = new Padding(14, 0, 0, 0);
            Inscription.Size = new Size(276, 46);
            Inscription.TabIndex = 7;
            Inscription.Text = "👤+  Inscription utilisateur";
            Inscription.TextAlign = ContentAlignment.MiddleLeft;
            Inscription.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.BackColor = Color.FromArgb(65, 103, 39);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(166, 192, 143);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(20, 845);
            button2.Name = "button2";
            button2.Size = new Size(276, 46);
            button2.TabIndex = 13;
            button2.Text = "⇥   Déconnexion";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // pagevendeur
            // 
            pagevendeur.BackColor = Color.FromArgb(65, 103, 39);
            pagevendeur.Cursor = Cursors.Hand;
            pagevendeur.FlatAppearance.BorderSize = 0;
            pagevendeur.FlatStyle = FlatStyle.Flat;
            pagevendeur.Font = new Font("Segoe UI", 11.5F);
            pagevendeur.ForeColor = Color.White;
            pagevendeur.Location = new Point(20, 339);
            pagevendeur.Name = "pagevendeur";
            pagevendeur.Padding = new Padding(14, 0, 0, 0);
            pagevendeur.Size = new Size(276, 44);
            pagevendeur.TabIndex = 8;
            pagevendeur.Text = "🏪  Page Vendeur";
            pagevendeur.TextAlign = ContentAlignment.MiddleLeft;
            pagevendeur.UseVisualStyleBackColor = false;
            pagevendeur.Click += pagevendeur_Click_1;
            // 
            // unajoutanimal
            // 
            unajoutanimal.BackColor = Color.FromArgb(65, 103, 39);
            unajoutanimal.Cursor = Cursors.Hand;
            unajoutanimal.FlatAppearance.BorderSize = 0;
            unajoutanimal.FlatStyle = FlatStyle.Flat;
            unajoutanimal.Font = new Font("Segoe UI", 11.5F);
            unajoutanimal.ForeColor = Color.White;
            unajoutanimal.Location = new Point(20, 389);
            unajoutanimal.Name = "unajoutanimal";
            unajoutanimal.Padding = new Padding(14, 0, 0, 0);
            unajoutanimal.Size = new Size(276, 44);
            unajoutanimal.TabIndex = 9;
            unajoutanimal.Text = "🐄  Ajouter Animal";
            unajoutanimal.TextAlign = ContentAlignment.MiddleLeft;
            unajoutanimal.UseVisualStyleBackColor = false;
            unajoutanimal.Click += unajoutanimal_Click;
            // 
            // afficherlogs
            // 
            afficherlogs.BackColor = Color.FromArgb(65, 103, 39);
            afficherlogs.Cursor = Cursors.Hand;
            afficherlogs.FlatAppearance.BorderSize = 0;
            afficherlogs.FlatStyle = FlatStyle.Flat;
            afficherlogs.Font = new Font("Segoe UI", 11.5F);
            afficherlogs.ForeColor = Color.White;
            afficherlogs.Location = new Point(20, 447);
            afficherlogs.Name = "afficherlogs";
            afficherlogs.Padding = new Padding(14, 0, 0, 0);
            afficherlogs.Size = new Size(276, 44);
            afficherlogs.TabIndex = 10;
            afficherlogs.Text = "📄  Afficher les logs";
            afficherlogs.TextAlign = ContentAlignment.MiddleLeft;
            afficherlogs.UseVisualStyleBackColor = false;
            afficherlogs.Click += afficherlogs_Click_1;
            // 
            // livrees
            // 
            livrees.BackColor = Color.FromArgb(65, 103, 39);
            livrees.Cursor = Cursors.Hand;
            livrees.FlatAppearance.BorderSize = 0;
            livrees.FlatStyle = FlatStyle.Flat;
            livrees.Font = new Font("Segoe UI", 11.5F);
            livrees.ForeColor = Color.White;
            livrees.Location = new Point(20, 634);
            livrees.Name = "livrees";
            livrees.Padding = new Padding(14, 0, 0, 0);
            livrees.Size = new Size(276, 44);
            livrees.TabIndex = 12;
            livrees.Text = "✔  Commandes livrées";
            livrees.TextAlign = ContentAlignment.MiddleLeft;
            livrees.UseVisualStyleBackColor = false;
            livrees.Click += livrees_Click_1;
            // 
            // livraison_
            // 
            livraison_.BackColor = Color.FromArgb(65, 103, 39);
            livraison_.Cursor = Cursors.Hand;
            livraison_.FlatAppearance.BorderSize = 0;
            livraison_.FlatStyle = FlatStyle.Flat;
            livraison_.Font = new Font("Segoe UI", 11.5F);
            livraison_.ForeColor = Color.White;
            livraison_.Location = new Point(20, 584);
            livraison_.Name = "livraison_";
            livraison_.Padding = new Padding(14, 0, 0, 0);
            livraison_.Size = new Size(276, 44);
            livraison_.TabIndex = 11;
            livraison_.Text = "🚚  En cours de livraison";
            livraison_.TextAlign = ContentAlignment.MiddleLeft;
            livraison_.UseVisualStyleBackColor = false;
            livraison_.Click += livraison__Click_1;
            // 
            // sidebar
            // 
            sidebar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            sidebar.BackColor = Color.FromArgb(65, 103, 39);
            sidebar.Controls.Add(logoTitle);
            sidebar.Controls.Add(logoSubtitle);
            sidebar.Controls.Add(separator);
            sidebar.Controls.Add(comptesLabel);
            sidebar.Controls.Add(gestionLabel);
            sidebar.Controls.Add(commandesLabel);
            sidebar.Controls.Add(Inscription);
            sidebar.Controls.Add(pagevendeur);
            sidebar.Controls.Add(unajoutanimal);
            sidebar.Controls.Add(afficherlogs);
            sidebar.Controls.Add(livraison_);
            sidebar.Controls.Add(livrees);
            sidebar.Controls.Add(button2);
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(316, 918);
            sidebar.TabIndex = 2;
            // 
            // logoTitle
            // 
            logoTitle.BackColor = Color.Transparent;
            logoTitle.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            logoTitle.ForeColor = Color.White;
            logoTitle.Location = new Point(101, 16);
            logoTitle.Name = "logoTitle";
            logoTitle.Size = new Size(195, 71);
            logoTitle.TabIndex = 1;
            logoTitle.Text = "Eure-et-Loir\nFromage";
            // 
            // logoSubtitle
            // 
            logoSubtitle.BackColor = Color.Transparent;
            logoSubtitle.Font = new Font("Segoe UI", 9.5F);
            logoSubtitle.ForeColor = Color.FromArgb(196, 218, 177);
            logoSubtitle.Location = new Point(101, 87);
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
            // gestionLabel
            // 
            gestionLabel.BackColor = Color.Transparent;
            gestionLabel.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            gestionLabel.ForeColor = Color.FromArgb(182, 206, 162);
            gestionLabel.Location = new Point(20, 279);
            gestionLabel.Name = "gestionLabel";
            gestionLabel.Size = new Size(260, 20);
            gestionLabel.TabIndex = 5;
            gestionLabel.Text = "GESTION";
            // 
            // commandesLabel
            // 
            commandesLabel.BackColor = Color.Transparent;
            commandesLabel.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            commandesLabel.ForeColor = Color.FromArgb(182, 206, 162);
            commandesLabel.Location = new Point(22, 532);
            commandesLabel.Name = "commandesLabel";
            commandesLabel.Size = new Size(260, 20);
            commandesLabel.TabIndex = 6;
            commandesLabel.Text = "COMMANDES";
            commandesLabel.Click += commandesLabel_Click;
            // 
            // logo
            // 
            logo.BackColor = Color.FromArgb(232, 241, 211);
            logo.Font = new Font("Segoe UI Emoji", 30F);
            logo.Image = Properties.Resources.brandlogo;
            logo.Location = new Point(402, 32);
            logo.Name = "logo";
            logo.Size = new Size(260, 268);
            logo.TabIndex = 0;
            logo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.BackColor = Color.FromArgb(250, 251, 249);
            mainPanel.BackgroundImage = (Image)resources.GetObject("mainPanel.BackgroundImage");
            mainPanel.Controls.Add(logo);
            mainPanel.Controls.Add(adminLabel);
            mainPanel.Controls.Add(inscriptionPanel);
            mainPanel.Location = new Point(322, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1213, 918);
            mainPanel.TabIndex = 0;
            // 
            // yellowLine
            // 
            yellowLine.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            yellowLine.BackColor = Color.FromArgb(241, 187, 30);
            yellowLine.Location = new Point(312, 0);
            yellowLine.Name = "yellowLine";
            yellowLine.Size = new Size(276, 918);
            yellowLine.TabIndex = 1;
            // 
            // PageAdmin
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1535, 918);
            Controls.Add(mainPanel);
            Controls.Add(yellowLine);
            Controls.Add(sidebar);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1100, 750);
            Name = "PageAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administration - Eure-et-Loir Fromage";
            inscriptionPanel.ResumeLayout(false);
            inscriptionPanel.PerformLayout();
            sidebar.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void togglePasswordBtn_Click(object sender, EventArgs e)
        {
            UnInscripMDPUser.PasswordChar = UnInscripMDPUser.PasswordChar == '•' ? '\0' : '•';
        }

        private void inscriptionPanel_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush badgeBrush = new SolidBrush(Color.FromArgb(255, 243, 205)))
            {
                e.Graphics.FillRectangle(badgeBrush, 32, 30, 34, 34);
            }

            using (Font iconFont = new Font("Segoe UI Emoji", 12F))
            using (SolidBrush iconBrush = new SolidBrush(Color.FromArgb(180, 115, 0)))
            {
                e.Graphics.DrawString("👤+", iconFont, iconBrush, new PointF(34, 34));
            }
        }
    }
}