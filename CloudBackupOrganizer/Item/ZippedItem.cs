using System;
using System.Collections.Generic;
using System.IO;
using BinaryObjectFormat;
using CommonUtilities;

namespace CloudBackupOrganizer {
    public abstract class ZippedItem : Item {
        public string UniqueID { get; private set; }

        public string Password {
            get => _password;
            set {
                if (_password == value) return;

                _password = value;
                CallContentsChanged();
            }
        }
        private string _password;

        public long Size {
            get => _size;
            set {
                if (_size == value) return;

                _size = value;
                CallContentsChanged();
            }
        }
        private long _size;

        public string LastZippedFile {
            get => _lastZippedFile;
            set {
                if (_lastZippedFile == value) return;

                _lastZippedFile = value;
                CallContentsChanged();
            }
        }
        private string _lastZippedFile;

        public DateTime LastZipped {
            get => _lastZipped;
            set {
                if (_lastZipped == value) return;

                _lastZipped = value;
                CallContentsChanged();
            }
        }
        private DateTime _lastZipped;

        public OrganizerResource Resource { get; set; }

        public ZippedItem(OrganizerResource resource, ItemID itemID) : base(itemID) {
            Resource = resource;

            UniqueID = IdUtilities.GenerateID();
            _password = "";
            _lastZippedFile = "";
            _lastZipped = DateTime.MinValue;
        }
        
        public void ZipFile(string outputArchive, IProgress<float> progress) {
            Zip zip = new Zip() {
                FileName = Resource.ZipFilePath
            };

            ZOperation operation = ProvideZOperation(outputArchive);
            operation.Progress = progress;

            operation.Execute(zip);

            Size = new FileInfo(outputArchive).Length;
            LastZippedFile = outputArchive;
            LastZipped = DateTime.Now;

            Resource.Save();
        }
        public void Extract(string archivePath, string outputDirectory, IProgress<float> progress) {
            Zip zip = new Zip() {
                FileName = Resource.ZipFilePath
            };
            UnzipOperation operation = new UnzipOperation() {
                ArchivePath = archivePath,
                OutputDirectory = outputDirectory,
                Password = Password,
                Progress = progress
            };

            operation.Execute(zip);
        }

        protected abstract ZOperation ProvideZOperation(string outputArchive);

        public void ChangeID(string uniqueID) {
            if (UniqueID == uniqueID) return;

            UniqueID = uniqueID;
            CallContentsChanged();
        }

        public override ObjectTag Serialize() {
            ObjectTag output =  base.Serialize();

            output.Add("UniqueID", UniqueID);
            output.Add("Password", Password);
            output.Add("Size", Size);
            output.Add("LastZippedFile", LastZippedFile);
            output.Add("LastZipped", LastZipped);

            return output;
        }
        protected override void DeserializeItem(ObjectTag tag) {
            base.DeserializeItem(tag);
            
            UniqueID = tag["UniqueID"];
            Password = tag["Password"];
            Size = tag["Size"];
            LastZippedFile = tag.ContainsKey("LastZippedFile") ? tag["LastZippedFile"] : "";
            LastZipped = tag["LastZipped"];
        }

        public override abstract object Clone();
        protected void CloneZippedItem(ZippedItem newIten) {
            newIten.Password = Password;
            newIten.LastZipped = LastZipped;
            newIten.Size = Size;
            newIten.LastZippedFile = LastZippedFile;

            base.CloneItem(newIten);
        }
    }
}
