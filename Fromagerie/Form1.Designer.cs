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
            AjoutMouvementB = new Button();
            TableauFromageB = new Button();
            TableauLogsB = new Button();
            testCatalogBtn = new Button();
            SuspendLayout();
            // 
            // Inscription
            // 
            Inscription.Location = new Point(805, 352);
            Inscription.Name = "Inscription";
            Inscription.Size = new Size(101, 41);
            Inscription.TabIndex = 0;
            Inscription.Text = "Inscription";
            Inscription.UseVisualStyleBackColor = true;
            Inscription.Click += button1_Click;
            // 
            // label1
            // 
            label1.Location = new Point(476, 101);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 4;
            label1.Text = "Eure-Et-Loir Fromage";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(110, 68);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 5;
            button1.Text = "test";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // NomTB
            // 
            NomTB.Location = new Point(223, 223);
            NomTB.Margin = new Padding(3, 2, 3, 2);
            NomTB.Name = "NomTB";
            NomTB.Size = new Size(110, 23);
            NomTB.TabIndex = 6;
            NomTB.TextChanged += Nom_TextChanged;
            // 
            // mdp
            // 
            mdp.Location = new Point(223, 268);
            mdp.Margin = new Padding(3, 2, 3, 2);
            mdp.Name = "mdp";
            mdp.Size = new Size(110, 23);
            mdp.TabIndex = 7;
            // 
            // TestMDP
            // 
            TestMDP.Location = new Point(233, 336);
            TestMDP.Margin = new Padding(3, 2, 3, 2);
            TestMDP.Name = "TestMDP";
            TestMDP.Size = new Size(82, 22);
            TestMDP.TabIndex = 8;
            TestMDP.Text = "Connexion";
            TestMDP.UseVisualStyleBackColor = true;
            TestMDP.Click += TestMDP_Click;
            // 
            // InscripUserTb
            // 
            InscripUserTb.Location = new Point(780, 223);
            InscripUserTb.Margin = new Padding(3, 2, 3, 2);
            InscripUserTb.Name = "InscripUserTb";
            InscripUserTb.Size = new Size(144, 23);
            InscripUserTb.TabIndex = 9;
            // 
            // InscripMDPUser
            // 
            InscripMDPUser.Location = new Point(796, 254);
            InscripMDPUser.Margin = new Padding(3, 2, 3, 2);
            InscripMDPUser.Name = "InscripMDPUser";
            InscripMDPUser.Size = new Size(110, 23);
            InscripMDPUser.TabIndex = 10;
            // 
            // envoiepagefromage
            // 
            envoiepagefromage.Location = new Point(100, 590);
            envoiepagefromage.Margin = new Padding(3, 2, 3, 2);
            envoiepagefromage.Name = "envoiepagefromage";
            envoiepagefromage.Size = new Size(125, 28);
            envoiepagefromage.TabIndex = 11;
            envoiepagefromage.Text = "AjoutFromage";
            envoiepagefromage.UseVisualStyleBackColor = true;
            envoiepagefromage.Click += envoiepage_Click;
            // 
            // AjoutAchatB
            // 
            AjoutAchatB.Location = new Point(290, 590);
            AjoutAchatB.Margin = new Padding(3, 2, 3, 2);
            AjoutAchatB.Name = "AjoutAchatB";
            AjoutAchatB.Size = new Size(125, 28);
            AjoutAchatB.TabIndex = 12;
            AjoutAchatB.Text = "AjoutAchat";
            AjoutAchatB.UseVisualStyleBackColor = true;
            AjoutAchatB.Click += AjoutAchatB_Click;
            // 
            // label2
            // 
            label2.Location = new Point(221, 172);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 13;
            // 
            // AjoutCommandeB
            // 
            AjoutCommandeB.Location = new Point(486, 590);
            AjoutCommandeB.Margin = new Padding(3, 2, 3, 2);
            AjoutCommandeB.Name = "AjoutCommandeB";
            AjoutCommandeB.Size = new Size(125, 28);
            AjoutCommandeB.TabIndex = 14;
            AjoutCommandeB.Text = "AjoutCommande";
            AjoutCommandeB.UseVisualStyleBackColor = true;
            AjoutCommandeB.Click += AjoutCommande_Click;
            // 
            // AjoutRoleB
            // 
            AjoutRoleB.Location = new Point(676, 590);
            AjoutRoleB.Margin = new Padding(3, 2, 3, 2);
            AjoutRoleB.Name = "AjoutRoleB";
            AjoutRoleB.Size = new Size(125, 28);
            AjoutRoleB.TabIndex = 15;
            AjoutRoleB.Text = "AjoutRole";
            AjoutRoleB.UseVisualStyleBackColor = true;
            AjoutRoleB.Click += AjoutRoleB_Click;
            // 
            // RoleCB
            // 
            RoleCB.FormattingEnabled = true;
            RoleCB.Location = new Point(790, 310);
            RoleCB.Margin = new Padding(3, 2, 3, 2);
            RoleCB.Name = "RoleCB";
            RoleCB.Size = new Size(134, 23);
            RoleCB.TabIndex = 16;
            RoleCB.SelectedIndexChanged += RoleCB_SelectedIndexChanged;
            // 
            // AjoutTypeFromageB
            // 
            AjoutTypeFromageB.Location = new Point(847, 590);
            AjoutTypeFromageB.Margin = new Padding(3, 2, 3, 2);
            AjoutTypeFromageB.Name = "AjoutTypeFromageB";
            AjoutTypeFromageB.Size = new Size(125, 28);
            AjoutTypeFromageB.TabIndex = 17;
            AjoutTypeFromageB.Text = "AjoutTypeFromage";
            AjoutTypeFromageB.UseVisualStyleBackColor = true;
            AjoutTypeFromageB.Click += AjoutTypeFromageB_Click;
            // 
            // AjoutProducteur
            // 
            AjoutProducteur.Location = new Point(100, 660);
            AjoutProducteur.Margin = new Padding(3, 2, 3, 2);
            AjoutProducteur.Name = "AjoutProducteur";
            AjoutProducteur.Size = new Size(125, 28);
            AjoutProducteur.TabIndex = 18;
            AjoutProducteur.Text = "AjoutProducteurB";
            AjoutProducteur.UseVisualStyleBackColor = true;
            AjoutProducteur.Click += AjoutProducteur_Click;
            // 
            // button2
            // 
            button2.Location = new Point(290, 660);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(125, 28);
            button2.TabIndex = 19;
            button2.Text = "AjoutPermission";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AjoutPermissionDesRolesB
            // 
            AjoutPermissionDesRolesB.Location = new Point(459, 660);
            AjoutPermissionDesRolesB.Margin = new Padding(3, 2, 3, 2);
            AjoutPermissionDesRolesB.Name = "AjoutPermissionDesRolesB";
            AjoutPermissionDesRolesB.Size = new Size(164, 28);
            AjoutPermissionDesRolesB.TabIndex = 20;
            AjoutPermissionDesRolesB.Text = "AjoutPermissionDesRoles";
            AjoutPermissionDesRolesB.UseVisualStyleBackColor = true;
            AjoutPermissionDesRolesB.Click += AjoutPermissionDesRolesB_Click;
            // 
            // AjoutEntrepotB
            // 
            AjoutEntrepotB.Location = new Point(682, 658);
            AjoutEntrepotB.Margin = new Padding(3, 2, 3, 2);
            AjoutEntrepotB.Name = "AjoutEntrepotB";
            AjoutEntrepotB.Size = new Size(119, 30);
            AjoutEntrepotB.TabIndex = 21;
            AjoutEntrepotB.Text = "AjoutEntrepot";
            AjoutEntrepotB.UseVisualStyleBackColor = true;
            AjoutEntrepotB.Click += AjoutEntrepotB_Click;
            // 
            // AjoutZoneB
            // 
            AjoutZoneB.Location = new Point(847, 660);
            AjoutZoneB.Margin = new Padding(3, 2, 3, 2);
            AjoutZoneB.Name = "AjoutZoneB";
            AjoutZoneB.Size = new Size(119, 30);
            AjoutZoneB.TabIndex = 22;
            AjoutZoneB.Text = "AjoutZone";
            AjoutZoneB.UseVisualStyleBackColor = true;
            AjoutZoneB.Click += AjoutZoneB_Click;
            // 
            // AjoutEmplacementB
            // 
            AjoutEmplacementB.Location = new Point(100, 724);
            AjoutEmplacementB.Margin = new Padding(3, 2, 3, 2);
            AjoutEmplacementB.Name = "AjoutEmplacementB";
            AjoutEmplacementB.Size = new Size(130, 28);
            AjoutEmplacementB.TabIndex = 23;
            AjoutEmplacementB.Text = "AjoutEmplacement";
            AjoutEmplacementB.UseVisualStyleBackColor = true;
            AjoutEmplacementB.Click += AjoutEmplacementB_Click;
            // 
            // AjoutMouvementB
            // 
            AjoutMouvementB.Location = new Point(290, 724);
            AjoutMouvementB.Margin = new Padding(3, 2, 3, 2);
            AjoutMouvementB.Name = "AjoutMouvementB";
            AjoutMouvementB.Size = new Size(125, 28);
            AjoutMouvementB.TabIndex = 24;
            AjoutMouvementB.Text = "AjoutMouvement";
            AjoutMouvementB.UseVisualStyleBackColor = true;
            AjoutMouvementB.Click += AjoutMouvementB_Click;
            // 
            // TableauFromageB
            // 
            TableauFromageB.Location = new Point(486, 724);
            TableauFromageB.Margin = new Padding(3, 2, 3, 2);
            TableauFromageB.Name = "TableauFromageB";
            TableauFromageB.Size = new Size(125, 28);
            TableauFromageB.TabIndex = 25;
            TableauFromageB.Text = "TableauFromage";
            TableauFromageB.UseVisualStyleBackColor = true;
            TableauFromageB.Click += TableauFromageB_Click;
            // 
            // TableauLogsB
            // 
            TableauLogsB.Location = new Point(676, 724);
            TableauLogsB.Margin = new Padding(3, 2, 3, 2);
            TableauLogsB.Name = "TableauLogsB";
            TableauLogsB.Size = new Size(125, 28);
            TableauLogsB.TabIndex = 26;
            TableauLogsB.Text = "TableauLogs";
            TableauLogsB.UseVisualStyleBackColor = true;
            TableauLogsB.Click += TableauLogsB_Click;
            // 
            // testCatalogBtn
            // 
            testCatalogBtn.Location = new Point(847, 729);
            testCatalogBtn.Name = "testCatalogBtn";
            testCatalogBtn.Size = new Size(119, 23);
            testCatalogBtn.TabIndex = 27;
            testCatalogBtn.Text = "TestCalogue";
            testCatalogBtn.UseVisualStyleBackColor = true;
            testCatalogBtn.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 824);
            Controls.Add(testCatalogBtn);
            Controls.Add(TableauLogsB);
            Controls.Add(TableauFromageB);
            Controls.Add(AjoutMouvementB);
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
        private Button AjoutMouvementB;
        private Button TableauFromageB;
        private Button TableauLogsB;
        private Button testCatalogBtn;
    }
}
