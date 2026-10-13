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
            label1 = new Label();
            InscripUserTb = new TextBox();
            label2 = new Label();
            InscripMDPUser = new TextBox();
            button1 = new Button();
            signUpLink = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 231);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // InscripUserTb
            // 
            InscripUserTb.Location = new Point(283, 249);
            InscripUserTb.Name = "InscripUserTb";
            InscripUserTb.Size = new Size(189, 23);
            InscripUserTb.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 290);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // InscripMDPUser
            // 
            InscripMDPUser.Location = new Point(283, 319);
            InscripMDPUser.Name = "InscripMDPUser";
            InscripMDPUser.Size = new Size(189, 23);
            InscripMDPUser.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(339, 399);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Sign in";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // signUpLink
            // 
            signUpLink.AutoSize = true;
            signUpLink.LinkColor = Color.Black;
            signUpLink.Location = new Point(339, 371);
            signUpLink.Name = "signUpLink";
            signUpLink.Size = new Size(75, 15);
            signUpLink.TabIndex = 5;
            signUpLink.TabStop = true;
            signUpLink.Text = "Se connecter";
            signUpLink.LinkClicked += signUpLink_LinkClicked;
            // 
            // Inscription
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 670);
            Controls.Add(signUpLink);
            Controls.Add(button1);
            Controls.Add(InscripMDPUser);
            Controls.Add(label2);
            Controls.Add(InscripUserTb);
            Controls.Add(label1);
            Name = "Inscription";
            Text = "Inscription";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox InscripUserTb;
        private Label label2;
        private TextBox InscripMDPUser;
        private Button button1;
        private LinkLabel signUpLink;
    }
}