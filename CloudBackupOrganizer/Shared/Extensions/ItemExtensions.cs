using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBackupOrganizer {
    public static class ItemExtensions {
        public static void GetAllZippedItems(this Group group, IList<ZippedItem> output) {
            foreach (var item in group.Items) {
                if (item is ZippedItem z) output.Add(z);
                else GetAllZippedItems(item as Group, output);
            }
        }

        public static string GetPathInDrive(this Item item) {
            StringBuilder builder = new StringBuilder(item.DisplayName);

            Item parent = item.Parent;
            while (parent != null) {
                builder.Insert(0, $"{parent.DisplayName}\\");

                parent = parent.Parent;
            }

            return builder.ToString();
        }
    }
}
