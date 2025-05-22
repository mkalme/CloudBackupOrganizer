using System;
using System.Drawing;
using System.Windows.Forms;
using CustomDialogs;

namespace CloudBackupOrganizerGUI {
    public partial class ZipDirectoryForm : Form {
        public GuiApplicationInformation Information { get; }

        public string SelectedDirectory { get; private set; }
        public bool DialogClosed { get; private set; } = true;

        public ZipDirectoryForm(GuiApplicationInformation information) {
            InitializeComponent();

            Information = information;
            DefaultDirectoryCheckBox.Checked = true;
        }

        private void BrowseButton_Click(object sender, EventArgs e) {
            FolderBrowserDialog.ShowDialog();
            PathTextBox.Text = FolderBrowserDialog.SelectedPath;
        }
        private void BrowseButton_Paint(object sender, PaintEventArgs e) {
            Button btn = (Button)sender;
            SolidBrush drawBrush = new SolidBrush(btn.ForeColor);
            StringFormat sf = new StringFormat() {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            BrowseButton.Text = string.Empty;

            Rectangle rect = e.ClipRectangle;
            rect.Offset(-10, 0);

            e.Graphics.DrawString("Browse", btn.Font, drawBrush, rect, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }

        private void DefaultDirectoryCheckBox_CheckedChanged(object sender, EventArgs e) {
            if (DefaultDirectoryCheckBox.Checked) PathTextBox.Text = Information.DefaultZipOutputDirectory;

            BrowseButton.Enabled = !DefaultDirectoryCheckBox.Checked;
            PathTextBox.Enabled = !DefaultDirectoryCheckBox.Checked;
            
            BrowseButton.ForeColor = DefaultDirectoryCheckBox.Checked ? Color.Gray : SystemColors.HighlightText;
        }

        private void ZipButton_Click(object sender, EventArgs e) {
            if (!ValidateContents()) return;

            SelectedDirectory = DefaultDirectoryCheckBox.Checked ? Information.DefaultZipOutputDirectory : PathTextBox.Text;
            
            DialogClosed = false;
            Close();
        }
        private bool ValidateContents() {
            if (string.IsNullOrEmpty(PathTextBox.Text)) {
                CustomDialog.ShowError("Error", "Output directory cannot be empty.");
                return false;
            }

            return true;
        }
    }
}
