namespace Fromagerie
{
    partial class AjoutProducteur
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
            NomTB = new TextBox();
            TelephoneTB = new TextBox();
            AdresseTB = new TextBox();
            EnregistrezB = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 168);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(740, 168);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = "Adresse";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(378, 168);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 2;
            label3.Text = "Téléphone";
            // 
            // NomTB
            // 
            NomTB.Location = new Point(56, 215);
            NomTB.Name = "NomTB";
            NomTB.Size = new Size(151, 27);
            NomTB.TabIndex = 3;
            // 
            // TelephoneTB
            // 
            TelephoneTB.Location = new Point(340, 215);
            TelephoneTB.Name = "TelephoneTB";
            TelephoneTB.Size = new Size(151, 27);
            TelephoneTB.TabIndex = 4;
            // 
            // AdresseTB
            // 
            AdresseTB.Location = new Point(617, 215);
            AdresseTB.Name = "AdresseTB";
            AdresseTB.Size = new Size(334, 27);
            AdresseTB.TabIndex = 5;
            // 
            // EnregistrezB
            // 
            EnregistrezB.Location = new Point(453, 455);
            EnregistrezB.Name = "EnregistrezB";
            EnregistrezB.Size = new Size(94, 29);
            EnregistrezB.TabIndex = 6;
            EnregistrezB.Text = "Enregistrez";
            EnregistrezB.UseVisualStyleBackColor = true;
            EnregistrezB.Click += EnregistrezB_Click;
            // 
            // AjoutProducteur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 885);
            Controls.Add(EnregistrezB);
            Controls.Add(AdresseTB);
            Controls.Add(TelephoneTB);
            Controls.Add(NomTB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AjoutProducteur";
            Text = "AjoutProducteur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox NomTB;
        private TextBox TelephoneTB;
        private TextBox AdresseTB;
        private Button EnregistrezB;
    }
}