using System;
using System.IO;

namespace CloudBackupOrganizerRecovery {
    public abstract class Item {
        public string DisplayName {
            get {
                string directoryName = Path.GetFileName(PathInDrive); ;

                if (string.IsNullOrWhiteSpace(directoryName)) return PathInDrive;
                return directoryName;
            }
        }
        public string PathInDrive { get; set; }
    }
}
