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
            pagevendeur = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 167);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Prix Total";
            // 
            // PrixTB
            // 
            PrixTB.Location = new Point(128, 217);
            PrixTB.Margin = new Padding(3, 2, 3, 2);
            PrixTB.Name = "PrixTB";
            PrixTB.Size = new Size(108, 23);
            PrixTB.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(362, 191);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Vendeur";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(519, 191);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 3;
            label3.Text = "Acheteur";
            // 
            // VendeurCB
            // 
            VendeurCB.FormattingEnabled = true;
            VendeurCB.Location = new Point(332, 235);
            VendeurCB.Margin = new Padding(3, 2, 3, 2);
            VendeurCB.Name = "VendeurCB";
            VendeurCB.Size = new Size(120, 23);
            VendeurCB.TabIndex = 4;
            VendeurCB.SelectedIndexChanged += VendeurCB_SelectedIndexChanged;
            // 
            // AcheteurCB
            // 
            AcheteurCB.FormattingEnabled = true;
            AcheteurCB.Location = new Point(494, 235);
            AcheteurCB.Margin = new Padding(3, 2, 3, 2);
            AcheteurCB.Name = "AcheteurCB";
            AcheteurCB.Size = new Size(120, 23);
            AcheteurCB.TabIndex = 5;
            AcheteurCB.SelectedIndexChanged += AcheteurCB_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(424, 366);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 6;
            button1.Text = "Enregistrer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pagevendeur
            // 
            pagevendeur.Location = new Point(398, 474);
            pagevendeur.Name = "pagevendeur";
            pagevendeur.Size = new Size(176, 46);
            pagevendeur.TabIndex = 7;
            pagevendeur.Text = "Revenir à la page Vendeur";
            pagevendeur.UseVisualStyleBackColor = true;
            pagevendeur.Click += button2_Click;
            // 
            // AjoutCommande
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 686);
            Controls.Add(pagevendeur);
            Controls.Add(button1);
            Controls.Add(AcheteurCB);
            Controls.Add(VendeurCB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PrixTB);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AjoutCommande";
            Text = "AjoutCommande";
            Load += AjoutCommande_Load;
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
        private Button pagevendeur;
    }
}