namespace Fromagerie
{
    partial class AjoutEntrepot
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
            NomTB = new TextBox();
            NbZoneTB = new TextBox();
            EnregistrerB = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 113);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(317, 113);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre de zone";
            // 
            // NomTB
            // 
            NomTB.Location = new Point(96, 145);
            NomTB.Name = "NomTB";
            NomTB.Size = new Size(125, 27);
            NomTB.TabIndex = 2;
            // 
            // NbZoneTB
            // 
            NbZoneTB.Location = new Point(298, 155);
            NbZoneTB.Name = "NbZoneTB";
            NbZoneTB.Size = new Size(158, 27);
            NbZoneTB.TabIndex = 3;
            // 
            // EnregistrerB
            // 
            EnregistrerB.Location = new Point(354, 352);
            EnregistrerB.Name = "EnregistrerB";
            EnregistrerB.Size = new Size(138, 36);
            EnregistrerB.TabIndex = 4;
            EnregistrerB.Text = "Enregistrer";
            EnregistrerB.UseVisualStyleBackColor = true;
            EnregistrerB.Click += EnregistrerB_Click;
            // 
            // AjoutEntrepot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 978);
            Controls.Add(EnregistrerB);
            Controls.Add(NbZoneTB);
            Controls.Add(NomTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AjoutEntrepot";
            Text = "AjoutEntrepot";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox NomTB;
        private TextBox NbZoneTB;
        private Button EnregistrerB;
    }
}