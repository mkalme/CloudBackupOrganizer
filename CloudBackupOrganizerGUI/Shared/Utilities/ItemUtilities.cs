using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Media;
using System.Linq;
using CloudBackupOrganizer;
using CustomDialogs;
using CommonUtilities;
using BinaryObjectFormat;

namespace CloudBackupOrganizerGUI {
    public static class ItemUtilities {
        public static void Zip(GuiApplicationInformation information, IEnumerable<Item> items) {
            List<ZippedItem> zippedItems = new List<ZippedItem>();
            items.GetZippedItems(zippedItems);

            if (zippedItems.Count < 1) return;

            ZipDirectoryForm form = new ZipDirectoryForm(information);
            form.ShowDialog();

            if (form.DialogClosed) return;

            if (zippedItems.Count < 2) {
                zippedItems[0].ApplyChangeMode();

                ProgressUtilities.ShowProgressDialog("Creating archive", progress => {
                    try {
                        Zip(zippedItems[0], form.SelectedDirectory, progress);
                    } catch (Exception e) {
                        CustomDialog.ShowError(e);
                        return;
                    }
                });

                zippedItems[0].SuspendChangeMode();

                Process.Start("explorer.exe", $"/select, \"{zippedItems[0].LastZippedFile}\"");
            } else {
                new ProgressBundleForm(zippedItems, form.SelectedDirectory).ShowDialog();
            }
        }
        public static void Zip(ZippedItem item, string outputDirectory, IProgress<float> progress) {
            if (!Directory.Exists(outputDirectory)) Directory.CreateDirectory(outputDirectory);

            string archive = $"{outputDirectory}\\{item.UniqueID}.7z";
            if (File.Exists(archive)) File.Delete(archive);

            item.ZipFile(archive, progress);
        }

        public static void Extract(ZippedItem item, string zippedFile, string outputDirectory) {
            ProgressUtilities.ShowProgressDialog("Unzipping file", progress => {
                try {
                    item.Extract(zippedFile, outputDirectory, progress);
                } catch (Exception e) {
                    CustomDialog.ShowError(e);
                }
            });
        }

        public static void EditItem(Item item) {
            if (item is Group) RenameItem(item);
            else if (item is ZippedFolder f) EditZippedFolder(f);
            else if (item is ZippedItemBundle b) EditZippedItemBundle(b);
            else if (item is ZippedFilteredFolder ff) EditZippedFilteredFolder(ff);
            else EditZippedFile(item as ZippedFile);
        }
        public static void EditZippedFolder(ZippedFolder folder) {
            ZippedFolderEditor form = new ZippedFolderEditor(folder);
            form.ShowDialog();
        }
        public static void EditZippedItemBundle(ZippedItemBundle item) {
            ZippedItemBundleEditor form = new ZippedItemBundleEditor(item);
            form.ShowDialog();
        }
        public static void EditZippedFilteredFolder(ZippedFilteredFolder folder) {
            ZippedFilteredFolderEditor form = new ZippedFilteredFolderEditor(folder);
            form.ShowDialog();
        }
        public static void EditZippedFile(ZippedFile file) {
            ZippedFileEditor form = new ZippedFileEditor(file);
            form.ShowDialog();
        }
        public static void RenameItem(Item item) {
            InputResult<string> result = CustomDialog.ShowTextInput($"Rename {item.DisplayName}", $"Edit {item.DisplayName}'s name", item.DisplayName,
                Properties.Resources._64pxRename, x => NameUtilities.ValidateName(item, x));

            if (result.DialogClosed) return;

            item.DisplayName = result.Value;
        }

        public static void ChangePassword(ZippedItem item) {
            InputResult<string> result = DialogUtilities.ShowPasswordInput(item.DisplayName, item.Password);
            if (result.DialogClosed) return;

            item.Password = result.Value;
        }
        public static void ChangeLink(Item item) {
            InputResult<string> result = DialogUtilities.ShowLinkInput(item.DisplayName, item.Link);
            if (result.DialogClosed) return;

            item.Link = result.Value;
        }
        public static void ChangeGroupRealName(Group group) {
            IdInputForm idInputForm = new IdInputForm($"{group.DisplayName}'s real name", $"Change {group.DisplayName}'s real name", group.RealName, Properties.Resources._64pxWebFolder, x => true) { 
                Generator = () => IdUtilities.GenerateID()
            };
            idInputForm.ShowDialog();
            if (idInputForm.DialogClosed) return;

            group.RealName = idInputForm.InputText;
        }
        public static void OpenInBrowser(Item item) {
            if (string.IsNullOrEmpty(item.Link)) return;

            try {
                using (Process process = new Process()) {
                    process.StartInfo.UseShellExecute = true;
                    process.StartInfo.FileName = item.Link;
                    process.Start();
                }
            } catch {
                CustomDialog.ShowError("Error", "There was an error opening the link.");
            }
        }

        public static void Paste(Group parent, IEnumerable<Item> items) {
            foreach (var item in items) {
                parent.Items.Add(item.Clone() as Item);
            }
        }

        public static void MoveItems(Group group, IEnumerable<Item> items) {
            Func<object, bool> validator = thisItem => {
                if (((Item)thisItem).ID != ItemID.Group || items.Contains((Item)thisItem)) return false;
                return true;
            };

            InputResult<IList<object>> selectionResult = ItemSelectorUtilities.ShowSelector(group, new ItemSelectorProfile() {
                SelectedItemValidator = i => !items.Contains(i as Item) && i != group
            }, validator);

            if (selectionResult.DialogClosed || selectionResult.Value.Count < 1) return;

            group.ApplyChangeMode();

            group.Move(items, selectionResult.Value[0] as Group);

            group.SuspendChangeMode();
        }
        public static void Delete(Group parent, IEnumerable<Item> items) {
            if (!CustomDialog.ShowDeletionConfirmation()) return;

            parent.ApplyChangeMode();

            foreach (var item in items) {
                parent.Items.Remove(item);
            }

            parent.SuspendChangeMode();
        }

        public static void OpenProperties(Item item) {
            if (item is Group g) {
                GroupProperties properties = new GroupProperties(g);
                properties.ShowDialog();
            } else {
                ZippedItemProperties properties = new ZippedItemProperties(item as ZippedItem);
                properties.ShowDialog();
            }
        }

        public static void ExportItems(Group parent) {
            ViewController viewController = new ViewController(new GroupViewNode(parent));
            ItemSelectionDataGridViewControl gridViewControl = new ItemSelectionDataGridViewControl(thisItem => true) {
                ViewController = viewController
            };

            InputResult<IList<object>> result = CustomDialog.ShowItemSelector(viewController, gridViewControl, new ItemSelectorProfile() {
                SelectedItemValidator = i => i != viewController.CurrentView.ViewNode.Node,
                SingleSelection = false
            });
            viewController.Dispose();
            if (result.DialogClosed) return;

            InputResult<string> pathResult = CustomDialog.ShowBrowser(BrowseType.SaveFile);
            if (pathResult.DialogClosed) return;

            Func<string, bool> keyValidator = key => {
                if (key.Length == 0) return true;
                return KeyExtensions.KeyValidator(key);
            };

            PasswordGeneratorDialogProfile profile = PasswordGeneratorDialogProfile.NewKey;
            profile.Message = "Leave empty if you don't want to encrypt.";
            profile.PasswordValidator = keyValidator;

            InputResult<string> encryptResult = CustomDialog.ShowPasswordGenerator(profile);
            if (encryptResult.DialogClosed) return;

            CloudBackupOrganizer.ItemUtilities.Export(result.Value.Cast<Item>(), pathResult.Value, encryptResult.Value);
        }
        public static void ImportItems(Group parent) {
            InputResult<string> pathResult = CustomDialog.ShowBrowser(BrowseType.OpenFile);
            if (pathResult.DialogClosed) return;

            using (FileStream fs = File.OpenRead(pathResult.Value)) {
                bool encrypted = fs.ReadByte() == 1;

                byte[] bytes = new byte[fs.Length - 1];
                fs.Read(bytes, 0, bytes.Length);

                if (encrypted) {
                    InputResult<byte[]> encryptResult = CustomDialog.ShowKeyInput(KeyExtensions.KeyValidator);
                    if (encryptResult.DialogClosed) return;

                    bytes = AesEncryption.Decrypt(bytes, encryptResult.Value);
                }

                bytes = GZip.Decompress(bytes);

                Group group = Group.Deserialize(Tag.FromBytes(bytes) as ObjectTag, parent.Resource);

                parent.Items.Add(group);
            }
        }

        public static void ShowSettings(OrganizerApplication application, GuiApplication guiApplication) {
            SettingsForm form = new SettingsForm(application, guiApplication.AppInformation);
            form.ShowDialog();
        }
        public static void ChangeKey(OrganizerApplication application, GuiApplication guiApplication) {
            InputResult<byte[]> keyResult = CustomDialog.ShowKeyInput(KeyExtensions.KeyValidator,
                "Current key", "Enter the current key");

            if (keyResult.DialogClosed) return;
            if (!keyResult.Value.KeyEquals(application.Key)) {
                CustomDialog.ShowError("Error", "The key is incorrect.");
                return;
            }

            InputResult<byte[]> newKeyResult = CustomDialog.ShowKeyGenerator();

            if (newKeyResult.DialogClosed) return;
            if (newKeyResult.Value.KeyEquals(application.Key)) {
                CustomDialog.ShowError("Error", "The key is the same.");
                return;
            }

            application.ChangeKey(newKeyResult.Value);

            guiApplication.AppInformation.KeyHistory.Add(DateTime.Now);
            guiApplication.AppInformation.Save();

            CustomDialog.ShowMessage("Key changed", "Key changed successfully.", Properties.Resources._64pxKey, SystemSounds.Exclamation);
        }
        public static void ShowInformation(GuiApplication guiApplication) {
            CustomDialog.ShowInformationViewer(new BuildInformationPanel(), new KeyInformationPanel(guiApplication), new ProgramInformationPanel(guiApplication));
        }
    }
}