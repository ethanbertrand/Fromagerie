namespace Fromagerie
{
    partial class TCatalog
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
            catalog = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // catalog
            // 
            catalog.Location = new Point(12, 12);
            catalog.Name = "catalog";
            catalog.Size = new Size(776, 426);
            catalog.TabIndex = 0;
            // 
            // TCatalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(catalog);
            Name = "TCatalog";
            Text = "TCatalog";
            Load += TCatalog_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel catalog;
    }
}