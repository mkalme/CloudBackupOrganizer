using System;
using System.Collections.Generic;
using CustomDialogs;

namespace CloudBackupOrganizerGUI {
    public class ExtractedGroupViewNode : IViewNode {
        public ExtractedGroup ExtractedGroup { get; set; }

        public object Node { get; private set; }
        public object Parent { get; set; }

        public ICollection<object> Items => ExtractedGroup.Items;

        public event EventHandler ContentsChanged;
        public event EventHandler Removed;

        public ExtractedGroupViewNode(ExtractedGroup group) {
            ExtractedGroup = group;

            Node = new Node() {
                Group = ExtractedGroup.Group,
                IsTop = false
            };

            ExtractedGroup.SetZippedItems();

            ExtractedGroup.ContentsChanged += Group_ContentsChanged;
            ExtractedGroup.Removed += Group_Removed;
        }

        private void Group_ContentsChanged(object sender, EventArgs e) {
            ContentsChanged?.Invoke(Node, EventArgs.Empty);
        }
        private void Group_Removed(object sender, EventArgs e) {
            Removed?.Invoke(Node, EventArgs.Empty);
        }

        public IViewNode CreateNode(object node) {
            return null;
        }

        public void Dispose() {
            ExtractedGroup.ContentsChanged -= Group_ContentsChanged;
            ExtractedGroup.Removed -= Group_Removed;
        }
    }
}
