using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CloudBackupOrganizer;
using CustomDialogs;

namespace CloudBackupOrganizerGUI {
    public partial class ZippedItemBundleEditor : Form {
        public ZippedItemBundle ZippedItem { get; set; }

        private HashSet<string> _folders;
        private HashSet<string> _files;

        private Func<string, Image> _getFolderIconFunction;
        private Func<string, Image> _getFileIconFunction;

        private string _link;
        private string _password;

        private bool _closed = false;

        public ZippedItemBundleEditor(ZippedItemBundle item) {
            InitializeComponent();

            ZippedItem = item;

            _folders = new HashSet<string>(ZippedItem.Folders);
            _files = new HashSet<string>(ZippedItem.Files);

            _link = ZippedItem.Link;
            _password = ZippedItem.Password;

            NameTextBox.Text = ZippedItem.DisplayName;

            _getFolderIconFunction = (value) => {
                return Properties.Resources._22pxDirectory.Resize(20, 20);
            };
            _getFileIconFunction = (value) => {
                return Icon.ExtractAssociatedIcon(value).ToBitmap().Resize(20, 20);
            };

            LoadGridView(FolderGridView, _folders, _getFolderIconFunction);
            LoadGridView(FileGridView, _files, _getFileIconFunction);
        }

        private void ZippedItemEditor_Load(object sender, EventArgs e) {
            FolderGridView.ClearSelection();
            FileGridView.ClearSelection();
        }

        private void LoadGridView(DataGridView gridView, IEnumerable<string> items, Func<string, Image> getIconFunction) {
            gridView.Rows.Clear();

            foreach (var item in items) {
                gridView.Rows.Add(item);
                gridView.Rows[gridView.Rows.Count - 1].DisplayImage(gridView.Columns[0], getIconFunction(item), 25);
            }

            gridView.ClearSelection();
        }

        private void AddFolderButton_Click(object sender, EventArgs e) {
            FolderBrowserDialog.ShowDialog();
            if (string.IsNullOrEmpty(FolderBrowserDialog.SelectedPath)) return;

            _folders.Add(FolderBrowserDialog.SelectedPath);
            LoadGridView(FolderGridView, _folders, _getFolderIconFunction);
        }
        private void AddFileButton_Click(object sender, EventArgs e) {
            OpenFileDialog.ShowDialog();
            if (OpenFileDialog.FileNames.Length < 1) return;

            foreach (var file in OpenFileDialog.FileNames) {
                if (File.Exists(file)) _files.Add(file);
            }

            LoadGridView(FileGridView, _files, _getFileIconFunction);
        }

        private void ExpandFoldersButton_Click(object sender, EventArgs e) {
            Icon icon = ImageToIconConverter.Convert(Properties.Resources._22pxDirectory, 22, 22);

            Func<IEnumerable<string>> addFunction = () => {
                FolderBrowserDialog.ShowDialog();
                if (string.IsNullOrEmpty(FolderBrowserDialog.SelectedPath)) return new string[0];

                return new string[] { FolderBrowserDialog.SelectedPath };
            };

            InputResult<ISet<string>> results = CustomDialog.ShowTextCollectionEditor(_folders, "Folders", addFunction, _getFolderIconFunction, icon);
            if (results.DialogClosed) return;

            _folders = new HashSet<string>(results.Value);

            LoadGridView(FolderGridView, _folders, _getFolderIconFunction);
        }
        private void ExpandFilesButton_Click(object sender, EventArgs e) {
            Func<IEnumerable<string>> addFunction = () => {
                OpenFileDialog.ShowDialog();

                List<string> fileNames = new List<string>(OpenFileDialog.FileNames.Length);
                foreach (var file in OpenFileDialog.FileNames) {
                    if (File.Exists(file)) fileNames.Add(file);
                }

                return fileNames;
            };

            InputResult<ISet<string>> results = CustomDialog.ShowTextCollectionEditor(_files, "Files", addFunction, _getFileIconFunction, Properties.Resources._64pxDocumentIcon);
            if (results.DialogClosed) return;

            _files = new HashSet<string>(results.Value);

            LoadGridView(FileGridView, _files, _getFileIconFunction);
        }

        private void RemoveFoldersLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            foreach (DataGridViewRow folder in FolderGridView.SelectedRows) {
                _folders.Remove((string)folder.Cells[0].Value);
            }

            LoadGridView(FolderGridView, _folders, _getFolderIconFunction);
        }
        private void RemoveFilesLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            foreach (DataGridViewRow file in FileGridView.SelectedRows) {
                _files.Remove((string)file.Cells[0].Value);
            }

            LoadGridView(FileGridView, _files, _getFileIconFunction);
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e) {
            InputResult<string> result = DialogUtilities.ShowPasswordInput(ZippedItem.DisplayName, _password);
            if (result.DialogClosed) return;

            _password = result.Value;
        }
        private void ChangeLinkButton_Click(object sender, EventArgs e) {
            InputResult<string> result = DialogUtilities.ShowLinkInput(ZippedItem.DisplayName, _link);
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

        private void ZippedItemBundleEditor_FormClosing(object sender, FormClosingEventArgs e) {
            if (!_closed && CheckForChanges()) {
                string result = CustomDialog.ShowSaveConfirmation();

                if (result == "Close" || result == "Cancel") {
                    e.Cancel = true;
                    return;
                }
                if (result == "Don't Save") return;

                if (!ValidateContent()) {
                    e.Cancel = true;
                    return;
                }

                SaveChanges();
            }
        }

        private bool CheckForChanges() {
            if (NameTextBox.Text != ZippedItem.DisplayName || _link != ZippedItem.Link || ZippedItem.Password != _password) return true;

            if (ZippedItem.Folders.Count != _folders.Count || !ZippedItem.Folders.All(x => _folders.Contains(x))) return true;
            return ZippedItem.Files.Count != _files.Count || !ZippedItem.Files.All(x => _files.Contains(x));
        }
        private bool ValidateContent() {
            return NameUtilities.ValidateName(ZippedItem, NameTextBox.Text);
        }
        private void SaveChanges() {
            ZippedItem.ApplyChangeMode();

            ZippedItem.DisplayName = NameTextBox.Text;
            ZippedItem.Link = _link;
            ZippedItem.Password = _password;

            ZippedItem.Folders.Clear();
            foreach (var folder in _folders) {
                ZippedItem.Folders.Add(folder);
            }

            ZippedItem.Files.Clear();
            foreach (var file in _files) {
                ZippedItem.Files.Add(file);
            }

            ZippedItem.SuspendChangeMode();
        }
    }
}
