internal sealed class TreeDataController<T> // TypeDefIndex: 6193
{
	// Fields
	private TreeData<T> m_TreeData; // 0x0
	private Stack<IEnumerator<int>> m_IteratorStack; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void SetRootItems(IList<TreeViewItemData<T>> rootItems) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127E7E0 Offset: 0x127D1E0 VA: 0x18127E7E0
	|-TreeDataController<object>.SetRootItems
	|
	|-RVA: 0x127E780 Offset: 0x127D180 VA: 0x18127E780
	|-TreeDataController<__Il2CppFullySharedGenericType>.SetRootItems
	*/

	// RVA: -1 Offset: -1
	public T GetDataForId(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127E010 Offset: 0x127CA10 VA: 0x18127E010
	|-TreeDataController<object>.GetDataForId
	|
	|-RVA: 0x127E050 Offset: 0x127CA50 VA: 0x18127E050
	|-TreeDataController<__Il2CppFullySharedGenericType>.GetDataForId
	*/

	// RVA: -1 Offset: -1
	public int GetParentId(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127E3E0 Offset: 0x127CDE0 VA: 0x18127E3E0
	|-TreeDataController<object>.GetParentId
	|
	|-RVA: 0x127E400 Offset: 0x127CE00 VA: 0x18127E400
	|-TreeDataController<__Il2CppFullySharedGenericType>.GetParentId
	*/

	// RVA: -1 Offset: -1
	public bool HasChildren(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127E530 Offset: 0x127CF30 VA: 0x18127E530
	|-TreeDataController<object>.HasChildren
	|
	|-RVA: 0x127E420 Offset: 0x127CE20 VA: 0x18127E420
	|-TreeDataController<__Il2CppFullySharedGenericType>.HasChildren
	*/

	[IteratorStateMachine(typeof(TreeDataController.<GetItemIds>d__9<T>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<int> GetItemIds(IEnumerable<TreeViewItemData<T>> items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127E200 Offset: 0x127CC00 VA: 0x18127E200
	|-TreeDataController<object>.GetItemIds
	|
	|-RVA: 0x127E2B0 Offset: 0x127CCB0 VA: 0x18127E2B0
	|-TreeDataController<__Il2CppFullySharedGenericType>.GetItemIds
	*/

	// RVA: -1 Offset: -1
	public IEnumerable<int> GetChildrenIds(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127DE00 Offset: 0x127C800 VA: 0x18127DE00
	|-TreeDataController<object>.GetChildrenIds
	|
	|-RVA: 0x127DEE0 Offset: 0x127C8E0 VA: 0x18127DEE0
	|-TreeDataController<__Il2CppFullySharedGenericType>.GetChildrenIds
	*/

	// RVA: -1 Offset: -1
	public void Move(int id, int newParentId, int childIndex = -1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127E630 Offset: 0x127D030 VA: 0x18127E630
	|-TreeDataController<object>.Move
	|
	|-RVA: 0x127E6E0 Offset: 0x127D0E0 VA: 0x18127E6E0
	|-TreeDataController<__Il2CppFullySharedGenericType>.Move
	*/

	// RVA: -1 Offset: -1
	public bool IsChildOf(int childId, int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127E5E0 Offset: 0x127CFE0 VA: 0x18127E5E0
	|-TreeDataController<object>.IsChildOf
	|
	|-RVA: 0x127E600 Offset: 0x127D000 VA: 0x18127E600
	|-TreeDataController<__Il2CppFullySharedGenericType>.IsChildOf
	*/

	[IteratorStateMachine(typeof(TreeDataController.<GetAllItemIds>d__13<T>))]
	// RVA: -1 Offset: -1
	public IEnumerable<int> GetAllItemIds(IEnumerable<int> rootIds) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127DCA0 Offset: 0x127C6A0 VA: 0x18127DCA0
	|-TreeDataController<object>.GetAllItemIds
	|
	|-RVA: 0x127DD50 Offset: 0x127C750 VA: 0x18127DD50
	|-TreeDataController<__Il2CppFullySharedGenericType>.GetAllItemIds
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127E8C0 Offset: 0x127D2C0 VA: 0x18127E8C0
	|-TreeDataController<object>..ctor
	|
	|-RVA: 0x127E840 Offset: 0x127D240 VA: 0x18127E840
	|-TreeDataController<__Il2CppFullySharedGenericType>..ctor
	*/
}
