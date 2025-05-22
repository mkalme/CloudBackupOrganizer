using System;
using System.Collections.Generic;
using CloudBackupOrganizer;
using CustomDialogs;

namespace CloudBackupOrganizerGUI {
    public static class ItemSelectorUtilities {
        public static InputResult<IList<object>> ShowSelector(Group group, ItemSelectorProfile profile, Func<object, bool> viewableItemValidator) {
            ViewController viewController = new ViewController(new GroupViewNode(group));
            ItemSelectionDataGridViewControl gridViewControl = new ItemSelectionDataGridViewControl(viewableItemValidator) {
                ViewController = viewController
            };

            ItemSelector selector = new ItemSelector(viewController, gridViewControl, profile);
            selector.Width += 30;
            selector.Height += 20;
            selector.ShowDialog();

            viewController.Dispose();

            return new InputResult<IList<object>>(selector.SelectedItems, selector.DialogClosed);
        }
    }
}
