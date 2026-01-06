internal struct UnsafeStreamBlockData // TypeDefIndex: 16008
{
	// Fields
	internal const int AllocationSize = 4096;
	internal AllocatorManager.AllocatorHandle Allocator; // 0x0
	internal UnsafeStreamBlock** Blocks; // 0x8
	internal int BlockCount; // 0x10
	internal UnsafeStreamBlock* Free; // 0x18
	internal UnsafeStreamRange* Ranges; // 0x20
	internal int RangeCount; // 0x28

	// Methods

	// RVA: 0x27424B0 Offset: 0x2740EB0 VA: 0x1827424B0
	internal UnsafeStreamBlock* Allocate(UnsafeStreamBlock* oldBlock, int threadIndex) { }
}
