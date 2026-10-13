namespace Fromagerie
{
    partial class Connexion
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
            signInLink = new LinkLabel();
            SignUpBtn = new Button();
            mdp = new TextBox();
            label2 = new Label();
            NomTB = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // signInLink
            // 
            signInLink.AutoSize = true;
            signInLink.LinkColor = Color.Black;
            signInLink.Location = new Point(411, 368);
            signInLink.Name = "signInLink";
            signInLink.Size = new Size(98, 15);
            signInLink.TabIndex = 11;
            signInLink.TabStop = true;
            signInLink.Text = "créer ton compte";
            signInLink.LinkClicked += signInLink_LinkClicked;
            // 
            // SignUpBtn
            // 
            SignUpBtn.Location = new Point(424, 396);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(75, 23);
            SignUpBtn.TabIndex = 10;
            SignUpBtn.Text = "Sign up";
            SignUpBtn.UseVisualStyleBackColor = true;
            // 
            // mdp
            // 
            mdp.Location = new Point(368, 316);
            mdp.Name = "mdp";
            mdp.Size = new Size(189, 23);
            mdp.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(368, 287);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 8;
            label2.Text = "Password";
            // 
            // NomTB
            // 
            NomTB.Location = new Point(368, 246);
            NomTB.Name = "NomTB";
            NomTB.Size = new Size(189, 23);
            NomTB.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(368, 228);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 6;
            label1.Text = "Username";
            // 
            // Connexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 647);
            Controls.Add(signInLink);
            Controls.Add(SignUpBtn);
            Controls.Add(mdp);
            Controls.Add(label2);
            Controls.Add(NomTB);
            Controls.Add(label1);
            Name = "Connexion";
            Text = "Connexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel signInLink;
        private Button SignUpBtn;
        private TextBox mdp;
        private Label label2;
        private TextBox NomTB;
        private Label label1;
    }
}