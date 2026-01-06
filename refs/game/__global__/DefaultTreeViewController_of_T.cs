internal class DefaultTreeViewController<T> : TreeViewController // TypeDefIndex: 6187
{
	// Fields
	private TreeDataController<T> m_TreeDataController; // 0x0

	// Properties
	private TreeDataController<T> treeDataController { get; }
	public override IList itemsSource { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	private TreeDataController<T> get_treeDataController() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E6F10 Offset: 0x14E5910 VA: 0x1814E6F10
	|-DefaultTreeViewController<object>.get_treeDataController
	|
	|-RVA: 0x14E6E80 Offset: 0x14E5880 VA: 0x1814E6E80
	|-DefaultTreeViewController<__Il2CppFullySharedGenericType>.get_treeDataController
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override IList get_itemsSource() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E6650 Offset: 0x14E5050 VA: 0x1814E6650
	|-DefaultTreeViewController<object>.get_itemsSource
	|-DefaultTreeViewController<__Il2CppFullySharedGenericType>.get_itemsSource
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override void set_itemsSource(IList value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E70D0 Offset: 0x14E5AD0 VA: 0x1814E70D0
	|-DefaultTreeViewController<object>.set_itemsSource
	|
	|-RVA: 0x14E6FA0 Offset: 0x14E59A0 VA: 0x1814E6FA0
	|-DefaultTreeViewController<__Il2CppFullySharedGenericType>.set_itemsSource
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public void SetRootItems(IList<TreeViewItemData<T>> items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E6DE0 Offset: 0x14E57E0 VA: 0x1814E6DE0
	|-DefaultTreeViewController<object>.SetRootItems
	|
	|-RVA: 0x14E6520 Offset: 0x14E4F20 VA: 0x1814E6520
	|-DefaultTreeViewController<__Il2CppFullySharedGenericType>.SetRootItems
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override object GetItemForIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E6B20 Offset: 0x14E5520 VA: 0x1814E6B20
	|-DefaultTreeViewController<object>.GetItemForIndex
	|
	|-RVA: 0x14E5FC0 Offset: 0x14E49C0 VA: 0x1814E5FC0
	|-DefaultTreeViewController<__Il2CppFullySharedGenericType>.GetItemForIndex
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public override int GetParentId(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E6BB0 Offset: 0x14E55B0 VA: 0x1814E6BB0
	|-DefaultTreeViewController<object>.GetParentId
	|
	|-RVA: 0x14E60E0 Offset: 0x14E4AE0 VA: 0x1814E60E0
	|-DefaultTreeViewController<__Il2CppFullySharedGenericType>.GetParentId
	*/

	// RVA: -1 Offset: -1 Slot: 26
	public override bool HasChildren(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E6C10 Offset: 0x14E5610 VA: 0x1814E6C10
	|-DefaultTreeViewController<object>.HasChildren
	|
	|-RVA: 0x14E61A0 Offset: 0x14E4BA0 VA: 0x1814E61A0
	|-DefaultTreeViewController<__Il2CppFullySharedGenericType>.HasChildren
	*/

	// RVA: -1 Offset: -1 Slot: 24
	public override IEnumerable<int> GetChildrenIds(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E6AC0 Offset: 0x14E54C0 VA: 0x1814E6AC0
	|-DefaultTreeViewController<object>.GetChildrenIds
	|
	|-RVA: 0x14E5ED0 Offset: 0x14E48D0 VA: 0x1814E5ED0
	|-DefaultTreeViewController<__Il2CppFullySharedGenericType>.GetChildrenIds
	*/

	// RVA: -1 Offset: -1 Slot: 25
	public override void Move(int id, int newParentId, int childIndex = -1, bool rebuildTree = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E6CE0 Offset: 0x14E56E0 VA: 0x1814E6CE0
	|-DefaultTreeViewController<object>.Move
	|
	|-RVA: 0x14E6440 Offset: 0x14E4E40 VA: 0x1814E6440
	|-DefaultTreeViewController<__Il2CppFullySharedGenericType>.Move
	*/

	// RVA: -1 Offset: -1
	private bool IsChildOf(int childId, int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E6C70 Offset: 0x14E5670 VA: 0x1814E6C70
	|-DefaultTreeViewController<object>.IsChildOf
	|
	|-RVA: 0x14E62D0 Offset: 0x14E4CD0 VA: 0x1814E62D0
	|-DefaultTreeViewController<__Il2CppFullySharedGenericType>.IsChildOf
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public override IEnumerable<int> GetAllItemIds(IEnumerable<int> rootIds) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E6A60 Offset: 0x14E5460 VA: 0x1814E6A60
	|-DefaultTreeViewController<object>.GetAllItemIds
	|
	|-RVA: 0x14E5DB0 Offset: 0x14E47B0 VA: 0x1814E5DB0
	|-DefaultTreeViewController<__Il2CppFullySharedGenericType>.GetAllItemIds
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E6E70 Offset: 0x14E5870 VA: 0x1814E6E70
	|-DefaultTreeViewController<object>..ctor
	|-DefaultTreeViewController<__Il2CppFullySharedGenericType>..ctor
	*/
}
