using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CloudBackupOrganizer;
using CustomDialogs;

namespace CloudBackupOrganizerGUI {
    public class GroupViewNode : IViewNode {
        public object Node => _node;
        private Group _node;

        public object Parent => _node.Parent;

        public ICollection<object> Items => _node.Items.Cast<object>().ToArray();

        public event EventHandler ContentsChanged;
        public event EventHandler Removed;

        public GroupViewNode(Group group) {
            _node = group;

            _node.ContentsChanged += Node_ContentsChanged;
            _node.Deleted += Node_Removed;
        }

        private void Node_ContentsChanged(object sender, EventArgs e) {
            ContentsChanged?.Invoke(Node, EventArgs.Empty);
        }
        private void Node_Removed(object sender, EventArgs e) {
            Removed?.Invoke(Node, EventArgs.Empty);
        }

        public IViewNode CreateNode(object group) => new GroupViewNode(group as Group);

        public void Dispose() {
            _node.ContentsChanged -= Node_ContentsChanged;
            _node.Deleted -= Node_Removed;
        }
    }
}
