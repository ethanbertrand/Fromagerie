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
            SuspendLayout();
            // 
            // NomFromageTB
            // 
            NomFromageTB.Location = new Point(202, 295);
            NomFromageTB.Name = "NomFromageTB";
            NomFromageTB.Size = new Size(125, 27);
            NomFromageTB.TabIndex = 0;
            NomFromageTB.TextChanged += textBox1_TextChanged;
            // 
            // ProducteurCB
            // 
            ProducteurCB.FormattingEnabled = true;
            ProducteurCB.Location = new Point(148, 393);
            ProducteurCB.Name = "ProducteurCB";
            ProducteurCB.Size = new Size(238, 28);
            ProducteurCB.TabIndex = 1;
            ProducteurCB.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(243, 251);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 2;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 359);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 3;
            label2.Text = "Producteur";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 491);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 4;
            label3.Text = "Type Fromage";
            // 
            // TypeFromageCB
            // 
            TypeFromageCB.FormattingEnabled = true;
            TypeFromageCB.Location = new Point(189, 548);
            TypeFromageCB.Name = "TypeFromageCB";
            TypeFromageCB.Size = new Size(151, 28);
            TypeFromageCB.TabIndex = 5;
            TypeFromageCB.SelectedIndexChanged += TypeFromageCB_SelectedIndexChanged;
            // 
            // PoidsFromageTB
            // 
            PoidsFromageTB.Location = new Point(633, 295);
            PoidsFromageTB.Name = "PoidsFromageTB";
            PoidsFromageTB.Size = new Size(125, 27);
            PoidsFromageTB.TabIndex = 6;
            // 
            // PrixKGFromageTB
            // 
            PrixKGFromageTB.Location = new Point(633, 412);
            PrixKGFromageTB.Name = "PrixKGFromageTB";
            PrixKGFromageTB.Size = new Size(125, 27);
            PrixKGFromageTB.TabIndex = 7;
            // 
            // Poids
            // 
            Poids.AutoSize = true;
            Poids.Location = new Point(664, 257);
            Poids.Name = "Poids";
            Poids.Size = new Size(44, 20);
            Poids.TabIndex = 8;
            Poids.Text = "Poids";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(670, 381);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 9;
            label4.Text = "Prix/KG";
            // 
            // EnregistrerFromage
            // 
            EnregistrerFromage.Location = new Point(649, 547);
            EnregistrerFromage.Name = "EnregistrerFromage";
            EnregistrerFromage.Size = new Size(94, 29);
            EnregistrerFromage.TabIndex = 10;
            EnregistrerFromage.Text = "Enregistrer";
            EnregistrerFromage.UseVisualStyleBackColor = true;
            EnregistrerFromage.Click += button1_Click;
            // 
            // AjoutFromage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1531, 1140);
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
    }
}