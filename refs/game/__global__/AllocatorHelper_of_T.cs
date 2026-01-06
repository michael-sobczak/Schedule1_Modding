public struct AllocatorHelper<T> : IDisposable // TypeDefIndex: 15726
{
	// Fields
	private readonly T* m_allocator; // 0x0
	private AllocatorManager.AllocatorHandle m_backingAllocator; // 0x0

	// Properties
	public T Allocator { get; }

	// Methods

	// RVA: -1 Offset: -1
	public ref T get_Allocator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1580B30 Offset: 0x157F530 VA: 0x181580B30
	|-AllocatorHelper<__Il2CppFullySharedGenericStructType>.get_Allocator
	*/

	[NotBurstCompatible]
	// RVA: -1 Offset: -1
	public void .ctor(AllocatorManager.AllocatorHandle backingAllocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1580A20 Offset: 0x157F420 VA: 0x181580A20
	|-AllocatorHelper<__Il2CppFullySharedGenericStructType>..ctor
	*/

	[NotBurstCompatible]
	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1580920 Offset: 0x157F320 VA: 0x181580920
	|-AllocatorHelper<__Il2CppFullySharedGenericStructType>.Dispose
	*/
}
