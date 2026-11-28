namespace Fromagerie
{
    partial class AjoutPermission
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
            Enregistrez = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(499, 205);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Libelle";
            // 
            // LibelleTB
            // 
            LibelleTB.Location = new Point(428, 252);
            LibelleTB.Name = "LibelleTB";
            LibelleTB.Size = new Size(195, 27);
            LibelleTB.TabIndex = 1;
            // 
            // Enregistrez
            // 
            Enregistrez.Location = new Point(469, 335);
            Enregistrez.Name = "Enregistrez";
            Enregistrez.Size = new Size(94, 29);
            Enregistrez.TabIndex = 2;
            Enregistrez.Text = "Enregistrez";
            Enregistrez.UseVisualStyleBackColor = true;
            Enregistrez.Click += Enregistrez_Click;
            // 
            // AjoutPermission
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 867);
            Controls.Add(Enregistrez);
            Controls.Add(LibelleTB);
            Controls.Add(label1);
            Name = "AjoutPermission";
            Text = "AjoutPermission";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox LibelleTB;
        private Button Enregistrez;
    }
}