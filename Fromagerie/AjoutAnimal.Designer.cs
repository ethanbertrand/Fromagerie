namespace Fromagerie
{
    partial class AjoutAnimal
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
            animal = new TextBox();
            button1 = new Button();
            retouradmin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(358, 90);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Ajout Animal";
            // 
            // animal
            // 
            animal.Location = new Point(330, 137);
            animal.Name = "animal";
            animal.Size = new Size(129, 23);
            animal.TabIndex = 1;
            animal.TextChanged += animal_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(348, 234);
            button1.Name = "button1";
            button1.Size = new Size(87, 23);
            button1.TabIndex = 2;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // retouradmin
            // 
            retouradmin.Location = new Point(319, 301);
            retouradmin.Name = "retouradmin";
            retouradmin.Size = new Size(151, 58);
            retouradmin.TabIndex = 3;
            retouradmin.Text = "Revenir au menu admin";
            retouradmin.UseVisualStyleBackColor = true;
            retouradmin.Click += retouradmin_Click;
            // 
            // AjoutAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(retouradmin);
            Controls.Add(button1);
            Controls.Add(animal);
            Controls.Add(label1);
            Name = "AjoutAnimal";
            Text = "AjoutAnimal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox animal;
        private Button button1;
        private Button retouradmin;
    }
}