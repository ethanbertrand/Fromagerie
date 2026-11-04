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
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(336, 46);
            label1.Name = "label1";
            label1.Size = new Size(296, 15);
            label1.TabIndex = 0;
            label1.Text = "Bienvenue sur le site Internet d'Eure-et-Loir Fromage !!!";
            // 
            // histoire
            // 
            histoire.Location = new Point(433, 91);
            histoire.Name = "histoire";
            histoire.Size = new Size(112, 23);
            histoire.TabIndex = 1;
            histoire.Text = "Notre histoire";
            histoire.UseVisualStyleBackColor = true;
            histoire.Click += button1_Click;
            // 
            // deconnexion
            // 
            deconnexion.Location = new Point(433, 593);
            deconnexion.Name = "deconnexion";
            deconnexion.Size = new Size(112, 23);
            deconnexion.TabIndex = 2;
            deconnexion.Text = "Déconnexion";
            deconnexion.UseVisualStyleBackColor = true;
            deconnexion.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 156);
            label2.Name = "label2";
            label2.Size = new Size(633, 15);
            label2.TabIndex = 3;
            label2.Text = "Vous avez le catalogue à dispositions avec le fromage ainsi que son prix au kilo. Vous n'avez juste qu'à faire votre choix !";
            label2.Click += label2_Click;
            // 
            // PageAcheteur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 715);
            Controls.Add(label2);
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
        private Label label2;
    }
}