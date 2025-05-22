using System;
using System.Windows.Forms;
using CustomDialogs;

namespace CloudBackupOrganizerGUI {
    public partial class ProgressForm : Form {
        public string ActivityType { get; set; }

        private Progress<float> _progress;
        private bool _canClose = false;

        public ProgressForm(Progress<float> progress, string activityType) {
            InitializeComponent();

            _progress = progress;
            _progress.ProgressChanged += UpdateProgress;

            ActivityType = activityType;
            Text = ActivityType;

            UploadingTitleTimer.Interval = 400;
            UploadingTitleTimer.Start();
        }

        public void SetText(string text) {
            if (_title.StartsWith(text)) return;

            Text = text;
            _title = text;

            ProgressPanel.SetText(Text);
        }

        private void UpdateProgress(object sender, float progress) {
            SetText(ActivityType);

            ProgressPanel.Update(new ProgressReport() { 
                Percentage = progress,
                ActivityType = ActivityType,
                Message = ""
            });

            if (progress >= 1) {
                _canClose = true;
                Close(); 
            }
        }

        private void ProgressForm_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = !_canClose;
        }

        private string _title = "";
        private void UploadingTitleTimer_Tick(object sender, EventArgs e) {
            if (Text.Length - _title.Length < 3) {
                Text += ".";
            } else {
                Text = _title;
            }

            ProgressPanel.SetText(Text);
        }
    }
}
