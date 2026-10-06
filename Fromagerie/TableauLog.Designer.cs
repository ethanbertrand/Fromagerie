namespace Fromagerie
{
    partial class TableauLog
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
            LogTB = new TableLayoutPanel();
            SuspendLayout();
            // 
            // LogTB
            // 
            LogTB.AutoScroll = true;
            LogTB.ColumnCount = 2;
            LogTB.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LogTB.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LogTB.Dock = DockStyle.Fill;
            LogTB.Location = new Point(0, 0);
            LogTB.Name = "LogTB";
            LogTB.RowCount = 2;
            LogTB.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            LogTB.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            LogTB.Size = new Size(800, 450);
            LogTB.TabIndex = 0;
            LogTB.Paint += LogTB_Paint;
            // 
            // TableauLog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LogTB);
            Name = "TableauLog";
            Text = "TableauLog";
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel LogTB;
    }
}