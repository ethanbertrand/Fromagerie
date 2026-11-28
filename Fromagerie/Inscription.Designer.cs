
namespace Fromagerie
{
    partial class Inscription
    {
        private System.ComponentModel.IContainer components = null;

        private Panel card;
        private PictureBox brandLogo;
        private Label welcomeTitle;
        private Label subtitle;
        private Label footer;
        private TextBox EmailTB;
        private TextBox mdp;
        private TextBox mdpinscription;

        private Button TestMDP;
        private Label LienConnexion;
        private Panel emailPanel;
        private Panel passwordPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            card = new Panel();
            brandLogo = new PictureBox();
            welcomeTitle = new Label();
            subtitle = new Label();
            emailPanel = new Panel();
            userIcon = new Label();
            EmailTB = new TextBox();
            passwordPanel = new Panel();
            lockIcon = new Label();
            mdp = new TextBox();
            TestMDP = new Button();
            LienConnexion = new Label();
            footer = new Label();
            mdpinscription = new TextBox();
            card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)brandLogo).BeginInit();
            emailPanel.SuspendLayout();
            passwordPanel.SuspendLayout();
            SuspendLayout();
            // 
            // card
            // 
            card.Anchor = AnchorStyles.None;
            card.BackColor = Color.White;
            card.Controls.Add(brandLogo);
            card.Controls.Add(welcomeTitle);
            card.Controls.Add(subtitle);
            card.Controls.Add(emailPanel);
            card.Controls.Add(passwordPanel);
            card.Controls.Add(TestMDP);
            card.Controls.Add(LienConnexion);
            card.Controls.Add(footer);
            card.Location = new Point(388, 35);
            card.Name = "card";
            card.Size = new Size(760, 940);
            card.TabIndex = 0;
            // 
            // brandLogo
            // 
            brandLogo.BackColor = Color.Transparent;
            brandLogo.Image = Properties.Resources.brandlogo;
            brandLogo.Location = new Point(243, 21);
            brandLogo.Name = "brandLogo";
            brandLogo.Size = new Size(264, 223);
            brandLogo.SizeMode = PictureBoxSizeMode.Zoom;
            brandLogo.TabIndex = 0;
            brandLogo.TabStop = false;
            // 
            // welcomeTitle
            // 
            welcomeTitle.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            welcomeTitle.ForeColor = Color.FromArgb(35, 69, 20);
            welcomeTitle.Location = new Point(0, 273);
            welcomeTitle.Name = "welcomeTitle";
            welcomeTitle.Size = new Size(760, 65);
            welcomeTitle.TabIndex = 2;
            welcomeTitle.Text = "Créer un compte";
            welcomeTitle.TextAlign = ContentAlignment.MiddleCenter;
            welcomeTitle.Click += welcomeTitle_Click;
            // 
            // subtitle
            // 
            subtitle.Font = new Font("Segoe UI", 15F);
            subtitle.ForeColor = Color.FromArgb(65, 103, 39);
            subtitle.Location = new Point(0, 354);
            subtitle.Name = "subtitle";
            subtitle.Size = new Size(760, 40);
            subtitle.TabIndex = 3;
            subtitle.Text = "Rejoignez votre espace Eure-et-Loir Fromage";
            subtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // emailPanel
            // 
            emailPanel.BackColor = Color.White;
            emailPanel.BorderStyle = BorderStyle.FixedSingle;
            emailPanel.Controls.Add(userIcon);
            emailPanel.Controls.Add(EmailTB);
            emailPanel.Location = new Point(70, 424);
            emailPanel.Name = "emailPanel";
            emailPanel.Size = new Size(620, 65);
            emailPanel.TabIndex = 6;
            // 
            // userIcon
            // 
            userIcon.Font = new Font("Segoe UI Symbol", 25F);
            userIcon.ForeColor = Color.FromArgb(65, 103, 39);
            userIcon.Location = new Point(3, 0);
            userIcon.Name = "userIcon";
            userIcon.Size = new Size(55, 55);
            userIcon.TabIndex = 1;
            userIcon.Text = "📧";
            userIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EmailTB
            // 
            EmailTB.BorderStyle = BorderStyle.None;
            EmailTB.Font = new Font("Segoe UI", 16F);
            EmailTB.ForeColor = Color.FromArgb(65, 72, 60);
            EmailTB.Location = new Point(64, 15);
            EmailTB.Name = "EmailTB";
            EmailTB.PlaceholderText = "Adresse e-mail";
            EmailTB.Size = new Size(551, 36);
            EmailTB.TabIndex = 0;
            EmailTB.TextChanged += EmailTB_TextChanged;
            // 
            // passwordPanel
            // 
            passwordPanel.BackColor = Color.White;
            passwordPanel.BorderStyle = BorderStyle.FixedSingle;
            passwordPanel.Controls.Add(lockIcon);
            passwordPanel.Controls.Add(mdp);
            passwordPanel.Location = new Point(70, 529);
            passwordPanel.Name = "passwordPanel";
            passwordPanel.Size = new Size(620, 65);
            passwordPanel.TabIndex = 7;
            // 
            // lockIcon
            // 
            lockIcon.Font = new Font("Segoe UI Emoji", 22F);
            lockIcon.ForeColor = Color.FromArgb(65, 103, 39);
            lockIcon.Location = new Point(3, 1);
            lockIcon.Name = "lockIcon";
            lockIcon.Size = new Size(55, 55);
            lockIcon.TabIndex = 1;
            lockIcon.Text = "🔒";
            lockIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mdp
            // 
            mdp.BorderStyle = BorderStyle.None;
            mdp.Font = new Font("Segoe UI", 16F);
            mdp.ForeColor = Color.FromArgb(65, 72, 60);
            mdp.Location = new Point(64, 14);
            mdp.Name = "mdp";
            mdp.PasswordChar = '•';
            mdp.PlaceholderText = "Mot de passe";
            mdp.Size = new Size(551, 36);
            mdp.TabIndex = 0;
            // 
            // TestMDP
            // 
            TestMDP.BackColor = Color.FromArgb(65, 103, 39);
            TestMDP.Cursor = Cursors.Hand;
            TestMDP.FlatAppearance.BorderSize = 0;
            TestMDP.FlatStyle = FlatStyle.Flat;
            TestMDP.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TestMDP.ForeColor = Color.White;
            TestMDP.Location = new Point(70, 656);
            TestMDP.Name = "TestMDP";
            TestMDP.Size = new Size(620, 75);
            TestMDP.TabIndex = 8;
            TestMDP.Text = "Créer mon compte";
            TestMDP.UseVisualStyleBackColor = false;
            // 
            // LienConnexion
            // 
            LienConnexion.Cursor = Cursors.Hand;
            LienConnexion.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            LienConnexion.ForeColor = Color.FromArgb(65, 103, 39);
            LienConnexion.Location = new Point(70, 789);
            LienConnexion.Name = "LienConnexion";
            LienConnexion.Size = new Size(620, 35);
            LienConnexion.TabIndex = 9;
            LienConnexion.Text = "Déjà un compte ?  Se connecter";
            LienConnexion.TextAlign = ContentAlignment.MiddleCenter;
            LienConnexion.Click += LienConnexion_Click;
            // 
            // footer
            // 
            footer.Font = new Font("Segoe UI", 17F, FontStyle.Italic);
            footer.ForeColor = Color.FromArgb(35, 69, 20);
            footer.Location = new Point(70, 859);
            footer.Name = "footer";
            footer.Size = new Size(620, 35);
            footer.TabIndex = 10;
            footer.Text = "Eure-et-Loir Fromage";
            footer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mdpinscription
            // 
            mdpinscription.Location = new Point(0, 0);
            mdpinscription.Name = "mdpinscription";
            mdpinscription.Size = new Size(100, 27);
            mdpinscription.TabIndex = 0;
            mdpinscription.Visible = false;
            // 
            // Inscription
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(248, 249, 245);
            BackgroundImage = Properties.Resources.Designer__1_;
            ClientSize = new Size(1536, 1024);
            Controls.Add(card);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1050, 850);
            Name = "Inscription";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscription - Eure-et-Loir Fromage";
            card.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)brandLogo).EndInit();
            emailPanel.ResumeLayout(false);
            emailPanel.PerformLayout();
            passwordPanel.ResumeLayout(false);
            passwordPanel.PerformLayout();
            ResumeLayout(false);
        }

        private Label userIcon;
        private Label lockIcon;
    }
}
