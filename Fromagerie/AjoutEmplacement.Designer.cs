namespace Fromagerie
{
    partial class AjoutEmplacement
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
            label3 = new Label();
            CodeTB = new TextBox();
            CapaciteMaxTB = new TextBox();
            ZoneCB = new ComboBox();
            EnregistrerB = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 64);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 64);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "Capacité Max";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(478, 64);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "Zone";
            // 
            // CodeTB
            // 
            CodeTB.Location = new Point(21, 90);
            CodeTB.Margin = new Padding(3, 2, 3, 2);
            CodeTB.Name = "CodeTB";
            CodeTB.Size = new Size(110, 23);
            CodeTB.TabIndex = 3;
            // 
            // CapaciteMaxTB
            // 
            CapaciteMaxTB.Location = new Point(223, 94);
            CapaciteMaxTB.Margin = new Padding(3, 2, 3, 2);
            CapaciteMaxTB.Name = "CapaciteMaxTB";
            CapaciteMaxTB.Size = new Size(90, 23);
            CapaciteMaxTB.TabIndex = 4;
            CapaciteMaxTB.TextChanged += CapaciteMaxTB_TextChanged;
            // 
            // ZoneCB
            // 
            ZoneCB.FormattingEnabled = true;
            ZoneCB.Location = new Point(443, 94);
            ZoneCB.Margin = new Padding(3, 2, 3, 2);
            ZoneCB.Name = "ZoneCB";
            ZoneCB.Size = new Size(133, 23);
            ZoneCB.TabIndex = 5;
            ZoneCB.SelectedIndexChanged += ZoneCB_SelectedIndexChanged;
            // 
            // EnregistrerB
            // 
            EnregistrerB.Location = new Point(224, 212);
            EnregistrerB.Margin = new Padding(3, 2, 3, 2);
            EnregistrerB.Name = "EnregistrerB";
            EnregistrerB.Size = new Size(88, 31);
            EnregistrerB.TabIndex = 6;
            EnregistrerB.Text = "Enregistrer";
            EnregistrerB.UseVisualStyleBackColor = true;
            EnregistrerB.Click += EnregistrerB_Click;
            // 
            // AjoutEmplacement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(EnregistrerB);
            Controls.Add(ZoneCB);
            Controls.Add(CapaciteMaxTB);
            Controls.Add(CodeTB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AjoutEmplacement";
            Text = "AjoutEmplacement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox CodeTB;
        private TextBox CapaciteMaxTB;
        private ComboBox ZoneCB;
        private Button EnregistrerB;
    }
}