internal struct TreeData<T> // TypeDefIndex: 6428
{
	// Fields
	private readonly IList<int> m_RootItemIds; // 0x0
	private readonly Dictionary<int, TreeViewItemData<T>> m_Tree; // 0x0
	private readonly Dictionary<int, int> m_ParentIds; // 0x0
	private readonly Dictionary<int, List<int>> m_ChildrenIds; // 0x0

	// Properties
	public IEnumerable<int> rootItemIds { get; }

	// Methods

	// RVA: -1 Offset: -1
	public IEnumerable<int> get_rootItemIds() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	|-TreeData<object>.get_rootItemIds
	|-TreeData<__Il2CppFullySharedGenericType>.get_rootItemIds
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IList<TreeViewItemData<T>> rootItems) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1281A80 Offset: 0x1280480 VA: 0x181281A80
	|-TreeData<object>..ctor
	|
	|-RVA: 0x1281C30 Offset: 0x1280630 VA: 0x181281C30
	|-TreeData<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public TreeViewItemData<T> GetDataForId(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1280130 Offset: 0x127EB30 VA: 0x181280130
	|-TreeData<object>.GetDataForId
	|
	|-RVA: 0x1280200 Offset: 0x127EC00 VA: 0x181280200
	|-TreeData<__Il2CppFullySharedGenericType>.GetDataForId
	*/

	// RVA: -1 Offset: -1
	public int GetParentId(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1280450 Offset: 0x127EE50 VA: 0x181280450
	|-TreeData<object>.GetParentId
	|
	|-RVA: 0x12803E0 Offset: 0x127EDE0 VA: 0x1812803E0
	|-TreeData<__Il2CppFullySharedGenericType>.GetParentId
	*/

	// RVA: -1 Offset: -1
	public void Move(int id, int newParentId, int childIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1280AA0 Offset: 0x127F4A0 VA: 0x181280AA0
	|-TreeData<object>.Move
	|
	|-RVA: 0x1280600 Offset: 0x127F000 VA: 0x181280600
	|-TreeData<__Il2CppFullySharedGenericType>.Move
	*/

	// RVA: -1 Offset: -1
	public bool HasAncestor(int childId, int ancestorId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12804C0 Offset: 0x127EEC0 VA: 0x1812804C0
	|-TreeData<object>.HasAncestor
	|
	|-RVA: 0x1280540 Offset: 0x127EF40 VA: 0x181280540
	|-TreeData<__Il2CppFullySharedGenericType>.HasAncestor
	*/

	// RVA: -1 Offset: -1
	private void AddItemToParent(TreeViewItemData<T> item, int parentId, int childIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127E940 Offset: 0x127D340 VA: 0x18127E940
	|-TreeData<object>.AddItemToParent
	|
	|-RVA: 0x127EC20 Offset: 0x127D620 VA: 0x18127EC20
	|-TreeData<__Il2CppFullySharedGenericType>.AddItemToParent
	*/

	// RVA: -1 Offset: -1
	private void RemoveFromParent(int id, int parentId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1281010 Offset: 0x127FA10 VA: 0x181281010
	|-TreeData<object>.RemoveFromParent
	|
	|-RVA: 0x12811E0 Offset: 0x127FBE0 VA: 0x1812811E0
	|-TreeData<__Il2CppFullySharedGenericType>.RemoveFromParent
	*/

	// RVA: -1 Offset: -1
	private void UpdateParentTree(TreeViewItemData<T> current) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1281510 Offset: 0x127FF10 VA: 0x181281510
	|-TreeData<object>.UpdateParentTree
	|
	|-RVA: 0x12816E0 Offset: 0x12800E0 VA: 0x1812816E0
	|-TreeData<__Il2CppFullySharedGenericType>.UpdateParentTree
	*/

	// RVA: -1 Offset: -1
	private void RefreshTree(IList<TreeViewItemData<T>> rootItems) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1280EF0 Offset: 0x127F8F0 VA: 0x181280EF0
	|-TreeData<object>.RefreshTree
	|
	|-RVA: 0x1280D70 Offset: 0x127F770 VA: 0x181280D70
	|-TreeData<__Il2CppFullySharedGenericType>.RefreshTree
	*/

	// RVA: -1 Offset: -1
	private void BuildTree(IEnumerable<TreeViewItemData<T>> items, bool isRoot) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127F1B0 Offset: 0x127DBB0 VA: 0x18127F1B0
	|-TreeData<object>.BuildTree
	|
	|-RVA: 0x127F7E0 Offset: 0x127E1E0 VA: 0x18127F7E0
	|-TreeData<__Il2CppFullySharedGenericType>.BuildTree
	*/
}
