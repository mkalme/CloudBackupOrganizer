using System;
using System.Drawing;
using System.Windows.Forms;
using CloudBackupOrganizer;
using CustomDialogs;

namespace CloudBackupOrganizerGUI {
    public class ItemExplorerGridControl : ItemGridControl {
        public ItemExplorerGridControl(ViewController viewController) : base(viewController) {}

        protected override bool SetRow(DataGridViewRow row, object obj) {
            base.SetRow(row, obj);
            row.Cells[3].Value = !string.IsNullOrEmpty(((Item)obj).Link) ? "Open in browser" : "";

            return true;
        }

        protected override void SetGroupRow(DataGridViewRow row, Group group) {
            base.SetGroupRow(row, group);
            
            row.Cells[1].Value = group.RealName;
        }
        protected override void SetZippedItemRow(DataGridViewRow row, ZippedItem zippedItem) {
            base.SetZippedItemRow(row, zippedItem);
            
            row.Cells[1].Value = zippedItem.UniqueID;

            if (!string.IsNullOrEmpty(zippedItem.Password)) {
                row.DisplayImage(DataGridView.Columns[1], Properties.Resources._16pxKey);
            }

            row.Cells[4].Value = zippedItem.GetLastUpdatedString();
        }
    }
}
