namespace Fromagerie
{
    partial class PageAdmin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Inscription = new Button();
            Inscriptionvendeur = new TextBox();
            UnInscripMDPUser = new TextBox();
            RoleCB = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 78);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Page Admin";
            label1.Click += label1_Click;
            // 
            // Inscription
            // 
            Inscription.Location = new Point(127, 308);
            Inscription.Name = "Inscription";
            Inscription.Size = new Size(106, 42);
            Inscription.TabIndex = 1;
            Inscription.Text = "Inscrire";
            Inscription.UseVisualStyleBackColor = true;
            Inscription.Click += button1_Click;
            // 
            // Inscriptionvendeur
            // 
            Inscriptionvendeur.Location = new Point(127, 137);
            Inscriptionvendeur.Margin = new Padding(3, 2, 3, 2);
            Inscriptionvendeur.Name = "Inscriptionvendeur";
            Inscriptionvendeur.Size = new Size(110, 23);
            Inscriptionvendeur.TabIndex = 7;
            // 
            // UnInscripMDPUser
            // 
            UnInscripMDPUser.Location = new Point(127, 187);
            UnInscripMDPUser.Margin = new Padding(3, 2, 3, 2);
            UnInscripMDPUser.Name = "UnInscripMDPUser";
            UnInscripMDPUser.Size = new Size(110, 23);
            UnInscripMDPUser.TabIndex = 8;
            UnInscripMDPUser.TextChanged += textBox1_TextChanged;
            // 
            // RoleCB
            // 
            RoleCB.FormattingEnabled = true;
            RoleCB.Location = new Point(113, 237);
            RoleCB.Margin = new Padding(3, 2, 3, 2);
            RoleCB.Name = "RoleCB";
            RoleCB.Size = new Size(134, 23);
            RoleCB.TabIndex = 17;
            RoleCB.SelectedIndexChanged += RoleCB_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 18;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(291, 379);
            button2.Name = "button2";
            button2.Size = new Size(112, 36);
            button2.TabIndex = 19;
            button2.Text = "Déconnexion";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // PageAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(RoleCB);
            Controls.Add(UnInscripMDPUser);
            Controls.Add(Inscriptionvendeur);
            Controls.Add(Inscription);
            Controls.Add(label1);
            Name = "PageAdmin";
            Text = "PageAdmin";
            Load += PageAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Inscription;
        private TextBox Inscriptionvendeur;
        private TextBox UnInscripMDPUser;
        private ComboBox RoleCB;
        private Button button1;
        private Button button2;
    }
}