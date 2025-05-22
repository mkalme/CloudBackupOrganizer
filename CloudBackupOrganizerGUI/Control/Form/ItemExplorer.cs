using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using CloudBackupOrganizer;
using CustomDialogs;

namespace CloudBackupOrganizerGUI {
    public partial class ItemExplorer : Form {
        public OrganizerApplication Application { get; set; }
        public GuiApplication GuiApplication { get; set; }

        public Group CurrentGroup => CurrentView.ViewNode.Node as Group;
        public IView CurrentView => ViewControl.ViewController.CurrentView;

        public ItemExplorerGridControl GridControl { get; set; }
        public DataGridView GridView {
            get => GridControl.DataGridView;
        }

        public ViewControl ViewControl { get; set; }

        public ItemExplorer(OrganizerApplication application, GuiApplication guiApplication, Group group = null) {
            InitializeComponent();

            Application = application;
            GuiApplication = guiApplication;

            MenuStrip.CustomRenderer.ImageOffsets.Add(NewZippedItemBundleMenuItem, new Point(-1, 0));
            MoreMenuStrip.Renderer = new CustomToolStripRenderer(new CustomMenuStripColors() {
                BackColor = Color.FromArgb(35, 35, 35),
                BorderColor = Color.FromArgb(80, 80, 80),
                InnerBorderColor = Color.FromArgb(35, 35, 35),
                HoverColor = Color.FromArgb(70, 70, 70),
                DisabledHoverColor = Color.FromArgb(90, 90, 90)
            });

            ViewController viewController = new ViewController(new GroupViewNode(group ?? Application.CurrentProfile.Root));
            GridControl = new ItemExplorerGridControl(viewController);

            ViewControl = new ViewControl() {
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };

            StandardVerticalViewControl viewControl = new StandardVerticalViewControl(ViewControl, GridControl);
            viewControl.HeaderToolBar.ViewController = viewController;
            viewControl.HeaderToolBar.NodeCreator = item => new GroupNode(item as Group);

            ViewControl.Initialize(viewController, viewControl);
            GlobalContainer.Controls.Add(ViewControl, 0, 0);

            GridView.CellClick += GridView_CellClick;
            GridView.ContextMenuStrip = MenuStrip;
        }

        //Load
        private void ItemExplorer_Load(object sender, EventArgs e) {
            ViewControl.UpdateView();
        }
        private void ItemExplorer_FormClosing(object sender, FormClosingEventArgs e) {
            ViewControl.ViewController.Dispose();
        }

        private void GridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == 3) ItemUtilities.OpenInBrowser(GridView.Rows[e.RowIndex].Tag as Item);
        }

        //Bottom button
        private void CreateUsersheetButton_Click(object sender, EventArgs e) {
            InputResult<string> result = CustomDialog.ShowBrowser(BrowseType.SaveFile, "Zip files|*.7z", "UserSheet.7z");
            if (result.DialogClosed) return;

            ProgressUtilities.ShowProgressDialog("Creating usersheet",
                progress => Application.Resource.CurrentProfile.Root.CreateUserSheet(result.Value, Encoding.UTF8.GetString(Application.Key), progress));
        }

        private void MoreButton_Click(object sender, EventArgs e) {
            Point lowerleft = new Point(0, MoreButton.Height);
            lowerleft = MoreButton.PointToScreen(lowerleft);
            lowerleft.Offset(-(MoreMenuStrip.Width - MoreButton.Width) / 2, -MoreButton.Height - MoreMenuStrip.Height - 5);

            MoreMenuStrip.Show(lowerleft);
        }

        private void SettingsButton_Click(object sender, EventArgs e) {
            ItemUtilities.ShowSettings(Application, GuiApplication);
        }

        private void MoveUpButton_Click(object sender, EventArgs e) {
            if (GridView.SelectedRows.Count != 1) return;

            int rowIndex = GridView.SelectedRows[0].Index;
            if (rowIndex < 1) return;

            Item item = GridView.SelectedRows[0].Tag as Item;
            CurrentGroup.SwapItems(item, GridView.Rows[rowIndex - 1].Tag as Item);
        }
        private void MoveDownButton_Click(object sender, EventArgs e) {
            if (GridView.SelectedRows.Count != 1) return;

            int rowIndex = GridView.SelectedRows[0].Index;
            if (rowIndex >= GridView.Rows.Count - 1) return;

            Item item = GridView.SelectedRows[0].Tag as Item;
            CurrentGroup.SwapItems(item, GridView.Rows[rowIndex + 1].Tag as Item);
        }

        private void InformationButton_Click(object sender, EventArgs e) {
            ItemUtilities.ShowInformation(GuiApplication);
        }
        private void ChangeKeyButton_Click(object sender, EventArgs e) {
            ItemUtilities.ChangeKey(Application, GuiApplication);
        }

        private void DeselectButton_Click(object sender, EventArgs e) {
            GridView.ClearSelection();
        }
        private void CloseButton_Click(object sender, EventArgs e) {
            Close();
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
                    Application.CurrentProfile.Root.GetAllZippedItems(zippedItems);

                    string id = Path.GetFileNameWithoutExtension(file);
                    ZippedItem item = zippedItems.Find(x => x.UniqueID == id);

                    ExtractItemForm form = new ExtractItemForm(item, file);
                    form.ShowDialog();
                }
            }
        }

        //MenuStrip
        private void MenuStrip_Opening(object sender, CancelEventArgs e) {
            Item item = GridControl.GetItemFromPoint(MenuStrip.CursorWhenOpened) as Item;
            bool isZippedItem = item != null && item.ID != ItemID.Group && CurrentView.SelectedItems.Count == 1;

            ExtractMenuItem.Enabled = isZippedItem;
            
            OpenInNewWindowMenuItem.Enabled = item == null || (item.ID == ItemID.Group && CurrentView.SelectedItems.Count == 1);
            OpenInEditViewerMenuItem.Enabled = item == null || (item.ID == ItemID.Group && CurrentView.SelectedItems.Count == 1);

            ChangePasswordMenuItem.Enabled = isZippedItem;
            ChangeLinkMenuItem.Enabled = CurrentView.SelectedItems.Count < 2;
            ChangeRealNameMenuItem.Visible = item == null || (item.ID == ItemID.Group && CurrentView.SelectedItems.Count == 1);

            CopyMenuItem.Enabled = CurrentView.SelectedItems.Count > 0;
            PasteMenuItem.Enabled = GuiApplication.Clipbaord.CopiedItems?.Count > 0;

            MoveMenuItem.Enabled = CurrentView.SelectedItems.Count > 0;
            EditMenuItem.Visible = isZippedItem;
            RenameMenuItem.Enabled = CurrentView.SelectedItems.Count < 2;
            DeleteMenuItem.Enabled = CurrentView.SelectedItems.Count > 0;

            PropertiesMenuItem.Enabled = CurrentView.SelectedItems.Count < 2;
        }

        private void NewGroupMenuItem_Click(object sender, EventArgs e) {
            Group group = new Group() {
                DisplayName = "New group"
            };

            CurrentGroup.Items.Add(group);
            GridControl.SelectRow(group);

            ItemUtilities.RenameItem(group);
        }
        private void NewZippedFoldermenuItem_Click(object sender, EventArgs e) {
            ZippedFolder item = new ZippedFolder(Application.Resource) {
                DisplayName = "New zipped folder",
                Password = PasswordGeneratorDialogProfile.NewPassword.PasswordGenerator.Generate(GuiApplication.AppInformation.DefaultPasswordLength)
            };

            CurrentGroup.Items.Add(item);
            GridControl.SelectRow(item);

            ItemUtilities.EditZippedFolder(item);
        }
        private void ZippedFilteredFolderMenuItem_Click(object sender, EventArgs e) {
            ZippedFilteredFolder item = new ZippedFilteredFolder(Application.Resource) {
                DisplayName = "New zipped filtered folder",
                Password = PasswordGeneratorDialogProfile.NewPassword.PasswordGenerator.Generate(GuiApplication.AppInformation.DefaultPasswordLength)
            };

            CurrentGroup.Items.Add(item);
            GridControl.SelectRow(item);

            ItemUtilities.EditZippedFilteredFolder(item);
        }
        private void NewZippedItemBundleMenuItem_Click(object sender, EventArgs e) {
            ZippedItemBundle item = new ZippedItemBundle(Application.Resource) {
                DisplayName = "New zipped item bundle",
                Password = PasswordGeneratorDialogProfile.NewPassword.PasswordGenerator.Generate(GuiApplication.AppInformation.DefaultPasswordLength)
            };

            CurrentGroup.Items.Add(item);
            GridControl.SelectRow(item);

            ItemUtilities.EditZippedItemBundle(item);
        }
        private void NewZippedFileMenuItem_Click(object sender, EventArgs e) {
            ZippedFile item = new ZippedFile(Application.Resource) {
                DisplayName = "New zipped file",
                Password = PasswordGeneratorDialogProfile.NewPassword.PasswordGenerator.Generate(GuiApplication.AppInformation.DefaultPasswordLength)
            };

            CurrentGroup.Items.Add(item);
            GridControl.SelectRow(item);

            ItemUtilities.EditZippedFile(item);
        }

        private void OpenInNewWindowMenuItem_Click(object sender, EventArgs e) {
            Group group = GridControl.GetItemFromPoint(MenuStrip.CursorWhenOpened) as Group;

            new ItemExplorer(Application, GuiApplication, group ?? CurrentGroup).Show();
        }
        private void OpenInEditViewerMenuItem_Click(object sender, EventArgs e) {
            Group group = GridControl.GetItemFromPoint(MenuStrip.CursorWhenOpened) as Group;

            new EditView(Application, GuiApplication, group ?? CurrentGroup).Show();
        }

        private void ZipMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.Zip(GuiApplication.AppInformation, CurrentView.SelectedItems.Count > 0 ? CurrentView.SelectedItems.Cast<Item>() : new Item[] { CurrentGroup });
        }
        private void ExtractMenuItem_Click(object sender, EventArgs e) {
            ExtractItemForm form = new ExtractItemForm(GridControl.GetItemFromPoint(MenuStrip.CursorWhenOpened) as ZippedItem);
            form.ShowDialog();
        }

        private void ChangePasswordMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.ChangePassword(GridControl.GetItemFromPoint(MenuStrip.CursorWhenOpened) as ZippedItem);
        }
        private void ChangeLinkMenuItem_Click(object sender, EventArgs e) {
            Item item = GridControl.GetItemFromPoint(MenuStrip.CursorWhenOpened) as Item;

            ItemUtilities.ChangeLink(item ?? CurrentGroup);
        }
        private void ChangeRealNameMenuItem_Click(object sender, EventArgs e) {
            Group group = GridControl.GetItemFromPoint(MenuStrip.CursorWhenOpened) as Group;

            ItemUtilities.ChangeGroupRealName(group ?? CurrentGroup);
        }

        private void CopyMenuItem_Click(object sender, EventArgs e) {
            GuiApplication.Clipbaord.SetClipboard(CurrentView.SelectedItems.Cast<Item>());
        }
        private void PasteMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.Paste(CurrentGroup, GuiApplication.Clipbaord.CopiedItems.Cast<Item>());
        }

        private void MoveMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.MoveItems(CurrentGroup, CurrentView.SelectedItems.Cast<Item>());
        }
        private void EditMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.EditItem(GridControl.GetItemFromPoint(MenuStrip.CursorWhenOpened) as Item);
        }
        private void RenameMenuItem_Click(object sender, EventArgs e) {
            Item item = GridControl.GetItemFromPoint(MenuStrip.CursorWhenOpened) as Item;

            ItemUtilities.RenameItem(item ?? CurrentGroup);
        }
        private void DeleteMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.Delete(CurrentGroup, CurrentView.SelectedItems.Cast<Item>());
        }

        private void PropertiesMenuItem_Click(object sender, EventArgs e) {
            Item item = GridControl.GetItemFromPoint(MenuStrip.CursorWhenOpened) as Item;

            ItemUtilities.OpenProperties(item ?? CurrentGroup);
        }

        //MoreMenuStrip
        private void ExportItemsMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.ExportItems(CurrentGroup);
        }
        private void ImportItemsMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.ImportItems(CurrentGroup);
        }

        private void SwitchProfileMenuItem_Click(object sender, EventArgs e) {
            ProfileSelector selected = new ProfileSelector(Application.Resource.ProfileCatalog);
            selected.ShowDialog();

            if (selected.DialogClosed || selected.SelectedProfile == null) return;
            if (Application.Resource.CurrentProfile == selected.SelectedProfile) return;

            Application.Resource.ProfileCatalog.CurrentProfile = selected.SelectedProfile;
            Application.Resource.Save();

            ViewControl.ViewController.Index = -1;
            ViewControl.ViewController.Views.Clear();

            ViewControl.ViewController.OpenChild(Application.Resource.CurrentProfile.RootResource.Root);
        }
        private void OpenEditViewerMenuItem_Click(object sender, EventArgs e) {
            EditView view = new EditView(Application, GuiApplication);
            view.Show();
        }
    }
}
