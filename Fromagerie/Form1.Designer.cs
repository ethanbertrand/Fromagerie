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
            SuspendLayout();
            // 
            // Inscription
            // 
            Inscription.Location = new Point(910, 519);
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
            mdp.Location = new Point(253, 392);
            mdp.Name = "mdp";
            mdp.Size = new Size(125, 27);
            mdp.TabIndex = 7;
            // 
            // TestMDP
            // 
            TestMDP.Location = new Point(268, 489);
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
            InscripMDPUser.Location = new Point(910, 392);
            InscripMDPUser.Name = "InscripMDPUser";
            InscripMDPUser.Size = new Size(125, 27);
            InscripMDPUser.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 1099);
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
    }
}
