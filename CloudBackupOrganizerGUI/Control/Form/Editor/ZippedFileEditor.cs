using System;
using System.IO;
using System.Windows.Forms;
using CloudBackupOrganizer;
using CustomDialogs;

namespace CloudBackupOrganizerGUI {
    public partial class ZippedFileEditor : Form {
        public ZippedFile ZippedFile { get; set; }

        private string _link;
        private string _password;

        private bool _closed = false;

        public ZippedFileEditor(ZippedFile zippedFile) {
            InitializeComponent();

            ZippedFile = zippedFile;

            _link = ZippedFile.Link;
            _password = ZippedFile.Password;

            PathTextBox.Text = ZippedFile.FilePath;
            NameTextBox.Text = ZippedFile.DisplayName;
        }

        //DragDrop
        private void ZippedFileEditor_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        private void ZippedFileEditor_DragDrop(object sender, DragEventArgs e) {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            PathTextBox.Text = files[0];
            NameTextBox.Text = Path.GetFileName(files[0]);
        }

        private void BrowseButton_Click(object sender, EventArgs e) {
            OpenFileDialog.ShowDialog();
            PathTextBox.Text = OpenFileDialog.FileName;
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e) {
            InputResult<string> result = DialogUtilities.ShowPasswordInput(ZippedFile.DisplayName, _password);
            if (result.DialogClosed) return;

            _password = result.Value;
        }
        private void ChangeLinkButton_Click(object sender, EventArgs e) {
            InputResult<string> result = DialogUtilities.ShowLinkInput(ZippedFile.DisplayName, _link);
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
            if (NameTextBox.Text != ZippedFile.DisplayName || _link != ZippedFile.Link || ZippedFile.Password != _password) return true;

            return PathTextBox.Text != ZippedFile.FilePath;
        }
        private bool ValidateContent() {
            return NameUtilities.ValidateName(ZippedFile, NameTextBox.Text);
        }
        private void SaveChanges() {
            ZippedFile.ApplyChangeMode();

            ZippedFile.DisplayName = NameTextBox.Text;
            ZippedFile.Link = _link;
            ZippedFile.Password = _password;

            ZippedFile.FilePath = PathTextBox.Text;

            ZippedFile.SuspendChangeMode();
        }
    }
}
