namespace Fromagerie
{
    partial class AjoutRole
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
            libelleRoleTB = new TextBox();
            EnregistrerB = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 162);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Nom du Role";
            // 
            // libelleRoleTB
            // 
            libelleRoleTB.Location = new Point(152, 218);
            libelleRoleTB.Name = "libelleRoleTB";
            libelleRoleTB.Size = new Size(125, 27);
            libelleRoleTB.TabIndex = 1;
            // 
            // EnregistrerB
            // 
            EnregistrerB.Location = new Point(329, 324);
            EnregistrerB.Name = "EnregistrerB";
            EnregistrerB.Size = new Size(91, 44);
            EnregistrerB.TabIndex = 2;
            EnregistrerB.Text = "Enregistrer";
            EnregistrerB.UseVisualStyleBackColor = true;
            EnregistrerB.Click += EnregistrerB_Click;
            // 
            // AjoutRole
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 646);
            Controls.Add(EnregistrerB);
            Controls.Add(libelleRoleTB);
            Controls.Add(label1);
            Name = "AjoutRole";
            Text = "AjoutRole";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox libelleRoleTB;
        private Button EnregistrerB;
    }
}