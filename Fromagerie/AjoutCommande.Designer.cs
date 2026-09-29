namespace Fromagerie
{
    partial class AjoutCommande
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
            PrixTB = new TextBox();
            label2 = new Label();
            label3 = new Label();
            VendeurCB = new ComboBox();
            AcheteurCB = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 223);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Prix Total";
            // 
            // PrixTB
            // 
            PrixTB.Location = new Point(149, 269);
            PrixTB.Name = "PrixTB";
            PrixTB.Size = new Size(123, 27);
            PrixTB.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(414, 255);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 2;
            label2.Text = "Vendeur";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(593, 255);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 3;
            label3.Text = "Acheteur";
            // 
            // VendeurCB
            // 
            VendeurCB.FormattingEnabled = true;
            VendeurCB.Location = new Point(379, 313);
            VendeurCB.Name = "VendeurCB";
            VendeurCB.Size = new Size(136, 28);
            VendeurCB.TabIndex = 4;
            VendeurCB.SelectedIndexChanged += VendeurCB_SelectedIndexChanged;
            // 
            // AcheteurCB
            // 
            AcheteurCB.FormattingEnabled = true;
            AcheteurCB.Location = new Point(565, 313);
            AcheteurCB.Name = "AcheteurCB";
            AcheteurCB.Size = new Size(136, 28);
            AcheteurCB.TabIndex = 5;
            AcheteurCB.SelectedIndexChanged += AcheteurCB_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(583, 570);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Enregistrer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AjoutCommande
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 914);
            Controls.Add(button1);
            Controls.Add(AcheteurCB);
            Controls.Add(VendeurCB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PrixTB);
            Controls.Add(label1);
            Name = "AjoutCommande";
            Text = "AjoutCommande";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox PrixTB;
        private Label label2;
        private Label label3;
        private ComboBox VendeurCB;
        private ComboBox AcheteurCB;
        private Button button1;
    }
}