using System;
using CloudBackupOrganizer;
using CommonUtilities;
using CustomDialogs;

namespace CloudBackupOrganizerGUI {
    public class GuiApplication {
        public GuiApplicationInformation AppInformation { get; set; }
        public ItemClipboard Clipbaord { get; set; }

        public GuiApplication(IFileCacheController controller) {
            AppInformation = new GuiApplicationInformation(controller);
            AppInformation.Load();

            Clipbaord = new ItemClipboard(
                (item, ev) => ((Item)item).Deleted += ev,
                (item, ev) => ((Item)item).Deleted -= ev
            );
        }
    }
}
