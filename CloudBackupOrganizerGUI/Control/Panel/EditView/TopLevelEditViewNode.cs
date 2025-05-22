using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using CloudBackupOrganizer;
using CustomDialogs;

namespace CloudBackupOrganizerGUI {
    public class TopLevelEditViewNode : IViewNode {
        public object Node { get; }
        public object Parent { get; }

        public ICollection<object> Items {
            get {
                List<object> output = new List<object>();

                foreach (var group in _groups) {
                    if(group.Items.Count > 0) output.Add(group.Group);
                }

                return output.OrderBy(x => Path.GetDirectoryName(((Group)x).GetPathInDrive())).ToArray();
            }
        }

        public event EventHandler ContentsChanged;
        public event EventHandler Removed;

        private IList<ExtractedGroup> _groups;

        public TopLevelEditViewNode(Group group) {
            Node = new Node() {
                Group = group,
                IsTop = true
            };

            _groups = new List<ExtractedGroup>();
            ExtractAllGroups(group, _groups);
            ApplyEventHandlers(_groups);
        }

        public static void ExtractAllGroups(Group group, IList<ExtractedGroup> output) {
            foreach (var item in group.Items) {
                if (item is Group g) {
                    ExtractAllGroups(g, output);
                }
            }

            output.Add(new ExtractedGroup(group));
        }

        private void ExtractedGroup_Removed(object sender, EventArgs e) {
            ExtractedGroup group = _groups.Where(x => x == sender).First();

            group.Removed -= ExtractedGroup_Removed;
            group.Group.CollectionChanged -= ExtractedGroup_CollectionChanged;
            group.ContentsChanged -= ExtractedGroup_ContentsChanged;

            _groups.Remove(group);
            group.Dispose();

            ContentsChanged?.Invoke(Node, EventArgs.Empty);
        }
        private void ExtractedGroup_CollectionChanged(object sender, CollectionChangedEventArgs e) {
            bool update = false;
            
            foreach (var item in e.Items) {
                if (e.CollectionChangeType == CollectionChangedType.Add && item is Group g) {
                    List<ExtractedGroup> groups = new List<ExtractedGroup>();
                    ExtractAllGroups(g, groups);
                    ApplyEventHandlers(groups);

                    foreach (var group in groups) {
                        _groups.Add(group);
                    }

                    update = true;
                }
            }

            if (update) ContentsChanged?.Invoke(Node, EventArgs.Empty);
        }
        private void ExtractedGroup_ContentsChanged(object sender, EventArgs e) {
            ContentsChanged?.Invoke(Node, EventArgs.Empty);
        }

        private void ApplyEventHandlers(IList<ExtractedGroup> groups) {
            foreach (var group in groups) {
                group.Removed += ExtractedGroup_Removed;
                group.Group.CollectionChanged += ExtractedGroup_CollectionChanged;
                group.ContentsChanged += ExtractedGroup_ContentsChanged;
            }
        }

        public IViewNode CreateNode(object node) {
            ExtractedGroupViewNode viewNode = new ExtractedGroupViewNode(_groups.Where(x => x.Group == node).First());
            viewNode.Parent = Node;

            return viewNode;
        }

        public void Dispose() {
            foreach (var group in _groups) {
                group.Removed -= ExtractedGroup_Removed;
                group.Group.CollectionChanged -= ExtractedGroup_CollectionChanged;
                group.ContentsChanged -= ExtractedGroup_ContentsChanged;

                group.Dispose();
            }
        }
    }
}
