using System;
using System.Windows.Forms;
using CloudBackupOrganizer;
using CustomDialogs;

namespace CloudBackupOrganizerGUI {
    static class Program {
        private static OrganizerApplication OrganizerApplication;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            InputResult<byte[]> keyResult = CustomDialog.ShowKeyInput(KeyExtensions.KeyValidator);
            if (keyResult.DialogClosed) return;

            OrganizerApplication = new OrganizerApplication(keyResult.Value);
            GuiApplication guiApplication = new GuiApplication(OrganizerApplication.Controller);

            foreach (var profile in OrganizerApplication.Resource.ProfileCatalog.Profiles) {
                profile.RootResource.ContentsChanged += Root_ContentsChanged;
            }

            OrganizerApplication.Resource.ProfileCatalog.ProfileAdded += Profile_Added;
            OrganizerApplication.Resource.ProfileCatalog.ProfileRemoved += Profile_Removed;
            OrganizerApplication.Resource.ProfileCatalog.ProfileModified += Profile_Modified;

            Application.Run(new ItemExplorer(OrganizerApplication, guiApplication));
        }

        private static void Root_ContentsChanged(object sender, EventArgs e) {
            ((GroupResource)sender).Save();
        }

        private static void Profile_Added(object sender, EventArgs e) {
            ((Profile)sender).RootResource.ContentsChanged += Root_ContentsChanged;

            OrganizerApplication.Resource.Save();
        }
        private static void Profile_Removed(object sender, EventArgs e) {
            ((Profile)sender).RootResource.ContentsChanged -= Root_ContentsChanged;

            OrganizerApplication.Resource.Save();
        }
        private static void Profile_Modified(object sender, EventArgs e) {
            OrganizerApplication.Resource.Save();
        }
    }
}
