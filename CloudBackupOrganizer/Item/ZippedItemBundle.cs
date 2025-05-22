using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using BinaryObjectFormat;
using CommonUtilities;

namespace CloudBackupOrganizer {
    public class ZippedItemBundle : ZippedItem {
        public ObservableCollection<string> Folders { get; private set; }
        public ObservableCollection<string> Files { get; private set; }

        public ZippedItemBundle(OrganizerResource resource, IEnumerable<string> folders = null, IEnumerable<string> files = null) : base(resource, ItemID.ZippedItemBundle) {
            Folders = new ObservableCollection<string>(folders ?? new string[0]);
            Files = new ObservableCollection<string>(files ?? new string[0]);

            Folders.CollectionChanged += CallContentsChanged;
            Files.CollectionChanged += CallContentsChanged;
        }

        private void CallContentsChanged(object sender, EventArgs e) {
            CallContentsChanged();
        }

        protected override ZOperation ProvideZOperation(string outputArchive) {
            return new ZipOperation() { 
                Files = Files,
                Folders = Folders,
                OutputArchivePath = outputArchive,
                Password = Password
            };
        }

        public override ObjectTag Serialize() {
            ObjectTag obj = base.Serialize();

            obj.Add("Folders", Folders.ToArray());
            obj.Add("Files", Files.ToArray());

            return obj;
        }
        public static ZippedItemBundle Deserialize(ObjectTag tag, OrganizerResource resource) {
            ZippedItemBundle item = new ZippedItemBundle(resource, (string[])tag["Folders"], (string[])tag["Files"]);
            item.DeserializeItem(tag);

            return item;
        }

        public override object Clone() {
            ZippedItemBundle item = new ZippedItemBundle(Resource, Folders, Files);
            CloneZippedItem(item);

            return item;
        }
    }
}
