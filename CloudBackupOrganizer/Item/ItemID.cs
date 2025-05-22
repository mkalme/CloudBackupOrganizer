using System;

namespace CloudBackupOrganizer {
    public enum ItemID : byte {
        Group,
        ZippedItemBundle,
        ZippedFolder,
        ZippedFilteredFolder,
        ZippedFile
    }
}
