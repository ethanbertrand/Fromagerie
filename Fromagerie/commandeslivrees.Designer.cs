namespace Fromagerie
{
    partial class commandeslivrees
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            retouradmin = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(277, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(810, 422);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(638, 64);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 1;
            label1.Text = "Commandes livrées";
            label1.Click += label1_Click;
            // 
            // retouradmin
            // 
            retouradmin.Location = new Point(596, 593);
            retouradmin.Name = "retouradmin";
            retouradmin.Size = new Size(173, 66);
            retouradmin.TabIndex = 2;
            retouradmin.Text = "Revenir au menu  Acheteur";
            retouradmin.UseVisualStyleBackColor = true;
            retouradmin.Click += retouradmin_Click;
            // 
            // commandeslivrees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1381, 733);
            Controls.Add(retouradmin);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "commandeslivrees";
            Text = "commandeslivrees";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button retouradmin;
    }
}