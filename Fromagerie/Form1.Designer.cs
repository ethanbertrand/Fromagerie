namespace Fromagerie
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Inscription = new Button();
            label1 = new Label();
            button1 = new Button();
            NomTB = new TextBox();
            mdp = new TextBox();
            TestMDP = new Button();
            InscripUserTb = new TextBox();
            InscripMDPUser = new TextBox();
            envoiepagefromage = new Button();
            AjoutAchatB = new Button();
            label2 = new Label();
            AjoutCommandeB = new Button();
            AjoutRoleB = new Button();
            RoleCB = new ComboBox();
            AjoutTypeFromageB = new Button();
            AjoutProducteur = new Button();
            button2 = new Button();
            AjoutPermissionDesRolesB = new Button();
            AjoutEntrepotB = new Button();
            AjoutZoneB = new Button();
            AjoutEmplacementB = new Button();
            SuspendLayout();
            // 
            // Inscription
            // 
            Inscription.Location = new Point(920, 470);
            Inscription.Margin = new Padding(3, 4, 3, 4);
            Inscription.Name = "Inscription";
            Inscription.Size = new Size(115, 55);
            Inscription.TabIndex = 0;
            Inscription.Text = "Inscription";
            Inscription.UseVisualStyleBackColor = true;
            Inscription.Click += button1_Click;
            // 
            // label1
            // 
            label1.Location = new Point(555, 116);
            label1.Name = "label1";
            label1.Size = new Size(144, 27);
            label1.TabIndex = 4;
            label1.Text = "Eure-Et-Loir Fromage";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(126, 90);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "test";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // NomTB
            // 
            NomTB.Location = new Point(255, 297);
            NomTB.Name = "NomTB";
            NomTB.Size = new Size(125, 27);
            NomTB.TabIndex = 6;
            NomTB.TextChanged += Nom_TextChanged;
            // 
            // mdp
            // 
            mdp.Location = new Point(255, 357);
            mdp.Name = "mdp";
            mdp.Size = new Size(125, 27);
            mdp.TabIndex = 7;
            // 
            // TestMDP
            // 
            TestMDP.Location = new Point(266, 448);
            TestMDP.Name = "TestMDP";
            TestMDP.Size = new Size(94, 29);
            TestMDP.TabIndex = 8;
            TestMDP.Text = "Connexion";
            TestMDP.UseVisualStyleBackColor = true;
            TestMDP.Click += TestMDP_Click;
            // 
            // InscripUserTb
            // 
            InscripUserTb.Location = new Point(892, 297);
            InscripUserTb.Name = "InscripUserTb";
            InscripUserTb.Size = new Size(164, 27);
            InscripUserTb.TabIndex = 9;
            // 
            // InscripMDPUser
            // 
            InscripMDPUser.Location = new Point(910, 339);
            InscripMDPUser.Name = "InscripMDPUser";
            InscripMDPUser.Size = new Size(125, 27);
            InscripMDPUser.TabIndex = 10;
            // 
            // envoiepagefromage
            // 
            envoiepagefromage.Location = new Point(114, 786);
            envoiepagefromage.Name = "envoiepagefromage";
            envoiepagefromage.Size = new Size(143, 37);
            envoiepagefromage.TabIndex = 11;
            envoiepagefromage.Text = "AjoutFromage";
            envoiepagefromage.UseVisualStyleBackColor = true;
            envoiepagefromage.Click += envoiepage_Click;
            // 
            // AjoutAchatB
            // 
            AjoutAchatB.Location = new Point(331, 786);
            AjoutAchatB.Name = "AjoutAchatB";
            AjoutAchatB.Size = new Size(143, 37);
            AjoutAchatB.TabIndex = 12;
            AjoutAchatB.Text = "AjoutAchat";
            AjoutAchatB.UseVisualStyleBackColor = true;
            AjoutAchatB.Click += AjoutAchatB_Click;
            // 
            // label2
            // 
            label2.Location = new Point(253, 230);
            label2.Name = "label2";
            label2.Size = new Size(144, 27);
            label2.TabIndex = 13;
            // 
            // AjoutCommandeB
            // 
            AjoutCommandeB.Location = new Point(555, 786);
            AjoutCommandeB.Name = "AjoutCommandeB";
            AjoutCommandeB.Size = new Size(143, 37);
            AjoutCommandeB.TabIndex = 14;
            AjoutCommandeB.Text = "AjoutCommande";
            AjoutCommandeB.UseVisualStyleBackColor = true;
            AjoutCommandeB.Click += AjoutCommande_Click;
            // 
            // AjoutRoleB
            // 
            AjoutRoleB.Location = new Point(772, 786);
            AjoutRoleB.Name = "AjoutRoleB";
            AjoutRoleB.Size = new Size(143, 37);
            AjoutRoleB.TabIndex = 15;
            AjoutRoleB.Text = "AjoutRole";
            AjoutRoleB.UseVisualStyleBackColor = true;
            AjoutRoleB.Click += AjoutRoleB_Click;
            // 
            // RoleCB
            // 
            RoleCB.FormattingEnabled = true;
            RoleCB.Location = new Point(903, 413);
            RoleCB.Name = "RoleCB";
            RoleCB.Size = new Size(153, 28);
            RoleCB.TabIndex = 16;
            RoleCB.SelectedIndexChanged += RoleCB_SelectedIndexChanged;
            // 
            // AjoutTypeFromageB
            // 
            AjoutTypeFromageB.Location = new Point(968, 786);
            AjoutTypeFromageB.Name = "AjoutTypeFromageB";
            AjoutTypeFromageB.Size = new Size(143, 37);
            AjoutTypeFromageB.TabIndex = 17;
            AjoutTypeFromageB.Text = "AjoutTypeFromage";
            AjoutTypeFromageB.UseVisualStyleBackColor = true;
            AjoutTypeFromageB.Click += AjoutTypeFromageB_Click;
            // 
            // AjoutProducteur
            // 
            AjoutProducteur.Location = new Point(114, 880);
            AjoutProducteur.Name = "AjoutProducteur";
            AjoutProducteur.Size = new Size(143, 37);
            AjoutProducteur.TabIndex = 18;
            AjoutProducteur.Text = "AjoutProducteurB";
            AjoutProducteur.UseVisualStyleBackColor = true;
            AjoutProducteur.Click += AjoutProducteur_Click;
            // 
            // button2
            // 
            button2.Location = new Point(331, 880);
            button2.Name = "button2";
            button2.Size = new Size(143, 37);
            button2.TabIndex = 19;
            button2.Text = "AjoutPermission";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AjoutPermissionDesRolesB
            // 
            AjoutPermissionDesRolesB.Location = new Point(525, 880);
            AjoutPermissionDesRolesB.Name = "AjoutPermissionDesRolesB";
            AjoutPermissionDesRolesB.Size = new Size(188, 37);
            AjoutPermissionDesRolesB.TabIndex = 20;
            AjoutPermissionDesRolesB.Text = "AjoutPermissionDesRoles";
            AjoutPermissionDesRolesB.UseVisualStyleBackColor = true;
            AjoutPermissionDesRolesB.Click += AjoutPermissionDesRolesB_Click;
            // 
            // AjoutEntrepotB
            // 
            AjoutEntrepotB.Location = new Point(779, 877);
            AjoutEntrepotB.Name = "AjoutEntrepotB";
            AjoutEntrepotB.Size = new Size(136, 40);
            AjoutEntrepotB.TabIndex = 21;
            AjoutEntrepotB.Text = "AjoutEntrepot";
            AjoutEntrepotB.UseVisualStyleBackColor = true;
            AjoutEntrepotB.Click += AjoutEntrepotB_Click;
            // 
            // AjoutZoneB
            // 
            AjoutZoneB.Location = new Point(968, 880);
            AjoutZoneB.Name = "AjoutZoneB";
            AjoutZoneB.Size = new Size(136, 40);
            AjoutZoneB.TabIndex = 22;
            AjoutZoneB.Text = "AjoutZone";
            AjoutZoneB.UseVisualStyleBackColor = true;
            AjoutZoneB.Click += AjoutZoneB_Click;
            // 
            // AjoutEmplacementB
            // 
            AjoutEmplacementB.Location = new Point(114, 966);
            AjoutEmplacementB.Name = "AjoutEmplacementB";
            AjoutEmplacementB.Size = new Size(149, 37);
            AjoutEmplacementB.TabIndex = 23;
            AjoutEmplacementB.Text = "AjoutEmplacement";
            AjoutEmplacementB.UseVisualStyleBackColor = true;
            AjoutEmplacementB.Click += AjoutEmplacementB_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 1099);
            Controls.Add(AjoutEmplacementB);
            Controls.Add(AjoutZoneB);
            Controls.Add(AjoutEntrepotB);
            Controls.Add(AjoutPermissionDesRolesB);
            Controls.Add(button2);
            Controls.Add(AjoutProducteur);
            Controls.Add(AjoutTypeFromageB);
            Controls.Add(RoleCB);
            Controls.Add(AjoutRoleB);
            Controls.Add(AjoutCommandeB);
            Controls.Add(label2);
            Controls.Add(AjoutAchatB);
            Controls.Add(envoiepagefromage);
            Controls.Add(InscripMDPUser);
            Controls.Add(InscripUserTb);
            Controls.Add(TestMDP);
            Controls.Add(mdp);
            Controls.Add(NomTB);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(Inscription);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Inscription;
        private Label label1;
        private Button button1;
        private TextBox NomTB;
        private TextBox mdp;
        private Button TestMDP;
        private TextBox InscripUserTb;
        private TextBox InscripMDPUser;
        private Button envoiepagefromage;
        private Button AjoutAchatB;
        private Label label2;
        private Button AjoutCommandeB;
        private Button AjoutRoleB;
        private ComboBox RoleCB;
        private Button AjoutTypeFromageB;
        private Button AjoutProducteur;
        private Button button2;
        private Button AjoutPermissionDesRolesB;
        private Button AjoutEntrepotB;
        private Button AjoutZoneB;
        private Button AjoutEmplacementB;
    }
}
