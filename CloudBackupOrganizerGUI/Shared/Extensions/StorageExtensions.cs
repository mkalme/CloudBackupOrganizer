using System;

namespace CloudBackupOrganizerGUI {
    public static class StorageExtensions {
        private static string[] _prefixesLong = { "bytes", "kilobytes", "megabytes", "gigabytes", "terabytes" };
        private static string[] _prefixesShort = { "B", "KB", "MB", "GB", "TB" };

        public static string ConvertToShortStorage(this long storage, bool longPrefixes = false) {
            string[] prefixes = longPrefixes ? _prefixesLong : _prefixesShort;

            int magnitude = (int)Math.Floor(Math.Log(storage, 1024));
            if (storage == 0) magnitude = 0;

            return $"{(storage / Math.Pow(1024, magnitude)).Format()} {prefixes[magnitude]}";
        }
        public static string Format(this double storage) {
            return storage.ToString("N0");
        }
    }
}
