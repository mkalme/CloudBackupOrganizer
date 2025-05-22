using System;
using BinaryObjectFormat;

namespace CloudBackupOrganizer {
    public abstract class Item : ICloneable {
        public ItemID ID { get; }
        public Group Parent { get; internal set; }

        public string DisplayName {
            get => _displayName;
            set {
                if (_displayName == value) return;

                _displayName = value;
                CallContentsChanged();
                CallDisplayNameChanged();
            }
        }
        private string _displayName;

        public string Link {
            get => _link;
            set {
                if (_link == value) return;

                _link = value;
                CallContentsChanged();
            }
        }
        private string _link;

        public event EventHandler ContentsChanged;
        public event EventHandler DisplayNameChanged;
        public event EventHandler Deleted;

        private bool _changeMode = false;
        private bool _updateInChangeMode = false;

        public Item(ItemID id) {
            ID = id;
            _displayName = "";
            _link = "";
        }

        internal void CallContentsChanged() {
            if (_changeMode) {
                _updateInChangeMode = true;
                return;
            }

            ContentsChanged?.Invoke(this, EventArgs.Empty);
        }
        internal void CallDisplayNameChanged() {
            if (_changeMode) {
                _updateInChangeMode = true;
                return;
            }

            DisplayNameChanged?.Invoke(this, EventArgs.Empty);
        }
        internal void CallDeleted() {
            Deleted?.Invoke(this, EventArgs.Empty);
        }

        public void ApplyChangeMode() {
            _changeMode = true;
            _updateInChangeMode = false;
        }
        public void SuspendChangeMode() {
            _changeMode = false;
            
            if (_updateInChangeMode) {
                _updateInChangeMode = false;
                CallContentsChanged();
            }
        }

        public virtual ObjectTag Serialize() {
            return new ObjectTag() {
                { "ID", (byte)ID },
                { "DisplayName", DisplayName },
                { "Link", Link }
            };
        }
        protected virtual void DeserializeItem(ObjectTag tag) {
            DisplayName = tag["DisplayName"];
            Link = tag["Link"];
        }

        public abstract object Clone();
        protected virtual void CloneItem(Item newIten) {
            newIten.DisplayName = DisplayName;
            newIten.Link = Link;
        }
    }
}
