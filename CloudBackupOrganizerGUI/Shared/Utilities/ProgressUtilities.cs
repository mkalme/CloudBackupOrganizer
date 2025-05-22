using System;
using System.Threading;

namespace CloudBackupOrganizerGUI {
    public static class ProgressUtilities {
        public static void ShowProgressDialog(string activityType, Action<Progress<float>> func) {
            Progress<float> progress = new Progress<float>();

            new Thread(() => {
                func(progress);
                ((IProgress<float>)progress).Report(1);
            }).Start();

            ProgressForm form = new ProgressForm(progress, activityType);
            form.ShowDialog();
        }
    }
}
