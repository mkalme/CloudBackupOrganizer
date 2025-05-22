using System;
using System.Linq;

namespace CloudBackupOrganizerGUI {
    public class KeyInformationPanel : CustomDialogs.KeyInformationPanel {
        public KeyInformationPanel(GuiApplication application) { 
            CurrentKeySince = application.AppInformation.KeyHistory.Last().ToString();
            KeyHistory = application.AppInformation.KeyHistory;
            KeyCellIcon = Properties.Resources._16pxKey;
        }
    }
}
