using System;
using System.Globalization;
using System.Text;
using ClosedXML.Excel;
using CommonUtilities;

namespace CloudBackupOrganizerRecovery {
    public class ZippedItem : Item {
        public string UniqueID { get; init; }

        public string Password { get; set; }
        public string Link { get; set; }
        public DateTime LastZipped { get; set; }

        public static ZippedItem FromExcelRow(IXLRow row) {
            try {
                return new ZippedItem() {
                    UniqueID = row.Cell(3).GetString(),
                    PathInDrive = row.Cell(2).GetString(),
                    Password = Encoding.UTF8.GetString(Convert.FromBase64String(row.Cell(5).GetString())),
                    Link = row.Cell(6).GetString(),
                    LastZipped = DateTime.ParseExact(row.Cell(7).GetString(), "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                };
            } catch {
                return null;
            }
        }
        public void Extract(string archivePath, string outputDirectory, IProgress<float> progress, string zipExeFilePath) {
            Zip zip = new Zip() {
                FileName = zipExeFilePath
            };

            new UnzipOperation() {
                ArchivePath = archivePath,
                OutputDirectory = outputDirectory,
                Password = Password,
                Progress = progress
            }.Execute(zip);
        }
    }
}
