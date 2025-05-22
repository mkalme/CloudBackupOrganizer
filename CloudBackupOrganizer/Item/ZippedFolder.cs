using System;
using System.Collections.Generic;
using BinaryObjectFormat;
using CommonUtilities;

namespace CloudBackupOrganizer {
    public class ZippedFolder : ZippedItem {
        public string FolderPath {
            get => _folderPath;
            set {
                if (_folderPath == value) return;

                _folderPath = value;
                CallContentsChanged();
            }
        }
        private string _folderPath;

        public ZippedFolder(OrganizerResource resource) : base(resource, ItemID.ZippedFolder) {
            _folderPath = "";
        }

        protected override ZOperation ProvideZOperation(string outputArchive) {
            return new ZipOperation() {
                Folders = new string[] { FolderPath },
                OutputArchivePath = outputArchive,
                Password = Password
            };
        }

        public override ObjectTag Serialize() {
            ObjectTag obj = base.Serialize();

            obj.Add("FolderPath", FolderPath);

            return obj;
        }
        public static ZippedFolder Deserialize(ObjectTag tag, OrganizerResource resource) {
            ZippedFolder item = new ZippedFolder(resource);
            item.FolderPath = tag["FolderPath"];

            item.DeserializeItem(tag);

            return item;
        }

        public override object Clone() {
            ZippedFolder folder = new ZippedFolder(Resource);
            folder.FolderPath = FolderPath;

            CloneZippedItem(folder);

            return folder;
        }
    }
}
