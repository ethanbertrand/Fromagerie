namespace Fromagerie
{
    partial class AjoutFromage
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
            NomFromageTB = new TextBox();
            ProducteurCB = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TypeFromageCB = new ComboBox();
            PoidsFromageTB = new TextBox();
            PrixKGFromageTB = new TextBox();
            Poids = new Label();
            label4 = new Label();
            EnregistrerFromage = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // NomFromageTB
            // 
            NomFromageTB.Location = new Point(177, 221);
            NomFromageTB.Margin = new Padding(3, 2, 3, 2);
            NomFromageTB.Name = "NomFromageTB";
            NomFromageTB.Size = new Size(110, 23);
            NomFromageTB.TabIndex = 0;
            NomFromageTB.TextChanged += textBox1_TextChanged;
            // 
            // ProducteurCB
            // 
            ProducteurCB.FormattingEnabled = true;
            ProducteurCB.Location = new Point(130, 295);
            ProducteurCB.Margin = new Padding(3, 2, 3, 2);
            ProducteurCB.Name = "ProducteurCB";
            ProducteurCB.Size = new Size(209, 23);
            ProducteurCB.TabIndex = 1;
            ProducteurCB.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(213, 188);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 2;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 269);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 3;
            label2.Text = "Producteur";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 368);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 4;
            label3.Text = "Type Fromage";
            // 
            // TypeFromageCB
            // 
            TypeFromageCB.FormattingEnabled = true;
            TypeFromageCB.Location = new Point(165, 411);
            TypeFromageCB.Margin = new Padding(3, 2, 3, 2);
            TypeFromageCB.Name = "TypeFromageCB";
            TypeFromageCB.Size = new Size(133, 23);
            TypeFromageCB.TabIndex = 5;
            TypeFromageCB.SelectedIndexChanged += TypeFromageCB_SelectedIndexChanged;
            // 
            // PoidsFromageTB
            // 
            PoidsFromageTB.Location = new Point(554, 221);
            PoidsFromageTB.Margin = new Padding(3, 2, 3, 2);
            PoidsFromageTB.Name = "PoidsFromageTB";
            PoidsFromageTB.Size = new Size(110, 23);
            PoidsFromageTB.TabIndex = 6;
            // 
            // PrixKGFromageTB
            // 
            PrixKGFromageTB.Location = new Point(554, 309);
            PrixKGFromageTB.Margin = new Padding(3, 2, 3, 2);
            PrixKGFromageTB.Name = "PrixKGFromageTB";
            PrixKGFromageTB.Size = new Size(110, 23);
            PrixKGFromageTB.TabIndex = 7;
            // 
            // Poids
            // 
            Poids.AutoSize = true;
            Poids.Location = new Point(581, 193);
            Poids.Name = "Poids";
            Poids.Size = new Size(36, 15);
            Poids.TabIndex = 8;
            Poids.Text = "Poids";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(586, 286);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 9;
            label4.Text = "Prix/KG";
            // 
            // EnregistrerFromage
            // 
            EnregistrerFromage.Location = new Point(568, 410);
            EnregistrerFromage.Margin = new Padding(3, 2, 3, 2);
            EnregistrerFromage.Name = "EnregistrerFromage";
            EnregistrerFromage.Size = new Size(82, 22);
            EnregistrerFromage.TabIndex = 10;
            EnregistrerFromage.Text = "Enregistrer";
            EnregistrerFromage.UseVisualStyleBackColor = true;
            EnregistrerFromage.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(780, 193);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 11;
            label5.Text = "label5";
            // 
            // AjoutFromage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 855);
            Controls.Add(label5);
            Controls.Add(EnregistrerFromage);
            Controls.Add(label4);
            Controls.Add(Poids);
            Controls.Add(PrixKGFromageTB);
            Controls.Add(PoidsFromageTB);
            Controls.Add(TypeFromageCB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ProducteurCB);
            Controls.Add(NomFromageTB);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AjoutFromage";
            Text = "AjoutFromage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NomFromageTB;
        private ComboBox ProducteurCB;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox TypeFromageCB;
        private TextBox PoidsFromageTB;
        private TextBox PrixKGFromageTB;
        private Label Poids;
        private Label label4;
        private Button EnregistrerFromage;
        private Label label5;
    }
}