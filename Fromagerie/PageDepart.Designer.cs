namespace Fromagerie
{
    partial class PageDepart
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
            PsignIn__btn = new Button();
            SignUp_txt = new Label();
            PsignUp_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(553, 153);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 0;
            label1.Text = "Create your account";
            // 
            // PsignIn__btn
            // 
            PsignIn__btn.Location = new Point(572, 209);
            PsignIn__btn.Name = "PsignIn__btn";
            PsignIn__btn.Size = new Size(75, 23);
            PsignIn__btn.TabIndex = 1;
            PsignIn__btn.Text = "Sign in";
            PsignIn__btn.UseVisualStyleBackColor = true;
            PsignIn__btn.Click += PsignIn__btn_Click;
            // 
            // SignUp_txt
            // 
            SignUp_txt.AutoSize = true;
            SignUp_txt.Location = new Point(148, 153);
            SignUp_txt.Name = "SignUp_txt";
            SignUp_txt.Size = new Size(47, 15);
            SignUp_txt.TabIndex = 2;
            SignUp_txt.Text = "Sign up";
            // 
            // PsignUp_btn
            // 
            PsignUp_btn.Location = new Point(136, 196);
            PsignUp_btn.Name = "PsignUp_btn";
            PsignUp_btn.Size = new Size(75, 23);
            PsignUp_btn.TabIndex = 3;
            PsignUp_btn.Text = "Sign up";
            PsignUp_btn.UseVisualStyleBackColor = true;
            PsignUp_btn.Click += PsignUp_btn_Click;
            // 
            // PageDepart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PsignUp_btn);
            Controls.Add(SignUp_txt);
            Controls.Add(PsignIn__btn);
            Controls.Add(label1);
            Name = "PageDepart";
            Text = "PageDepart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button PsignIn__btn;
        private Label SignUp_txt;
        private Button PsignUp_btn;
    }
}