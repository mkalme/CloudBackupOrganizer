
namespace CloudBackupOrganizerRecoveryGUI {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemExplorer));
            this.MenuStrip = new CustomDialogs.DarkContextMenuStrip(this.components);
            this.ExtractMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowPasswordMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLinkMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeZipPathMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MenuStrip.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExtractMenuItem,
            this.ShowPasswordMenuItem,
            this.ShowLinkMenuItem,
            this.ChangeZipPathMenuItem});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(167, 92);
            this.MenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.MenuStrip_Opening);
            // 
            // ExtractMenuItem
            // 
            this.ExtractMenuItem.Name = "ExtractMenuItem";
            this.ExtractMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ExtractMenuItem.Text = "Extract";
            this.ExtractMenuItem.Click += new System.EventHandler(this.ExtractMenuItem_Click);
            // 
            // ShowPasswordMenuItem
            // 
            this.ShowPasswordMenuItem.Image = global::CloudBackupOrganizerRecoveryGUI.Properties.Resources._64pxKey;
            this.ShowPasswordMenuItem.Name = "ShowPasswordMenuItem";
            this.ShowPasswordMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ShowPasswordMenuItem.Text = "Show password";
            this.ShowPasswordMenuItem.Click += new System.EventHandler(this.ShowPasswordMenuItem_Click);
            // 
            // ShowLinkMenuItem
            // 
            this.ShowLinkMenuItem.Image = global::CloudBackupOrganizerRecoveryGUI.Properties.Resources._64pxLink;
            this.ShowLinkMenuItem.Name = "ShowLinkMenuItem";
            this.ShowLinkMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ShowLinkMenuItem.Text = "Show link";
            this.ShowLinkMenuItem.Click += new System.EventHandler(this.ShowLinkMenuItem_Click);
            // 
            // ChangeZipPathMenuItem
            // 
            this.ChangeZipPathMenuItem.Name = "ChangeZipPathMenuItem";
            this.ChangeZipPathMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ChangeZipPathMenuItem.Text = "Change 7zip path";
            this.ChangeZipPathMenuItem.Click += new System.EventHandler(this.ChangeZipPathMenuItem_Click);
            // 
            // ItemExplorer
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(864, 481);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemExplorer";
            this.Padding = new System.Windows.Forms.Padding(7, 6, 7, 7);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cloud Backup Organizer Recovery ";
            this.Load += new System.EventHandler(this.ItemExplorer_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.ItemExplorer_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.ItemExplorer_DragEnter);
            this.MenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomDialogs.DarkContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ExtractMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowPasswordMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowLinkMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeZipPathMenuItem;
    }
}

