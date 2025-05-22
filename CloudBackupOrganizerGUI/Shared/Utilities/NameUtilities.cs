using System;
using CloudBackupOrganizer;
using CustomDialogs;

namespace CloudBackupOrganizerGUI {
    public static class NameUtilities {
        public static bool ValidateName(Item item, string name) {
            if (string.IsNullOrEmpty(name)) {
                CustomDialog.ShowError("Error", $"{item.GetTypeString()}'s name cannot be empty.");

                return false;
            }

            if (name.Contains("\\")) {
                CustomDialog.ShowError("Error", "The item's name cannot contain the following character: '\\'");

                return false;
            }

            return true;
        }
    }
}
