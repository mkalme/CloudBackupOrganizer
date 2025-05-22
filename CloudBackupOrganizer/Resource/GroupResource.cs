using System;
using CommonUtilities;
using BinaryObjectFormat;

namespace CloudBackupOrganizer {
    public class GroupResource : Serializeable {
        public Group Root {
            get => _root;
            set {
                if (_root != null) _root.ContentsChanged -= Root_ContentsChanged;

                _root = value;
                _root.ContentsChanged += Root_ContentsChanged;
            }
        }
        private Group _root = null;

        public OrganizerResource OrganizerResource { get; set; }

        public override string ResourceName { get; set; }

        public event EventHandler ContentsChanged;

        public GroupResource(OrganizerResource organizerResource, IFileCacheController controller, string fileName) : base(controller) {
            OrganizerResource = organizerResource;
            ResourceName = fileName;
        }

        private void Root_ContentsChanged(object sender, EventArgs e) {
            ContentsChanged?.Invoke(this, EventArgs.Empty);
        }

        public override ObjectTag Serialize() {
            return Root.Serialize();
        }

        public override void SetDefaultState() {
            Root = new Group() {
                DisplayName = "Home"
            };
        }
        public override void SetState(ObjectTag obj) {
            Root = Group.Deserialize(obj, OrganizerResource);
        }
    }
}
