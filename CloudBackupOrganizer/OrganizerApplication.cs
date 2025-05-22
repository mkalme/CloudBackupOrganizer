using System;
using CommonUtilities;

namespace CloudBackupOrganizer {
    public class OrganizerApplication {
        public OrganizerResource Resource { get; set; }

        public Profile CurrentProfile => Resource.CurrentProfile;
        public string ZipFilePath => Resource.ZipFilePath;

        public byte[] Key { get; set; }
        public EncryptedFileController Controller { get; set; }
        public EncryptedFileController ProfileController { get; set; }

        public OrganizerApplication(byte[] key) {
            Key = key;
            
            Controller = new EncryptedFileController() {
                Directory = "Storage",
                Key = Key
            };
            ProfileController = new EncryptedFileController() { 
                Directory = "Storage\\Profiles",
                Key = Key
            };

            Resource = new OrganizerResource(Controller, ProfileController);
            Resource.Load();
        }

        public void ChangeKey(byte[] key) {
            Key = key;
            Controller.Key = Key;
            ProfileController.Key = Key;

            Controller.SaveAll();
            ProfileController.SaveAll();
        }
    }
}
