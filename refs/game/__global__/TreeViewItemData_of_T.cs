public struct TreeViewItemData<T> // TypeDefIndex: 6431
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly int <id>k__BackingField; // 0x0
	private readonly T m_Data; // 0x0
	private readonly IList<TreeViewItemData<T>> m_Children; // 0x0

	// Properties
	public int id { get; }
	public T data { get; }
	public IEnumerable<TreeViewItemData<T>> children { get; }
	public bool hasChildren { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public int get_id() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	|-TreeViewItemData<object>.get_id
	|
	|-RVA: 0x12886A0 Offset: 0x12870A0 VA: 0x1812886A0
	|-TreeViewItemData<__Il2CppFullySharedGenericType>.get_id
	*/

	// RVA: -1 Offset: -1
	public T get_data() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43C7B0 Offset: 0x43B1B0 VA: 0x18043C7B0
	|-TreeViewItemData<object>.get_data
	|
	|-RVA: 0x1288460 Offset: 0x1286E60 VA: 0x181288460
	|-TreeViewItemData<__Il2CppFullySharedGenericType>.get_data
	*/

	// RVA: -1 Offset: -1
	public IEnumerable<TreeViewItemData<T>> get_children() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	|-TreeViewItemData<object>.get_children
	|
	|-RVA: 0x1288410 Offset: 0x1286E10 VA: 0x181288410
	|-TreeViewItemData<__Il2CppFullySharedGenericType>.get_children
	*/

	// RVA: -1 Offset: -1
	public bool get_hasChildren() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1288540 Offset: 0x1286F40 VA: 0x181288540
	|-TreeViewItemData<object>.get_hasChildren
	|
	|-RVA: 0x12885B0 Offset: 0x1286FB0 VA: 0x1812885B0
	|-TreeViewItemData<__Il2CppFullySharedGenericType>.get_hasChildren
	*/

	// RVA: -1 Offset: -1
	internal void InsertChild(TreeViewItemData<T> child, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1287510 Offset: 0x1285F10 VA: 0x181287510
	|-TreeViewItemData<object>.InsertChild
	|
	|-RVA: 0x1287250 Offset: 0x1285C50 VA: 0x181287250
	|-TreeViewItemData<__Il2CppFullySharedGenericType>.InsertChild
	*/

	// RVA: -1 Offset: -1
	internal void RemoveChild(int childId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1287AC0 Offset: 0x12864C0 VA: 0x181287AC0
	|-TreeViewItemData<object>.RemoveChild
	|
	|-RVA: 0x1287750 Offset: 0x1286150 VA: 0x181287750
	|-TreeViewItemData<__Il2CppFullySharedGenericType>.RemoveChild
	*/

	// RVA: -1 Offset: -1
	internal int GetChildIndex(int itemId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1287060 Offset: 0x1285A60 VA: 0x181287060
	|-TreeViewItemData<object>.GetChildIndex
	|
	|-RVA: 0x1286DB0 Offset: 0x12857B0 VA: 0x181286DB0
	|-TreeViewItemData<__Il2CppFullySharedGenericType>.GetChildIndex
	*/

	// RVA: -1 Offset: -1
	internal void ReplaceChild(TreeViewItemData<T> newChild) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1288120 Offset: 0x1286B20 VA: 0x181288120
	|-TreeViewItemData<object>.ReplaceChild
	|
	|-RVA: 0x1287CB0 Offset: 0x12866B0 VA: 0x181287CB0
	|-TreeViewItemData<__Il2CppFullySharedGenericType>.ReplaceChild
	*/
}
