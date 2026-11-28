namespace Fromagerie
{
    partial class TableauFromage
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
            fromagetb = new TableLayoutPanel();
            SuspendLayout();
            // 
            // fromagetb
            // 
            fromagetb.AutoScroll = true;
            fromagetb.ColumnCount = 2;
            fromagetb.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            fromagetb.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            fromagetb.Dock = DockStyle.Fill;
            fromagetb.Location = new Point(0, 0);
            fromagetb.Name = "fromagetb";
            fromagetb.RowCount = 2;
            fromagetb.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            fromagetb.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            fromagetb.Size = new Size(1486, 1073);
            fromagetb.TabIndex = 0;
            // 
            // TableauFromage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 1073);
            Controls.Add(fromagetb);
            Name = "TableauFromage";
            Text = "TableauFromage";
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel fromagetb;
    }
}