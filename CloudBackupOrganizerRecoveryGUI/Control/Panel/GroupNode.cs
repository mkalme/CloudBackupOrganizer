using System;
using CloudBackupOrganizerRecovery;
using CustomDialogs;

namespace CloudBackupOrganizerRecoveryGUI {
    public class GroupNode : INode {
        public Group Group { get; set; }

        public INode Parent {
            get {
                if (_parent == null && Group.Parent != null) {
                    _parent = new GroupNode(Group.Parent);
                }

                return _parent;
            }
        }
        private INode _parent;

        public object Node => Group;
        public string DisplayedText => Group.DisplayName;

        public event EventHandler DisplayedTextChanged;

        public GroupNode(Group group) {
            Group = group;
        }

        public void Dispose() {

        }
    }
}
