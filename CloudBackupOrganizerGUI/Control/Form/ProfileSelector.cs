using System;
using System.Windows.Forms;
using System.ComponentModel;
using CloudBackupOrganizer;
using CustomDialogs;

namespace CloudBackupOrganizerGUI {
    public partial class ProfileSelector : Form {
        public ProfileCatalog Catalog { get; set; }
        public Profile SelectedProfile { get; set; }

        private Profile _selectedProfile;

        public bool DialogClosed { get; private set; } = true;

        public ProfileSelector(ProfileCatalog catalog) {
            InitializeComponent();

            Catalog = catalog;
            SelectedProfile = catalog.CurrentProfile;
            
            _selectedProfile = SelectedProfile;
        }
        
        //Update
        private void ProfileSelector_Load(object sender, EventArgs e) {
            LoadGridView();
        }

        private void LoadGridView() {
            GridView.Rows.Clear();

            foreach (var profile in Catalog.Profiles) {
                GridView.Rows.Add(profile.Name, profile.Id, profile.CreationDate);

                DataGridViewRow row = GridView.Rows[GridView.Rows.Count - 1];
                row.Tag = profile;
                row.DisplayImage(NameCol, Properties.Resources._16pxUserProfile, 24);

                if (_selectedProfile == profile) row.Selected = true;
                if (Catalog.CurrentProfile == profile) {
                    row.DisplayImage(IdCol, Properties.Resources._16pxFavourite);
                }
            }

            if (_selectedProfile == null) GridView.ClearSelection();
        }

        //MenuStrip
        private void MenuStrip_Opening(object sender, CancelEventArgs e) {
            RenameMenuItem.Enabled = GridView.SelectedRows.Count > 0;
            DeleteMenuItem.Enabled = GridView.SelectedRows.Count > 0 && Catalog.Profiles.Count > 1;
        }

        private void AddMenuItem_Click(object sender, EventArgs e) {
            Profile profile = new Profile();
            Catalog.AddProfile(profile);

            _selectedProfile = profile;
            LoadGridView();

            RenameProfile(profile);
        }
        private void RenameMenuItem_Click(object sender, EventArgs e) {
            RenameProfile(GridView.SelectedRows[0].Tag as Profile);
        }
        private void DeleteMenuItem_Click(object sender, EventArgs e) {
            RemoveProfile(GridView.SelectedRows[0].Tag as Profile);
        }

        //Functions
        private void RenameProfile(Profile profile) {
            InputResult<string> result = CustomDialog.ShowTextInput($"Rename profile", $"Edit {profile.Name}'s name", profile.Name, Properties.Resources._64pxRename);
            if (result.DialogClosed) return;

            profile.Name = result.Value;
            Catalog.CallProfileModified(profile);

            _selectedProfile = profile;
            LoadGridView();
        }
        private void RemoveProfile(Profile profile) {
            if (!CustomDialog.ShowDeletionConfirmation()) return;

            Catalog.RemoveProfile(profile);

            if (_selectedProfile == profile) _selectedProfile = null;
            LoadGridView();
        }

        private void SelectButton_Click(object sender, EventArgs e) {
            SelectedProfile = GridView.SelectedRows.Count > 0 ? GridView.SelectedRows[0].Tag as Profile : null;
            DialogClosed = false;

            Close();
        }
    }
}
