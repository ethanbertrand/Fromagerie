namespace Fromagerie
{
    partial class AjoutMouvement
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
            Date = new Label();
            label1 = new Label();
            CalendrierDate = new MonthCalendar();
            QuantiteTB = new TextBox();
            label2 = new Label();
            CommandeCB = new ComboBox();
            DeplaceurCB = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            FromageCB = new ComboBox();
            Emplacement = new Label();
            label5 = new Label();
            EmplacementCB1 = new ComboBox();
            EmplacementCB2 = new ComboBox();
            Enregistrer = new Button();
            SuspendLayout();
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Location = new Point(106, 20);
            Date.Name = "Date";
            Date.Size = new Size(41, 20);
            Date.TabIndex = 0;
            Date.Text = "Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(392, 20);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 1;
            label1.Text = "Quantite";
            // 
            // CalendrierDate
            // 
            CalendrierDate.Location = new Point(6, 60);
            CalendrierDate.Name = "CalendrierDate";
            CalendrierDate.TabIndex = 2;
            // 
            // QuantiteTB
            // 
            QuantiteTB.Location = new Point(366, 43);
            QuantiteTB.Name = "QuantiteTB";
            QuantiteTB.Size = new Size(125, 27);
            QuantiteTB.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(601, 20);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 4;
            label2.Text = "Commande";
            // 
            // CommandeCB
            // 
            CommandeCB.FormattingEnabled = true;
            CommandeCB.Location = new Point(573, 43);
            CommandeCB.Name = "CommandeCB";
            CommandeCB.Size = new Size(136, 28);
            CommandeCB.TabIndex = 5;
            // 
            // DeplaceurCB
            // 
            DeplaceurCB.FormattingEnabled = true;
            DeplaceurCB.Location = new Point(366, 153);
            DeplaceurCB.Name = "DeplaceurCB";
            DeplaceurCB.Size = new Size(125, 28);
            DeplaceurCB.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(392, 130);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 7;
            label3.Text = "Déplaceur";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(594, 131);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 8;
            label4.Text = "Fromage";
            // 
            // FromageCB
            // 
            FromageCB.FormattingEnabled = true;
            FromageCB.Location = new Point(573, 153);
            FromageCB.Name = "FromageCB";
            FromageCB.Size = new Size(136, 28);
            FromageCB.TabIndex = 9;
            // 
            // Emplacement
            // 
            Emplacement.AutoSize = true;
            Emplacement.Location = new Point(379, 213);
            Emplacement.Name = "Emplacement";
            Emplacement.Size = new Size(100, 20);
            Emplacement.TabIndex = 10;
            Emplacement.Text = "Emplacement";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(601, 213);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 11;
            label5.Text = "Emplacement";
            // 
            // EmplacementCB1
            // 
            EmplacementCB1.FormattingEnabled = true;
            EmplacementCB1.Location = new Point(366, 250);
            EmplacementCB1.Name = "EmplacementCB1";
            EmplacementCB1.Size = new Size(125, 28);
            EmplacementCB1.TabIndex = 12;
            // 
            // EmplacementCB2
            // 
            EmplacementCB2.FormattingEnabled = true;
            EmplacementCB2.Location = new Point(582, 250);
            EmplacementCB2.Name = "EmplacementCB2";
            EmplacementCB2.Size = new Size(127, 28);
            EmplacementCB2.TabIndex = 13;
            // 
            // Enregistrer
            // 
            Enregistrer.Location = new Point(295, 350);
            Enregistrer.Name = "Enregistrer";
            Enregistrer.Size = new Size(94, 29);
            Enregistrer.TabIndex = 14;
            Enregistrer.Text = "Enregistrer";
            Enregistrer.UseVisualStyleBackColor = true;
            Enregistrer.Click += Enregistrer_Click;
            // 
            // AjoutMouvement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Enregistrer);
            Controls.Add(EmplacementCB2);
            Controls.Add(EmplacementCB1);
            Controls.Add(label5);
            Controls.Add(Emplacement);
            Controls.Add(FromageCB);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(DeplaceurCB);
            Controls.Add(CommandeCB);
            Controls.Add(label2);
            Controls.Add(QuantiteTB);
            Controls.Add(CalendrierDate);
            Controls.Add(label1);
            Controls.Add(Date);
            Name = "AjoutMouvement";
            Text = "AjoutMouvement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Date;
        private Label label1;
        private MonthCalendar CalendrierDate;
        private TextBox QuantiteTB;
        private Label label2;
        private ComboBox CommandeCB;
        private ComboBox DeplaceurCB;
        private Label label3;
        private Label label4;
        private ComboBox FromageCB;
        private Label Emplacement;
        private Label label5;
        private ComboBox EmplacementCB1;
        private ComboBox EmplacementCB2;
        private Button Enregistrer;
    }
}