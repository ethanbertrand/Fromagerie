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
            label1.Location = new Point(40, 86);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 0;
            label1.Text = "Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 86);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 1;
            label2.Text = "Capacité Max";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(546, 86);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 2;
            label3.Text = "Zone";
            // 
            // CodeTB
            // 
            CodeTB.Location = new Point(24, 120);
            CodeTB.Name = "CodeTB";
            CodeTB.Size = new Size(125, 27);
            CodeTB.TabIndex = 3;
            // 
            // CapaciteMaxTB
            // 
            CapaciteMaxTB.Location = new Point(255, 126);
            CapaciteMaxTB.Name = "CapaciteMaxTB";
            CapaciteMaxTB.Size = new Size(102, 27);
            CapaciteMaxTB.TabIndex = 4;
            // 
            // ZoneCB
            // 
            ZoneCB.FormattingEnabled = true;
            ZoneCB.Location = new Point(506, 126);
            ZoneCB.Name = "ZoneCB";
            ZoneCB.Size = new Size(151, 28);
            ZoneCB.TabIndex = 5;
            ZoneCB.SelectedIndexChanged += ZoneCB_SelectedIndexChanged;
            // 
            // EnregistrerB
            // 
            EnregistrerB.Location = new Point(256, 283);
            EnregistrerB.Name = "EnregistrerB";
            EnregistrerB.Size = new Size(101, 41);
            EnregistrerB.TabIndex = 6;
            EnregistrerB.Text = "Enregistrer";
            EnregistrerB.UseVisualStyleBackColor = true;
            EnregistrerB.Click += EnregistrerB_Click;
            // 
            // AjoutEmplacement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EnregistrerB);
            Controls.Add(ZoneCB);
            Controls.Add(CapaciteMaxTB);
            Controls.Add(CodeTB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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