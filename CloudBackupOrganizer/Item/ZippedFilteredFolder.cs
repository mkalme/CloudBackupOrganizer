using System;
using BinaryObjectFormat;
using CommonUtilities;

namespace CloudBackupOrganizer {
    public class ZippedFilteredFolder : ZippedItem {
        public string FolderPath {
            get => _folderPath;
            set {
                if (_folderPath == value) return;

                _folderPath = value;
                CallContentsChanged();
            }
        }
        private string _folderPath;

        public string Filter {
            get => _filter;
            set {
                if (_filter == value) return;

                _filter = value;
                CallContentsChanged();
            }
        }
        private string _filter;

        public bool Exclude {
            get => _exclude;
            set {
                if (_exclude == value) return;

                _exclude = value;
                CallContentsChanged();
            }
        }
        private bool _exclude;

        public bool CaseSensitive {
            get => _caseSensitive;
            set {
                if (_caseSensitive == value) return;

                _caseSensitive = value;
                CallContentsChanged();
            }
        }
        private bool _caseSensitive;

        public ZippedFilteredFolder(OrganizerResource resource) : base(resource, ItemID.ZippedFilteredFolder) {
            _folderPath = "";
            _filter = "*";
            _exclude = false;
            _caseSensitive = false;
        }

        protected override ZOperation ProvideZOperation(string outputArchive) {
            return new FilteredZipOperation() {
                FolderPath = FolderPath,
                Filter = Filter,
                Exclude = Exclude,
                CaseSensitive = CaseSensitive,
                OutputArchivePath = outputArchive,
                Password = Password
            };
        }

        public override ObjectTag Serialize() {
            ObjectTag obj = base.Serialize();

            obj.Add("FolderPath", FolderPath);
            obj.Add("Filter", Filter);
            obj.Add("Exclude", Exclude);
            obj.Add("CaseSensitive", CaseSensitive);

            return obj;
        }
        public static ZippedFilteredFolder Deserialize(ObjectTag tag, OrganizerResource resource) {
            ZippedFilteredFolder item = new ZippedFilteredFolder(resource);
            item.FolderPath = tag["FolderPath"];
            item.Filter = tag["Filter"];
            item.Exclude = tag["Exclude"];
            item.CaseSensitive = tag["CaseSensitive"];

            item.DeserializeItem(tag);

            return item;
        }

        public override object Clone() {
            ZippedFilteredFolder folder = new ZippedFilteredFolder(Resource);
            folder.FolderPath = FolderPath;
            folder.Filter = Filter;
            folder.Exclude = Exclude;

            CloneZippedItem(folder);

            return folder;
        }
    }
}
