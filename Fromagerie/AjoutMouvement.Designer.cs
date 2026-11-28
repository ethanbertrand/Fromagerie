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
            DateChoisir = new DateTimePicker();
            SuspendLayout();
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Location = new Point(93, 15);
            Date.Name = "Date";
            Date.Size = new Size(31, 15);
            Date.TabIndex = 0;
            Date.Text = "Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(343, 15);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 1;
            label1.Text = "Quantite";
            // 
            // QuantiteTB
            // 
            QuantiteTB.Location = new Point(320, 32);
            QuantiteTB.Margin = new Padding(3, 2, 3, 2);
            QuantiteTB.Name = "QuantiteTB";
            QuantiteTB.Size = new Size(110, 23);
            QuantiteTB.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(526, 15);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 4;
            label2.Text = "Commande";
            // 
            // CommandeCB
            // 
            CommandeCB.FormattingEnabled = true;
            CommandeCB.Location = new Point(501, 32);
            CommandeCB.Margin = new Padding(3, 2, 3, 2);
            CommandeCB.Name = "CommandeCB";
            CommandeCB.Size = new Size(120, 23);
            CommandeCB.TabIndex = 5;
            CommandeCB.SelectedIndexChanged += CommandeCB_SelectedIndexChanged;
            // 
            // DeplaceurCB
            // 
            DeplaceurCB.FormattingEnabled = true;
            DeplaceurCB.Location = new Point(320, 115);
            DeplaceurCB.Margin = new Padding(3, 2, 3, 2);
            DeplaceurCB.Name = "DeplaceurCB";
            DeplaceurCB.Size = new Size(110, 23);
            DeplaceurCB.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(343, 98);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 7;
            label3.Text = "Déplaceur";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(520, 98);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 8;
            label4.Text = "Fromage";
            // 
            // FromageCB
            // 
            FromageCB.FormattingEnabled = true;
            FromageCB.Location = new Point(501, 115);
            FromageCB.Margin = new Padding(3, 2, 3, 2);
            FromageCB.Name = "FromageCB";
            FromageCB.Size = new Size(120, 23);
            FromageCB.TabIndex = 9;
            // 
            // Emplacement
            // 
            Emplacement.AutoSize = true;
            Emplacement.Location = new Point(332, 160);
            Emplacement.Name = "Emplacement";
            Emplacement.Size = new Size(80, 15);
            Emplacement.TabIndex = 10;
            Emplacement.Text = "Emplacement";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(526, 160);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 11;
            label5.Text = "Emplacement";
            // 
            // EmplacementCB1
            // 
            EmplacementCB1.FormattingEnabled = true;
            EmplacementCB1.Location = new Point(320, 188);
            EmplacementCB1.Margin = new Padding(3, 2, 3, 2);
            EmplacementCB1.Name = "EmplacementCB1";
            EmplacementCB1.Size = new Size(110, 23);
            EmplacementCB1.TabIndex = 12;
            // 
            // EmplacementCB2
            // 
            EmplacementCB2.FormattingEnabled = true;
            EmplacementCB2.Location = new Point(509, 188);
            EmplacementCB2.Margin = new Padding(3, 2, 3, 2);
            EmplacementCB2.Name = "EmplacementCB2";
            EmplacementCB2.Size = new Size(112, 23);
            EmplacementCB2.TabIndex = 13;
            // 
            // Enregistrer
            // 
            Enregistrer.Location = new Point(258, 262);
            Enregistrer.Margin = new Padding(3, 2, 3, 2);
            Enregistrer.Name = "Enregistrer";
            Enregistrer.Size = new Size(82, 22);
            Enregistrer.TabIndex = 14;
            Enregistrer.Text = "Enregistrer";
            Enregistrer.UseVisualStyleBackColor = true;
            Enregistrer.Click += Enregistrer_Click;
            // 
            // DateChoisir
            // 
            DateChoisir.Location = new Point(24, 44);
            DateChoisir.Margin = new Padding(3, 2, 3, 2);
            DateChoisir.Name = "DateChoisir";
            DateChoisir.Size = new Size(224, 23);
            DateChoisir.TabIndex = 15;
            // 
            // AjoutMouvement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(DateChoisir);
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
            Controls.Add(label1);
            Controls.Add(Date);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AjoutMouvement";
            Text = "AjoutMouvement";
            Load += AjoutMouvement_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Date;
        private Label label1;
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
        private DateTimePicker DateChoisir;
    }
}