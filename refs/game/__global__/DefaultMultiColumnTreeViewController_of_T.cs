internal class DefaultMultiColumnTreeViewController<T> : MultiColumnTreeViewController // TypeDefIndex: 6186
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
	|-RVA: 0x14E6700 Offset: 0x14E5100 VA: 0x1814E6700
	|-DefaultMultiColumnTreeViewController<object>.get_treeDataController
	|
	|-RVA: 0x14E6670 Offset: 0x14E5070 VA: 0x1814E6670
	|-DefaultMultiColumnTreeViewController<__Il2CppFullySharedGenericType>.get_treeDataController
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E6640 Offset: 0x14E5040 VA: 0x1814E6640
	|-DefaultMultiColumnTreeViewController<object>..ctor
	|-DefaultMultiColumnTreeViewController<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override IList get_itemsSource() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E6650 Offset: 0x14E5050 VA: 0x1814E6650
	|-DefaultMultiColumnTreeViewController<object>.get_itemsSource
	|-DefaultMultiColumnTreeViewController<__Il2CppFullySharedGenericType>.get_itemsSource
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override void set_itemsSource(IList value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E6790 Offset: 0x14E5190 VA: 0x1814E6790
	|-DefaultMultiColumnTreeViewController<object>.set_itemsSource
	|
	|-RVA: 0x14E6930 Offset: 0x14E5330 VA: 0x1814E6930
	|-DefaultMultiColumnTreeViewController<__Il2CppFullySharedGenericType>.set_itemsSource
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public void SetRootItems(IList<TreeViewItemData<T>> items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E65B0 Offset: 0x14E4FB0 VA: 0x1814E65B0
	|-DefaultMultiColumnTreeViewController<object>.SetRootItems
	|
	|-RVA: 0x14E6520 Offset: 0x14E4F20 VA: 0x1814E6520
	|-DefaultMultiColumnTreeViewController<__Il2CppFullySharedGenericType>.SetRootItems
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override object GetItemForIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E5F30 Offset: 0x14E4930 VA: 0x1814E5F30
	|-DefaultMultiColumnTreeViewController<object>.GetItemForIndex
	|
	|-RVA: 0x14E5FC0 Offset: 0x14E49C0 VA: 0x1814E5FC0
	|-DefaultMultiColumnTreeViewController<__Il2CppFullySharedGenericType>.GetItemForIndex
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public override int GetParentId(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E6140 Offset: 0x14E4B40 VA: 0x1814E6140
	|-DefaultMultiColumnTreeViewController<object>.GetParentId
	|
	|-RVA: 0x14E60E0 Offset: 0x14E4AE0 VA: 0x1814E60E0
	|-DefaultMultiColumnTreeViewController<__Il2CppFullySharedGenericType>.GetParentId
	*/

	// RVA: -1 Offset: -1 Slot: 26
	public override bool HasChildren(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E6200 Offset: 0x14E4C00 VA: 0x1814E6200
	|-DefaultMultiColumnTreeViewController<object>.HasChildren
	|
	|-RVA: 0x14E61A0 Offset: 0x14E4BA0 VA: 0x1814E61A0
	|-DefaultMultiColumnTreeViewController<__Il2CppFullySharedGenericType>.HasChildren
	*/

	// RVA: -1 Offset: -1 Slot: 24
	public override IEnumerable<int> GetChildrenIds(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E5E70 Offset: 0x14E4870 VA: 0x1814E5E70
	|-DefaultMultiColumnTreeViewController<object>.GetChildrenIds
	|
	|-RVA: 0x14E5ED0 Offset: 0x14E48D0 VA: 0x1814E5ED0
	|-DefaultMultiColumnTreeViewController<__Il2CppFullySharedGenericType>.GetChildrenIds
	*/

	// RVA: -1 Offset: -1 Slot: 25
	public override void Move(int id, int newParentId, int childIndex = -1, bool rebuildTree = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E6340 Offset: 0x14E4D40 VA: 0x1814E6340
	|-DefaultMultiColumnTreeViewController<object>.Move
	|
	|-RVA: 0x14E6440 Offset: 0x14E4E40 VA: 0x1814E6440
	|-DefaultMultiColumnTreeViewController<__Il2CppFullySharedGenericType>.Move
	*/

	// RVA: -1 Offset: -1
	private bool IsChildOf(int childId, int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E6260 Offset: 0x14E4C60 VA: 0x1814E6260
	|-DefaultMultiColumnTreeViewController<object>.IsChildOf
	|
	|-RVA: 0x14E62D0 Offset: 0x14E4CD0 VA: 0x1814E62D0
	|-DefaultMultiColumnTreeViewController<__Il2CppFullySharedGenericType>.IsChildOf
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public override IEnumerable<int> GetAllItemIds(IEnumerable<int> rootIds) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E5E10 Offset: 0x14E4810 VA: 0x1814E5E10
	|-DefaultMultiColumnTreeViewController<object>.GetAllItemIds
	|
	|-RVA: 0x14E5DB0 Offset: 0x14E47B0 VA: 0x1814E5DB0
	|-DefaultMultiColumnTreeViewController<__Il2CppFullySharedGenericType>.GetAllItemIds
	*/
}
