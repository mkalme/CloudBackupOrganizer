
namespace CloudBackupOrganizerGUI {
    partial class ZipDirectoryForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZipDirectoryForm));
            this.BrowseButton = new CustomDialogs.DarkButton();
            this.PathTextBox = new CustomDialogs.DarkTextBox();
            this.DefaultDirectoryCheckBox = new CustomDialogs.DarkCheckBox();
            this.ZippedItemOutputDirectoryLabel = new CustomDialogs.DarkLabel();
            this.ZipButton = new CustomDialogs.DarkButton();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // BrowseButton
            // 
            this.BrowseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.BrowseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BrowseButton.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxFolderClosed;
            this.BrowseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BrowseButton.Location = new System.Drawing.Point(13, 35);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(0);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 25);
            this.BrowseButton.TabIndex = 0;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            this.BrowseButton.Paint += new System.Windows.Forms.PaintEventHandler(this.BrowseButton_Paint);
            // 
            // PathTextBox
            // 
            this.PathTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.PathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PathTextBox.Location = new System.Drawing.Point(97, 35);
            this.PathTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.PathTextBox.PasswordChar = '\0';
            this.PathTextBox.ReadOnly = false;
            this.PathTextBox.Size = new System.Drawing.Size(402, 25);
            this.PathTextBox.TabIndex = 1;
            this.PathTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathTextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.PathTextBox.XOffset = 0;
            this.PathTextBox.YOffset = 0;
            // 
            // DefaultDirectoryCheckBox
            // 
            this.DefaultDirectoryCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.DefaultDirectoryCheckBox.BoxBackColor = System.Drawing.Color.Transparent;
            this.DefaultDirectoryCheckBox.BoxBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.DefaultDirectoryCheckBox.BoxHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DefaultDirectoryCheckBox.BoxMouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DefaultDirectoryCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DefaultDirectoryCheckBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DefaultDirectoryCheckBox.Location = new System.Drawing.Point(12, 68);
            this.DefaultDirectoryCheckBox.Name = "DefaultDirectoryCheckBox";
            this.DefaultDirectoryCheckBox.Size = new System.Drawing.Size(243, 19);
            this.DefaultDirectoryCheckBox.TabIndex = 2;
            this.DefaultDirectoryCheckBox.Text = "Use default zipped item output directory";
            this.DefaultDirectoryCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DefaultDirectoryCheckBox.UseVisualStyleBackColor = true;
            this.DefaultDirectoryCheckBox.CheckedChanged += new System.EventHandler(this.DefaultDirectoryCheckBox_CheckedChanged);
            // 
            // ZippedItemOutputDirectoryLabel
            // 
            this.ZippedItemOutputDirectoryLabel.AutoSize = true;
            this.ZippedItemOutputDirectoryLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ZippedItemOutputDirectoryLabel.Location = new System.Drawing.Point(10, 16);
            this.ZippedItemOutputDirectoryLabel.Name = "ZippedItemOutputDirectoryLabel";
            this.ZippedItemOutputDirectoryLabel.Size = new System.Drawing.Size(160, 15);
            this.ZippedItemOutputDirectoryLabel.TabIndex = 3;
            this.ZippedItemOutputDirectoryLabel.Text = "Zipped item output directory";
            // 
            // ZipButton
            // 
            this.ZipButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ZipButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.ZipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZipButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ZipButton.Location = new System.Drawing.Point(13, 128);
            this.ZipButton.Margin = new System.Windows.Forms.Padding(0);
            this.ZipButton.Name = "ZipButton";
            this.ZipButton.Size = new System.Drawing.Size(75, 25);
            this.ZipButton.TabIndex = 4;
            this.ZipButton.Text = "Zip";
            this.ZipButton.UseVisualStyleBackColor = true;
            this.ZipButton.Click += new System.EventHandler(this.ZipButton_Click);
            // 
            // ZipDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(508, 168);
            this.Controls.Add(this.ZipButton);
            this.Controls.Add(this.ZippedItemOutputDirectoryLabel);
            this.Controls.Add(this.DefaultDirectoryCheckBox);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.BrowseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ZipDirectoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zip item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDialogs.DarkButton BrowseButton;
        private CustomDialogs.DarkTextBox PathTextBox;
        private CustomDialogs.DarkCheckBox DefaultDirectoryCheckBox;
        private CustomDialogs.DarkLabel ZippedItemOutputDirectoryLabel;
        private CustomDialogs.DarkButton ZipButton;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
    }
}