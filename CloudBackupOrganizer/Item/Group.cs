using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using BinaryObjectFormat;

namespace CloudBackupOrganizer {
    public class Group : Item {
        public ObservableCollection<Item> Items { get; private set; }

        public string RealName {
            get => _realName;
            set {
                if (_realName == value) return;

                _realName = value;
                CallContentsChanged();
            }
        }
        private string _realName;

        public OrganizerResource Resource { get; set; }

        public event CollectionChangedHandler CollectionChanged;

        public Group() : base(ItemID.Group) {
            Items = new ObservableCollection<Item>();
            Items.CollectionChanged += Item_CollectionChanged;

            _realName = IdUtilities.GenerateID();

            Deleted += OnDeletion;
        }

        private bool _ignoreCollectionChanged = false;
        private void Item_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e) {
            if (_ignoreCollectionChanged) return;

            if (e.Action != NotifyCollectionChangedAction.Move) {
                if (e.OldItems != null) {
                    foreach (Item oldItem in e.OldItems) {
                        oldItem.ContentsChanged -= Item_ContentsChanged;
                        oldItem.Parent = null;

                        oldItem.CallDeleted();
                    }
                }

                if (e.NewItems != null) {
                    foreach (Item newItem in e.NewItems) {
                        newItem.ContentsChanged += Item_ContentsChanged;
                        newItem.Parent = this;
                    }
                }
            }

            if(e.OldItems != null) CallCollectionChanged(e.OldItems.Cast<Item>(), CollectionChangedType.Remove);
            if(e.NewItems != null) CallCollectionChanged(e.NewItems.Cast<Item>(), CollectionChangedType.Add);

            CallContentsChanged();
        }
        private void Item_ContentsChanged(object sender, EventArgs e) {
            CallContentsChanged();
        }

        private void CallCollectionChanged(IEnumerable<Item> items, CollectionChangedType collectionChangedType) {
            CollectionChanged?.Invoke(this, new CollectionChangedEventArgs(items, collectionChangedType));
        }

        private void OnDeletion(object sender, EventArgs e) {
            foreach (var item in Items) {
                item.CallDeleted();
            }
        }

        public void SwapItems(Item left, Item right) {
            Items.Move(Items.IndexOf(left), Items.IndexOf(right));
        }
        public void Move(IEnumerable<Item> children, Group newGroup) {
            foreach (var child in children) {
                Items.Remove(child);

                child.Parent = newGroup;
                newGroup.Items.Add(child);
            }
        }

        public void CreateUserSheet(string outputPath, string password, IProgress<float> progress) {
            SheetUtilities.CreateUserSheet(this, outputPath, password, progress);
        }

        public override ObjectTag Serialize() {
            ObjectTag obj = base.Serialize();

            ObjectTag[] items = new ObjectTag[Items.Count];
            for (int i = 0; i < items.Length; i++) {
                items[i] = Items[i].Serialize();
            }

            obj.Add("Items", items);
            obj.Add("RealName", RealName);

            return obj;
        }
        public static Group Deserialize(ObjectTag tag, OrganizerResource resource) {
            ObjectTag[] itemsArray = tag["Items"];

            Group group = new Group() { 
                Resource = resource,
                RealName = tag["RealName"]
            };

            foreach (var itemObj in itemsArray) {
                Item item;

                switch ((ItemID)(byte)itemObj["ID"]) {
                    case ItemID.Group:
                        item = Deserialize(itemObj, resource);
                        break;
                    case ItemID.ZippedItemBundle:
                        item = ZippedItemBundle.Deserialize(itemObj, resource);
                        break;
                    case ItemID.ZippedFolder:
                        item = ZippedFolder.Deserialize(itemObj, resource);
                        break;
                    case ItemID.ZippedFilteredFolder:
                        item = ZippedFilteredFolder.Deserialize(itemObj, resource);
                        break;
                    default:
                        item = ZippedFile.Deserialize(itemObj, resource);
                        break;
                }

                group.Items.Add(item);
            }

            group.DeserializeItem(tag);

            return group;
        }

        public override object Clone() {
            Group group = new Group();

            foreach (var item in Items) {
                group.Items.Add(item.Clone() as Item);
            }

            CloneItem(group);

            return group;
        }
    }
}
