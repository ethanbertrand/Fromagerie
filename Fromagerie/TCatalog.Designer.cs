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
            catalog = new TableLayoutPanel();
            SuspendLayout();
            // 
            // catalog
            // 
            catalog.ColumnCount = 2;
            catalog.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            catalog.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            catalog.Location = new Point(12, 12);
            catalog.Name = "catalog";
            catalog.RowCount = 2;
            catalog.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            catalog.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            catalog.Size = new Size(776, 426);
            catalog.TabIndex = 0;
            catalog.Paint += catalog_Paint;
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

        private TableLayoutPanel catalog;
    }
}