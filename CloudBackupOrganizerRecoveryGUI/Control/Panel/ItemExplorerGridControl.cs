using System;
using System.Drawing;
using System.Windows.Forms;
using CloudBackupOrganizerRecovery;
using CustomDialogs;

namespace CloudBackupOrganizerRecoveryGUI {
    public class ItemExplorerGridControl : DataGridViewControl {
        public ViewController ViewController { get; set; }
        public string ColumnName { get; set; }

        public ItemExplorerGridControl(ViewController viewController, string columnName) {
            ViewController = viewController;
            ColumnName = columnName;

            Initialize();
        }

        public override DataGridViewColumn[] CreateColumns() {
            return new DataGridViewColumn[] {
                new TextAndImageColumn(){
                    HeaderText = "Name",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                    Width = 190
                },
                new TextAndImageColumn(){
                    HeaderText = "Id",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                    AlignmentToRight = true,
                    DefaultCellStyle = new DataGridViewCellStyle(){
                        Font = new Font("Consolas", 8),
                        Padding = new Padding(3, 1, 0, 0)
                    }
                },
                new DataGridViewLinkColumn(){
                    HeaderText = "Open in browser",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                    Width = 110,
                    LinkColor = Color.LightGray,
                    ActiveLinkColor = Color.Gray,
                    VisitedLinkColor = Color.LightGray
                },
                new DataGridViewLinkColumn(){
                    HeaderText = "Extract",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                    Width = 49,
                    LinkColor = Color.LightGray,
                    ActiveLinkColor = Color.Gray,
                    VisitedLinkColor = Color.LightGray
                },
                new DataGridViewTextBoxColumn(){
                    HeaderText = ColumnName,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                    Width = 110,
                    DefaultCellStyle = new DataGridViewCellStyle(){
                        Alignment = DataGridViewContentAlignment.MiddleRight,
                        Padding = new Padding(0, 0, 5, 0)
                    }
                }
            };
        }
        protected override void GridDoubleClick(DataGridViewCellEventArgs e, object item) {
            if (item is Group g) {
                ViewController.OpenChild(g);
            }
        }

        //Update
        private ImageCache _imageCache = new ImageCache();

        protected override bool SetRow(DataGridViewRow row, object item) {
            if (item is Group g) SetGroupRow(row, g);
            else SetZippedItemRow(row, item as ZippedItem);

            return true;
        }

        private void SetGroupRow(DataGridViewRow row, Group group) {
            row.DisplayImage(DataGridView.Columns[0], _imageCache.GetImage("group", Properties.Resources._64pxGroup, 22, 22), 27);

            row.Cells[0].Value = group.DisplayName;
        }
        private void SetZippedItemRow(DataGridViewRow row, ZippedItem zippedItem) {
            ((TextAndImageCell)row.Cells[0]).XOffet = 4;
            row.DisplayImage(DataGridView.Columns[0], _imageCache.GetImage("zippedFile", Properties.Resources._64pxZippedFile, 16, 16), 27);

            if (!string.IsNullOrEmpty(zippedItem.Password)) {
                row.DisplayImage(DataGridView.Columns[1], Properties.Resources._16pxKey);
            }

            row.Cells[0].Value = zippedItem.DisplayName;
            row.Cells[1].Value = zippedItem.UniqueID;
            row.Cells[2].Value = "Open in browser";
            row.Cells[3].Value = "Extract";
            row.Cells[4].Value = zippedItem.LastZipped == DateTime.MinValue ? "Never" : (DateTime.Now - zippedItem.LastZipped).ToRelativeTimeString();
        }
    }
}
