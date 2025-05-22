using System;
using System.IO;
using System.Windows.Forms;
using CloudBackupOrganizer;
using CustomDialogs;

namespace CloudBackupOrganizerGUI {
    public partial class ZippedFolderEditor : Form {
        public ZippedFolder ZippedFolder { get; set; }

        private string _link;
        private string _password;

        private bool _closed = false;

        public ZippedFolderEditor(ZippedFolder zippedFolder) {
            InitializeComponent();

            ZippedFolder = zippedFolder;

            _link = ZippedFolder.Link;
            _password = ZippedFolder.Password;

            PathTextBox.Text = ZippedFolder.FolderPath;
            NameTextBox.Text = ZippedFolder.DisplayName;
        }

        //DragDrop
        private void ZippedFolderEditor_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        private void ZippedFolderEditor_DragDrop(object sender, DragEventArgs e) {
            string[] folders = (string[])e.Data.GetData(DataFormats.FileDrop);

            PathTextBox.Text = folders[0];
            NameTextBox.Text = Path.GetFileName(folders[0]);
        }

        private void BrowseButton_Click(object sender, EventArgs e) {
            FolderBrowserDialog.ShowDialog();
            PathTextBox.Text = FolderBrowserDialog.SelectedPath;
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e) {
            InputResult<string> result = DialogUtilities.ShowPasswordInput(ZippedFolder.DisplayName, _password);
            if (result.DialogClosed) return;

            _password = result.Value;
        }
        private void ChangeLinkButton_Click(object sender, EventArgs e) {
            InputResult<string> result = DialogUtilities.ShowLinkInput(ZippedFolder.DisplayName, _link);
            if (result.DialogClosed) return;

            _link = result.Value;
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            if (!ValidateContent()) return;
            SaveChanges();

            _closed = true;
            Close();
        }
        private void CancelButton_Click(object sender, EventArgs e) {
            _closed = true;
            Close();
        }

        private void ZippedFolderEditor_FormClosing(object sender, FormClosingEventArgs e) {
            if (!_closed && CheckForChanges()) {
                string result = CustomDialog.ShowSaveConfirmation();

                if (result == "Close" || result == "Cancel") {
                    e.Cancel = true;
                    return;
                } if (result == "Don't Save") return;

                if (!ValidateContent()) {
                    e.Cancel = true;
                    return;
                }
                
                SaveChanges();
            }
        }

        private bool CheckForChanges() {
            if (NameTextBox.Text != ZippedFolder.DisplayName || _link != ZippedFolder.Link || ZippedFolder.Password != _password) return true;

            return PathTextBox.Text != ZippedFolder.FolderPath;
        }
        private bool ValidateContent() {
            return NameUtilities.ValidateName(ZippedFolder, NameTextBox.Text);
        }
        private void SaveChanges() {
            ZippedFolder.ApplyChangeMode();

            ZippedFolder.DisplayName = NameTextBox.Text;
            ZippedFolder.Link = _link;
            ZippedFolder.Password = _password;

            ZippedFolder.FolderPath = PathTextBox.Text;

            ZippedFolder.SuspendChangeMode();
        }
    }
}
