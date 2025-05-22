using System;
using CustomDialogs;

namespace CloudBackupOrganizerGUI {
    public class EditNode : INode {
        public object Node { get; set; }
        public INode Parent { get; set; }

        public string DisplayedText { get; set; }

        public event EventHandler DisplayedTextChanged;

        public EditNode(object node, INode parent) {
            Node = node;
            
            if (parent == null) {
                DisplayedText = CreateDisplayName(((Node)Node).Group.DisplayName);

                ((Node)Node).Group.DisplayNameChanged += DisplayNameChanged;
            } else {
                Parent = parent;
                DisplayedText = ((Node)Node).Group.DisplayName;
            }
        }

        private static string CreateDisplayName(string name) { 
            return $"{name} | Edit view";
        }

        private void DisplayNameChanged(object sender, EventArgs e) {
            DisplayedText = CreateDisplayName(((Node)Node).Group.DisplayName);
            DisplayedTextChanged?.Invoke(Node, EventArgs.Empty);
        }

        public void Dispose() {
            ((Node)Node).Group.DisplayNameChanged -= DisplayNameChanged;
        }
    }
}
