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
            PageSignIn_btn = new Button();
            SuspendLayout();
            // 
            // Inscription
            // 
            Inscription.Location = new Point(796, 389);
            Inscription.Name = "Inscription";
            Inscription.Size = new Size(101, 41);
            Inscription.TabIndex = 0;
            Inscription.Text = "Inscription";
            Inscription.UseVisualStyleBackColor = true;
            Inscription.Click += button1_Click;
            // 
            // label1
            // 
            label1.Location = new Point(486, 87);
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
            mdp.Location = new Point(221, 294);
            mdp.Margin = new Padding(3, 2, 3, 2);
            mdp.Name = "mdp";
            mdp.Size = new Size(110, 23);
            mdp.TabIndex = 7;
            // 
            // TestMDP
            // 
            TestMDP.Location = new Point(234, 367);
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
            InscripUserTb.TextChanged += InscripUserTb_TextChanged;
            // 
            // InscripMDPUser
            // 
            InscripMDPUser.Location = new Point(796, 294);
            InscripMDPUser.Margin = new Padding(3, 2, 3, 2);
            InscripMDPUser.Name = "InscripMDPUser";
            InscripMDPUser.Size = new Size(110, 23);
            InscripMDPUser.TabIndex = 10;
            InscripMDPUser.TextChanged += InscripMDPUser_TextChanged;
            // 
            // PageSignIn_btn
            // 
            PageSignIn_btn.Location = new Point(792, 511);
            PageSignIn_btn.Name = "PageSignIn_btn";
            PageSignIn_btn.Size = new Size(75, 23);
            PageSignIn_btn.TabIndex = 11;
            PageSignIn_btn.Text = "Sign in";
            PageSignIn_btn.UseVisualStyleBackColor = true;
            PageSignIn_btn.Click += PageSignIn_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 824);
            Controls.Add(PageSignIn_btn);
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
        private Button PageSignIn_btn;
    }
}
