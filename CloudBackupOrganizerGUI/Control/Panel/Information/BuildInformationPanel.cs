using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;

namespace CloudBackupOrganizerGUI {
    public class BuildInformationPanel : CustomDialogs.BuildInformationPanel {
        internal static readonly Assembly Assembly = Assembly.GetExecutingAssembly();
        internal static readonly FileVersionInfo FileVersion = FileVersionInfo.GetVersionInfo(Assembly.Location);

        public override Image Icon { get; set; } = Properties.Resources._256pxCloudOrganizerIcon.ToBitmap();

        public override string Name { get; set; } = Assembly.GetName().Name;
        public override string Version { get; set; } = FormatFileVersion(FileVersion.FileVersion);
        public override string VersionReleased { get; set; } = FileVersion.Comments;

        private static string FormatFileVersion(string version) {
            string[] n = version.Split(".");

            return $"{n[0]}.{n[1]}.{n[2]}";
        }
    }
}
