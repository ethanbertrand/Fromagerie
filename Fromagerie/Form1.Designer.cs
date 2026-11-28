
namespace Fromagerie
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button Inscription;
        private Label label1;
        private TextBox NomTB;
        private TextBox mdp;
        private TextBox mdpinscription;
        private Button TestMDP;
        private Label label2;
        private Label logo;
        private Label LienInscription;
        private Panel card;
        private PictureBox brandLogo;
        private Label welcomeTitle;
        private Label subtitle;
        private Label footer;
        private Panel usernamePanel;
        private Panel passwordPanel;
        private Label userIcon;
        private Label lockIcon;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Inscription = new Button();
            label1 = new Label();
            NomTB = new TextBox();
            mdp = new TextBox();
            mdpinscription = new TextBox();
            TestMDP = new Button();
            label2 = new Label();
            logo = new Label();
            LienInscription = new Label();
            card = new Panel();
            brandLogo = new PictureBox();
            welcomeTitle = new Label();
            subtitle = new Label();
            usernamePanel = new Panel();
            userIcon = new Label();
            passwordPanel = new Panel();
            lockIcon = new Label();
            footer = new Label();
            card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)brandLogo).BeginInit();
            usernamePanel.SuspendLayout();
            passwordPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Inscription
            // 
            Inscription.Location = new Point(0, 0);
            Inscription.Name = "Inscription";
            Inscription.Size = new Size(75, 23);
            Inscription.TabIndex = 0;
            Inscription.Visible = false;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Visible = false;
            // 
            // NomTB
            // 
            NomTB.BorderStyle = BorderStyle.None;
            NomTB.Font = new Font("Segoe UI", 17F);
            NomTB.ForeColor = Color.FromArgb(65, 72, 60);
            NomTB.Location = new Point(82, 20);
            NomTB.Name = "NomTB";
            NomTB.PlaceholderText = "Identifiant";
            NomTB.Size = new Size(510, 38);
            NomTB.TabIndex = 1;
            NomTB.TextChanged += Nom_TextChanged;
            // 
            // mdp
            // 
            mdp.BorderStyle = BorderStyle.None;
            mdp.Font = new Font("Segoe UI", 17F);
            mdp.ForeColor = Color.FromArgb(65, 72, 60);
            mdp.Location = new Point(82, 20);
            mdp.Name = "mdp";
            mdp.PasswordChar = '•';
            mdp.PlaceholderText = "Mot de passe";
            mdp.Size = new Size(510, 38);
            mdp.TabIndex = 1;
            mdp.TextChanged += mdp_TextChanged;
            // 
            // mdpinscription
            // 
            mdpinscription.Location = new Point(0, 0);
            mdpinscription.Name = "mdpinscription";
            mdpinscription.Size = new Size(100, 27);
            mdpinscription.TabIndex = 0;
            mdpinscription.Visible = false;
            // 
            // TestMDP
            // 
            TestMDP.BackColor = Color.FromArgb(65, 103, 39);
            TestMDP.Cursor = Cursors.Hand;
            TestMDP.FlatAppearance.BorderSize = 0;
            TestMDP.FlatStyle = FlatStyle.Flat;
            TestMDP.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            TestMDP.ForeColor = Color.White;
            TestMDP.Location = new Point(70, 680);
            TestMDP.Name = "TestMDP";
            TestMDP.Size = new Size(620, 82);
            TestMDP.TabIndex = 6;
            TestMDP.Text = "➜   Se connecter";
            TestMDP.UseVisualStyleBackColor = false;
            TestMDP.Click += TestMDP_Click;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            label2.Visible = false;
            // 
            // logo
            // 
            logo.Location = new Point(0, 0);
            logo.Name = "logo";
            logo.Size = new Size(100, 23);
            logo.TabIndex = 0;
            logo.Visible = false;
            // 
            // LienInscription
            // 
            LienInscription.Cursor = Cursors.Hand;
            LienInscription.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            LienInscription.ForeColor = Color.FromArgb(65, 103, 39);
            LienInscription.Location = new Point(100, 785);
            LienInscription.Name = "LienInscription";
            LienInscription.Size = new Size(560, 36);
            LienInscription.TabIndex = 7;
            LienInscription.Text = "Pas encore de compte ?  Créer un compte";
            LienInscription.TextAlign = ContentAlignment.MiddleCenter;
            LienInscription.Click += label3_Click;
            // 
            // card
            // 
            card.Anchor = AnchorStyles.None;
            card.BackColor = Color.White;
            card.Controls.Add(brandLogo);
            card.Controls.Add(welcomeTitle);
            card.Controls.Add(subtitle);
            card.Controls.Add(usernamePanel);
            card.Controls.Add(passwordPanel);
            card.Controls.Add(TestMDP);
            card.Controls.Add(LienInscription);
            card.Controls.Add(footer);
            card.Location = new Point(388, 55);
            card.Name = "card";
            card.Padding = new Padding(5);
            card.Size = new Size(760, 900);
            card.TabIndex = 0;
            // 
            // brandLogo
            // 
            brandLogo.BackColor = Color.Transparent;
            brandLogo.Image = Properties.Resources.brandlogo;
            brandLogo.Location = new Point(233, 25);
            brandLogo.Name = "brandLogo";
            brandLogo.Size = new Size(293, 262);
            brandLogo.SizeMode = PictureBoxSizeMode.Zoom;
            brandLogo.TabIndex = 0;
            brandLogo.TabStop = false;
            brandLogo.Click += brandLogo_Click;
            // 
            // welcomeTitle
            // 
            welcomeTitle.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            welcomeTitle.ForeColor = Color.FromArgb(35, 69, 20);
            welcomeTitle.Location = new Point(50, 290);
            welcomeTitle.Name = "welcomeTitle";
            welcomeTitle.Size = new Size(660, 72);
            welcomeTitle.TabIndex = 2;
            welcomeTitle.Text = "Bienvenue";
            welcomeTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // subtitle
            // 
            subtitle.Font = new Font("Segoe UI", 17F);
            subtitle.ForeColor = Color.FromArgb(65, 103, 39);
            subtitle.Location = new Point(35, 365);
            subtitle.Name = "subtitle";
            subtitle.Size = new Size(690, 42);
            subtitle.TabIndex = 3;
            subtitle.Text = "Connectez-vous pour accéder à votre espace";
            subtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usernamePanel
            // 
            usernamePanel.BackColor = Color.White;
            usernamePanel.BorderStyle = BorderStyle.FixedSingle;
            usernamePanel.Controls.Add(userIcon);
            usernamePanel.Controls.Add(NomTB);
            usernamePanel.Location = new Point(70, 465);
            usernamePanel.Name = "usernamePanel";
            usernamePanel.Size = new Size(620, 76);
            usernamePanel.TabIndex = 4;
            // 
            // userIcon
            // 
            userIcon.Font = new Font("Segoe UI Symbol", 25F);
            userIcon.ForeColor = Color.FromArgb(65, 103, 39);
            userIcon.Location = new Point(12, 8);
            userIcon.Name = "userIcon";
            userIcon.Size = new Size(55, 55);
            userIcon.TabIndex = 0;
            userIcon.Text = "📧";
            userIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordPanel
            // 
            passwordPanel.BackColor = Color.White;
            passwordPanel.BorderStyle = BorderStyle.FixedSingle;
            passwordPanel.Controls.Add(lockIcon);
            passwordPanel.Controls.Add(mdp);
            passwordPanel.Location = new Point(70, 565);
            passwordPanel.Name = "passwordPanel";
            passwordPanel.Size = new Size(620, 76);
            passwordPanel.TabIndex = 5;
            // 
            // lockIcon
            // 
            lockIcon.Font = new Font("Segoe UI Emoji", 22F);
            lockIcon.ForeColor = Color.FromArgb(65, 103, 39);
            lockIcon.Location = new Point(12, 8);
            lockIcon.Name = "lockIcon";
            lockIcon.Size = new Size(55, 55);
            lockIcon.TabIndex = 0;
            lockIcon.Text = "🔒";
            lockIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // footer
            // 
            footer.Font = new Font("Segoe UI", 18F, FontStyle.Italic);
            footer.ForeColor = Color.FromArgb(35, 69, 20);
            footer.Location = new Point(90, 840);
            footer.Name = "footer";
            footer.Size = new Size(580, 35);
            footer.TabIndex = 8;
            footer.Text = "Eure-et-Loir Fromage";
            footer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(248, 249, 245);
            BackgroundImage = Properties.Resources.Designer__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1536, 1024);
            Controls.Add(card);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1050, 780);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Connexion - Eure-et-Loir Fromage";
            card.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)brandLogo).EndInit();
            usernamePanel.ResumeLayout(false);
            usernamePanel.PerformLayout();
            passwordPanel.ResumeLayout(false);
            passwordPanel.PerformLayout();
            ResumeLayout(false);
        }
    }
}
