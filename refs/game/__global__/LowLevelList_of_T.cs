internal class LowLevelList<T> // TypeDefIndex: 5003
{
	// Fields
	private const int _defaultCapacity = 4;
	protected T[] _items; // 0x0
	protected int _size; // 0x0
	protected int _version; // 0x0
	private static readonly T[] s_emptyArray; // 0x0

	// Properties
	public int Capacity { get; set; }
	public int Count { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102B630 Offset: 0x102A030 VA: 0x18102B630
	|-LowLevelList<object>..ctor
	|-LowLevelList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105C200 Offset: 0x105AC00 VA: 0x18105C200
	|-LowLevelList<object>..ctor
	|-LowLevelList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4AA50 Offset: 0xC49450 VA: 0x180C4AA50
	|-LowLevelList<object>.get_Capacity
	|-LowLevelList<__Il2CppFullySharedGenericType>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105C470 Offset: 0x105AE70 VA: 0x18105C470
	|-LowLevelList<object>.set_Capacity
	|-LowLevelList<__Il2CppFullySharedGenericType>.set_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	|-LowLevelList<object>.get_Count
	|-LowLevelList<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105C310 Offset: 0x105AD10 VA: 0x18105C310
	|-LowLevelList<object>.get_Item
	|
	|-RVA: 0x105C380 Offset: 0x105AD80 VA: 0x18105C380
	|-LowLevelList<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105C730 Offset: 0x105B130 VA: 0x18105C730
	|-LowLevelList<object>.set_Item
	|
	|-RVA: 0x105C5C0 Offset: 0x105AFC0 VA: 0x18105C5C0
	|-LowLevelList<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105A3F0 Offset: 0x1058DF0 VA: 0x18105A3F0
	|-LowLevelList<object>.Add
	|
	|-RVA: 0x105A480 Offset: 0x1058E80 VA: 0x18105A480
	|-LowLevelList<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	private void EnsureCapacity(int min) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105A8A0 Offset: 0x10592A0 VA: 0x18105A8A0
	|-LowLevelList<object>.EnsureCapacity
	|
	|-RVA: 0x105AA20 Offset: 0x1059420 VA: 0x18105AA20
	|-LowLevelList<__Il2CppFullySharedGenericType>.EnsureCapacity
	*/

	// RVA: -1 Offset: -1
	public void AddRange(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105A3B0 Offset: 0x1058DB0 VA: 0x18105A3B0
	|-LowLevelList<object>.AddRange
	|
	|-RVA: 0x105A3D0 Offset: 0x1058DD0 VA: 0x18105A3D0
	|-LowLevelList<__Il2CppFullySharedGenericType>.AddRange
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105A5F0 Offset: 0x1058FF0 VA: 0x18105A5F0
	|-LowLevelList<object>.Clear
	|-LowLevelList<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105A630 Offset: 0x1059030 VA: 0x18105A630
	|-LowLevelList<object>.Contains
	|
	|-RVA: 0x105A6E0 Offset: 0x10590E0 VA: 0x18105A6E0
	|-LowLevelList<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x101C800 Offset: 0x101B200 VA: 0x18101C800
	|-LowLevelList<object>.CopyTo
	|-LowLevelList<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105AA80 Offset: 0x1059480 VA: 0x18105AA80
	|-LowLevelList<object>.IndexOf
	|
	|-RVA: 0x105AAB0 Offset: 0x10594B0 VA: 0x18105AAB0
	|-LowLevelList<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105B530 Offset: 0x1059F30 VA: 0x18105B530
	|-LowLevelList<object>.Insert
	|
	|-RVA: 0x105B640 Offset: 0x105A040 VA: 0x18105B640
	|-LowLevelList<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1
	public void InsertRange(int index, IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105B050 Offset: 0x1059A50 VA: 0x18105B050
	|-LowLevelList<object>.InsertRange
	|
	|-RVA: 0x105ABC0 Offset: 0x10595C0 VA: 0x18105ABC0
	|-LowLevelList<__Il2CppFullySharedGenericType>.InsertRange
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105BFD0 Offset: 0x105A9D0 VA: 0x18105BFD0
	|-LowLevelList<object>.Remove
	|
	|-RVA: 0x105C0F0 Offset: 0x105AAF0 VA: 0x18105C0F0
	|-LowLevelList<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public int RemoveAll(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105B820 Offset: 0x105A220 VA: 0x18105B820
	|-LowLevelList<object>.RemoveAll
	|
	|-RVA: 0x105B9F0 Offset: 0x105A3F0 VA: 0x18105B9F0
	|-LowLevelList<__Il2CppFullySharedGenericType>.RemoveAll
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x105BD40 Offset: 0x105A740 VA: 0x18105BD40
	|-LowLevelList<object>.RemoveAt
	|
	|-RVA: 0x105BE00 Offset: 0x105A800 VA: 0x18105BE00
	|-LowLevelList<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102B560 Offset: 0x1029F60 VA: 0x18102B560
	|-LowLevelList<object>..cctor
	|-LowLevelList<__Il2CppFullySharedGenericType>..cctor
	*/
}
