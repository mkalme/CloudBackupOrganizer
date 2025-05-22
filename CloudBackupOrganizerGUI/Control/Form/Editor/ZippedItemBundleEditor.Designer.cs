
namespace CloudBackupOrganizerGUI {
    partial class ZippedItemBundleEditor {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZippedItemBundleEditor));
            this.ExpandFilesButton = new System.Windows.Forms.Button();
            this.ExpandFoldersButton = new System.Windows.Forms.Button();
            this.RemoveFoldersLink = new System.Windows.Forms.LinkLabel();
            this.RemoveFilesLink = new System.Windows.Forms.LinkLabel();
            this.AddFileButton = new CustomDialogs.DarkButton();
            this.AddFolderButton = new CustomDialogs.DarkButton();
            this.FileGridView = new CustomDialogs.DarkDataGridView();
            this.FileCol = new CustomDialogs.TextAndImageColumn();
            this.FolderGridView = new CustomDialogs.DarkDataGridView();
            this.FolderCol = new CustomDialogs.TextAndImageColumn();
            this.SaveButton = new CustomDialogs.DarkButton();
            this.NameTextBox = new CustomDialogs.DarkTextBox();
            this.NameLabel = new CustomDialogs.DarkLabel();
            this.CancelButton = new CustomDialogs.DarkButton();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ChangePasswordButton = new CustomDialogs.DarkButton();
            this.ChangeLinkButton = new CustomDialogs.DarkButton();
            ((System.ComponentModel.ISupportInitialize)(this.FileGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FolderGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ExpandFilesButton
            // 
            this.ExpandFilesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ExpandFilesButton.FlatAppearance.BorderSize = 0;
            this.ExpandFilesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpandFilesButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExpandFilesButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ExpandFilesButton.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxZoom;
            this.ExpandFilesButton.Location = new System.Drawing.Point(397, 168);
            this.ExpandFilesButton.Margin = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.ExpandFilesButton.Name = "ExpandFilesButton";
            this.ExpandFilesButton.Size = new System.Drawing.Size(25, 25);
            this.ExpandFilesButton.TabIndex = 21;
            this.ExpandFilesButton.UseVisualStyleBackColor = false;
            this.ExpandFilesButton.Click += new System.EventHandler(this.ExpandFilesButton_Click);
            // 
            // ExpandFoldersButton
            // 
            this.ExpandFoldersButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ExpandFoldersButton.FlatAppearance.BorderSize = 0;
            this.ExpandFoldersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpandFoldersButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExpandFoldersButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ExpandFoldersButton.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxZoom;
            this.ExpandFoldersButton.Location = new System.Drawing.Point(104, 168);
            this.ExpandFoldersButton.Margin = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.ExpandFoldersButton.Name = "ExpandFoldersButton";
            this.ExpandFoldersButton.Size = new System.Drawing.Size(25, 25);
            this.ExpandFoldersButton.TabIndex = 20;
            this.ExpandFoldersButton.UseVisualStyleBackColor = false;
            this.ExpandFoldersButton.Click += new System.EventHandler(this.ExpandFoldersButton_Click);
            // 
            // RemoveFoldersLink
            // 
            this.RemoveFoldersLink.ActiveLinkColor = System.Drawing.Color.Gray;
            this.RemoveFoldersLink.AutoSize = true;
            this.RemoveFoldersLink.DisabledLinkColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveFoldersLink.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveFoldersLink.LinkColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveFoldersLink.Location = new System.Drawing.Point(243, 165);
            this.RemoveFoldersLink.Name = "RemoveFoldersLink";
            this.RemoveFoldersLink.Size = new System.Drawing.Size(50, 15);
            this.RemoveFoldersLink.TabIndex = 19;
            this.RemoveFoldersLink.TabStop = true;
            this.RemoveFoldersLink.Text = "Remove";
            this.RemoveFoldersLink.VisitedLinkColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveFoldersLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RemoveFoldersLink_LinkClicked);
            // 
            // RemoveFilesLink
            // 
            this.RemoveFilesLink.ActiveLinkColor = System.Drawing.Color.Gray;
            this.RemoveFilesLink.AutoSize = true;
            this.RemoveFilesLink.DisabledLinkColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveFilesLink.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveFilesLink.LinkColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveFilesLink.Location = new System.Drawing.Point(536, 165);
            this.RemoveFilesLink.Name = "RemoveFilesLink";
            this.RemoveFilesLink.Size = new System.Drawing.Size(50, 15);
            this.RemoveFilesLink.TabIndex = 18;
            this.RemoveFilesLink.TabStop = true;
            this.RemoveFilesLink.Text = "Remove";
            this.RemoveFilesLink.VisitedLinkColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveFilesLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RemoveFilesLink_LinkClicked);
            // 
            // AddFileButton
            // 
            this.AddFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.AddFileButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.AddFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFileButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddFileButton.Location = new System.Drawing.Point(306, 167);
            this.AddFileButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(87, 25);
            this.AddFileButton.TabIndex = 17;
            this.AddFileButton.Text = "Add file";
            this.AddFileButton.UseVisualStyleBackColor = true;
            this.AddFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // AddFolderButton
            // 
            this.AddFolderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.AddFolderButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.AddFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFolderButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddFolderButton.Location = new System.Drawing.Point(13, 167);
            this.AddFolderButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddFolderButton.Name = "AddFolderButton";
            this.AddFolderButton.Size = new System.Drawing.Size(87, 25);
            this.AddFolderButton.TabIndex = 16;
            this.AddFolderButton.Text = "Add folder";
            this.AddFolderButton.UseVisualStyleBackColor = true;
            this.AddFolderButton.Click += new System.EventHandler(this.AddFolderButton_Click);
            // 
            // FileGridView
            // 
            this.FileGridView.AllowUserToAddRows = false;
            this.FileGridView.AllowUserToDeleteRows = false;
            this.FileGridView.AllowUserToOrderColumns = true;
            this.FileGridView.AllowUserToResizeRows = false;
            this.FileGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FileGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileGridView.CellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FileGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.FileGridView.CellForeColor = System.Drawing.SystemColors.HighlightText;
            this.FileGridView.CellGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.FileGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FileGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FileGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FileGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FileGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.FileGridView.EnableHeadersVisualStyles = false;
            this.FileGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.FileGridView.Location = new System.Drawing.Point(305, 12);
            this.FileGridView.Name = "FileGridView";
            this.FileGridView.ReadOnly = true;
            this.FileGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FileGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.FileGridView.RowTemplate.Height = 25;
            this.FileGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FileGridView.Size = new System.Drawing.Size(284, 150);
            this.FileGridView.TabIndex = 15;
            // 
            // FileCol
            // 
            this.FileCol.AlignmentToRight = false;
            this.FileCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FileCol.HeaderText = "Files";
            this.FileCol.Image = null;
            this.FileCol.Name = "FileCol";
            this.FileCol.ReadOnly = true;
            // 
            // FolderGridView
            // 
            this.FolderGridView.AllowUserToAddRows = false;
            this.FolderGridView.AllowUserToDeleteRows = false;
            this.FolderGridView.AllowUserToOrderColumns = true;
            this.FolderGridView.AllowUserToResizeRows = false;
            this.FolderGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FolderGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FolderGridView.CellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FolderGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.FolderGridView.CellForeColor = System.Drawing.SystemColors.HighlightText;
            this.FolderGridView.CellGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.FolderGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FolderGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.FolderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FolderGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FolderCol});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FolderGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.FolderGridView.EnableHeadersVisualStyles = false;
            this.FolderGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.FolderGridView.Location = new System.Drawing.Point(12, 12);
            this.FolderGridView.Name = "FolderGridView";
            this.FolderGridView.ReadOnly = true;
            this.FolderGridView.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FolderGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.FolderGridView.RowTemplate.Height = 25;
            this.FolderGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FolderGridView.Size = new System.Drawing.Size(284, 150);
            this.FolderGridView.TabIndex = 14;
            // 
            // FolderCol
            // 
            this.FolderCol.AlignmentToRight = false;
            this.FolderCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FolderCol.HeaderText = "Folders";
            this.FolderCol.Image = null;
            this.FolderCol.Name = "FolderCol";
            this.FolderCol.ReadOnly = true;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.SaveButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SaveButton.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxSave;
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveButton.Location = new System.Drawing.Point(12, 297);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.SaveButton.Size = new System.Drawing.Size(75, 25);
            this.SaveButton.TabIndex = 22;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameTextBox.Location = new System.Drawing.Point(12, 228);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.ReadOnly = false;
            this.NameTextBox.Size = new System.Drawing.Size(284, 25);
            this.NameTextBox.TabIndex = 23;
            this.NameTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameTextBox.XOffset = 0;
            this.NameTextBox.YOffset = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameLabel.Location = new System.Drawing.Point(9, 209);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 15);
            this.NameLabel.TabIndex = 24;
            this.NameLabel.Text = "Name";
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CancelButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CancelButton.Location = new System.Drawing.Point(98, 297);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(0);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 25);
            this.CancelButton.TabIndex = 27;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Multiselect = true;
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ChangePasswordButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.ChangePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePasswordButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ChangePasswordButton.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxKey;
            this.ChangePasswordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChangePasswordButton.Location = new System.Drawing.Point(460, 228);
            this.ChangePasswordButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(129, 25);
            this.ChangePasswordButton.TabIndex = 28;
            this.ChangePasswordButton.Text = "Change password";
            this.ChangePasswordButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // ChangeLinkButton
            // 
            this.ChangeLinkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ChangeLinkButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.ChangeLinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeLinkButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ChangeLinkButton.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxLink;
            this.ChangeLinkButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChangeLinkButton.Location = new System.Drawing.Point(349, 228);
            this.ChangeLinkButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChangeLinkButton.Name = "ChangeLinkButton";
            this.ChangeLinkButton.Size = new System.Drawing.Size(102, 25);
            this.ChangeLinkButton.TabIndex = 29;
            this.ChangeLinkButton.Text = "Change link";
            this.ChangeLinkButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangeLinkButton.UseVisualStyleBackColor = true;
            this.ChangeLinkButton.Click += new System.EventHandler(this.ChangeLinkButton_Click);
            // 
            // ZippedItemBundleEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(601, 336);
            this.Controls.Add(this.ChangeLinkButton);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ExpandFilesButton);
            this.Controls.Add(this.ExpandFoldersButton);
            this.Controls.Add(this.RemoveFoldersLink);
            this.Controls.Add(this.RemoveFilesLink);
            this.Controls.Add(this.AddFileButton);
            this.Controls.Add(this.AddFolderButton);
            this.Controls.Add(this.FileGridView);
            this.Controls.Add(this.FolderGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ZippedItemBundleEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zipped item bundle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ZippedItemBundleEditor_FormClosing);
            this.Load += new System.EventHandler(this.ZippedItemEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FileGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FolderGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExpandFilesButton;
        private System.Windows.Forms.Button ExpandFoldersButton;
        private System.Windows.Forms.LinkLabel RemoveFoldersLink;
        private System.Windows.Forms.LinkLabel RemoveFilesLink;
        private CustomDialogs.DarkButton AddFileButton;
        private CustomDialogs.DarkButton AddFolderButton;
        private CustomDialogs.DarkDataGridView FileGridView;
        private CustomDialogs.TextAndImageColumn FileCol;
        private CustomDialogs.DarkDataGridView FolderGridView;
        private CustomDialogs.TextAndImageColumn FolderCol;
        private CustomDialogs.DarkButton SaveButton;
        private CustomDialogs.DarkTextBox NameTextBox;
        private CustomDialogs.DarkLabel NameLabel;
        private CustomDialogs.DarkButton CancelButton;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private CustomDialogs.DarkButton ChangePasswordButton;
        private CustomDialogs.DarkButton ChangeLinkButton;
    }
}