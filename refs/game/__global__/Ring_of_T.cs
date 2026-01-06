public class Ring<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 10444
{
	// Fields
	private readonly List<T> mList; // 0x0
	[CompilerGenerated]
	private int <Size>k__BackingField; // 0x0
	private int mIndex; // 0x0

	// Properties
	public int Size { get; set; }
	public T Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public int get_Size() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	|-Ring<long>.get_Size
	|-Ring<__Il2CppFullySharedGenericType>.get_Size
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_Size(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49D810 Offset: 0x49C210 VA: 0x18049D810
	|-Ring<long>.set_Size
	|-Ring<__Il2CppFullySharedGenericType>.set_Size
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11AF1E0 Offset: 0x11ADBE0 VA: 0x1811AF1E0
	|-Ring<long>..ctor
	|
	|-RVA: 0x11AF270 Offset: 0x11ADC70 VA: 0x1811AF270
	|-Ring<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11AEB30 Offset: 0x11AD530 VA: 0x1811AEB30
	|-Ring<long>.Add
	|
	|-RVA: 0x11AE920 Offset: 0x11AD320 VA: 0x1811AE920
	|-Ring<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11AEC10 Offset: 0x11AD610 VA: 0x1811AEC10
	|-Ring<long>.Clear
	|
	|-RVA: 0x11AEC40 Offset: 0x11AD640 VA: 0x1811AEC40
	|-Ring<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11AEF20 Offset: 0x11AD920 VA: 0x1811AEF20
	|-Ring<long>.IndexOf
	|
	|-RVA: 0x11AEF50 Offset: 0x11AD950 VA: 0x1811AEF50
	|-Ring<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11AF040 Offset: 0x11ADA40 VA: 0x1811AF040
	|-Ring<long>.Insert
	|-Ring<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11AF080 Offset: 0x11ADA80 VA: 0x1811AF080
	|-Ring<long>.RemoveAt
	|-Ring<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11AF3F0 Offset: 0x11ADDF0 VA: 0x1811AF3F0
	|-Ring<long>.get_Item
	|
	|-RVA: 0x11AF320 Offset: 0x11ADD20 VA: 0x1811AF320
	|-Ring<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11AF520 Offset: 0x11ADF20 VA: 0x1811AF520
	|-Ring<long>.set_Item
	|
	|-RVA: 0x11AF420 Offset: 0x11ADE20 VA: 0x1811AF420
	|-Ring<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public IEnumerator GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11AEEB0 Offset: 0x11AD8B0 VA: 0x1811AEEB0
	|-Ring<long>.GetEnumerator
	|
	|-RVA: 0x11AEE00 Offset: 0x11AD800 VA: 0x1811AEE00
	|-Ring<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11AEC80 Offset: 0x11AD680 VA: 0x1811AEC80
	|-Ring<long>.Contains
	|
	|-RVA: 0x11AECB0 Offset: 0x11AD6B0 VA: 0x1811AECB0
	|-Ring<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11AEDD0 Offset: 0x11AD7D0 VA: 0x1811AEDD0
	|-Ring<long>.CopyTo
	|
	|-RVA: 0x11AEDA0 Offset: 0x11AD7A0 VA: 0x1811AEDA0
	|-Ring<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4AA50 Offset: 0xC49450 VA: 0x180C4AA50
	|-Ring<long>.get_Count
	|
	|-RVA: 0x10EB270 Offset: 0x10E9C70 VA: 0x1810EB270
	|-Ring<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC9ED0 Offset: 0xFC88D0 VA: 0x180FC9ED0
	|-Ring<long>.get_IsReadOnly
	|-Ring<__Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11AF0C0 Offset: 0x11ADAC0 VA: 0x1811AF0C0
	|-Ring<long>.Remove
	|
	|-RVA: 0x11AF0F0 Offset: 0x11ADAF0 VA: 0x1811AF0F0
	|-Ring<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859A0 Offset: 0x10843A0 VA: 0x1810859A0
	|-Ring<long>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-Ring<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/
}
