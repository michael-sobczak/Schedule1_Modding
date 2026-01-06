public struct InputControlList<TControl> : IList<TControl>, ICollection<TControl>, IEnumerable<TControl>, IEnumerable, IReadOnlyList<TControl>, IReadOnlyCollection<TControl>, IDisposable // TypeDefIndex: 7355
{
	// Fields
	private int m_Count; // 0x0
	private NativeArray<ulong> m_Indices; // 0x0
	private readonly Allocator m_Allocator; // 0x0
	private const ulong kInvalidIndex = 18446744073709551615;

	// Properties
	public int Count { get; }
	public int Capacity { get; set; }
	public bool IsReadOnly { get; }
	public TControl Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 19
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	|-InputControlList<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x186FC50 Offset: 0x186E650 VA: 0x18186FC50
	|-InputControlList<object>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x186FD90 Offset: 0x186E790 VA: 0x18186FD90
	|-InputControlList<object>.set_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-InputControlList<object>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public TControl get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x186FC90 Offset: 0x186E690 VA: 0x18186FC90
	|-InputControlList<object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, TControl value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x186FE90 Offset: 0x186E890 VA: 0x18186FE90
	|-InputControlList<object>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Allocator allocator, int initialCapacity = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x186F9D0 Offset: 0x186E3D0 VA: 0x18186F9D0
	|-InputControlList<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<TControl> values, Allocator allocator = 4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x186F660 Offset: 0x186E060 VA: 0x18186F660
	|-InputControlList<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(TControl[] values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x186FA30 Offset: 0x186E430 VA: 0x18186FA30
	|-InputControlList<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Resize(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x186EF50 Offset: 0x186D950 VA: 0x18186EF50
	|-InputControlList<object>.Resize
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(TControl item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x186E4F0 Offset: 0x186CEF0 VA: 0x18186E4F0
	|-InputControlList<object>.Add
	*/

	// RVA: -1 Offset: -1
	public void AddSlice<TList>(TList list, int count = -1, int destinationIndex = -1, int sourceIndex = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC69B0 Offset: 0xDC53B0 VA: 0x180DC69B0
	|-InputControlList<object>.AddSlice<ReadOnlyArray<object>>
	|
	|-RVA: 0xDC6420 Offset: 0xDC4E20 VA: 0x180DC6420
	|-InputControlList<object>.AddSlice<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void AddRange(IEnumerable<TControl> list, int count = -1, int destinationIndex = -1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x186E0B0 Offset: 0x186CAB0 VA: 0x18186E0B0
	|-InputControlList<object>.AddRange
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(TControl item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x186EE80 Offset: 0x186D880 VA: 0x18186EE80
	|-InputControlList<object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x186ED70 Offset: 0x186D770 VA: 0x18186ED70
	|-InputControlList<object>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(TControl[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x186E8C0 Offset: 0x186D2C0 VA: 0x18186E8C0
	|-InputControlList<object>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(TControl item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x186ED10 Offset: 0x186D710 VA: 0x18186ED10
	|-InputControlList<object>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(TControl item, int startIndex, int count = -1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x186EB70 Offset: 0x186D570 VA: 0x18186EB70
	|-InputControlList<object>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, TControl item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x186E8C0 Offset: 0x186D2C0 VA: 0x18186E8C0
	|-InputControlList<object>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x186E7B0 Offset: 0x186D1B0 VA: 0x18186E7B0
	|-InputControlList<object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(TControl item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x186E840 Offset: 0x186D240 VA: 0x18186E840
	|-InputControlList<object>.Contains
	*/

	// RVA: -1 Offset: -1
	public bool Contains(TControl item, int startIndex, int count = -1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x186E7C0 Offset: 0x186D1C0 VA: 0x18186E7C0
	|-InputControlList<object>.Contains
	*/

	// RVA: -1 Offset: -1
	public void SwapElements(int index1, int index2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x186F0F0 Offset: 0x186DAF0 VA: 0x18186F0F0
	|-InputControlList<object>.SwapElements
	*/

	// RVA: -1 Offset: -1
	public void Sort<TCompare>(int startIndex, int count, TCompare comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC6EC0 Offset: 0xDC58C0 VA: 0x180DC6EC0
	|-InputControlList<object>.Sort<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xDC6CD0 Offset: 0xDC56D0 VA: 0x180DC6CD0
	|-InputControlList<object>.Sort<InputUser.CompareDevicesByUserAccount>
	*/

	// RVA: -1 Offset: -1
	public TControl[] ToArray(bool dispose = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x186F230 Offset: 0x186DC30 VA: 0x18186F230
	|-InputControlList<object>.ToArray
	*/

	// RVA: -1 Offset: -1
	internal void AppendTo(ref TControl[] array, ref int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x186E600 Offset: 0x186D000 VA: 0x18186E600
	|-InputControlList<object>.AppendTo
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x186E900 Offset: 0x186D300 VA: 0x18186E900
	|-InputControlList<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<TControl> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x186EAC0 Offset: 0x186D4C0 VA: 0x18186EAC0
	|-InputControlList<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x186F1F0 Offset: 0x186DBF0 VA: 0x18186F1F0
	|-InputControlList<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x186F510 Offset: 0x186DF10 VA: 0x18186F510
	|-InputControlList<object>.ToString
	*/

	// RVA: -1 Offset: -1
	private static ulong ToIndex(TControl control) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x186F470 Offset: 0x186DE70 VA: 0x18186F470
	|-InputControlList<object>.ToIndex
	*/

	// RVA: -1 Offset: -1
	private static TControl FromIndex(ulong index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x186E960 Offset: 0x186D360 VA: 0x18186E960
	|-InputControlList<object>.FromIndex
	*/
}
