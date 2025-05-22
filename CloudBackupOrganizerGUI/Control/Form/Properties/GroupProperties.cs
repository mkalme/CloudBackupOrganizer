using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using CloudBackupOrganizer;
using CustomDialogs;

namespace CloudBackupOrganizerGUI {
    public partial class GroupProperties : Form {
        public Group Group { get; }

        public GroupProperties(Group group) {
            InitializeComponent();

            Group = group;
            Icon = ImageToIconConverter.Convert(Properties.Resources._64pxGroup, 64, 64);

            LoadDialog();
        }

        private void LoadDialog() {
            NameTextBox.Text = Group.DisplayName;
            LocationTextBox.Text = Group.Parent?.GetPathInDrive();

            int groupA = CountGroups(Group);
            int folderA = CountZippedItems(Group, typeof(ZippedFolder));
            int filteredFolderA = CountZippedItems(Group, typeof(ZippedFilteredFolder));
            int bundleA = CountZippedItems(Group, typeof(ZippedItemBundle));
            int fileA = CountZippedItems(Group, typeof(ZippedFile));

            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"{groupA} Group{(groupA != 1 ? "s" : "")}");
            builder.AppendLine($"{folderA} Zipped folder{(folderA != 1 ? "s" : "")}");
            builder.AppendLine($"{filteredFolderA} Zipped filtered folder{(filteredFolderA != 1 ? "s" : "")}");
            builder.AppendLine($"{bundleA} Zipped item bundle{(bundleA != 1 ? "s" : "")}");
            builder.AppendLine($"{fileA} Zipped file{(fileA != 1 ? "s" : "")}");

            ContainsRichTextBox.Text = builder.ToString();

            long size = Group.Items.GetSize();
            SizeTextBox.Text = $"{size.ConvertToStorage()} ({size.ToString("N0")} bytes)";

            RealNameTextBox.Text = Group.RealName;
            PathInDriveTextBox.Text = Group.GetPathInDrive();

            CloseButton.Select();
        }

        private static int CountGroups(Group group) {
            int output = 0;

            foreach (var item in group.Items) {
                if (item.GetType() == typeof(Group)) {
                    output += 1 + CountGroups(item as Group);
                }
            }

            return output;
        }
        private static int CountZippedItems(Group group, Type type) {
            int output = 0;

            foreach (var item in group.Items) {
                if (item.GetType() == type) {
                    output++;
                } else if (item.GetType() == typeof(Group)) {
                    output += CountZippedItems(item as Group, type);
                }
            }

            return output;
        }

        private void SeeFullLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            CustomDialog.ShowMessage($"Real name | {Group.DisplayName}", Group.RealName);
        }
        private void CopyRealName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Clipboard.SetText(Group.RealName);
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
