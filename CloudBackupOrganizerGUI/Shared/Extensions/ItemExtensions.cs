using System;
using System.Collections.Generic;
using System.Drawing;
using CloudBackupOrganizer;
using CustomDialogs;

namespace CloudBackupOrganizerGUI {
    public static class ItemExtensions {
        public static string GetLastUpdatedString(this ZippedItem item) {
            if (item.LastZipped == DateTime.MinValue) return "Never";

            return (DateTime.Now - item.LastZipped).ToRelativeTimeString();
        }
        public static Image GetIcon(this Item item) {
            switch (item.ID) {
                case ItemID.Group:
                    return Properties.Resources._64pxGroup;
                case ItemID.ZippedItemBundle:
                    return Properties.Resources._64pxItemBundle;
                case ItemID.ZippedFolder:
                    return Properties.Resources._64pxFolderClosed;
                case ItemID.ZippedFilteredFolder:
                    return Properties.Resources._64pxFilteredFolder;
                default:
                    return Properties.Resources._64pxTextFile;
            }
        }
        public static string GetTypeString(this Item item) {
            switch (item.ID) {
                case ItemID.Group:
                    return "Group";
                case ItemID.ZippedItemBundle:
                    return "Zipped item bundle";
                case ItemID.ZippedFolder:
                    return "Zipped folder";
                case ItemID.ZippedFilteredFolder:
                    return "Zipped filtered folder";
                default:
                    return "Zipped file";
            }
        }

        public static void GetItems(this Group group, Type type, IList<Item> output, bool topGroup = false) {
            foreach (var item in group.Items) {
                if (type.IsAssignableFrom(item.GetType())) {
                    output.Add(item);
                }

                if (!topGroup && item is Group g) {
                    g.GetItems(type, output);
                }
            }
        }
        public static void GetZippedItems(this IEnumerable<Item> items, IList<ZippedItem> output) {
            foreach (Item item in items) {
                if (item.ID != ItemID.Group) {
                    output.Add(item as ZippedItem);
                } else {
                    GetZippedItems((item as Group).Items, output);
                }
            }
        }
        public static long GetSize(this IEnumerable<Item> items) {
            long output = 0;

            foreach (var item in items) {
                if (item is ZippedItem z) {
                    output += z.Size;
                } else if (item.ID == ItemID.Group) {
                    output += GetSize((item as Group).Items);
                }
            }

            return output;
        }
    }
}
