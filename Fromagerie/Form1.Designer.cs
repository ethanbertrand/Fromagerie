namespace Fromagerie
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Inscription = new Button();
            identifiant = new ListBox();
            Connection = new Button();
            Mdp = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Inscription
            // 
            Inscription.Location = new Point(796, 569);
            Inscription.Name = "Inscription";
            Inscription.Size = new Size(101, 41);
            Inscription.TabIndex = 0;
            Inscription.Text = "Inscription";
            Inscription.UseVisualStyleBackColor = true;
            Inscription.Click += button1_Click;
            // 
            // identifiant
            // 
            identifiant.FormattingEnabled = true;
            identifiant.Location = new Point(223, 329);
            identifiant.Name = "identifiant";
            identifiant.Size = new Size(106, 49);
            identifiant.TabIndex = 1;
            // 
            // Connection
            // 
            Connection.Location = new Point(237, 599);
            Connection.Name = "Connection";
            Connection.Size = new Size(101, 41);
            Connection.TabIndex = 2;
            Connection.Text = "Connection";
            Connection.UseVisualStyleBackColor = true;
            // 
            // Mdp
            // 
            Mdp.FormattingEnabled = true;
            Mdp.Location = new Point(223, 465);
            Mdp.Name = "Mdp";
            Mdp.Size = new Size(106, 49);
            Mdp.TabIndex = 3;
            // 
            // label1
            // 
            label1.Location = new Point(486, 87);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 4;
            label1.Text = "Eure-Et-Loir Fromage";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 824);
            Controls.Add(label1);
            Controls.Add(Mdp);
            Controls.Add(Connection);
            Controls.Add(identifiant);
            Controls.Add(Inscription);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Inscription;
        private ListBox identifiant;
        private Button Connection;
        private ListBox Mdp;
        private Label label1;
    }
}
