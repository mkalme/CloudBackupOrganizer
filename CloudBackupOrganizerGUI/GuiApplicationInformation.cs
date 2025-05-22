using System;
using System.Collections.Generic;
using System.Linq;
using BinaryObjectFormat;
using CommonUtilities;

namespace CloudBackupOrganizerGUI {
    public class GuiApplicationInformation : Serializeable {
        public DateTime Created { get; set; }
        public IList<DateTime> KeyHistory { get; set; }
        public string DefaultZipOutputDirectory { get; set; }
        public int DefaultPasswordLength { get; set; }

        public override string ResourceName { get; set; } = "App";

        public GuiApplicationInformation(IFileCacheController controller) : base(controller) { }

        public override ObjectTag Serialize() {
            return new ObjectTag() {
                { "Created", Created },
                { "KeyHistory", KeyHistory.ToArray() },
                { "DefaultZipOutputDirectory", DefaultZipOutputDirectory },
                { "DefaultPasswordLength", DefaultPasswordLength }
            };
        }

        public override void SetDefaultState() {
            Created = DateTime.Now;
            KeyHistory = new List<DateTime>() { DateTime.Now };
            DefaultZipOutputDirectory = "D:\\CloudBackupOrganizer Zipped files";
            DefaultPasswordLength = 0;
        }
        public override void SetState(ObjectTag obj) {
            Created = obj["Created"];
            KeyHistory = new List<DateTime>((DateTime[])obj["KeyHistory"]);
            DefaultZipOutputDirectory = obj["DefaultZipOutputDirectory"];
            DefaultPasswordLength = obj["DefaultPasswordLength"];
        }
    }
}
