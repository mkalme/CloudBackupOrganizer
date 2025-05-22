using System;
using System.Linq;
using System.Collections.Generic;
using CommonUtilities;
using BinaryObjectFormat;

namespace CloudBackupOrganizer {
    public class OrganizerResource : Serializeable {
        public override string ResourceName { get; set; } = "organizer";

        public ProfileCatalog ProfileCatalog { get; set; }
        public Profile CurrentProfile => ProfileCatalog.CurrentProfile;

        public string ZipFilePath { get; set; }

        public IFileCacheController Controller { get; set; }
        public IFileCacheController ProfileController { get; set; }

        public OrganizerResource(IFileCacheController controller, IFileCacheController profileController) : base(controller) {
            Controller = controller;
            ProfileController = profileController;
        }

        public override void SetDefaultState() {
            ProfileCatalog = new ProfileCatalog(this, ProfileController);
            ProfileCatalog.AddProfile(new Profile());
            ProfileCatalog.CurrentProfile = ProfileCatalog.Profiles[0];

            ZipFilePath = "7z.exe";
        }
        public override void SetState(ObjectTag obj) {
            ProfileCatalog = new ProfileCatalog(this, ProfileController);

            ObjectTag[] profiles = obj["Profiles"];
            foreach (var profileObj in profiles) {
                ProfileCatalog.AddProfile(Profile.Deserialize(profileObj));
            }

            string id = obj["CurrentProfile"];

            ProfileCatalog.CurrentProfile = ProfileCatalog.Profiles.Where(x => x.Id == id).First();
            ZipFilePath = obj["ZipFilePath"];
        }

        public override ObjectTag Serialize() {
            ObjectTag[] profiles = new ObjectTag[ProfileCatalog.Profiles.Count];
            for (int i = 0; i < ProfileCatalog.Profiles.Count; i++) {
                profiles[i] = ProfileCatalog.Profiles[i].Serialize();
            }

            return new ObjectTag() {
                { "Profiles", profiles },
                { "CurrentProfile", CurrentProfile.Id },
                { "ZipFilePath", ZipFilePath }
            };
        }
    }
}
