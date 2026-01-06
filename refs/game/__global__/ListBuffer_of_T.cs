public struct ListBuffer<T> // TypeDefIndex: 13586
{
	// Fields
	private T* m_BufferPtr; // 0x0
	private int m_Capacity; // 0x0
	private int* m_CountPtr; // 0x0

	// Properties
	internal T* BufferPtr { get; }
	public int Count { get; }
	public int Capacity { get; }
	public T Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal T* get_BufferPtr() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	|-ListBuffer<__Il2CppFullySharedGenericStructType>.get_BufferPtr
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18E0910 Offset: 0x18DF310 VA: 0x1818E0910
	|-ListBuffer<__Il2CppFullySharedGenericStructType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x489DD0 Offset: 0x4887D0 VA: 0x180489DD0
	|-ListBuffer<__Il2CppFullySharedGenericStructType>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T* bufferPtr, int* countPtr, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18E0900 Offset: 0x18DF300 VA: 0x1818E0900
	|-ListBuffer<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public ref T get_Item(in int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18E0920 Offset: 0x18DF320 VA: 0x1818E0920
	|-ListBuffer<__Il2CppFullySharedGenericStructType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public ref T GetUnchecked(in int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18E02E0 Offset: 0x18DECE0 VA: 0x1818E02E0
	|-ListBuffer<__Il2CppFullySharedGenericStructType>.GetUnchecked
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(in T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18E0330 Offset: 0x18DED30 VA: 0x1818E0330
	|-ListBuffer<__Il2CppFullySharedGenericStructType>.TryAdd
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T* dstBuffer, int startDstIndex, int copyCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18E0200 Offset: 0x18DEC00 VA: 0x1818E0200
	|-ListBuffer<__Il2CppFullySharedGenericStructType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public bool TryCopyTo(ListBuffer<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18E0670 Offset: 0x18DF070 VA: 0x1818E0670
	|-ListBuffer<__Il2CppFullySharedGenericStructType>.TryCopyTo
	*/

	// RVA: -1 Offset: -1
	public bool TryCopyFrom(T* srcPtr, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18E04E0 Offset: 0x18DEEE0 VA: 0x1818E04E0
	|-ListBuffer<__Il2CppFullySharedGenericStructType>.TryCopyFrom
	*/
}
