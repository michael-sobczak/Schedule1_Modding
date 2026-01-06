internal struct UntypedUnsafeList // TypeDefIndex: 15965
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	public void* Ptr; // 0x0
	public int m_length; // 0x8
	public int m_capacity; // 0xC
	public AllocatorManager.AllocatorHandle Allocator; // 0x10
	internal int obsolete_length; // 0x14
	internal int obsolete_capacity; // 0x18
}
