using System;
using System.Drawing;
using System.Windows.Forms;
using CloudBackupOrganizer;
using CustomDialogs;

namespace CloudBackupOrganizerGUI {
    public partial class ItemSelectionDataGridViewControl : IDataGridViewSelectionControl {
        public DataGridView DataGridView { get; set; }
        public Func<object, bool> ViewableItemValidator { get; }

        public ViewController ViewController { get; set; }

        public ItemSelectionDataGridViewControl(Func<object, bool> viewableItemValidator) {
            ViewableItemValidator = viewableItemValidator;
        }

        public DataGridViewColumn[] CreateColumns() {
            return new DataGridViewTextBoxColumn[] {
                new TextAndImageColumn(){
                    HeaderText = "Name",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                    Width = 190
                },
                new TextAndImageColumn(){
                    HeaderText = "Id",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                    Width = 110,
                    AlignmentToRight = true,
                    DefaultCellStyle = new DataGridViewCellStyle(){
                        Font = new Font("Consolas", 8),
                        Padding = new Padding(3, 1, 0, 0)
                    }
                }
            };
        }

        //Update
        private ImageCache _imageCache = new ImageCache();

        public void SetRow(DataGridViewRow row, object obj) {
            Item item = obj as Item;

            row.Cells[0].Value = item.DisplayName;

            if (item is Group) SetGroupRow(row, item as Group);
            else SetZippedItemRow(row, item as ZippedItem);
        }
        private void SetGroupRow(DataGridViewRow row, Group group) {
            row.Cells[1].Value = group.RealName;
            row.DisplayImage(DataGridView.Columns[0], _imageCache.GetImage("group", Properties.Resources._64pxGroup, 22, 22), 27);
        }
        private void SetZippedItemRow(DataGridViewRow row, ZippedItem item) {
            row.Cells[1].Value = item.UniqueID;

            ((TextAndImageCell)row.Cells[0]).XOffet = (item.ID == ItemID.ZippedFolder || item.ID == ItemID.ZippedFilteredFolder) ? 4 : 3;
            row.DisplayImage(DataGridView.Columns[0], _imageCache.GetImage(item.GetTypeString(), item.GetIcon(), 16, 16), 27);

            if (!string.IsNullOrEmpty(item.Password)) {
                row.DisplayImage(DataGridView.Columns[1], Properties.Resources._16pxKey);
            }
        }

        //Double click
        public void GridDoubleClick(DataGridViewCellEventArgs e, object item) {
            ItemID id = ((Item)item).ID;

            if (id == ItemID.Group) {
                ViewController.OpenChild(item as Group);
            }
        }
    }
}
