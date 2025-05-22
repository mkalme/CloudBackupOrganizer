using System;
using System.IO;
using System.Windows.Forms;
using CloudBackupOrganizer;
using CustomDialogs;

namespace CloudBackupOrganizerGUI {
    public partial class ExtractItemForm : Form {
        public ZippedItem ZippedItem { get; }

        public ExtractItemForm(ZippedItem item, string archivePath = "") {
            InitializeComponent();

            ZippedItem = item;
            ArchivePathTextBox.Text = archivePath;
        }

        private void BrowseArchiveButton_Click(object sender, EventArgs e) {
            OpenFileDialog.ShowDialog();
            ArchivePathTextBox.Text = OpenFileDialog.FileName;
        }
        private void BrowseDirectoryButton_Click(object sender, EventArgs e) {
            FolderBrowserDialog.ShowDialog();
            DirectoryPathTextBox.Text = FolderBrowserDialog.SelectedPath;
        }

        private void ExtractButton_Click(object sender, EventArgs e) {
            if (!ValidateContents()) return;
            
            ItemUtilities.Extract(ZippedItem, ArchivePathTextBox.Text, DirectoryPathTextBox.Text);
            Close();
        }

        private bool ValidateContents() {
            if (string.IsNullOrEmpty(ArchivePathTextBox.Text)) {
                CustomDialog.ShowError("Error", "Archive path cannot be empty.");
                return false;
            }

            if (!File.Exists(ArchivePathTextBox.Text)) {
                CustomDialog.ShowError("Error", "Archive doesn't exist.");
                return false;
            }

            if (string.IsNullOrEmpty(DirectoryPathTextBox.Text)) {
                CustomDialog.ShowError("Error", "Output directory path cannot be empty.");
                return false;
            }

            return true;
        }
    }
}
