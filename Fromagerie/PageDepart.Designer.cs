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
            label2 = new Label();
            PsignUp_btn = new Button();
            PsignIn_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(585, 207);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 0;
            label1.Text = "Create your account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 207);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Sign up";
            // 
            // PsignUp_btn
            // 
            PsignUp_btn.Location = new Point(181, 246);
            PsignUp_btn.Name = "PsignUp_btn";
            PsignUp_btn.Size = new Size(75, 23);
            PsignUp_btn.TabIndex = 2;
            PsignUp_btn.Text = "Sign up";
            PsignUp_btn.UseVisualStyleBackColor = true;
            PsignUp_btn.Click += button1_Click;
            // 
            // PsignIn_btn
            // 
            PsignIn_btn.Location = new Point(605, 246);
            PsignIn_btn.Name = "PsignIn_btn";
            PsignIn_btn.Size = new Size(75, 23);
            PsignIn_btn.TabIndex = 3;
            PsignIn_btn.Text = "Sign in";
            PsignIn_btn.UseVisualStyleBackColor = true;
            PsignIn_btn.Click += SignIn_Click;
            // 
            // PageDepart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 655);
            Controls.Add(PsignIn_btn);
            Controls.Add(PsignUp_btn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PageDepart";
            Text = "PageDepart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button PsignUp_btn;
        private Button PsignIn_btn;
    }
}