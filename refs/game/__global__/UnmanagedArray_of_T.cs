internal struct UnmanagedArray<T> : IDisposable // TypeDefIndex: 15904
{
	// Fields
	private IntPtr m_pointer; // 0x0
	private int m_length; // 0x0
	private AllocatorManager.AllocatorHandle m_allocator; // 0x0

	// Properties
	public T Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int length, AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D6560 Offset: 0x12D4F60 VA: 0x1812D6560
	|-UnmanagedArray<__Il2CppFullySharedGenericStructType>..ctor
	|
	|-RVA: 0x12D6600 Offset: 0x12D5000 VA: 0x1812D6600
	|-UnmanagedArray<RewindableAllocator.MemoryBlock>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D64B0 Offset: 0x12D4EB0 VA: 0x1812D64B0
	|-UnmanagedArray<__Il2CppFullySharedGenericStructType>.Dispose
	|
	|-RVA: 0x12D6440 Offset: 0x12D4E40 VA: 0x1812D6440
	|-UnmanagedArray<RewindableAllocator.MemoryBlock>.Dispose
	*/

	// RVA: -1 Offset: -1
	public T* GetUnsafePointer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D6550 Offset: 0x12D4F50 VA: 0x1812D6550
	|-UnmanagedArray<__Il2CppFullySharedGenericStructType>.GetUnsafePointer
	|-UnmanagedArray<RewindableAllocator.MemoryBlock>.GetUnsafePointer
	*/

	// RVA: -1 Offset: -1
	public ref T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D6670 Offset: 0x12D5070 VA: 0x1812D6670
	|-UnmanagedArray<__Il2CppFullySharedGenericStructType>.get_Item
	|
	|-RVA: 0x12D66D0 Offset: 0x12D50D0 VA: 0x1812D66D0
	|-UnmanagedArray<RewindableAllocator.MemoryBlock>.get_Item
	*/
}
