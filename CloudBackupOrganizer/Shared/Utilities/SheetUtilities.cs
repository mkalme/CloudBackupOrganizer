using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ClosedXML.Excel;
using CommonUtilities;

namespace CloudBackupOrganizer {
    public static class SheetUtilities {
        public static void CreateUserSheet(Group group, string outputPath, string password, IProgress<float> progress) {
            using (XLWorkbook workbook = new XLWorkbook()) {
                IXLWorksheet worksheet = workbook.Worksheets.Add("Data");
                AddToWorksheet(worksheet, group);

                string xlPath = $"{Path.GetDirectoryName(outputPath)}\\{Path.GetFileNameWithoutExtension(outputPath)}.xlsx";
                workbook.SaveAs(xlPath);

                Zip zip = new Zip() {
                    FileName = group.Resource.ZipFilePath
                };

                ZipOperation operation = new ZipOperation() { 
                    Files = new string[] { xlPath },
                    OutputArchivePath = outputPath,
                    Password = password,
                    Progress = progress
                };
                operation.Execute(zip);

                File.Delete(xlPath);
            }
        }
        private static void AddToWorksheet(IXLWorksheet sheet, Group group) {
            List<ZippedItem> items = new List<ZippedItem>();
            group.GetAllZippedItems(items);
            
            string[][] cells = new string[items.Count + 1][];
            cells[0] = new string[] { "Name", "Path in drive", "ID", "Password", "Base64 string password", "Link", "Last zipped" };

            for (int i = 0; i < items.Count; i++) {
                ZippedItem item = items[i];

                cells[i + 1] = new string[] {
                    item.DisplayName,
                    item.GetPathInDrive(),
                    item.UniqueID,
                    item.Password,
                    Convert.ToBase64String(Encoding.UTF8.GetBytes(item.Password)),
                    item.Link,
                    item.LastZipped.ToString()
                };
            }

            AddCellsToWorksheet(sheet, cells);

            sheet.Columns().AdjustToContents();
        }
        private static void AddCellsToWorksheet(IXLWorksheet sheet, string[][] cells) {
            for (int row = 0; row < cells.Length; row++) {
                for (int column = 0; column < cells[row].Length; column++) {
                    IXLCell cell = sheet.Cell(row + 1, column + 1);

                    cell.Value = cells[row][column];
                    cell.Style.Font.Bold = row == 0;
                }
            }
        }
    }
}
