using System;
using System.Windows.Forms;
using CloudBackupOrganizerRecovery;
using CustomDialogs;

namespace CloudBackupOrganizerRecoveryGUI {
    static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length == 0) {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.ShowDialog();

                args = new string[] { dialog.SelectedPath };
            }

            try {
                Group group = Group.FromUsersheet(args[0], out string columnName);

                Application.Run(new ItemExplorer(group, columnName));
            } catch (Exception e) {
                CustomDialog.ShowError(e);
            }
        }
    }
}
