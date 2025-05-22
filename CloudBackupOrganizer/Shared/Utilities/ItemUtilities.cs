using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using CommonUtilities;
using BinaryObjectFormat;

namespace CloudBackupOrganizer {
    public static class ItemUtilities {
        public static void Export(IEnumerable<Item> items, string outputFile, string password) {
            Group group = new Group() { 
                DisplayName = "Imported items"
            };

            foreach (var item in items) {
                group.Items.Add(item);
            }

            byte[] bytes = GZip.Compress(group.Serialize().ToBytes());
            if (!string.IsNullOrEmpty(password)) {
                bytes = AesEncryption.Encrypt(bytes, Encoding.UTF8.GetBytes(password));
            }

            using (FileStream fs = File.Create(outputFile)) {
                fs.Write(new byte[] { (byte)(string.IsNullOrEmpty(password) ? 0 : 1) }, 0, 1);
                fs.Write(bytes, 0, bytes.Length);
            }
        }
    }
}
