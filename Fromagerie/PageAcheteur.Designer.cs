namespace Fromagerie
{
    partial class PageAcheteur
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
            histoire = new Button();
            deconnexion = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 50);
            label1.Name = "label1";
            label1.Size = new Size(296, 15);
            label1.TabIndex = 0;
            label1.Text = "Bienvenue sur le site Internet d'Eure-et-Loir Fromage !!!";
            // 
            // histoire
            // 
            histoire.Location = new Point(336, 107);
            histoire.Name = "histoire";
            histoire.Size = new Size(112, 23);
            histoire.TabIndex = 1;
            histoire.Text = "Notre histoire";
            histoire.UseVisualStyleBackColor = true;
            histoire.Click += button1_Click;
            // 
            // deconnexion
            // 
            deconnexion.Location = new Point(336, 261);
            deconnexion.Name = "deconnexion";
            deconnexion.Size = new Size(112, 23);
            deconnexion.TabIndex = 2;
            deconnexion.Text = "Déconnexion";
            deconnexion.UseVisualStyleBackColor = true;
            deconnexion.Click += button1_Click_1;
            // 
            // PageAcheteur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deconnexion);
            Controls.Add(histoire);
            Controls.Add(label1);
            Name = "PageAcheteur";
            Text = "PageAcheteur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button histoire;
        private Button deconnexion;
    }
}