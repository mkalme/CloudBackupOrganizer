using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using CloudBackupOrganizer;
using CustomDialogs;

namespace CloudBackupOrganizerGUI {
    public partial class ProgressBundleForm : Form {
        public IList<ZippedItem> ZippedItems { get; set; }
        public string OutputDirectory { get; set; }

        private bool _canClose = false;

        public bool UpdateSuccessfull { get; private set; } = false;

        public ProgressBundleForm(IEnumerable<Item> zippedItems, string outputDirectory) {
            InitializeComponent();

            ZippedItems = new List<ZippedItem>();
            zippedItems.GetZippedItems(ZippedItems);

            OutputDirectory = outputDirectory;

            UploadingTimer.Interval = 400;
            UploadingTimer.Start();
        }

        private void ProgressBundleView_Load(object sender, EventArgs e) {
            BeginUpdate();
        }

        private void BeginUpdate() {
            IProgress<ProgressReport> itemProgress = new Progress<ProgressReport>();
            ((Progress<ProgressReport>)itemProgress).ProgressChanged += ItemZippingProgress;

            Thread thread = new Thread(() => {
                for (int i = 0; i < ZippedItems.Count; i++) {
                    ZippedItem item = ZippedItems[i];

                    itemProgress.Report(new ProgressReport() {
                        Percentage = i / (float)ZippedItems.Count,
                        Message = $"{i} / {ZippedItems.Count}",
                        ActivityType = $"Zipping {item.DisplayName}",
                    });

                    ZipItem(item);
                }

                _canClose = true;
                Invoke(new Action(() => Close()));
            });

            thread.Start();
        }
        private void ZipItem(ZippedItem item) {
            Invoke(new Action(() => {
                SubProgressPanel.SetText("Creating archive");
                SubProgressPanel.Update(new ProgressReport() {
                    Percentage = 0,
                    ActivityType = "Creating archive"
                });
            }));

            Progress<float> progress = new Progress<float>();
            progress.ProgressChanged += ZippingProgress;

            item.ApplyChangeMode();
            ItemUtilities.Zip(item, OutputDirectory, progress);
            item.SuspendChangeMode();

            UpdateSuccessfull = true;
        }

        private void ItemZippingProgress(object sender, ProgressReport progress) {
            Invoke(new Action(() => {
                if (progress.ActivityType != MainProgressPanel.OriginalActivityTypeText) {
                    MainProgressPanel.SetText(progress.ActivityType);
                }

                MainProgressPanel.Update(progress);

                if (progress.Percentage >= 1) {
                    _canClose = true;
                    Close();
                }
            }));
        }

        private DateTime _prevUpdate = DateTime.MinValue;
        private void ZippingProgress(object sender, float progress) {
            if (progress < 1 && (DateTime.Now - _prevUpdate) < TimeSpan.FromMilliseconds(50)) return;
            _prevUpdate = DateTime.Now;

            Invoke(new Action(() => {    
                ProgressReport report = new ProgressReport() {
                    Percentage = (float)progress,
                    ActivityType = "Creating archive",
                    Message = ""
                };

                SubProgressPanel.Update(report);
                SubProgressPanel.SetText(report.ActivityType);
            }));
        }

        private void UploadingTimer_Tick(object sender, EventArgs e) {
            UpdateText(MainProgressPanel);
            UpdateText(SubProgressPanel);

            Text = MainProgressPanel.ActivityTypeText;
        }
        private void UpdateText(ProgressPanel panel) {
            if (panel.ActivityTypeText.Length - panel.OriginalActivityTypeText.Length < 3) {
                panel.SetText(panel.ActivityTypeText + ".");
            } else {
                panel.SetText(panel.OriginalActivityTypeText);
            }
        }

        private void ProgressBundleView_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = !_canClose;
        }
    }
}
