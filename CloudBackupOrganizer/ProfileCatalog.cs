using System;
using System.Collections.Generic;
using CommonUtilities;

namespace CloudBackupOrganizer {
    public class ProfileCatalog {
        public IReadOnlyList<Profile> Profiles => _profiles.AsReadOnly();
        private List<Profile> _profiles = new List<Profile>();

        public Profile CurrentProfile { get; set; }

        public event EventHandler ProfileAdded;
        public event EventHandler ProfileRemoved;
        public event EventHandler ProfileModified;

        public OrganizerResource OrganizerResource { get; set; }
        public IFileCacheController ProfileController { get; set; }

        public ProfileCatalog(OrganizerResource organizerResource, IFileCacheController profileController) {
            OrganizerResource = organizerResource;
            ProfileController = profileController;
        }

        public void AddProfile(Profile profile) {
            _profiles.Add(profile);

            profile.RootResource = new GroupResource(OrganizerResource, ProfileController, profile.Id);
            profile.RootResource.Load();

            ProfileAdded?.Invoke(profile, EventArgs.Empty);
        }
        public void RemoveProfile(Profile profile) {
            _profiles.Remove(profile);
            ProfileController.RemoveCache(profile.Id);

            ProfileRemoved?.Invoke(profile, EventArgs.Empty);
        }

        public void CallProfileModified(Profile profile) {
            ProfileModified?.Invoke(profile, EventArgs.Empty);
        }
    }

    public interface ICloudProvider { 
        string Name { get; }
        
    }
}
