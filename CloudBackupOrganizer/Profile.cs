using System;
using BinaryObjectFormat;

namespace CloudBackupOrganizer {
    public class Profile {
        public string Name { get; set; }
        public GroupResource RootResource { get; set; }
        public Group Root => RootResource.Root;

        public string Id { get; private set; }
        public DateTime CreationDate { get; private set; }

        public Profile() {
            Name = "New profile";
            Id = IdUtilities.GenerateID();
            CreationDate = DateTime.Now;
        }

        public static Profile Deserialize(ObjectTag obj) {
            return new Profile() {
                Name = obj["Name"],
                Id = obj["Id"],
                CreationDate = obj["CreationDate"]
            };
        }
        public ObjectTag Serialize() {
            return new ObjectTag() {
                { "Name", Name },
                { "Id", Id },
                { "CreationDate", CreationDate }
            };
        }
    }
}
