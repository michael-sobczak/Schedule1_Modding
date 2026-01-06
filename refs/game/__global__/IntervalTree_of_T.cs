internal class IntervalTree<T> // TypeDefIndex: 17408
{
	// Fields
	private const int kMinNodeSize = 10;
	private const int kInvalidNode = -1;
	private const long kCenterUnknown = 9223372036854775807;
	private readonly List<IntervalTree.Entry<T>> m_Entries; // 0x0
	private readonly List<IntervalTreeNode> m_Nodes; // 0x0
	[CompilerGenerated]
	private bool <dirty>k__BackingField; // 0x0

	// Properties
	public bool dirty { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public bool get_dirty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	|-IntervalTree<object>.get_dirty
	|-IntervalTree<__Il2CppFullySharedGenericType>.get_dirty
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal void set_dirty(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	|-IntervalTree<object>.set_dirty
	|-IntervalTree<__Il2CppFullySharedGenericType>.set_dirty
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x189ABE0 Offset: 0x18995E0 VA: 0x18189ABE0
	|-IntervalTree<object>.Add
	|
	|-RVA: 0x189AD60 Offset: 0x1899760 VA: 0x18189AD60
	|-IntervalTree<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void IntersectsWith(long value, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x189B4D0 Offset: 0x1899ED0 VA: 0x18189B4D0
	|-IntervalTree<object>.IntersectsWith
	|
	|-RVA: 0x189B5D0 Offset: 0x1899FD0 VA: 0x18189B5D0
	|-IntervalTree<__Il2CppFullySharedGenericType>.IntersectsWith
	*/

	// RVA: -1 Offset: -1
	public void IntersectsWithRange(long start, long end, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x189B3A0 Offset: 0x1899DA0 VA: 0x18189B3A0
	|-IntervalTree<object>.IntersectsWithRange
	|
	|-RVA: 0x189B230 Offset: 0x1899C30 VA: 0x18189B230
	|-IntervalTree<__Il2CppFullySharedGenericType>.IntersectsWithRange
	*/

	// RVA: -1 Offset: -1
	public void UpdateIntervals() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x189DF60 Offset: 0x189C960 VA: 0x18189DF60
	|-IntervalTree<object>.UpdateIntervals
	|
	|-RVA: 0x189D930 Offset: 0x189C330 VA: 0x18189D930
	|-IntervalTree<__Il2CppFullySharedGenericType>.UpdateIntervals
	*/

	// RVA: -1 Offset: -1
	private void Query(IntervalTreeNode intervalTreeNode, long value, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x189BE10 Offset: 0x189A810 VA: 0x18189BE10
	|-IntervalTree<object>.Query
	|
	|-RVA: 0x189C070 Offset: 0x189AA70 VA: 0x18189C070
	|-IntervalTree<__Il2CppFullySharedGenericType>.Query
	*/

	// RVA: -1 Offset: -1
	private void QueryRange(IntervalTreeNode intervalTreeNode, long start, long end, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x189B720 Offset: 0x189A120 VA: 0x18189B720
	|-IntervalTree<object>.QueryRange
	|
	|-RVA: 0x189B980 Offset: 0x189A380 VA: 0x18189B980
	|-IntervalTree<__Il2CppFullySharedGenericType>.QueryRange
	*/

	// RVA: -1 Offset: -1
	private void Rebuild() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x189C5D0 Offset: 0x189AFD0 VA: 0x18189C5D0
	|-IntervalTree<object>.Rebuild
	|
	|-RVA: 0x189C4E0 Offset: 0x189AEE0 VA: 0x18189C4E0
	|-IntervalTree<__Il2CppFullySharedGenericType>.Rebuild
	*/

	// RVA: -1 Offset: -1
	private int Rebuild(int start, int end) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x189C6A0 Offset: 0x189B0A0 VA: 0x18189C6A0
	|-IntervalTree<object>.Rebuild
	|
	|-RVA: 0x189CCF0 Offset: 0x189B6F0 VA: 0x18189CCF0
	|-IntervalTree<__Il2CppFullySharedGenericType>.Rebuild
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x189B1C0 Offset: 0x1899BC0 VA: 0x18189B1C0
	|-IntervalTree<object>.Clear
	|
	|-RVA: 0x189B150 Offset: 0x1899B50 VA: 0x18189B150
	|-IntervalTree<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x189E2C0 Offset: 0x189CCC0 VA: 0x18189E2C0
	|-IntervalTree<object>..ctor
	|
	|-RVA: 0x189E1E0 Offset: 0x189CBE0 VA: 0x18189E1E0
	|-IntervalTree<__Il2CppFullySharedGenericType>..ctor
	*/
}
