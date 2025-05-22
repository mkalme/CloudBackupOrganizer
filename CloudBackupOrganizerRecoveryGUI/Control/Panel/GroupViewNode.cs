using System;
using System.Collections.Generic;
using System.Linq;
using CloudBackupOrganizerRecovery;
using CustomDialogs;

namespace CloudBackupOrganizerRecoveryGUI {
    public class GroupViewNode : IViewNode {
        public object Node => _node;
        private Group _node;

        public object Parent => _node.Parent;

        public ICollection<object> Items => _node.Items.Cast<object>().ToArray();

        public event EventHandler ContentsChanged;
        public event EventHandler Removed;

        public GroupViewNode(Group group) {
            _node = group;
        }

        public IViewNode CreateNode(object group) => new GroupViewNode(group as Group);

        public void Dispose() {

        }
    }
}
