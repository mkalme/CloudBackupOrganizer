using System;
using System.Diagnostics;
using System.Threading;
using CloudBackupOrganizerRecovery;
using CustomDialogs;

namespace CloudBackupOrganizerRecoveryGUI {
    public static class ItemUtilities {
        public static void Extract(ZippedItem item, string zipPath, string archivePath = "") {
            try {
                if (string.IsNullOrEmpty(archivePath)) {
                    InputResult<string> archiveResult = CustomDialog.ShowBrowser(BrowseType.OpenFile);
                    if (archiveResult.DialogClosed) return;

                    archivePath = archiveResult.Value;
                }

                InputResult<string> outputResult = CustomDialog.ShowBrowser(BrowseType.BrowseFolder);
                if (outputResult.DialogClosed) return;

                Progress<float> progress = new Progress<float>();

                new Thread(() => {
                    item.Extract(archivePath, outputResult.Value, progress, zipPath);
                    ((IProgress<float>)progress).Report(1);
                }).Start();

                ProgressForm form = new ProgressForm(progress);
                form.SetText("Extracting");
                form.ShowDialog();
            } catch (Exception e) {
                CustomDialog.ShowError(e);
            }
        }
        public static void OpenInBrowser(ZippedItem item) {
            try {
                using (Process process = new Process()) {
                    process.StartInfo.UseShellExecute = true;
                    process.StartInfo.FileName = item.Link;
                    process.Start();
                }
            } catch {
                CustomDialog.ShowError("Error", "There was an error opening the link.");
            }
        }
    }
}
