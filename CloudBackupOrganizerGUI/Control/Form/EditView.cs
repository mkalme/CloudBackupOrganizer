using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using CloudBackupOrganizer;
using CustomDialogs;

namespace CloudBackupOrganizerGUI {
    public partial class EditView : Form {
        public OrganizerApplication Application { get; set; }
        public GuiApplication GuiApplication { get; set; }

        public Group CurrentGroup => ((Node)CurrentView.ViewNode.Node).Group;
        public IView CurrentView => ViewControl.ViewController.CurrentView;

        public EditViewItemExplorerGridControl GridControl { get; set; }
        public DataGridView GridView {
            get => GridControl.DataGridView;
        }

        public ViewControl ViewControl { get; set; }

        public EditView(OrganizerApplication application, GuiApplication guiApplication, Group group = null) {
            InitializeComponent();

            Application = application;
            GuiApplication = guiApplication;

            TopLevelEditViewNode facade = new TopLevelEditViewNode(group ?? Application.CurrentProfile.Root);

            ViewController viewController = new ViewController(facade);
            GridControl = new EditViewItemExplorerGridControl(viewController);

            ViewControl = new ViewControl() {
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };

            EditNode parentNode = new EditNode(facade.Node, null);

            StandardVerticalViewControl viewControl = new StandardVerticalViewControl(ViewControl, GridControl);
            viewControl.HeaderToolBar.ViewController = viewController;
            viewControl.HeaderToolBar.NodeCreator = item => {
                if (parentNode.Node == item) return parentNode; 
                return new EditNode(item, parentNode);
            };

            ViewControl.Initialize(viewController, viewControl);
            GlobalContainer.Controls.Add(ViewControl, 0, 0);

            ViewControl.BeginUpdate += ViewController_BeginUpdate;
            ViewControl.Updated += ViewController_Updated;

            GridView.CellClick += GridView_CellClick;
            GridView.SelectionChanged += GridView_SelectionChanged;
            GridView.ContextMenuStrip = MenuStrip;
        }

        //Load
        private void EditView_Load(object sender, EventArgs e) {
            CenterToScreen();

            ViewControl.UpdateView();
        }
        private void EditView_FormClosing(object sender, FormClosingEventArgs e) {
            ViewControl.ViewController.Dispose();
        }

        private bool _inUpdate = false;
        private void ViewController_BeginUpdate(object sender, EventArgs e) {
            _inUpdate = true;
        }
        private void ViewController_Updated(object sender, EventArgs e) {
            _inUpdate = false;
            
            UpdateItemsCountLabel();
            UpdateSelectedItemsLabel();
        }

        private void UpdateItemsCountLabel() {
            List<Item> items = new List<Item>();
            foreach (DataGridViewRow row in GridView.Rows) {
                items.Add(row.Tag as Item);
            }

            long size = items.GetSize();
            ItemsCountLabel.Text = $"Items: {items.Count}; Size: {size.ConvertToShortStorage()} ({size.ToString("N0")} bytes)";
        }
        private void UpdateSelectedItemsLabel() {
            IEnumerable<Item> items = CurrentView.SelectedItems.Cast<Item>();

            long size = items.GetSize();
            SelectedItemsLabel.Text = $"Selected items: {items.Count()}; Size: {size.ConvertToShortStorage()} ({size.ToString("N0")} bytes)";
        }

        private void GridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == 3) ItemUtilities.OpenInBrowser(GridView.Rows[e.RowIndex].Tag as Item);
        }
        private void GridView_SelectionChanged(object sender, EventArgs e) {
            if (_inUpdate) return;

            UpdateSelectedItemsLabel();
        }

        //Bottom button
        private void OpenFolderInBrowser_Click(object sender, EventArgs e) {
            ItemUtilities.OpenInBrowser(CurrentGroup);
        }

        //MenuStrip
        private void MenuStrip_Opening(object sender, CancelEventArgs e) {
            Item item = GridControl.GetItemFromPoint(MenuStrip.CursorWhenOpened) as Item;
            bool enabled = item?.ID != ItemID.Group && CurrentView.SelectedItems.Count == 1;

            CopyLastZippedPathMenuItem.Enabled = item?.ID != ItemID.Group && CurrentView.SelectedItems.Count > 0;

            ChangePasswordMenuItem.Enabled = enabled;
            ChangeLinkMenuItem.Enabled = CurrentView.SelectedItems.Count == 1;
            
            EditMenuItem.Visible = enabled;
            RenameMenuItem.Enabled = CurrentView.SelectedItems.Count == 1;

            PropertiesMenuItem.Enabled = ((Node)CurrentView.ViewNode.Node).IsTop ? CurrentView.SelectedItems.Count == 1 : CurrentView.SelectedItems.Count < 2;
        }

        private void ZipMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.Zip(GuiApplication.AppInformation, CurrentView.SelectedItems.Count > 0 ? CurrentView.SelectedItems.Cast<Item>() : new Item[] { CurrentGroup });
        }
        private void CopyLastZippedPathMenuItem_Click(object sender, EventArgs e) {
            IEnumerable<ZippedItem> items = CurrentView.SelectedItems.Cast<ZippedItem>();

            StringCollection paths = new StringCollection();
            foreach (var item in items) {
                if(!string.IsNullOrEmpty(item.LastZippedFile)) paths.Add(item.LastZippedFile);
            }

            Clipboard.SetFileDropList(paths);
        }

        private void ChangePasswordMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.ChangePassword(GridControl.GetItemFromPoint(MenuStrip.CursorWhenOpened) as ZippedItem);
        }
        private void ChangeLinkMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.ChangeLink(GridControl.GetItemFromPoint(MenuStrip.CursorWhenOpened) as Item);
        }

        private void EditMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.EditItem(GridControl.GetItemFromPoint(MenuStrip.CursorWhenOpened) as Item);
        }
        private void RenameMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.RenameItem(GridControl.GetItemFromPoint(MenuStrip.CursorWhenOpened) as Item);
        }

        private void PropertiesMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.OpenProperties(GridControl.GetItemFromPoint(MenuStrip.CursorWhenOpened) as Item ?? CurrentGroup);
        }
    }
}
