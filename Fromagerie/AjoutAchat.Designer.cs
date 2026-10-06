namespace Fromagerie
{
    partial class AjoutAchat
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
            QuantiteTB = new TextBox();
            CommandeCB = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            FromageCB = new ComboBox();
            EnregistrerB = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(388, 297);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Quantite";
            // 
            // QuantiteTB
            // 
            QuantiteTB.Location = new Point(362, 349);
            QuantiteTB.Name = "QuantiteTB";
            QuantiteTB.Size = new Size(130, 27);
            QuantiteTB.TabIndex = 1;
            // 
            // CommandeCB
            // 
            CommandeCB.FormattingEnabled = true;
            CommandeCB.Location = new Point(66, 348);
            CommandeCB.Name = "CommandeCB";
            CommandeCB.Size = new Size(151, 28);
            CommandeCB.TabIndex = 2;
            CommandeCB.SelectedIndexChanged += CommandeCB_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 297);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 3;
            label2.Text = "Numéro Commande";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(653, 305);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 4;
            label3.Text = "Fromage";
            // 
            // FromageCB
            // 
            FromageCB.FormattingEnabled = true;
            FromageCB.Location = new Point(623, 360);
            FromageCB.Name = "FromageCB";
            FromageCB.Size = new Size(151, 28);
            FromageCB.TabIndex = 5;
            FromageCB.SelectedIndexChanged += FromageCB_SelectedIndexChanged;
            // 
            // EnregistrerB
            // 
            EnregistrerB.Location = new Point(448, 573);
            EnregistrerB.Name = "EnregistrerB";
            EnregistrerB.Size = new Size(103, 38);
            EnregistrerB.TabIndex = 6;
            EnregistrerB.Text = "Enregistrer";
            EnregistrerB.UseVisualStyleBackColor = true;
            EnregistrerB.Click += EnregistrerB_Click;
            // 
            // AjoutAchat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 860);
            Controls.Add(EnregistrerB);
            Controls.Add(FromageCB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CommandeCB);
            Controls.Add(QuantiteTB);
            Controls.Add(label1);
            Name = "AjoutAchat";
            Text = "AjoutAchat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox QuantiteTB;
        private ComboBox CommandeCB;
        private Label label2;
        private Label label3;
        private ComboBox FromageCB;
        private Button EnregistrerB;
    }
}