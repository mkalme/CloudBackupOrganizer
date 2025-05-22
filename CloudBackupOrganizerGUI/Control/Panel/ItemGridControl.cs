using System;
using System.Drawing;
using System.Windows.Forms;
using CloudBackupOrganizer;
using CustomDialogs;

namespace CloudBackupOrganizerGUI {
    public class ItemGridControl : DataGridViewControl {
        public ViewController ViewController { get; set; }

        public ItemGridControl(ViewController viewController) {
            ViewController = viewController;

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
                new DataGridViewTextBoxColumn(){
                    HeaderText = "Size",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                    MinimumWidth = 65,
                    DefaultCellStyle = new DataGridViewCellStyle(){
                        Alignment = DataGridViewContentAlignment.MiddleRight,
                        ForeColor = Color.FromArgb(175, 175, 175),
                        Padding = new Padding(0, 0, 5, 0)
                    }
                },
                new DataGridViewLinkColumn(){
                    HeaderText = "Open in browser",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                    Width = 99,
                    LinkColor = Color.FromArgb(200, 200, 200),
                    ActiveLinkColor = Color.Gray,
                    VisitedLinkColor = Color.FromArgb(200, 200, 200),
                    DefaultCellStyle = new DataGridViewCellStyle() { 
                        Alignment = DataGridViewContentAlignment.MiddleCenter
                    }
                },
                new DataGridViewTextBoxColumn(){
                    HeaderText = "Last zipped",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                    Width = 105,
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
            } else {
                ItemUtilities.EditItem(item as Item);
            }
        }

        //Update
        private ImageCache _imageCache = new ImageCache();

        protected override bool SetRow(DataGridViewRow row, object obj) {
            Item item = obj as Item;

            row.Cells[0].Value = item.DisplayName;

            row.Cells[2].Style.Padding = new Padding(0, 0, 6, 0);
            row.Cells[3].Style.Padding = new Padding(1, 0, 0, 0);

            if (item is Group) SetGroupRow(row, item as Group);
            else SetZippedItemRow(row, item as ZippedItem);

            return true;
        }

        protected virtual void SetGroupRow(DataGridViewRow row, Group group) {
            row.DisplayImage(DataGridView.Columns[0], _imageCache.GetImage("group", Properties.Resources._64pxGroup, 22, 22), 27);
            
            row.Cells[2].Value = group.Items.GetSize().ConvertToShortStorage();
        }
        protected virtual void SetZippedItemRow(DataGridViewRow row, ZippedItem zippedItem) {
            ((TextAndImageCell)row.Cells[0]).XOffet = (zippedItem.ID == ItemID.ZippedFolder || zippedItem.ID == ItemID.ZippedFilteredFolder) ? 4 : 3;
            row.DisplayImage(DataGridView.Columns[0], _imageCache.GetImage(zippedItem.GetTypeString(), zippedItem.GetIcon(), 16, 16), 27);

            row.Cells[2].Value = zippedItem.Size.ConvertToShortStorage();
        }
    }
}
