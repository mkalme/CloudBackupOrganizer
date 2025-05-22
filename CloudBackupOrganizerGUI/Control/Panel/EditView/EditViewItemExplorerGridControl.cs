using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CloudBackupOrganizer;
using CustomDialogs;

namespace CloudBackupOrganizerGUI {
    public class EditViewItemExplorerGridControl : ItemExplorerGridControl {
        public EditViewItemExplorerGridControl(ViewController viewController) : base(viewController) {}

        //Update
        protected override void SetGroupRow(DataGridViewRow row, Group group) {
            base.SetGroupRow(row, group);

            DataGridView.Columns[1].HeaderText = "Path in drive";

            row.Cells[1].Value = Path.GetDirectoryName(group.GetPathInDrive());
            row.Cells[1].Style = new DataGridViewCellStyle() {
                Font = new Font("Segoe UI", 9)
            };

        }
        protected override void SetZippedItemRow(DataGridViewRow row, ZippedItem zippedItem) {
            base.SetZippedItemRow(row, zippedItem);

            DataGridView.Columns[1].HeaderText = "Id";

            row.Cells[1].Value = zippedItem.UniqueID;
        }
    }
}
