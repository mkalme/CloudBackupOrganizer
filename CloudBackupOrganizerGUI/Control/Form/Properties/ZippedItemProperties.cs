using System;
using System.Windows.Forms;
using System.Media;
using System.Linq;
using System.Collections.Generic;
using CloudBackupOrganizer;
using CustomDialogs;

namespace CloudBackupOrganizerGUI {
    public partial class ZippedItemProperties : Form {
        public ZippedItem ZippedItem { get; }

        public ZippedItemProperties(ZippedItem zippedItem) {
            InitializeComponent();

            ZippedItem = zippedItem;
            Icon = ImageToIconConverter.Convert(zippedItem.GetIcon(), 64, 64);

            LoadDialog();
        }

        private void LoadDialog() {
            Text = ZippedItem.GetTypeString();

            PictureBox.Image = ZippedItem.GetIcon();
            NameTextBox.Text = ZippedItem.DisplayName;

            TypeTextBox.Text = ZippedItem.GetTypeString();
            LocationTextBox.Text = ZippedItem.Parent?.GetPathInDrive();
            SizeTextBox.Text = $"{ZippedItem.Size.ConvertToStorage()} ({ZippedItem.Size.ToString("N0")} bytes)";

            LastUpdatedTextBox.Text = ZippedItem.GetLastUpdatedString();

            IdTextBox.Text = ZippedItem.UniqueID;
            PathInDriveTextBox.Text = ZippedItem.GetPathInDrive();

            CloseButton.Select();
        }

        private void SeeFullLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            CustomDialog.ShowMessage($"ID | {ZippedItem.DisplayName}", ZippedItem.UniqueID);
        }
        private void CopyIdLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Clipboard.SetText(ZippedItem.UniqueID);
        }
        private void AcquireExistingID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            InputResult<IList<object>> selectionResult = ItemSelectorUtilities.ShowSelector(ZippedItem.Parent, new ItemSelectorProfile() {
                SelectedItemValidator = i => i is ZippedItem
            }, thisItem => thisItem != ZippedItem);

            if (selectionResult.DialogClosed || selectionResult.Value.Count < 1) return;
            if (((Item)selectionResult.Value.ElementAt(0)).ID == ItemID.Group) {
                CustomDialog.ShowError("Error", "Selected item must be updateable.");
                return;
            }

            string result = CustomDialog.ShowMessage($"ID Change | {ZippedItem.DisplayName}", "Are you sure you want to change the ID of this item?",
                Properties.Resources._64pxId, SystemSounds.Hand, "Yes", "No");

            if (result == "No" || result == "Closed") return;

            ZippedItem zippedItem = selectionResult.Value[0] as ZippedItem;
            ZippedItem.ChangeID(zippedItem.UniqueID);

            zippedItem.Parent.Items.Remove(zippedItem);

            LoadDialog();
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
