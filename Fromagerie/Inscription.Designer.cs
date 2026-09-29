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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // InscripUserTb
            // 
            InscripUserTb.Location = new Point(278, 262);
            InscripUserTb.Margin = new Padding(3, 2, 3, 2);
            InscripUserTb.Name = "InscripUserTb";
            InscripUserTb.Size = new Size(214, 23);
            InscripUserTb.TabIndex = 10;
            InscripUserTb.TextChanged += InscripUserTb_TextChanged;
            // 
            // InscripMDPUser
            // 
            InscripMDPUser.Location = new Point(278, 313);
            InscripMDPUser.Margin = new Padding(3, 2, 3, 2);
            InscripMDPUser.Name = "InscripMDPUser";
            InscripMDPUser.Size = new Size(214, 23);
            InscripMDPUser.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(366, 274);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 23);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(366, 352);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 23);
            textBox2.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(390, 438);
            button1.Name = "button1";
            button1.Size = new Size(168, 41);
            button1.TabIndex = 12;
            button1.Text = "SIgn up";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(366, 244);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 13;
            label1.Text = "Username";
            label1.Visible = false;
            label1.Click += this.label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(366, 326);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 14;
            label2.Text = "Password";
            label2.Visible = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(442, 410);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(60, 15);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            linkLabel1.LinkClicked += this.linkLabel1_LinkClicked;
            // 
            // Inscription
            // 
            ClientSize = new Size(1006, 721);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Inscription";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InscripUserTb;
        private TextBox InscripMDPUser;
        private Button Inscription;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
    }
}