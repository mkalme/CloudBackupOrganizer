
namespace CloudBackupOrganizerGUI {
    partial class EditView {
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
            this.components = new System.ComponentModel.Container();
            CustomDialogs.CustomToolStripRenderer customToolStripRenderer1 = new CustomDialogs.CustomToolStripRenderer();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditView));
            this.GlobalContainer = new System.Windows.Forms.TableLayoutPanel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.SelectedItemsLabel = new CustomDialogs.DarkLabel();
            this.ItemsCountLabel = new CustomDialogs.DarkLabel();
            this.OpenFolderInBrowser = new System.Windows.Forms.Button();
            this.MenuStrip = new CustomDialogs.DarkContextMenuStrip(this.components);
            this.ZipMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyLastZippedPathMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyLastZippedPathSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.ChangePasswordMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeLinkMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeLinkSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.PropertiesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GlobalContainer.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // GlobalContainer
            // 
            this.GlobalContainer.ColumnCount = 1;
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.Controls.Add(this.BottomPanel, 0, 1);
            this.GlobalContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalContainer.Location = new System.Drawing.Point(7, 6);
            this.GlobalContainer.Margin = new System.Windows.Forms.Padding(0);
            this.GlobalContainer.Name = "GlobalContainer";
            this.GlobalContainer.RowCount = 2;
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.Size = new System.Drawing.Size(850, 490);
            this.GlobalContainer.TabIndex = 0;
            // 
            // BottomPanel
            // 
            this.BottomPanel.AutoSize = true;
            this.BottomPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BottomPanel.Controls.Add(this.SelectedItemsLabel);
            this.BottomPanel.Controls.Add(this.ItemsCountLabel);
            this.BottomPanel.Controls.Add(this.OpenFolderInBrowser);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomPanel.Location = new System.Drawing.Point(0, 468);
            this.BottomPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(850, 22);
            this.BottomPanel.TabIndex = 9;
            // 
            // SelectedItemsLabel
            // 
            this.SelectedItemsLabel.AutoSize = true;
            this.SelectedItemsLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SelectedItemsLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SelectedItemsLabel.Location = new System.Drawing.Point(613, 0);
            this.SelectedItemsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SelectedItemsLabel.Name = "SelectedItemsLabel";
            this.SelectedItemsLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.SelectedItemsLabel.Size = new System.Drawing.Size(237, 18);
            this.SelectedItemsLabel.TabIndex = 14;
            this.SelectedItemsLabel.Text = "Selected items: 50; Size 50gb (454 544 bytes)";
            this.SelectedItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ItemsCountLabel
            // 
            this.ItemsCountLabel.AutoSize = true;
            this.ItemsCountLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ItemsCountLabel.Location = new System.Drawing.Point(200, 3);
            this.ItemsCountLabel.Name = "ItemsCountLabel";
            this.ItemsCountLabel.Size = new System.Drawing.Size(190, 15);
            this.ItemsCountLabel.TabIndex = 15;
            this.ItemsCountLabel.Text = "Items: 50; Size 50gb (454 544 bytes)";
            // 
            // OpenFolderInBrowser
            // 
            this.OpenFolderInBrowser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.OpenFolderInBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFolderInBrowser.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenFolderInBrowser.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.OpenFolderInBrowser.Location = new System.Drawing.Point(0, -1);
            this.OpenFolderInBrowser.Margin = new System.Windows.Forms.Padding(0);
            this.OpenFolderInBrowser.Name = "OpenFolderInBrowser";
            this.OpenFolderInBrowser.Size = new System.Drawing.Size(180, 23);
            this.OpenFolderInBrowser.TabIndex = 8;
            this.OpenFolderInBrowser.Text = "Open current folder in browser";
            this.OpenFolderInBrowser.UseVisualStyleBackColor = true;
            this.OpenFolderInBrowser.Click += new System.EventHandler(this.OpenFolderInBrowser_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            customToolStripRenderer1.RoundedEdges = true;
            this.MenuStrip.CustomRenderer = customToolStripRenderer1;
            this.MenuStrip.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ZipMenuItem,
            this.CopyLastZippedPathMenuItem,
            this.CopyLastZippedPathSeperator,
            this.ChangePasswordMenuItem,
            this.ChangeLinkMenuItem,
            this.ChangeLinkSeperator,
            this.EditMenuItem,
            this.RenameMenuItem,
            this.RenameSeperator,
            this.PropertiesMenuItem});
            this.MenuStrip.Name = "contextMenuStrip1";
            this.MenuStrip.Size = new System.Drawing.Size(189, 176);
            this.MenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.MenuStrip_Opening);
            // 
            // ZipMenuItem
            // 
            this.ZipMenuItem.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxUpload;
            this.ZipMenuItem.Name = "ZipMenuItem";
            this.ZipMenuItem.Size = new System.Drawing.Size(188, 22);
            this.ZipMenuItem.Text = "Zip";
            this.ZipMenuItem.Click += new System.EventHandler(this.ZipMenuItem_Click);
            // 
            // CopyLastZippedPathMenuItem
            // 
            this.CopyLastZippedPathMenuItem.Name = "CopyLastZippedPathMenuItem";
            this.CopyLastZippedPathMenuItem.Size = new System.Drawing.Size(188, 22);
            this.CopyLastZippedPathMenuItem.Text = "Copy last zipped path";
            this.CopyLastZippedPathMenuItem.Click += new System.EventHandler(this.CopyLastZippedPathMenuItem_Click);
            // 
            // CopyLastZippedPathSeperator
            // 
            this.CopyLastZippedPathSeperator.Name = "CopyLastZippedPathSeperator";
            this.CopyLastZippedPathSeperator.Size = new System.Drawing.Size(185, 6);
            // 
            // ChangePasswordMenuItem
            // 
            this.ChangePasswordMenuItem.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxPasswordStrength;
            this.ChangePasswordMenuItem.Name = "ChangePasswordMenuItem";
            this.ChangePasswordMenuItem.Size = new System.Drawing.Size(188, 22);
            this.ChangePasswordMenuItem.Text = "Change password";
            this.ChangePasswordMenuItem.Click += new System.EventHandler(this.ChangePasswordMenuItem_Click);
            // 
            // ChangeLinkMenuItem
            // 
            this.ChangeLinkMenuItem.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxLink;
            this.ChangeLinkMenuItem.Name = "ChangeLinkMenuItem";
            this.ChangeLinkMenuItem.Size = new System.Drawing.Size(188, 22);
            this.ChangeLinkMenuItem.Text = "Change link";
            this.ChangeLinkMenuItem.Click += new System.EventHandler(this.ChangeLinkMenuItem_Click);
            // 
            // ChangeLinkSeperator
            // 
            this.ChangeLinkSeperator.Name = "ChangeLinkSeperator";
            this.ChangeLinkSeperator.Size = new System.Drawing.Size(185, 6);
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxEdit;
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(188, 22);
            this.EditMenuItem.Text = "Edit";
            this.EditMenuItem.Click += new System.EventHandler(this.EditMenuItem_Click);
            // 
            // RenameMenuItem
            // 
            this.RenameMenuItem.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxRename;
            this.RenameMenuItem.Name = "RenameMenuItem";
            this.RenameMenuItem.Size = new System.Drawing.Size(188, 22);
            this.RenameMenuItem.Text = "Rename";
            this.RenameMenuItem.Click += new System.EventHandler(this.RenameMenuItem_Click);
            // 
            // RenameSeperator
            // 
            this.RenameSeperator.Name = "RenameSeperator";
            this.RenameSeperator.Size = new System.Drawing.Size(185, 6);
            // 
            // PropertiesMenuItem
            // 
            this.PropertiesMenuItem.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxProperty;
            this.PropertiesMenuItem.Name = "PropertiesMenuItem";
            this.PropertiesMenuItem.Size = new System.Drawing.Size(188, 22);
            this.PropertiesMenuItem.Text = "Properties";
            this.PropertiesMenuItem.Click += new System.EventHandler(this.PropertiesMenuItem_Click);
            // 
            // EditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(864, 496);
            this.Controls.Add(this.GlobalContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditView";
            this.Padding = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit View";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditView_FormClosing);
            this.Load += new System.EventHandler(this.EditView_Load);
            this.GlobalContainer.ResumeLayout(false);
            this.GlobalContainer.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel GlobalContainer;
        private System.Windows.Forms.Button OpenFolderInBrowser;
        private CustomDialogs.DarkContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripSeparator CopyLastZippedPathSeperator;
        private System.Windows.Forms.ToolStripMenuItem ChangePasswordMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeLinkMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RenameMenuItem;
        private System.Windows.Forms.ToolStripSeparator RenameSeperator;
        private System.Windows.Forms.ToolStripMenuItem PropertiesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZipMenuItem;
        private System.Windows.Forms.ToolStripSeparator ChangeLinkSeperator;
        private System.Windows.Forms.ToolStripMenuItem CopyLastZippedPathMenuItem;
        private System.Windows.Forms.Panel BottomPanel;
        private CustomDialogs.DarkLabel ItemsCountLabel;
        private CustomDialogs.DarkLabel SelectedItemsLabel;
    }
}