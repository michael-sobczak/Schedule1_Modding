internal struct LargeArrayBuilder<T> // TypeDefIndex: 4990
{
	// Fields
	private readonly int _maxCapacity; // 0x0
	private T[] _first; // 0x0
	private ArrayBuilder<T[]> _buffers; // 0x0
	private T[] _current; // 0x0
	private int _index; // 0x0
	private int _count; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(bool initialize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D4EF0 Offset: 0x18D38F0 VA: 0x1818D4EF0
	|-LargeArrayBuilder<object>..ctor
	|
	|-RVA: 0x18D4F30 Offset: 0x18D3930 VA: 0x1818D4F30
	|-LargeArrayBuilder<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int maxCapacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D5060 Offset: 0x18D3A60 VA: 0x1818D5060
	|-LargeArrayBuilder<object>..ctor
	|
	|-RVA: 0x18D4FB0 Offset: 0x18D39B0 VA: 0x1818D4FB0
	|-LargeArrayBuilder<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void AddRange(IEnumerable<T> items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D3A60 Offset: 0x18D2460 VA: 0x1818D3A60
	|-LargeArrayBuilder<object>.AddRange
	|
	|-RVA: 0x18D3D10 Offset: 0x18D2710 VA: 0x1818D3D10
	|-LargeArrayBuilder<__Il2CppFullySharedGenericType>.AddRange
	*/

	// RVA: -1 Offset: -1
	private void AddWithBufferAllocation(T item, ref T[] destination, ref int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D4360 Offset: 0x18D2D60 VA: 0x1818D4360
	|-LargeArrayBuilder<object>.AddWithBufferAllocation
	|
	|-RVA: 0x18D4180 Offset: 0x18D2B80 VA: 0x1818D4180
	|-LargeArrayBuilder<__Il2CppFullySharedGenericType>.AddWithBufferAllocation
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array, int arrayIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D4950 Offset: 0x18D3350 VA: 0x1818D4950
	|-LargeArrayBuilder<object>.CopyTo
	|
	|-RVA: 0x18D4820 Offset: 0x18D3220 VA: 0x1818D4820
	|-LargeArrayBuilder<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public T[] GetBuffer(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D4BC0 Offset: 0x18D35C0 VA: 0x1818D4BC0
	|-LargeArrayBuilder<object>.GetBuffer
	|
	|-RVA: 0x18D4AB0 Offset: 0x18D34B0 VA: 0x1818D4AB0
	|-LargeArrayBuilder<__Il2CppFullySharedGenericType>.GetBuffer
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D4DA0 Offset: 0x18D37A0 VA: 0x1818D4DA0
	|-LargeArrayBuilder<object>.ToArray
	|
	|-RVA: 0x18D4C60 Offset: 0x18D3660 VA: 0x1818D4C60
	|-LargeArrayBuilder<__Il2CppFullySharedGenericType>.ToArray
	*/

	// RVA: -1 Offset: -1
	public bool TryMove(out T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D4EB0 Offset: 0x18D38B0 VA: 0x1818D4EB0
	|-LargeArrayBuilder<object>.TryMove
	|-LargeArrayBuilder<__Il2CppFullySharedGenericType>.TryMove
	*/

	// RVA: -1 Offset: -1
	private void AllocateBuffer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18D4640 Offset: 0x18D3040 VA: 0x1818D4640
	|-LargeArrayBuilder<object>.AllocateBuffer
	|
	|-RVA: 0x18D4420 Offset: 0x18D2E20 VA: 0x1818D4420
	|-LargeArrayBuilder<__Il2CppFullySharedGenericType>.AllocateBuffer
	*/
}
