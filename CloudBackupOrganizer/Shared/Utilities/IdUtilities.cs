using System;

namespace CloudBackupOrganizer {
    public static class IdUtilities {
        public static string GenerateID() {
            return $"{Guid.NewGuid()}_{DateTime.UtcNow.Ticks}";
        }
    }
}
