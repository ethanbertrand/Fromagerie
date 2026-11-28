namespace Fromagerie
{
    partial class AjoutPermissionDesRoles
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
            label2 = new Label();
            RoleCB = new ComboBox();
            PermissionCB = new ComboBox();
            EnregistrerB = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 162);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "Role";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 158);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Permission";
            // 
            // RoleCB
            // 
            RoleCB.FormattingEnabled = true;
            RoleCB.Location = new Point(30, 201);
            RoleCB.Name = "RoleCB";
            RoleCB.Size = new Size(149, 28);
            RoleCB.TabIndex = 2;
            // 
            // PermissionCB
            // 
            PermissionCB.FormattingEnabled = true;
            PermissionCB.Location = new Point(275, 201);
            PermissionCB.Name = "PermissionCB";
            PermissionCB.Size = new Size(149, 28);
            PermissionCB.TabIndex = 3;
            // 
            // EnregistrerB
            // 
            EnregistrerB.Location = new Point(380, 403);
            EnregistrerB.Name = "EnregistrerB";
            EnregistrerB.Size = new Size(109, 46);
            EnregistrerB.TabIndex = 4;
            EnregistrerB.Text = "Enregistrer";
            EnregistrerB.UseVisualStyleBackColor = true;
            EnregistrerB.Click += EnregistrerB_Click;
            // 
            // AjoutPermissionDesRoles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 836);
            Controls.Add(EnregistrerB);
            Controls.Add(PermissionCB);
            Controls.Add(RoleCB);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AjoutPermissionDesRoles";
            Text = "AjoutPermissionDesRoles";
            Load += AjoutPermissionDesRoles_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox RoleCB;
        private ComboBox PermissionCB;
        private Button EnregistrerB;
    }
}