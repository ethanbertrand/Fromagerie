namespace Fromagerie
{
    partial class AjoutTypeFromage
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
            LibelleTB = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(418, 235);
            label1.Name = "label1";
            label1.Size = new Size(180, 20);
            label1.TabIndex = 0;
            label1.Text = "Nom du type de Fromage";
            // 
            // LibelleTB
            // 
            LibelleTB.Location = new Point(442, 285);
            LibelleTB.Name = "LibelleTB";
            LibelleTB.Size = new Size(125, 27);
            LibelleTB.TabIndex = 1;
            LibelleTB.TextChanged += LibelleTB_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(442, 369);
            button1.Name = "button1";
            button1.Size = new Size(114, 31);
            button1.TabIndex = 2;
            button1.Text = "Enregistrez";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AjoutTypeFromage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 742);
            Controls.Add(button1);
            Controls.Add(LibelleTB);
            Controls.Add(label1);
            Name = "AjoutTypeFromage";
            Text = "AjoutTypeFromage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox LibelleTB;
        private Button button1;
    }
}