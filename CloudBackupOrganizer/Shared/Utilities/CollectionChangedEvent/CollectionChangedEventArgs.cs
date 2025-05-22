using System;
using System.Collections.Generic;

namespace CloudBackupOrganizer {
    public class CollectionChangedEventArgs : EventArgs {
        public IEnumerable<Item> Items { get; }
        public CollectionChangedType CollectionChangeType { get; }

        public CollectionChangedEventArgs(IEnumerable<Item> items, CollectionChangedType collectionChangeType) {
            Items = items;
            CollectionChangeType = collectionChangeType;
        }
    }
}
