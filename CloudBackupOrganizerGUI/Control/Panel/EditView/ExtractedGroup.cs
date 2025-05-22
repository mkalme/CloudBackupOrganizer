using System;
using System.Collections.Generic;
using System.Linq;
using CloudBackupOrganizer;

namespace CloudBackupOrganizerGUI{
    public class ExtractedGroup : IDisposable {
        public Group Group { get; set; }
        public ICollection<object> Items { get; private set; }

        public event EventHandler ContentsChanged;
        public event EventHandler Removed;

        public ExtractedGroup(Group group) {
            Group = group;

            SetZippedItems();

            Group.CollectionChanged += Group_CollectionChanged;
            Group.ContentsChanged += Group_ContentsChanged;
            Group.Deleted += Group_Removed;
        }

        private void Group_CollectionChanged(object sender, EventArgs e) {
            SetZippedItems();
        }
        private void Group_ContentsChanged(object sender, EventArgs e) {
            ContentsChanged?.Invoke(this, EventArgs.Empty);
        }
        private void Group_Removed(object sender, EventArgs e) {
            Removed?.Invoke(this, EventArgs.Empty);
        }

        public void SetZippedItems() {
            List<Item> items = new List<Item>();
            Group.GetItems(typeof(ZippedItem), items, true);

            Items = items.Cast<object>().ToArray();
        }

        public void Dispose() {
            Group.CollectionChanged -= Group_CollectionChanged;
            Group.ContentsChanged -= Group_ContentsChanged;
            Group.Deleted -= Group_Removed;
        }
    }
}
