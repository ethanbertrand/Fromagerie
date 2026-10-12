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
            fromagetb.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.76923F));
            fromagetb.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.23077F));
            fromagetb.Dock = DockStyle.Fill;
            fromagetb.Location = new Point(0, 0);
            fromagetb.Margin = new Padding(3, 2, 3, 2);
            fromagetb.Name = "fromagetb";
            fromagetb.RowCount = 2;
            fromagetb.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            fromagetb.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            fromagetb.Size = new Size(692, 805);
            fromagetb.TabIndex = 0;
            fromagetb.Paint += fromagetb_Paint;
            // 
            // TableauFromage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 805);
            Controls.Add(fromagetb);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TableauFromage";
            Text = "TableauFromage";
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel fromagetb;
    }
}