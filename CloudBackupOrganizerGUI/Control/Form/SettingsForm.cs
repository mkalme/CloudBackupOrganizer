using System;
using System.Windows.Forms;
using CloudBackupOrganizer;
using CustomDialogs;

namespace CloudBackupOrganizerGUI {
    public partial class SettingsForm : Form {
        public OrganizerApplication Application { get; set; }
        public GuiApplicationInformation Information { get; set; }

        private bool _canceled = false;

        public SettingsForm(OrganizerApplication application, GuiApplicationInformation information) {
            InitializeComponent();

            Application = application;
            Information = information;

            DefaultPasswordLengthTextBox.Text = Information.DefaultPasswordLength.ToString();
            ZipPathTextBox.Text = Application.ZipFilePath;
            ZippedFolderPathTextBox.Text = Information.DefaultZipOutputDirectory;
        }

        private void BrowseZippedItemDirectoryLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            FolderBrowserDialog.ShowDialog();
            ZippedFolderPathTextBox.Text = FolderBrowserDialog.SelectedPath;
        }
        
        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (_canceled) return;

            if (!ValidateContents(false) || CheckForChanges()) {
                string result = CustomDialog.ShowSaveConfirmation();

                if (result == "Save") {
                    if (ValidateContents()) Save();
                    else e.Cancel = true;
                } else if (result == "Cancel") {
                    e.Cancel = true;
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            if (!ValidateContents()) return;

            Save();
            Close();
        }
        private void Cancelbutton_Click(object sender, EventArgs e) {
            _canceled = true;
            Close();
        }

        private bool ValidateContents(bool showErrorMessage = true) {
            if (!int.TryParse(DefaultPasswordLengthTextBox.Text, out int result)) {
                if (showErrorMessage) {
                    CustomDialog.ShowError("Error", "Cannot parse default password length.");
                }

                return false;
            }

            return true;
        }
        private bool CheckForChanges() {
            return Information.DefaultPasswordLength != int.Parse(DefaultPasswordLengthTextBox.Text) || Application.ZipFilePath != ZipPathTextBox.Text || Information.DefaultZipOutputDirectory != ZippedFolderPathTextBox.Text;
        }
        private void Save() {
            if (Information.DefaultPasswordLength.ToString() != DefaultPasswordLengthTextBox.Text) {
                Information.DefaultPasswordLength = int.Parse(DefaultPasswordLengthTextBox.Text);
                Information.Save();
            }

            if (Application.ZipFilePath != ZipPathTextBox.Text) {
                Application.Resource.ZipFilePath = ZipPathTextBox.Text;
                Application.Resource.Save();
            }

            if (Information.DefaultZipOutputDirectory != ZippedFolderPathTextBox.Text) {
                Information.DefaultZipOutputDirectory = ZippedFolderPathTextBox.Text;
                Information.Save();
            }
        }
    }
}
