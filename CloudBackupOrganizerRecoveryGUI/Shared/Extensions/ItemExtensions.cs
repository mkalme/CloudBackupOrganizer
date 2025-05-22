using System;
using System.Collections.Generic;
using CloudBackupOrganizerRecovery;

namespace CloudBackupOrganizerRecoveryGUI {
    public static class ItemExtensions {
        public static void GetAllZippedItems(this Group group, IList<ZippedItem> output) {
            foreach (var item in group.Items) {
                if (item is ZippedItem z) output.Add(z);
                else GetAllZippedItems(item as Group, output);
            }
        }
    }
}
