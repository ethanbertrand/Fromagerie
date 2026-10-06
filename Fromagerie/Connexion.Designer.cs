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
            Pw_label = new Label();
            User_label = new Label();
            SignUpBtn = new Button();
            CPwd = new TextBox();
            UserTb = new TextBox();
            signInLink = new LinkLabel();
            SuspendLayout();
            // 
            // Pw_label
            // 
            Pw_label.AutoSize = true;
            Pw_label.Location = new Point(331, 273);
            Pw_label.Name = "Pw_label";
            Pw_label.Size = new Size(57, 15);
            Pw_label.TabIndex = 20;
            Pw_label.Text = "Password";
            // 
            // User_label
            // 
            User_label.AutoSize = true;
            User_label.Location = new Point(331, 189);
            User_label.Name = "User_label";
            User_label.Size = new Size(60, 15);
            User_label.TabIndex = 19;
            User_label.Text = "Username";
            // 
            // SignUpBtn
            // 
            SignUpBtn.Location = new Point(383, 392);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(123, 35);
            SignUpBtn.TabIndex = 18;
            SignUpBtn.Text = "Sign up";
            SignUpBtn.UseVisualStyleBackColor = true;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // CPwd
            // 
            CPwd.Location = new Point(331, 301);
            CPwd.Margin = new Padding(3, 2, 3, 2);
            CPwd.Name = "CPwd";
            CPwd.Size = new Size(225, 23);
            CPwd.TabIndex = 17;
            // 
            // UserTb
            // 
            UserTb.Location = new Point(331, 219);
            UserTb.Margin = new Padding(3, 2, 3, 2);
            UserTb.Name = "UserTb";
            UserTb.Size = new Size(225, 23);
            UserTb.TabIndex = 16;
            // 
            // signInLink
            // 
            signInLink.AutoSize = true;
            signInLink.LinkColor = Color.Black;
            signInLink.Location = new Point(383, 354);
            signInLink.Name = "signInLink";
            signInLink.Size = new Size(115, 15);
            signInLink.TabIndex = 21;
            signInLink.TabStop = true;
            signInLink.Text = "ou créer ton compte";
            signInLink.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Connexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 616);
            Controls.Add(signInLink);
            Controls.Add(Pw_label);
            Controls.Add(User_label);
            Controls.Add(SignUpBtn);
            Controls.Add(CPwd);
            Controls.Add(UserTb);
            Name = "Connexion";
            Text = "Connexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Pw_label;
        private Label User_label;
        private Button SignUpBtn;
        private TextBox CPwd;
        private TextBox UserTb;
        private LinkLabel signInLink;
    }
}