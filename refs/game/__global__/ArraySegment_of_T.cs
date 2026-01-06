public struct ArraySegment<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T> // TypeDefIndex: 3597
{
	// Fields
	[CompilerGenerated]
	private static readonly ArraySegment<T> <Empty>k__BackingField; // 0x0
	private readonly T[] _array; // 0x0
	private readonly int _offset; // 0x0
	private readonly int _count; // 0x0

	// Properties
	public static ArraySegment<T> Empty { get; }
	public T[] Array { get; }
	public int Offset { get; }
	public int Count { get; }
	private T System.Collections.Generic.IList<T>.Item { get; set; }
	private T System.Collections.Generic.IReadOnlyList<T>.Item { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static ArraySegment<T> get_Empty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x165B190 Offset: 0x1659B90 VA: 0x18165B190
	|-ArraySegment<byte>.get_Empty
	|-ArraySegment<char>.get_Empty
	|-ArraySegment<__Il2CppFullySharedGenericType>.get_Empty
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x165B130 Offset: 0x1659B30 VA: 0x18165B130
	|-ArraySegment<byte>..ctor
	|-ArraySegment<char>..ctor
	|-ArraySegment<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array, int offset, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x165B0C0 Offset: 0x1659AC0 VA: 0x18165B0C0
	|-ArraySegment<byte>..ctor
	|-ArraySegment<char>..ctor
	|-ArraySegment<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T[] get_Array() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	|-ArraySegment<byte>.get_Array
	|-ArraySegment<char>.get_Array
	|-ArraySegment<__Il2CppFullySharedGenericType>.get_Array
	*/

	// RVA: -1 Offset: -1
	public int get_Offset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x489DD0 Offset: 0x4887D0 VA: 0x180489DD0
	|-ArraySegment<byte>.get_Offset
	|-ArraySegment<char>.get_Offset
	|-ArraySegment<__Il2CppFullySharedGenericType>.get_Offset
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4975D0 Offset: 0x495FD0 VA: 0x1804975D0
	|-ArraySegment<byte>.get_Count
	|-ArraySegment<char>.get_Count
	|-ArraySegment<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public ArraySegment.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x165A940 Offset: 0x1659340 VA: 0x18165A940
	|-ArraySegment<byte>.GetEnumerator
	|-ArraySegment<char>.GetEnumerator
	|
	|-RVA: 0x169CB60 Offset: 0x169B560 VA: 0x18169CB60
	|-ArraySegment<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x165AA20 Offset: 0x1659420 VA: 0x18165AA20
	|-ArraySegment<byte>.GetHashCode
	|
	|-RVA: 0x169CD10 Offset: 0x169B710 VA: 0x18169CD10
	|-ArraySegment<char>.GetHashCode
	|
	|-RVA: 0x169CC70 Offset: 0x169B670 VA: 0x18169CC70
	|-ArraySegment<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] destination, int destinationIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x165A710 Offset: 0x1659110 VA: 0x18165A710
	|-ArraySegment<byte>.CopyTo
	|-ArraySegment<char>.CopyTo
	|
	|-RVA: 0x169C8E0 Offset: 0x169B2E0 VA: 0x18169C8E0
	|-ArraySegment<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x165A7F0 Offset: 0x16591F0 VA: 0x18165A7F0
	|-ArraySegment<byte>.Equals
	|-ArraySegment<char>.Equals
	|
	|-RVA: 0x169C9D0 Offset: 0x169B3D0 VA: 0x18169C9D0
	|-ArraySegment<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1
	public bool Equals(ArraySegment<T> obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x165A7D0 Offset: 0x16591D0 VA: 0x18165A7D0
	|-ArraySegment<byte>.Equals
	|-ArraySegment<char>.Equals
	|-ArraySegment<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IList<T>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x165ADA0 Offset: 0x16597A0 VA: 0x18165ADA0
	|-ArraySegment<byte>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x169D620 Offset: 0x169C020 VA: 0x18169D620
	|-ArraySegment<char>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x169D4A0 Offset: 0x169BEA0 VA: 0x18169D4A0
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void System.Collections.Generic.IList<T>.set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x165AE70 Offset: 0x1659870 VA: 0x18165AE70
	|-ArraySegment<byte>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x169D6F0 Offset: 0x169C0F0 VA: 0x18169D6F0
	|-ArraySegment<char>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x169D7D0 Offset: 0x169C1D0 VA: 0x18169D7D0
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.Generic.IList<T>.IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x165ACB0 Offset: 0x16596B0 VA: 0x18165ACB0
	|-ArraySegment<byte>.System.Collections.Generic.IList<T>.IndexOf
	|
	|-RVA: 0x169D1A0 Offset: 0x169BBA0 VA: 0x18169D1A0
	|-ArraySegment<char>.System.Collections.Generic.IList<T>.IndexOf
	|
	|-RVA: 0x169D290 Offset: 0x169BC90 VA: 0x18169D290
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.IList<T>.Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x165AAC0 Offset: 0x16594C0 VA: 0x18165AAC0
	|-ArraySegment<byte>.System.Collections.Generic.IList<T>.Insert
	|-ArraySegment<char>.System.Collections.Generic.IList<T>.Insert
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.Generic.IList<T>.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x165AAC0 Offset: 0x16594C0 VA: 0x18165AAC0
	|-ArraySegment<byte>.System.Collections.Generic.IList<T>.RemoveAt
	|-ArraySegment<char>.System.Collections.Generic.IList<T>.RemoveAt
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private T System.Collections.Generic.IReadOnlyList<T>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x165ADA0 Offset: 0x16597A0 VA: 0x18165ADA0
	|-ArraySegment<byte>.System.Collections.Generic.IReadOnlyList<T>.get_Item
	|
	|-RVA: 0x169D620 Offset: 0x169C020 VA: 0x18169D620
	|-ArraySegment<char>.System.Collections.Generic.IReadOnlyList<T>.get_Item
	|
	|-RVA: 0x169D4A0 Offset: 0x169BEA0 VA: 0x18169D4A0
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyList<T>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	|-ArraySegment<byte>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ArraySegment<char>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private void System.Collections.Generic.ICollection<T>.Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x165AAC0 Offset: 0x16594C0 VA: 0x18165AAC0
	|-ArraySegment<byte>.System.Collections.Generic.ICollection<T>.Add
	|-ArraySegment<char>.System.Collections.Generic.ICollection<T>.Add
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private void System.Collections.Generic.ICollection<T>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x165AAC0 Offset: 0x16594C0 VA: 0x18165AAC0
	|-ArraySegment<byte>.System.Collections.Generic.ICollection<T>.Clear
	|-ArraySegment<char>.System.Collections.Generic.ICollection<T>.Clear
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<T>.Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x165AAD0 Offset: 0x16594D0 VA: 0x18165AAD0
	|-ArraySegment<byte>.System.Collections.Generic.ICollection<T>.Contains
	|
	|-RVA: 0x169CFB0 Offset: 0x169B9B0 VA: 0x18169CFB0
	|-ArraySegment<char>.System.Collections.Generic.ICollection<T>.Contains
	|
	|-RVA: 0x169CDB0 Offset: 0x169B7B0 VA: 0x18169CDB0
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private bool System.Collections.Generic.ICollection<T>.Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x165ABC0 Offset: 0x16595C0 VA: 0x18165ABC0
	|-ArraySegment<byte>.System.Collections.Generic.ICollection<T>.Remove
	|-ArraySegment<char>.System.Collections.Generic.ICollection<T>.Remove
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x165ABE0 Offset: 0x16595E0 VA: 0x18165ABE0
	|-ArraySegment<byte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-ArraySegment<char>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x169D0A0 Offset: 0x169BAA0 VA: 0x18169D0A0
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x165ABE0 Offset: 0x16595E0 VA: 0x18165ABE0
	|-ArraySegment<byte>.System.Collections.IEnumerable.GetEnumerator
	|-ArraySegment<char>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x169D0A0 Offset: 0x169BAA0 VA: 0x18169D0A0
	|-ArraySegment<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private void ThrowInvalidOperationIfDefault() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x165AF50 Offset: 0x1659950 VA: 0x18165AF50
	|-ArraySegment<byte>.ThrowInvalidOperationIfDefault
	|-ArraySegment<char>.ThrowInvalidOperationIfDefault
	|-ArraySegment<__Il2CppFullySharedGenericType>.ThrowInvalidOperationIfDefault
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x165AF70 Offset: 0x1659970 VA: 0x18165AF70
	|-ArraySegment<byte>..cctor
	|-ArraySegment<char>..cctor
	|-ArraySegment<__Il2CppFullySharedGenericType>..cctor
	*/
}
