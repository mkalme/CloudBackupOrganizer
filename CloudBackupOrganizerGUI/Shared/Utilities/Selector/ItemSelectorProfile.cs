using System;
using CloudBackupOrganizer;
using CustomDialogs;

namespace CloudBackupOrganizerGUI {
    public class ItemSelectorProfile : CustomDialogs.ItemSelectorProfile {
        public override Func<object, bool> DoubleClickValidator => item => ((Item)item).ID != ItemID.Group;
        public override Func<object, string> ItemNameCreator => item => ((Item)item).DisplayName;
        public override Func<object, INode> NodeCreator => item => new GroupNode(item as Group);
    }
}
