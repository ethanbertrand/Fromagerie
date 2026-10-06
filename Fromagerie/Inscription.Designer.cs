namespace Fromagerie
{
    partial class Inscription
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
            InscripUserTb = new TextBox();
            InscripMDPUser = new TextBox();
            SignInBtn = new Button();
            User_label = new Label();
            Pw_label = new Label();
            signUpLink = new LinkLabel();
            SuspendLayout();
            // 
            // InscripUserTb
            // 
            InscripUserTb.Location = new Point(333, 265);
            InscripUserTb.Margin = new Padding(3, 2, 3, 2);
            InscripUserTb.Name = "InscripUserTb";
            InscripUserTb.Size = new Size(225, 23);
            InscripUserTb.TabIndex = 10;
            InscripUserTb.TextChanged += InscripUserTb_TextChanged;
            // 
            // InscripMDPUser
            // 
            InscripMDPUser.Location = new Point(333, 347);
            InscripMDPUser.Margin = new Padding(3, 2, 3, 2);
            InscripMDPUser.Name = "InscripMDPUser";
            InscripMDPUser.Size = new Size(225, 23);
            InscripMDPUser.TabIndex = 11;
            // 
            // SignInBtn
            // 
            SignInBtn.Location = new Point(385, 438);
            SignInBtn.Name = "SignInBtn";
            SignInBtn.Size = new Size(123, 35);
            SignInBtn.TabIndex = 12;
            SignInBtn.Text = "Sign in";
            SignInBtn.UseVisualStyleBackColor = true;
            SignInBtn.Click += SignInBtn_Click;
            // 
            // User_label
            // 
            User_label.AutoSize = true;
            User_label.Location = new Point(333, 235);
            User_label.Name = "User_label";
            User_label.Size = new Size(60, 15);
            User_label.TabIndex = 14;
            User_label.Text = "Username";
            User_label.Click += label1_Click;
            // 
            // Pw_label
            // 
            Pw_label.AutoSize = true;
            Pw_label.Location = new Point(333, 319);
            Pw_label.Name = "Pw_label";
            Pw_label.Size = new Size(57, 15);
            Pw_label.TabIndex = 15;
            Pw_label.Text = "Password";
            // 
            // signUpLink
            // 
            signUpLink.AutoSize = true;
            signUpLink.LinkColor = Color.Black;
            signUpLink.Location = new Point(406, 407);
            signUpLink.Name = "signUpLink";
            signUpLink.Size = new Size(75, 15);
            signUpLink.TabIndex = 16;
            signUpLink.TabStop = true;
            signUpLink.Text = "Se connecter";
            signUpLink.LinkClicked += signUpLink_LinkClicked;
            // 
            // Inscription
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 719);
            Controls.Add(signUpLink);
            Controls.Add(Pw_label);
            Controls.Add(User_label);
            Controls.Add(SignInBtn);
            Controls.Add(InscripMDPUser);
            Controls.Add(InscripUserTb);
            Name = "Inscription";
            Text = "Inscription";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InscripUserTb;
        private TextBox InscripMDPUser;
        private Button SignInBtn;
        private Label User_label;
        private Label Pw_label;
        private LinkLabel signUpLink;
    }
}