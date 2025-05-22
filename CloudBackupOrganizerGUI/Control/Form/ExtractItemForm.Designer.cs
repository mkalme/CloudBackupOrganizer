
namespace CloudBackupOrganizerGUI {
    partial class ExtractItemForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtractItemForm));
            this.ArchiveLabel = new CustomDialogs.DarkLabel();
            this.ArchivePathTextBox = new CustomDialogs.DarkTextBox();
            this.BrowseArchiveButton = new CustomDialogs.DarkButton();
            this.darkLabel1 = new CustomDialogs.DarkLabel();
            this.DirectoryPathTextBox = new CustomDialogs.DarkTextBox();
            this.BrowseDirectoryButton = new CustomDialogs.DarkButton();
            this.ExtractButton = new CustomDialogs.DarkButton();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // ArchiveLabel
            // 
            this.ArchiveLabel.AutoSize = true;
            this.ArchiveLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ArchiveLabel.Location = new System.Drawing.Point(11, 14);
            this.ArchiveLabel.Name = "ArchiveLabel";
            this.ArchiveLabel.Size = new System.Drawing.Size(74, 15);
            this.ArchiveLabel.TabIndex = 6;
            this.ArchiveLabel.Text = "Archive path";
            // 
            // ArchivePathTextBox
            // 
            this.ArchivePathTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ArchivePathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ArchivePathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ArchivePathTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ArchivePathTextBox.Location = new System.Drawing.Point(98, 33);
            this.ArchivePathTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.ArchivePathTextBox.Name = "ArchivePathTextBox";
            this.ArchivePathTextBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.ArchivePathTextBox.PasswordChar = '\0';
            this.ArchivePathTextBox.ReadOnly = false;
            this.ArchivePathTextBox.Size = new System.Drawing.Size(396, 25);
            this.ArchivePathTextBox.TabIndex = 5;
            this.ArchivePathTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ArchivePathTextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.ArchivePathTextBox.XOffset = 0;
            this.ArchivePathTextBox.YOffset = 0;
            // 
            // BrowseArchiveButton
            // 
            this.BrowseArchiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.BrowseArchiveButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.BrowseArchiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseArchiveButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BrowseArchiveButton.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxDocument;
            this.BrowseArchiveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BrowseArchiveButton.Location = new System.Drawing.Point(14, 33);
            this.BrowseArchiveButton.Margin = new System.Windows.Forms.Padding(0);
            this.BrowseArchiveButton.Name = "BrowseArchiveButton";
            this.BrowseArchiveButton.Size = new System.Drawing.Size(75, 25);
            this.BrowseArchiveButton.TabIndex = 4;
            this.BrowseArchiveButton.Text = "Browse";
            this.BrowseArchiveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BrowseArchiveButton.UseVisualStyleBackColor = true;
            this.BrowseArchiveButton.Click += new System.EventHandler(this.BrowseArchiveButton_Click);
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.darkLabel1.Location = new System.Drawing.Point(11, 75);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(122, 15);
            this.darkLabel1.TabIndex = 9;
            this.darkLabel1.Text = "Output directory path";
            // 
            // DirectoryPathTextBox
            // 
            this.DirectoryPathTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DirectoryPathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.DirectoryPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DirectoryPathTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DirectoryPathTextBox.Location = new System.Drawing.Point(98, 94);
            this.DirectoryPathTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.DirectoryPathTextBox.Name = "DirectoryPathTextBox";
            this.DirectoryPathTextBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.DirectoryPathTextBox.PasswordChar = '\0';
            this.DirectoryPathTextBox.ReadOnly = false;
            this.DirectoryPathTextBox.Size = new System.Drawing.Size(396, 25);
            this.DirectoryPathTextBox.TabIndex = 8;
            this.DirectoryPathTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DirectoryPathTextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.DirectoryPathTextBox.XOffset = 0;
            this.DirectoryPathTextBox.YOffset = 0;
            // 
            // BrowseDirectoryButton
            // 
            this.BrowseDirectoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.BrowseDirectoryButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.BrowseDirectoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseDirectoryButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BrowseDirectoryButton.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxFolderClosed;
            this.BrowseDirectoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BrowseDirectoryButton.Location = new System.Drawing.Point(14, 94);
            this.BrowseDirectoryButton.Margin = new System.Windows.Forms.Padding(0);
            this.BrowseDirectoryButton.Name = "BrowseDirectoryButton";
            this.BrowseDirectoryButton.Size = new System.Drawing.Size(75, 25);
            this.BrowseDirectoryButton.TabIndex = 7;
            this.BrowseDirectoryButton.Text = "Browse";
            this.BrowseDirectoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BrowseDirectoryButton.UseVisualStyleBackColor = true;
            this.BrowseDirectoryButton.Click += new System.EventHandler(this.BrowseDirectoryButton_Click);
            // 
            // ExtractButton
            // 
            this.ExtractButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ExtractButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.ExtractButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExtractButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ExtractButton.Location = new System.Drawing.Point(14, 166);
            this.ExtractButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExtractButton.Name = "ExtractButton";
            this.ExtractButton.Size = new System.Drawing.Size(75, 25);
            this.ExtractButton.TabIndex = 10;
            this.ExtractButton.Text = "Extract";
            this.ExtractButton.UseVisualStyleBackColor = true;
            this.ExtractButton.Click += new System.EventHandler(this.ExtractButton_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "Zip files|*.7z";
            // 
            // ExtractItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(508, 205);
            this.Controls.Add(this.ExtractButton);
            this.Controls.Add(this.darkLabel1);
            this.Controls.Add(this.DirectoryPathTextBox);
            this.Controls.Add(this.BrowseDirectoryButton);
            this.Controls.Add(this.ArchiveLabel);
            this.Controls.Add(this.ArchivePathTextBox);
            this.Controls.Add(this.BrowseArchiveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ExtractItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Extract item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDialogs.DarkLabel ArchiveLabel;
        private CustomDialogs.DarkTextBox ArchivePathTextBox;
        private CustomDialogs.DarkButton BrowseArchiveButton;
        private CustomDialogs.DarkLabel darkLabel1;
        private CustomDialogs.DarkTextBox DirectoryPathTextBox;
        private CustomDialogs.DarkButton BrowseDirectoryButton;
        private CustomDialogs.DarkButton ExtractButton;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
    }
}