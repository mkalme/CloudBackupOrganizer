using System;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO;
using System.Collections.Generic;
using CloudBackupOrganizerRecovery;
using CustomDialogs;

namespace CloudBackupOrganizerRecoveryGUI {
    public partial class ItemExplorer : Form {
        public Group Group { get; set; }
        public Group CurrentGroup => CurrentView.ViewNode.Node as Group;

        public IView CurrentView => ViewControl.ViewController.CurrentView;

        public ItemExplorerGridControl GridControl { get; set; }
        public DataGridView GridView {
            get => GridControl.DataGridView;
        }

        public ViewControl ViewControl { get; set; }

        public string ZipPath { get; set; } = "7z.exe";

        public ItemExplorer(Group group, string columnName) {
            InitializeComponent();

            Group = group;

            ViewController viewController = new ViewController(new GroupViewNode(Group));
            GridControl = new ItemExplorerGridControl(viewController, columnName);

            ViewControl = new ViewControl() {
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };

            StandardVerticalViewControl viewControl = new StandardVerticalViewControl(ViewControl, GridControl);
            viewControl.HeaderToolBar.ViewController = viewController;
            viewControl.HeaderToolBar.NodeCreator = item => new GroupNode(item as Group);

            ViewControl.Initialize(viewController, viewControl);
            Controls.Add(ViewControl);

            GridView.CellClick += GridView_CellClick;
            GridView.ContextMenuStrip = MenuStrip;
        }

        private void ItemExplorer_Load(object sender, EventArgs e) {
            ViewControl.UpdateView();
        }

        private void GridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (CurrentView.SelectedItems.ElementAt(0) is not ZippedItem z) return;

            if (e.ColumnIndex == 2) ItemUtilities.OpenInBrowser(z);
            else if (e.ColumnIndex == 3) ItemUtilities.Extract(z, ZipPath);
        }

        //DragDrop
        private void ItemExplorer_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        private void ItemExplorer_DragDrop(object sender, DragEventArgs e) {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in files) {
                string ext = Path.GetExtension(file).ToLower();

                if (ext == ".7z") {
                    List<ZippedItem> zippedItems = new List<ZippedItem>();
                    Group.GetAllZippedItems(zippedItems);

                    string id = Path.GetFileNameWithoutExtension(file);
                    ZippedItem item = zippedItems.Find(x => x.UniqueID == id);

                    ItemUtilities.Extract(item, ZipPath, file);
                }
            }
        }

        //MenuStrip
        private void MenuStrip_Opening(object sender, CancelEventArgs e) {
            Item item = GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as Item;

            ExtractMenuItem.Enabled = item != null && item is ZippedItem;
            ShowPasswordMenuItem.Enabled = item != null && item is ZippedItem;
            ShowLinkMenuItem.Enabled = item != null && item is ZippedItem;
        }

        private void ExtractMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.Extract(GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as ZippedItem, ZipPath);
        }
        private void ShowPasswordMenuItem_Click(object sender, EventArgs e) {
            ZippedItem item = GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as ZippedItem;

            CustomDialog.ShowMessage($"Password | {item.DisplayName}", item.Password, Properties.Resources._64pxKey);
        }
        private void ShowLinkMenuItem_Click(object sender, EventArgs e) {
            ZippedItem item = GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as ZippedItem;

            CustomDialog.ShowMessage($"Link | {item.DisplayName}", item.Link, Properties.Resources._64pxLink);
        }
        private void ChangeZipPathMenuItem_Click(object sender, EventArgs e) {
            InputResult<string> result = CustomDialog.ShowTextInput("7zip path", "7zip path", ZipPath);
            if (result.DialogClosed) return;

            ZipPath = result.Value;
        }
    }
}
