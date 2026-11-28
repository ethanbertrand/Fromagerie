namespace Fromagerie
{
    partial class PageLivreur
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
            button1 = new Button();
            button2 = new Button();
            deconnexion = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(529, 70);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Page livreur";
            // 
            // button1
            // 
            button1.Location = new Point(332, 221);
            button1.Name = "button1";
            button1.Size = new Size(164, 53);
            button1.TabIndex = 1;
            button1.Text = "Commandes préparées";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(581, 221);
            button2.Name = "button2";
            button2.Size = new Size(164, 53);
            button2.TabIndex = 2;
            button2.Text = "Commandes en cours de Livraison";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // deconnexion
            // 
            deconnexion.Location = new Point(483, 436);
            deconnexion.Name = "deconnexion";
            deconnexion.Size = new Size(140, 60);
            deconnexion.TabIndex = 3;
            deconnexion.Text = "Déconnexion";
            deconnexion.UseVisualStyleBackColor = true;
            deconnexion.Click += deconnexion_Click;
            // 
            // PageLivreur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 607);
            Controls.Add(deconnexion);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "PageLivreur";
            Text = "PageLivreur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button deconnexion;
    }
}