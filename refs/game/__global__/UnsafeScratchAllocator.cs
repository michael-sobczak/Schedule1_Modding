public struct UnsafeScratchAllocator // TypeDefIndex: 16004
{
	// Fields
	private void* m_Pointer; // 0x0
	private int m_LengthInBytes; // 0x8
	private readonly int m_CapacityInBytes; // 0xC

	// Methods

	// RVA: 0x27424A0 Offset: 0x2740EA0 VA: 0x1827424A0
	public void .ctor(void* ptr, int capacityInBytes) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x27423A0 Offset: 0x2740DA0 VA: 0x1827423A0
	private void CheckAllocationDoesNotExceedCapacity(ulong requestedSize) { }

	// RVA: 0x2742300 Offset: 0x2740D00 VA: 0x182742300
	public void* Allocate(int sizeInBytes, int alignmentInBytes) { }

	[BurstCompatible(GenericTypeArguments = new[] { typeof(int) })]
	// RVA: -1 Offset: -1
	public void* Allocate<T>(int count = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF6C230 Offset: 0xF6AC30 VA: 0x180F6C230
	|-UnsafeScratchAllocator.Allocate<__Il2CppFullySharedGenericStructType>
	*/
}
