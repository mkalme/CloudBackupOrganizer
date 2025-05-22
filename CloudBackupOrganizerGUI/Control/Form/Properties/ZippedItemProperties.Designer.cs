
namespace CloudBackupOrganizerGUI {
    partial class ZippedItemProperties {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZippedItemProperties));
            this.CloseButton = new CustomDialogs.DarkButton();
            this.GlobalContainer = new System.Windows.Forms.Panel();
            this.InformationContainer = new System.Windows.Forms.TableLayoutPanel();
            this.IdContainer = new System.Windows.Forms.TableLayoutPanel();
            this.SeeFullPanel = new System.Windows.Forms.Panel();
            this.AcquireExistingID = new System.Windows.Forms.LinkLabel();
            this.CopyIdLabel = new System.Windows.Forms.LinkLabel();
            this.SeeFullLinkLabel = new System.Windows.Forms.LinkLabel();
            this.PathInDriveTextBox = new System.Windows.Forms.TextBox();
            this.PathInDriveLabel = new CustomDialogs.DarkLabel();
            this.IdLabel = new CustomDialogs.DarkLabel();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.TypeSeperator = new System.Windows.Forms.Panel();
            this.HeaderPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.NameTextBox = new CustomDialogs.DarkTextBox();
            this.HeaderSeperator = new System.Windows.Forms.Panel();
            this.TypeContainer = new System.Windows.Forms.TableLayoutPanel();
            this.LastZippedLabel = new CustomDialogs.DarkLabel();
            this.LastUpdatedTextBox = new System.Windows.Forms.TextBox();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.TypeLabel = new CustomDialogs.DarkLabel();
            this.LocationLabel = new CustomDialogs.DarkLabel();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.SizeLabel = new CustomDialogs.DarkLabel();
            this.SizeTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.darkLabel1 = new CustomDialogs.DarkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GlobalContainer.SuspendLayout();
            this.InformationContainer.SuspendLayout();
            this.IdContainer.SuspendLayout();
            this.SeeFullPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.TypeContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CloseButton.Location = new System.Drawing.Point(267, 382);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 24);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // GlobalContainer
            // 
            this.GlobalContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.GlobalContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GlobalContainer.Controls.Add(this.InformationContainer);
            this.GlobalContainer.Location = new System.Drawing.Point(8, 8);
            this.GlobalContainer.Name = "GlobalContainer";
            this.GlobalContainer.Size = new System.Drawing.Size(334, 366);
            this.GlobalContainer.TabIndex = 2;
            // 
            // InformationContainer
            // 
            this.InformationContainer.AutoSize = true;
            this.InformationContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InformationContainer.ColumnCount = 1;
            this.InformationContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InformationContainer.Controls.Add(this.IdContainer, 0, 4);
            this.InformationContainer.Controls.Add(this.TypeSeperator, 0, 3);
            this.InformationContainer.Controls.Add(this.HeaderPanel, 0, 0);
            this.InformationContainer.Controls.Add(this.HeaderSeperator, 0, 1);
            this.InformationContainer.Controls.Add(this.TypeContainer, 0, 2);
            this.InformationContainer.Location = new System.Drawing.Point(13, 12);
            this.InformationContainer.Name = "InformationContainer";
            this.InformationContainer.RowCount = 5;
            this.InformationContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InformationContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InformationContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InformationContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InformationContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InformationContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.InformationContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.InformationContainer.Size = new System.Drawing.Size(312, 233);
            this.InformationContainer.TabIndex = 0;
            // 
            // IdContainer
            // 
            this.IdContainer.AutoSize = true;
            this.IdContainer.ColumnCount = 2;
            this.IdContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.IdContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.IdContainer.Controls.Add(this.SeeFullPanel, 1, 1);
            this.IdContainer.Controls.Add(this.PathInDriveTextBox, 1, 2);
            this.IdContainer.Controls.Add(this.PathInDriveLabel, 0, 2);
            this.IdContainer.Controls.Add(this.IdLabel, 0, 0);
            this.IdContainer.Controls.Add(this.IdTextBox, 1, 0);
            this.IdContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.IdContainer.Location = new System.Drawing.Point(0, 169);
            this.IdContainer.Margin = new System.Windows.Forms.Padding(0);
            this.IdContainer.Name = "IdContainer";
            this.IdContainer.RowCount = 3;
            this.IdContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.IdContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.IdContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.IdContainer.Size = new System.Drawing.Size(312, 64);
            this.IdContainer.TabIndex = 8;
            // 
            // SeeFullPanel
            // 
            this.SeeFullPanel.AutoSize = true;
            this.SeeFullPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SeeFullPanel.Controls.Add(this.AcquireExistingID);
            this.SeeFullPanel.Controls.Add(this.CopyIdLabel);
            this.SeeFullPanel.Controls.Add(this.SeeFullLinkLabel);
            this.SeeFullPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SeeFullPanel.Location = new System.Drawing.Point(84, 22);
            this.SeeFullPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.SeeFullPanel.Name = "SeeFullPanel";
            this.SeeFullPanel.Size = new System.Drawing.Size(228, 12);
            this.SeeFullPanel.TabIndex = 4;
            // 
            // AcquireExistingID
            // 
            this.AcquireExistingID.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.AcquireExistingID.AutoSize = true;
            this.AcquireExistingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AcquireExistingID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.AcquireExistingID.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.AcquireExistingID.Location = new System.Drawing.Point(92, -1);
            this.AcquireExistingID.Margin = new System.Windows.Forms.Padding(0);
            this.AcquireExistingID.Name = "AcquireExistingID";
            this.AcquireExistingID.Size = new System.Drawing.Size(95, 13);
            this.AcquireExistingID.TabIndex = 8;
            this.AcquireExistingID.TabStop = true;
            this.AcquireExistingID.Text = "Acquire existing ID";
            this.AcquireExistingID.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.AcquireExistingID.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AcquireExistingID_LinkClicked);
            // 
            // CopyIdLabel
            // 
            this.CopyIdLabel.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.CopyIdLabel.AutoSize = true;
            this.CopyIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CopyIdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.CopyIdLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.CopyIdLabel.Location = new System.Drawing.Point(44, -1);
            this.CopyIdLabel.Margin = new System.Windows.Forms.Padding(0);
            this.CopyIdLabel.Name = "CopyIdLabel";
            this.CopyIdLabel.Size = new System.Drawing.Size(45, 13);
            this.CopyIdLabel.TabIndex = 7;
            this.CopyIdLabel.TabStop = true;
            this.CopyIdLabel.Text = "Copy ID";
            this.CopyIdLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.CopyIdLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyIdLabel_LinkClicked);
            // 
            // SeeFullLinkLabel
            // 
            this.SeeFullLinkLabel.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.SeeFullLinkLabel.AutoSize = true;
            this.SeeFullLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SeeFullLinkLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SeeFullLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SeeFullLinkLabel.Location = new System.Drawing.Point(-1, -1);
            this.SeeFullLinkLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SeeFullLinkLabel.Name = "SeeFullLinkLabel";
            this.SeeFullLinkLabel.Size = new System.Drawing.Size(42, 13);
            this.SeeFullLinkLabel.TabIndex = 6;
            this.SeeFullLinkLabel.TabStop = true;
            this.SeeFullLinkLabel.Text = "See full";
            this.SeeFullLinkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SeeFullLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SeeFullLinkLabel_LinkClicked);
            // 
            // PathInDriveTextBox
            // 
            this.PathInDriveTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.PathInDriveTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PathInDriveTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PathInDriveTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PathInDriveTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PathInDriveTextBox.Location = new System.Drawing.Point(86, 43);
            this.PathInDriveTextBox.Margin = new System.Windows.Forms.Padding(2, 6, 3, 0);
            this.PathInDriveTextBox.Name = "PathInDriveTextBox";
            this.PathInDriveTextBox.ReadOnly = true;
            this.PathInDriveTextBox.Size = new System.Drawing.Size(223, 13);
            this.PathInDriveTextBox.TabIndex = 5;
            // 
            // PathInDriveLabel
            // 
            this.PathInDriveLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PathInDriveLabel.AutoSize = true;
            this.PathInDriveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PathInDriveLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PathInDriveLabel.Location = new System.Drawing.Point(0, 44);
            this.PathInDriveLabel.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.PathInDriveLabel.Name = "PathInDriveLabel";
            this.PathInDriveLabel.Size = new System.Drawing.Size(69, 13);
            this.PathInDriveLabel.TabIndex = 4;
            this.PathInDriveLabel.Text = "Path in drive:";
            // 
            // IdLabel
            // 
            this.IdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.IdLabel.Location = new System.Drawing.Point(0, 7);
            this.IdLabel.Margin = new System.Windows.Forms.Padding(0, 7, 0, 2);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(21, 13);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "ID:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.IdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IdTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.IdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.IdTextBox.Location = new System.Drawing.Point(86, 6);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(2, 6, 3, 0);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(223, 13);
            this.IdTextBox.TabIndex = 3;
            // 
            // TypeSeperator
            // 
            this.TypeSeperator.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TypeSeperator.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TypeSeperator.Location = new System.Drawing.Point(2, 162);
            this.TypeSeperator.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.TypeSeperator.Name = "TypeSeperator";
            this.TypeSeperator.Size = new System.Drawing.Size(308, 1);
            this.TypeSeperator.TabIndex = 4;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.AutoSize = true;
            this.HeaderPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HeaderPanel.ColumnCount = 2;
            this.HeaderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.HeaderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HeaderPanel.Controls.Add(this.PictureBox, 0, 0);
            this.HeaderPanel.Controls.Add(this.NameTextBox, 1, 0);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.RowCount = 1;
            this.HeaderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HeaderPanel.Size = new System.Drawing.Size(312, 35);
            this.HeaderPanel.TabIndex = 1;
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(4, 0);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(4, 0, 0, 4);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(31, 31);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // NameTextBox
            // 
            this.NameTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameTextBox.Location = new System.Drawing.Point(84, 7);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(224, 22);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameTextBox.XOffset = 0;
            this.NameTextBox.YOffset = 0;
            // 
            // HeaderSeperator
            // 
            this.HeaderSeperator.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HeaderSeperator.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.HeaderSeperator.Location = new System.Drawing.Point(2, 41);
            this.HeaderSeperator.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.HeaderSeperator.Name = "HeaderSeperator";
            this.HeaderSeperator.Size = new System.Drawing.Size(308, 1);
            this.HeaderSeperator.TabIndex = 2;
            // 
            // TypeContainer
            // 
            this.TypeContainer.AutoSize = true;
            this.TypeContainer.ColumnCount = 2;
            this.TypeContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.TypeContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TypeContainer.Controls.Add(this.LastZippedLabel, 0, 3);
            this.TypeContainer.Controls.Add(this.LastUpdatedTextBox, 1, 3);
            this.TypeContainer.Controls.Add(this.LocationTextBox, 1, 1);
            this.TypeContainer.Controls.Add(this.TypeLabel, 0, 0);
            this.TypeContainer.Controls.Add(this.LocationLabel, 0, 1);
            this.TypeContainer.Controls.Add(this.TypeTextBox, 1, 0);
            this.TypeContainer.Controls.Add(this.SizeLabel, 0, 2);
            this.TypeContainer.Controls.Add(this.SizeTextBox, 1, 2);
            this.TypeContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.TypeContainer.Location = new System.Drawing.Point(0, 48);
            this.TypeContainer.Margin = new System.Windows.Forms.Padding(0);
            this.TypeContainer.Name = "TypeContainer";
            this.TypeContainer.RowCount = 4;
            this.TypeContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TypeContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TypeContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TypeContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TypeContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TypeContainer.Size = new System.Drawing.Size(312, 108);
            this.TypeContainer.TabIndex = 3;
            // 
            // LastZippedLabel
            // 
            this.LastZippedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LastZippedLabel.AutoSize = true;
            this.LastZippedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastZippedLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LastZippedLabel.Location = new System.Drawing.Point(0, 88);
            this.LastZippedLabel.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.LastZippedLabel.Name = "LastZippedLabel";
            this.LastZippedLabel.Size = new System.Drawing.Size(64, 13);
            this.LastZippedLabel.TabIndex = 6;
            this.LastZippedLabel.Text = "Last zipped:";
            // 
            // LastUpdatedTextBox
            // 
            this.LastUpdatedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.LastUpdatedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastUpdatedTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LastUpdatedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastUpdatedTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LastUpdatedTextBox.Location = new System.Drawing.Point(86, 87);
            this.LastUpdatedTextBox.Margin = new System.Windows.Forms.Padding(2, 6, 3, 0);
            this.LastUpdatedTextBox.Name = "LastUpdatedTextBox";
            this.LastUpdatedTextBox.ReadOnly = true;
            this.LastUpdatedTextBox.Size = new System.Drawing.Size(223, 13);
            this.LastUpdatedTextBox.TabIndex = 5;
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.LocationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LocationTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LocationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LocationTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LocationTextBox.Location = new System.Drawing.Point(86, 33);
            this.LocationTextBox.Margin = new System.Windows.Forms.Padding(2, 6, 3, 0);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.ReadOnly = true;
            this.LocationTextBox.Size = new System.Drawing.Size(223, 13);
            this.LocationTextBox.TabIndex = 4;
            // 
            // TypeLabel
            // 
            this.TypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypeLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TypeLabel.Location = new System.Drawing.Point(0, 7);
            this.TypeLabel.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(34, 13);
            this.TypeLabel.TabIndex = 0;
            this.TypeLabel.Text = "Type:";
            // 
            // LocationLabel
            // 
            this.LocationLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LocationLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LocationLabel.Location = new System.Drawing.Point(0, 34);
            this.LocationLabel.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(51, 13);
            this.LocationLabel.TabIndex = 1;
            this.LocationLabel.Text = "Location:";
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TypeTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.TypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypeTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TypeTextBox.Location = new System.Drawing.Point(86, 6);
            this.TypeTextBox.Margin = new System.Windows.Forms.Padding(2, 6, 3, 0);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.ReadOnly = true;
            this.TypeTextBox.Size = new System.Drawing.Size(223, 13);
            this.TypeTextBox.TabIndex = 3;
            this.TypeTextBox.Text = "Zipped item";
            // 
            // SizeLabel
            // 
            this.SizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SizeLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SizeLabel.Location = new System.Drawing.Point(0, 61);
            this.SizeLabel.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(30, 13);
            this.SizeLabel.TabIndex = 7;
            this.SizeLabel.Text = "Size:";
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.SizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SizeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SizeTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SizeTextBox.Location = new System.Drawing.Point(86, 60);
            this.SizeTextBox.Margin = new System.Windows.Forms.Padding(2, 6, 3, 0);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.ReadOnly = true;
            this.SizeTextBox.Size = new System.Drawing.Size(223, 13);
            this.SizeTextBox.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.darkLabel1, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // darkLabel1
            // 
            this.darkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.darkLabel1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.darkLabel1.Location = new System.Drawing.Point(0, 63);
            this.darkLabel1.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(72, 13);
            this.darkLabel1.TabIndex = 6;
            this.darkLabel1.Text = "Last updated:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Location = new System.Drawing.Point(86, 6);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 6, 3, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(111, 13);
            this.textBox1.TabIndex = 5;
            // 
            // ZippedItemProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(350, 415);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.GlobalContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ZippedItemProperties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Updateable item";
            this.GlobalContainer.ResumeLayout(false);
            this.GlobalContainer.PerformLayout();
            this.InformationContainer.ResumeLayout(false);
            this.InformationContainer.PerformLayout();
            this.IdContainer.ResumeLayout(false);
            this.IdContainer.PerformLayout();
            this.SeeFullPanel.ResumeLayout(false);
            this.SeeFullPanel.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.TypeContainer.ResumeLayout(false);
            this.TypeContainer.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomDialogs.DarkButton CloseButton;
        private System.Windows.Forms.Panel GlobalContainer;
        private System.Windows.Forms.TableLayoutPanel InformationContainer;
        private System.Windows.Forms.Panel TypeSeperator;
        private System.Windows.Forms.TableLayoutPanel HeaderPanel;
        private System.Windows.Forms.PictureBox PictureBox;
        private CustomDialogs.DarkTextBox NameTextBox;
        private System.Windows.Forms.Panel HeaderSeperator;
        private System.Windows.Forms.TableLayoutPanel TypeContainer;
        private CustomDialogs.DarkLabel LastZippedLabel;
        private System.Windows.Forms.TextBox LastUpdatedTextBox;
        private System.Windows.Forms.TextBox LocationTextBox;
        private CustomDialogs.DarkLabel TypeLabel;
        private CustomDialogs.DarkLabel LocationLabel;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomDialogs.DarkLabel darkLabel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox SizeTextBox;
        private CustomDialogs.DarkLabel SizeLabel;
        private System.Windows.Forms.TableLayoutPanel IdContainer;
        private System.Windows.Forms.Panel SeeFullPanel;
        private System.Windows.Forms.LinkLabel AcquireExistingID;
        private System.Windows.Forms.LinkLabel CopyIdLabel;
        private System.Windows.Forms.LinkLabel SeeFullLinkLabel;
        private System.Windows.Forms.TextBox PathInDriveTextBox;
        private CustomDialogs.DarkLabel PathInDriveLabel;
        private CustomDialogs.DarkLabel IdLabel;
        private System.Windows.Forms.TextBox IdTextBox;
    }
}