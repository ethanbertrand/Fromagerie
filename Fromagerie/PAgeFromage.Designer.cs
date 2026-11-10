namespace Fromagerie
{
    partial class PAgeFromage
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
            fromages = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // fromages
            // 
            fromages.Location = new Point(12, 12);
            fromages.Name = "fromages";
            fromages.Size = new Size(979, 640);
            fromages.TabIndex = 0;
            fromages.Paint += flowLayoutPanel1_Paint;
            // 
            // PAgeFromage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 664);
            Controls.Add(fromages);
            Name = "PAgeFromage";
            Text = "PAgeFromage";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel fromages;
    }
}