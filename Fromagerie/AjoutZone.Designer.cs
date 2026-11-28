namespace Fromagerie
{
    partial class AjoutZone
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
            nomTB = new TextBox();
            label2 = new Label();
            EntrepotCB = new ComboBox();
            EnregistrerB = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 82);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "Nom";
            // 
            // nomTB
            // 
            nomTB.Location = new Point(23, 118);
            nomTB.Name = "nomTB";
            nomTB.Size = new Size(134, 27);
            nomTB.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 86);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 2;
            label2.Text = "Entrepot";
            // 
            // EntrepotCB
            // 
            EntrepotCB.FormattingEnabled = true;
            EntrepotCB.Location = new Point(225, 118);
            EntrepotCB.Name = "EntrepotCB";
            EntrepotCB.Size = new Size(151, 28);
            EntrepotCB.TabIndex = 3;
            // 
            // EnregistrerB
            // 
            EnregistrerB.Location = new Point(253, 217);
            EnregistrerB.Name = "EnregistrerB";
            EnregistrerB.Size = new Size(123, 47);
            EnregistrerB.TabIndex = 4;
            EnregistrerB.Text = "Enregistrer";
            EnregistrerB.UseVisualStyleBackColor = true;
            EnregistrerB.Click += EnregistrerB_Click;
            // 
            // AjoutZone
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EnregistrerB);
            Controls.Add(EntrepotCB);
            Controls.Add(label2);
            Controls.Add(nomTB);
            Controls.Add(label1);
            Name = "AjoutZone";
            Text = "AjoutZone";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nomTB;
        private Label label2;
        private ComboBox EntrepotCB;
        private Button EnregistrerB;
    }
}