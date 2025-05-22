
namespace CloudBackupOrganizerGUI {
    partial class ZippedFolderEditor {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZippedFolderEditor));
            this.PathLabel = new CustomDialogs.DarkLabel();
            this.PathTextBox = new CustomDialogs.DarkTextBox();
            this.BrowseButton = new CustomDialogs.DarkButton();
            this.CancelButton = new CustomDialogs.DarkButton();
            this.SaveButton = new CustomDialogs.DarkButton();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.NameLabel = new CustomDialogs.DarkLabel();
            this.NameTextBox = new CustomDialogs.DarkTextBox();
            this.ChangeLinkButton = new CustomDialogs.DarkButton();
            this.ChangePasswordButton = new CustomDialogs.DarkButton();
            this.SuspendLayout();
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PathLabel.Location = new System.Drawing.Point(9, 13);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(31, 15);
            this.PathLabel.TabIndex = 13;
            this.PathLabel.Text = "Path";
            // 
            // PathTextBox
            // 
            this.PathTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.PathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PathTextBox.Location = new System.Drawing.Point(96, 32);
            this.PathTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.PathTextBox.PasswordChar = '\0';
            this.PathTextBox.ReadOnly = false;
            this.PathTextBox.Size = new System.Drawing.Size(496, 25);
            this.PathTextBox.TabIndex = 12;
            this.PathTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathTextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.PathTextBox.XOffset = 0;
            this.PathTextBox.YOffset = 0;
            // 
            // BrowseButton
            // 
            this.BrowseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.BrowseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BrowseButton.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxFolderClosed;
            this.BrowseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BrowseButton.Location = new System.Drawing.Point(12, 32);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(0);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 25);
            this.BrowseButton.TabIndex = 11;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CancelButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CancelButton.Location = new System.Drawing.Point(98, 176);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(0);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 25);
            this.CancelButton.TabIndex = 29;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.SaveButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SaveButton.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxSave;
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveButton.Location = new System.Drawing.Point(12, 176);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.SaveButton.Size = new System.Drawing.Size(75, 25);
            this.SaveButton.TabIndex = 28;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameLabel.Location = new System.Drawing.Point(10, 74);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 15);
            this.NameLabel.TabIndex = 31;
            this.NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameTextBox.Location = new System.Drawing.Point(13, 93);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.ReadOnly = false;
            this.NameTextBox.Size = new System.Drawing.Size(284, 25);
            this.NameTextBox.TabIndex = 30;
            this.NameTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameTextBox.XOffset = 0;
            this.NameTextBox.YOffset = 0;
            // 
            // ChangeLinkButton
            // 
            this.ChangeLinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ChangeLinkButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.ChangeLinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeLinkButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ChangeLinkButton.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxLink;
            this.ChangeLinkButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChangeLinkButton.Location = new System.Drawing.Point(350, 93);
            this.ChangeLinkButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChangeLinkButton.Name = "ChangeLinkButton";
            this.ChangeLinkButton.Size = new System.Drawing.Size(102, 25);
            this.ChangeLinkButton.TabIndex = 35;
            this.ChangeLinkButton.Text = "Change link";
            this.ChangeLinkButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangeLinkButton.UseVisualStyleBackColor = true;
            this.ChangeLinkButton.Click += new System.EventHandler(this.ChangeLinkButton_Click);
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ChangePasswordButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.ChangePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePasswordButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ChangePasswordButton.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxKey;
            this.ChangePasswordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChangePasswordButton.Location = new System.Drawing.Point(461, 93);
            this.ChangePasswordButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(129, 25);
            this.ChangePasswordButton.TabIndex = 34;
            this.ChangePasswordButton.Text = "Change password";
            this.ChangePasswordButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // ZippedFolderEditor
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(601, 215);
            this.Controls.Add(this.ChangeLinkButton);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.BrowseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ZippedFolderEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zipped folder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ZippedFolderEditor_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.ZippedFolderEditor_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.ZippedFolderEditor_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomDialogs.DarkLabel PathLabel;
        private CustomDialogs.DarkTextBox PathTextBox;
        private CustomDialogs.DarkButton BrowseButton;
        private CustomDialogs.DarkButton CancelButton;
        private CustomDialogs.DarkButton SaveButton;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private CustomDialogs.DarkLabel NameLabel;
        private CustomDialogs.DarkTextBox NameTextBox;
        private CustomDialogs.DarkButton ChangeLinkButton;
        private CustomDialogs.DarkButton ChangePasswordButton;
    }
}