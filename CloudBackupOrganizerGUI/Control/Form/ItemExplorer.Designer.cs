
namespace CloudBackupOrganizerGUI {
    partial class ItemExplorer {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            CustomDialogs.CustomToolStripRenderer customToolStripRenderer2 = new CustomDialogs.CustomToolStripRenderer();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemExplorer));
            this.MenuStrip = new CustomDialogs.DarkContextMenuStrip(this.components);
            this.NewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGroupMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGroupSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.NewZippedFoldermenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZippedFilteredFolderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewZippedItemBundleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewZippedFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.OpenInNewWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenInEditViewerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenInEditViewerSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.ZipMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExtractMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZipSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.ChangePasswordMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeLinkMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeRealNameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeRealNameSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.CopyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.MoveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.PropertiesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GlobalContainer = new System.Windows.Forms.TableLayoutPanel();
            this.BottomContainer = new System.Windows.Forms.TableLayoutPanel();
            this.MoreButton = new System.Windows.Forms.Button();
            this.CreateUsersheetButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.CloseSeperatorLabel = new CustomDialogs.DarkLabel();
            this.ChangeKeyButton = new System.Windows.Forms.Button();
            this.InformationButton = new System.Windows.Forms.Button();
            this.DeselectButton = new System.Windows.Forms.Button();
            this.InformationSeperator = new CustomDialogs.DarkLabel();
            this.MoveDownButton = new System.Windows.Forms.Button();
            this.MoveUpButton = new System.Windows.Forms.Button();
            this.UpDownSeperator = new CustomDialogs.DarkLabel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.SettingsSeperator = new CustomDialogs.DarkLabel();
            this.MoreMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExportItemsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportItemsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportItemsSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.OpenEditViewerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SwitchProfileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.GlobalContainer.SuspendLayout();
            this.BottomContainer.SuspendLayout();
            this.MoreMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            customToolStripRenderer2.RoundedEdges = true;
            this.MenuStrip.CustomRenderer = customToolStripRenderer2;
            this.MenuStrip.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMenuItem,
            this.NewSeperator,
            this.OpenInNewWindowMenuItem,
            this.OpenInEditViewerMenuItem,
            this.OpenInEditViewerSeperator,
            this.ZipMenuItem,
            this.ExtractMenuItem,
            this.ZipSeperator,
            this.ChangePasswordMenuItem,
            this.ChangeLinkMenuItem,
            this.ChangeRealNameMenuItem,
            this.ChangeRealNameSeperator,
            this.CopyMenuItem,
            this.PasteMenuItem,
            this.PasteSeperator,
            this.MoveMenuItem,
            this.EditMenuItem,
            this.RenameMenuItem,
            this.DeleteMenuItem,
            this.DeleteSeperator,
            this.PropertiesMenuItem});
            this.MenuStrip.Name = "contextMenuStrip1";
            this.MenuStrip.Size = new System.Drawing.Size(204, 370);
            this.MenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.MenuStrip_Opening);
            // 
            // NewMenuItem
            // 
            this.NewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGroupMenuItem,
            this.NewGroupSeperator,
            this.NewZippedFoldermenuItem,
            this.ZippedFilteredFolderMenuItem,
            this.NewZippedItemBundleMenuItem,
            this.NewZippedFileMenuItem});
            this.NewMenuItem.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxAdd;
            this.NewMenuItem.Name = "NewMenuItem";
            this.NewMenuItem.Size = new System.Drawing.Size(203, 22);
            this.NewMenuItem.Text = "New                                   ";
            // 
            // NewGroupMenuItem
            // 
            this.NewGroupMenuItem.Image = global::CloudBackupOrganizerGUI.Properties.Resources._64pxMenuStripGroup;
            this.NewGroupMenuItem.Name = "NewGroupMenuItem";
            this.NewGroupMenuItem.Size = new System.Drawing.Size(203, 22);
            this.NewGroupMenuItem.Text = "Group                                ";
            this.NewGroupMenuItem.Click += new System.EventHandler(this.NewGroupMenuItem_Click);
            // 
            // NewGroupSeperator
            // 
            this.NewGroupSeperator.Name = "NewGroupSeperator";
            this.NewGroupSeperator.Size = new System.Drawing.Size(200, 6);
            // 
            // NewZippedFoldermenuItem
            // 
            this.NewZippedFoldermenuItem.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxFolderClosed;
            this.NewZippedFoldermenuItem.Name = "NewZippedFoldermenuItem";
            this.NewZippedFoldermenuItem.Size = new System.Drawing.Size(203, 22);
            this.NewZippedFoldermenuItem.Text = "Zipped folder";
            this.NewZippedFoldermenuItem.Click += new System.EventHandler(this.NewZippedFoldermenuItem_Click);
            // 
            // ZippedFilteredFolderMenuItem
            // 
            this.ZippedFilteredFolderMenuItem.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxFilteredFolder;
            this.ZippedFilteredFolderMenuItem.Name = "ZippedFilteredFolderMenuItem";
            this.ZippedFilteredFolderMenuItem.Size = new System.Drawing.Size(203, 22);
            this.ZippedFilteredFolderMenuItem.Text = "Zipped filterd folder";
            this.ZippedFilteredFolderMenuItem.Click += new System.EventHandler(this.ZippedFilteredFolderMenuItem_Click);
            // 
            // NewZippedItemBundleMenuItem
            // 
            this.NewZippedItemBundleMenuItem.Image = global::CloudBackupOrganizerGUI.Properties.Resources._64pxItemBundle;
            this.NewZippedItemBundleMenuItem.Name = "NewZippedItemBundleMenuItem";
            this.NewZippedItemBundleMenuItem.Size = new System.Drawing.Size(203, 22);
            this.NewZippedItemBundleMenuItem.Text = "Zipped item bundle";
            this.NewZippedItemBundleMenuItem.Click += new System.EventHandler(this.NewZippedItemBundleMenuItem_Click);
            // 
            // NewZippedFileMenuItem
            // 
            this.NewZippedFileMenuItem.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxTextFile;
            this.NewZippedFileMenuItem.Name = "NewZippedFileMenuItem";
            this.NewZippedFileMenuItem.Size = new System.Drawing.Size(203, 22);
            this.NewZippedFileMenuItem.Text = "Zipped file";
            this.NewZippedFileMenuItem.Click += new System.EventHandler(this.NewZippedFileMenuItem_Click);
            // 
            // NewSeperator
            // 
            this.NewSeperator.Name = "NewSeperator";
            this.NewSeperator.Size = new System.Drawing.Size(200, 6);
            // 
            // OpenInNewWindowMenuItem
            // 
            this.OpenInNewWindowMenuItem.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxApplication;
            this.OpenInNewWindowMenuItem.Name = "OpenInNewWindowMenuItem";
            this.OpenInNewWindowMenuItem.Size = new System.Drawing.Size(203, 22);
            this.OpenInNewWindowMenuItem.Text = "Open in new window";
            this.OpenInNewWindowMenuItem.Click += new System.EventHandler(this.OpenInNewWindowMenuItem_Click);
            // 
            // OpenInEditViewerMenuItem
            // 
            this.OpenInEditViewerMenuItem.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxBulletList;
            this.OpenInEditViewerMenuItem.Name = "OpenInEditViewerMenuItem";
            this.OpenInEditViewerMenuItem.Size = new System.Drawing.Size(203, 22);
            this.OpenInEditViewerMenuItem.Text = "Open in edit viewer";
            this.OpenInEditViewerMenuItem.Click += new System.EventHandler(this.OpenInEditViewerMenuItem_Click);
            // 
            // OpenInEditViewerSeperator
            // 
            this.OpenInEditViewerSeperator.Name = "OpenInEditViewerSeperator";
            this.OpenInEditViewerSeperator.Size = new System.Drawing.Size(200, 6);
            // 
            // ZipMenuItem
            // 
            this.ZipMenuItem.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxUpload;
            this.ZipMenuItem.Name = "ZipMenuItem";
            this.ZipMenuItem.Size = new System.Drawing.Size(203, 22);
            this.ZipMenuItem.Text = "Zip";
            this.ZipMenuItem.Click += new System.EventHandler(this.ZipMenuItem_Click);
            // 
            // ExtractMenuItem
            // 
            this.ExtractMenuItem.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxDownload;
            this.ExtractMenuItem.Name = "ExtractMenuItem";
            this.ExtractMenuItem.Size = new System.Drawing.Size(203, 22);
            this.ExtractMenuItem.Text = "Extract";
            this.ExtractMenuItem.Click += new System.EventHandler(this.ExtractMenuItem_Click);
            // 
            // ZipSeperator
            // 
            this.ZipSeperator.Name = "ZipSeperator";
            this.ZipSeperator.Size = new System.Drawing.Size(200, 6);
            // 
            // ChangePasswordMenuItem
            // 
            this.ChangePasswordMenuItem.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxPasswordStrength;
            this.ChangePasswordMenuItem.Name = "ChangePasswordMenuItem";
            this.ChangePasswordMenuItem.Size = new System.Drawing.Size(203, 22);
            this.ChangePasswordMenuItem.Text = "Change password";
            this.ChangePasswordMenuItem.Click += new System.EventHandler(this.ChangePasswordMenuItem_Click);
            // 
            // ChangeLinkMenuItem
            // 
            this.ChangeLinkMenuItem.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxLink;
            this.ChangeLinkMenuItem.Name = "ChangeLinkMenuItem";
            this.ChangeLinkMenuItem.Size = new System.Drawing.Size(203, 22);
            this.ChangeLinkMenuItem.Text = "Change link";
            this.ChangeLinkMenuItem.Click += new System.EventHandler(this.ChangeLinkMenuItem_Click);
            // 
            // ChangeRealNameMenuItem
            // 
            this.ChangeRealNameMenuItem.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxWebFolder;
            this.ChangeRealNameMenuItem.Name = "ChangeRealNameMenuItem";
            this.ChangeRealNameMenuItem.Size = new System.Drawing.Size(203, 22);
            this.ChangeRealNameMenuItem.Text = "Change real name";
            this.ChangeRealNameMenuItem.Click += new System.EventHandler(this.ChangeRealNameMenuItem_Click);
            // 
            // ChangeRealNameSeperator
            // 
            this.ChangeRealNameSeperator.Name = "ChangeRealNameSeperator";
            this.ChangeRealNameSeperator.Size = new System.Drawing.Size(200, 6);
            // 
            // CopyMenuItem
            // 
            this.CopyMenuItem.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxCopyItem;
            this.CopyMenuItem.Name = "CopyMenuItem";
            this.CopyMenuItem.Size = new System.Drawing.Size(203, 22);
            this.CopyMenuItem.Text = "Copy";
            this.CopyMenuItem.Click += new System.EventHandler(this.CopyMenuItem_Click);
            // 
            // PasteMenuItem
            // 
            this.PasteMenuItem.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxPaste;
            this.PasteMenuItem.Name = "PasteMenuItem";
            this.PasteMenuItem.Size = new System.Drawing.Size(203, 22);
            this.PasteMenuItem.Text = "Paste";
            this.PasteMenuItem.Click += new System.EventHandler(this.PasteMenuItem_Click);
            // 
            // PasteSeperator
            // 
            this.PasteSeperator.Name = "PasteSeperator";
            this.PasteSeperator.Size = new System.Drawing.Size(200, 6);
            // 
            // MoveMenuItem
            // 
            this.MoveMenuItem.Image = global::CloudBackupOrganizerGUI.Properties.Resources._64pxMove;
            this.MoveMenuItem.Name = "MoveMenuItem";
            this.MoveMenuItem.Size = new System.Drawing.Size(203, 22);
            this.MoveMenuItem.Text = "Move";
            this.MoveMenuItem.Click += new System.EventHandler(this.MoveMenuItem_Click);
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxEdit;
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(203, 22);
            this.EditMenuItem.Text = "Edit";
            this.EditMenuItem.Click += new System.EventHandler(this.EditMenuItem_Click);
            // 
            // RenameMenuItem
            // 
            this.RenameMenuItem.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxRename;
            this.RenameMenuItem.Name = "RenameMenuItem";
            this.RenameMenuItem.Size = new System.Drawing.Size(203, 22);
            this.RenameMenuItem.Text = "Rename";
            this.RenameMenuItem.Click += new System.EventHandler(this.RenameMenuItem_Click);
            // 
            // DeleteMenuItem
            // 
            this.DeleteMenuItem.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxTrash;
            this.DeleteMenuItem.Name = "DeleteMenuItem";
            this.DeleteMenuItem.Size = new System.Drawing.Size(203, 22);
            this.DeleteMenuItem.Text = "Delete";
            this.DeleteMenuItem.Click += new System.EventHandler(this.DeleteMenuItem_Click);
            // 
            // DeleteSeperator
            // 
            this.DeleteSeperator.Name = "DeleteSeperator";
            this.DeleteSeperator.Size = new System.Drawing.Size(200, 6);
            // 
            // PropertiesMenuItem
            // 
            this.PropertiesMenuItem.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxProperty;
            this.PropertiesMenuItem.Name = "PropertiesMenuItem";
            this.PropertiesMenuItem.Size = new System.Drawing.Size(203, 22);
            this.PropertiesMenuItem.Text = "Properties";
            this.PropertiesMenuItem.Click += new System.EventHandler(this.PropertiesMenuItem_Click);
            // 
            // GlobalContainer
            // 
            this.GlobalContainer.ColumnCount = 1;
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.Controls.Add(this.BottomContainer, 0, 1);
            this.GlobalContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalContainer.Location = new System.Drawing.Point(0, 0);
            this.GlobalContainer.Margin = new System.Windows.Forms.Padding(0);
            this.GlobalContainer.Name = "GlobalContainer";
            this.GlobalContainer.Padding = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.GlobalContainer.RowCount = 2;
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.Size = new System.Drawing.Size(864, 496);
            this.GlobalContainer.TabIndex = 2;
            // 
            // BottomContainer
            // 
            this.BottomContainer.AutoSize = true;
            this.BottomContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BottomContainer.ColumnCount = 13;
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.Controls.Add(this.MoreButton, 0, 0);
            this.BottomContainer.Controls.Add(this.CreateUsersheetButton, 0, 0);
            this.BottomContainer.Controls.Add(this.CloseButton, 12, 0);
            this.BottomContainer.Controls.Add(this.CloseSeperatorLabel, 10, 0);
            this.BottomContainer.Controls.Add(this.ChangeKeyButton, 9, 0);
            this.BottomContainer.Controls.Add(this.InformationButton, 8, 0);
            this.BottomContainer.Controls.Add(this.DeselectButton, 11, 0);
            this.BottomContainer.Controls.Add(this.InformationSeperator, 7, 0);
            this.BottomContainer.Controls.Add(this.MoveDownButton, 6, 0);
            this.BottomContainer.Controls.Add(this.MoveUpButton, 5, 0);
            this.BottomContainer.Controls.Add(this.UpDownSeperator, 4, 0);
            this.BottomContainer.Controls.Add(this.SettingsButton, 3, 0);
            this.BottomContainer.Controls.Add(this.SettingsSeperator, 2, 0);
            this.BottomContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomContainer.Location = new System.Drawing.Point(7, 471);
            this.BottomContainer.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.BottomContainer.Name = "BottomContainer";
            this.BottomContainer.RowCount = 1;
            this.BottomContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BottomContainer.Size = new System.Drawing.Size(850, 23);
            this.BottomContainer.TabIndex = 4;
            // 
            // MoreButton
            // 
            this.MoreButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.MoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoreButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoreButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MoreButton.Location = new System.Drawing.Point(339, 0);
            this.MoreButton.Margin = new System.Windows.Forms.Padding(0);
            this.MoreButton.Name = "MoreButton";
            this.MoreButton.Size = new System.Drawing.Size(50, 23);
            this.MoreButton.TabIndex = 22;
            this.MoreButton.Text = "More";
            this.MoreButton.UseVisualStyleBackColor = true;
            this.MoreButton.Click += new System.EventHandler(this.MoreButton_Click);
            // 
            // CreateUsersheetButton
            // 
            this.CreateUsersheetButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CreateUsersheetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateUsersheetButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateUsersheetButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CreateUsersheetButton.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxExportToExcel;
            this.CreateUsersheetButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreateUsersheetButton.Location = new System.Drawing.Point(0, 0);
            this.CreateUsersheetButton.Margin = new System.Windows.Forms.Padding(0);
            this.CreateUsersheetButton.Name = "CreateUsersheetButton";
            this.CreateUsersheetButton.Size = new System.Drawing.Size(125, 23);
            this.CreateUsersheetButton.TabIndex = 20;
            this.CreateUsersheetButton.Text = "Create user sheet";
            this.CreateUsersheetButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateUsersheetButton.UseVisualStyleBackColor = true;
            this.CreateUsersheetButton.Click += new System.EventHandler(this.CreateUsersheetButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CloseButton.Location = new System.Drawing.Point(785, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(65, 23);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CloseSeperatorLabel
            // 
            this.CloseSeperatorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseSeperatorLabel.AutoSize = true;
            this.CloseSeperatorLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.CloseSeperatorLabel.Location = new System.Drawing.Point(738, 3);
            this.CloseSeperatorLabel.Margin = new System.Windows.Forms.Padding(9, 0, 7, 1);
            this.CloseSeperatorLabel.Name = "CloseSeperatorLabel";
            this.CloseSeperatorLabel.Size = new System.Drawing.Size(10, 15);
            this.CloseSeperatorLabel.TabIndex = 8;
            this.CloseSeperatorLabel.Text = "|";
            // 
            // ChangeKeyButton
            // 
            this.ChangeKeyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ChangeKeyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeKeyButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeKeyButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ChangeKeyButton.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxKey;
            this.ChangeKeyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChangeKeyButton.Location = new System.Drawing.Point(631, 0);
            this.ChangeKeyButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChangeKeyButton.Name = "ChangeKeyButton";
            this.ChangeKeyButton.Size = new System.Drawing.Size(98, 23);
            this.ChangeKeyButton.TabIndex = 9;
            this.ChangeKeyButton.Text = "Change key";
            this.ChangeKeyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangeKeyButton.UseVisualStyleBackColor = true;
            this.ChangeKeyButton.Click += new System.EventHandler(this.ChangeKeyButton_Click);
            // 
            // InformationButton
            // 
            this.InformationButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.InformationButton.BackgroundImage = global::CloudBackupOrganizerGUI.Properties.Resources._16pxInformation;
            this.InformationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InformationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.InformationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InformationButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InformationButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.InformationButton.Location = new System.Drawing.Point(601, 0);
            this.InformationButton.Margin = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.InformationButton.Name = "InformationButton";
            this.InformationButton.Size = new System.Drawing.Size(23, 23);
            this.InformationButton.TabIndex = 10;
            this.InformationButton.UseVisualStyleBackColor = false;
            this.InformationButton.Click += new System.EventHandler(this.InformationButton_Click);
            // 
            // DeselectButton
            // 
            this.DeselectButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DeselectButton.BackgroundImage = global::CloudBackupOrganizerGUI.Properties.Resources._16pxDeselect;
            this.DeselectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeselectButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DeselectButton.FlatAppearance.BorderSize = 0;
            this.DeselectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeselectButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeselectButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DeselectButton.Location = new System.Drawing.Point(755, 0);
            this.DeselectButton.Margin = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.DeselectButton.Name = "DeselectButton";
            this.DeselectButton.Size = new System.Drawing.Size(23, 23);
            this.DeselectButton.TabIndex = 11;
            this.DeselectButton.UseVisualStyleBackColor = false;
            this.DeselectButton.Click += new System.EventHandler(this.DeselectButton_Click);
            // 
            // InformationSeperator
            // 
            this.InformationSeperator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InformationSeperator.AutoSize = true;
            this.InformationSeperator.ForeColor = System.Drawing.Color.DarkGray;
            this.InformationSeperator.Location = new System.Drawing.Point(583, 3);
            this.InformationSeperator.Margin = new System.Windows.Forms.Padding(9, 0, 8, 1);
            this.InformationSeperator.Name = "InformationSeperator";
            this.InformationSeperator.Size = new System.Drawing.Size(10, 15);
            this.InformationSeperator.TabIndex = 12;
            this.InformationSeperator.Text = "|";
            // 
            // MoveDownButton
            // 
            this.MoveDownButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MoveDownButton.BackgroundImage = global::CloudBackupOrganizerGUI.Properties.Resources._16pxMoveDown;
            this.MoveDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MoveDownButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.MoveDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveDownButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoveDownButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MoveDownButton.Location = new System.Drawing.Point(551, 0);
            this.MoveDownButton.Margin = new System.Windows.Forms.Padding(0);
            this.MoveDownButton.Name = "MoveDownButton";
            this.MoveDownButton.Size = new System.Drawing.Size(23, 23);
            this.MoveDownButton.TabIndex = 13;
            this.MoveDownButton.UseVisualStyleBackColor = false;
            this.MoveDownButton.Click += new System.EventHandler(this.MoveDownButton_Click);
            // 
            // MoveUpButton
            // 
            this.MoveUpButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MoveUpButton.BackgroundImage = global::CloudBackupOrganizerGUI.Properties.Resources._16pxMoveUp;
            this.MoveUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MoveUpButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.MoveUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveUpButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoveUpButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MoveUpButton.Location = new System.Drawing.Point(521, 0);
            this.MoveUpButton.Margin = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.MoveUpButton.Name = "MoveUpButton";
            this.MoveUpButton.Size = new System.Drawing.Size(23, 23);
            this.MoveUpButton.TabIndex = 14;
            this.MoveUpButton.UseVisualStyleBackColor = false;
            this.MoveUpButton.Click += new System.EventHandler(this.MoveUpButton_Click);
            // 
            // UpDownSeperator
            // 
            this.UpDownSeperator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpDownSeperator.AutoSize = true;
            this.UpDownSeperator.ForeColor = System.Drawing.Color.DarkGray;
            this.UpDownSeperator.Location = new System.Drawing.Point(503, 3);
            this.UpDownSeperator.Margin = new System.Windows.Forms.Padding(9, 0, 8, 1);
            this.UpDownSeperator.Name = "UpDownSeperator";
            this.UpDownSeperator.Size = new System.Drawing.Size(10, 15);
            this.UpDownSeperator.TabIndex = 15;
            this.UpDownSeperator.Text = "|";
            // 
            // SettingsButton
            // 
            this.SettingsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SettingsButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SettingsButton.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxSettings;
            this.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SettingsButton.Location = new System.Drawing.Point(416, 0);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(78, 23);
            this.SettingsButton.TabIndex = 16;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // SettingsSeperator
            // 
            this.SettingsSeperator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SettingsSeperator.AutoSize = true;
            this.SettingsSeperator.ForeColor = System.Drawing.Color.DarkGray;
            this.SettingsSeperator.Location = new System.Drawing.Point(398, 3);
            this.SettingsSeperator.Margin = new System.Windows.Forms.Padding(9, 0, 8, 1);
            this.SettingsSeperator.Name = "SettingsSeperator";
            this.SettingsSeperator.Size = new System.Drawing.Size(10, 15);
            this.SettingsSeperator.TabIndex = 21;
            this.SettingsSeperator.Text = "|";
            // 
            // MoreMenuStrip
            // 
            this.MoreMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.MoreMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportItemsMenuItem,
            this.ImportItemsMenuItem,
            this.ImportItemsSeperator,
            this.SwitchProfileMenuItem,
            this.OpenEditViewerMenuItem});
            this.MoreMenuStrip.Name = "MoreMenuStrip";
            this.MoreMenuStrip.Size = new System.Drawing.Size(181, 120);
            // 
            // ExportItemsMenuItem
            // 
            this.ExportItemsMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ExportItemsMenuItem.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxExport;
            this.ExportItemsMenuItem.Name = "ExportItemsMenuItem";
            this.ExportItemsMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExportItemsMenuItem.Text = "Export items             ";
            this.ExportItemsMenuItem.Click += new System.EventHandler(this.ExportItemsMenuItem_Click);
            // 
            // ImportItemsMenuItem
            // 
            this.ImportItemsMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ImportItemsMenuItem.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxImport;
            this.ImportItemsMenuItem.Name = "ImportItemsMenuItem";
            this.ImportItemsMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ImportItemsMenuItem.Text = "Import items";
            this.ImportItemsMenuItem.Click += new System.EventHandler(this.ImportItemsMenuItem_Click);
            // 
            // ImportItemsSeperator
            // 
            this.ImportItemsSeperator.Name = "ImportItemsSeperator";
            this.ImportItemsSeperator.Size = new System.Drawing.Size(177, 6);
            // 
            // OpenEditViewerMenuItem
            // 
            this.OpenEditViewerMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.OpenEditViewerMenuItem.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxBulletList;
            this.OpenEditViewerMenuItem.Name = "OpenEditViewerMenuItem";
            this.OpenEditViewerMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenEditViewerMenuItem.Text = "Open edit viewer";
            this.OpenEditViewerMenuItem.Click += new System.EventHandler(this.OpenEditViewerMenuItem_Click);
            // 
            // SwitchProfileMenuItem
            // 
            this.SwitchProfileMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SwitchProfileMenuItem.Image = global::CloudBackupOrganizerGUI.Properties.Resources._16pxUserProfile;
            this.SwitchProfileMenuItem.Name = "SwitchProfileMenuItem";
            this.SwitchProfileMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SwitchProfileMenuItem.Text = "Switch profile";
            this.SwitchProfileMenuItem.Click += new System.EventHandler(this.SwitchProfileMenuItem_Click);
            // 
            // ItemExplorer
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(864, 496);
            this.Controls.Add(this.GlobalContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cloud Backup Organizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ItemExplorer_FormClosing);
            this.Load += new System.EventHandler(this.ItemExplorer_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.ItemExplorer_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.ItemExplorer_DragEnter);
            this.MenuStrip.ResumeLayout(false);
            this.GlobalContainer.ResumeLayout(false);
            this.GlobalContainer.PerformLayout();
            this.BottomContainer.ResumeLayout(false);
            this.BottomContainer.PerformLayout();
            this.MoreMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomDialogs.DarkContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ExtractMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewGroupMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewZippedItemBundleMenuItem;
        private System.Windows.Forms.ToolStripSeparator NewSeperator;
        private System.Windows.Forms.ToolStripMenuItem ZipMenuItem;
        private System.Windows.Forms.ToolStripSeparator ZipSeperator;
        private System.Windows.Forms.ToolStripMenuItem ChangePasswordMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeLinkMenuItem;
        private System.Windows.Forms.ToolStripSeparator ChangeRealNameSeperator;
        private System.Windows.Forms.ToolStripMenuItem CopyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteMenuItem;
        private System.Windows.Forms.ToolStripSeparator PasteSeperator;
        private System.Windows.Forms.ToolStripMenuItem MoveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteMenuItem;
        private System.Windows.Forms.ToolStripSeparator DeleteSeperator;
        private System.Windows.Forms.ToolStripMenuItem PropertiesMenuItem;
        private System.Windows.Forms.TableLayoutPanel GlobalContainer;
        private System.Windows.Forms.TableLayoutPanel BottomContainer;
        private System.Windows.Forms.Button CloseButton;
        private CustomDialogs.DarkLabel CloseSeperatorLabel;
        private System.Windows.Forms.Button ChangeKeyButton;
        private System.Windows.Forms.Button InformationButton;
        private System.Windows.Forms.Button DeselectButton;
        private CustomDialogs.DarkLabel InformationSeperator;
        private System.Windows.Forms.Button MoveDownButton;
        private System.Windows.Forms.Button MoveUpButton;
        private CustomDialogs.DarkLabel UpDownSeperator;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button CreateUsersheetButton;
        private System.Windows.Forms.ToolStripSeparator NewGroupSeperator;
        private System.Windows.Forms.ToolStripMenuItem NewZippedFoldermenuItem;
        private System.Windows.Forms.ToolStripMenuItem RenameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeRealNameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZippedFilteredFolderMenuItem;
        private CustomDialogs.DarkLabel SettingsSeperator;
        private System.Windows.Forms.Button MoreButton;
        private System.Windows.Forms.ContextMenuStrip MoreMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ExportItemsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportItemsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewZippedFileMenuItem;
        private System.Windows.Forms.ToolStripSeparator ImportItemsSeperator;
        private System.Windows.Forms.ToolStripMenuItem OpenEditViewerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenInNewWindowMenuItem;
        private System.Windows.Forms.ToolStripSeparator OpenInEditViewerSeperator;
        private System.Windows.Forms.ToolStripMenuItem OpenInEditViewerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SwitchProfileMenuItem;
    }
}

