using System;
using System.Collections.Generic;
using BinaryObjectFormat;
using CommonUtilities;

namespace CloudBackupOrganizer {
    public class ZippedFile : ZippedItem {
        public string FilePath {
            get => _filePath;
            set {
                if (_filePath == value) return;

                _filePath = value;
                CallContentsChanged();
            }
        }
        private string _filePath;

        public ZippedFile(OrganizerResource resource) : base(resource, ItemID.ZippedFile) {
            _filePath = "";
        }

        protected override ZOperation ProvideZOperation(string outputArchive) {
            return new ZipOperation() {
                Files = new string[] { FilePath },
                OutputArchivePath = outputArchive,
                Password = Password
            };
        }

        public override ObjectTag Serialize() {
            ObjectTag obj = base.Serialize();

            obj.Add("FilePath", FilePath);

            return obj;
        }
        public static ZippedFile Deserialize(ObjectTag tag, OrganizerResource resource) {
            ZippedFile item = new ZippedFile(resource);
            item.FilePath = tag["FilePath"];

            item.DeserializeItem(tag);

            return item;
        }

        public override object Clone() {
            ZippedFolder folder = new ZippedFolder(Resource);
            folder.FolderPath = FilePath;

            CloneZippedItem(folder);

            return folder;
        }
    }
}
