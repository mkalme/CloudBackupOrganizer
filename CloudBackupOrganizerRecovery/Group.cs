using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ClosedXML.Excel;

namespace CloudBackupOrganizerRecovery {
    public class Group : Item {
        public IList<Item> Items { get; set; }
        public Group Parent { get; set; }

        public Group() {
            Items = new List<Item>();
        }

        public static Group FromUsersheet(string usersheetPath, out string columnName) {
            using (XLWorkbook book = new XLWorkbook(usersheetPath)) {
                IXLWorksheet sheet = book.Worksheet("Data");

                IXLRow[] rows = sheet.Rows().ToArray();
                List<ZippedItem> zippedItems = new List<ZippedItem>(rows.Length - 1);

                for (int i = 1; i < rows.Length; i++) {
                    ZippedItem item = ZippedItem.FromExcelRow(rows[i]);
                    if (item != null) zippedItems.Add(item);
                }

                Dictionary<string, Group> groups = new Dictionary<string, Group>();
                foreach (var zippedItem in zippedItems) {
                    string parent = Path.GetDirectoryName(zippedItem.PathInDrive);

                    if (!groups.TryGetValue(parent, out Group group)) {
                        group = new Group() {
                            PathInDrive = parent
                        };
                        groups.Add(group.PathInDrive, group);
                    }

                    group.Items.Add(zippedItem);
                }

                columnName = rows[0].Cell(7).GetString();
                return CreateRoot(groups);
            }
        }

        private static Group CreateRoot(IDictionary<string, Group> groups) {
            Dictionary<string, Group> clone = new Dictionary<string, Group>(groups);

            foreach (var pair in groups) {
                FindParent(pair.Value, clone);
            }

            Group root = groups.ElementAt(0).Value;
            while (root.Parent != null) {
                root = root.Parent;
            }

            return root;
        }
        private static void FindParent(Group group, IDictionary<string, Group> groups) {
            string parentPath = Path.GetDirectoryName(group.PathInDrive);
            if (string.IsNullOrEmpty(parentPath)) return;

            if (!groups.TryGetValue(parentPath, out Group parent)) {
                parent = new Group() {
                    PathInDrive = Path.GetDirectoryName(group.PathInDrive)
                };

                groups.Add(parent.PathInDrive, parent);
                FindParent(parent, groups);
            }

            group.Parent = parent;
            parent.Items.Add(group);
        }
    }
}
