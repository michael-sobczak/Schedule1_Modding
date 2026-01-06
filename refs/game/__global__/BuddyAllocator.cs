internal struct BuddyAllocator : IDisposable // TypeDefIndex: 8902
{
	// Fields
	private void* m_Data; // 0x0
	private ValueTuple<int, int> m_ActiveFreeMaskCounts; // 0x8
	private ValueTuple<int, int> m_FreeMasksStorage; // 0x10
	private ValueTuple<int, int> m_FreeMaskIndicesStorage; // 0x18
	private Allocator m_Allocator; // 0x20

	// Properties
	private BuddyAllocator.Header header { get; }
	private NativeArray<int> freeMaskCounts { get; }
	private NativeArray<ulong> freeMasksStorage { get; }
	private NativeArray<int> freeMaskIndicesStorage { get; }
	public int levelCount { get; }

	// Methods

	// RVA: 0x2AFD540 Offset: 0x2AFBF40 VA: 0x182AFD540
	private ref BuddyAllocator.Header get_header() { }

	// RVA: 0x2AFD3F0 Offset: 0x2AFBDF0 VA: 0x182AFD3F0
	private NativeArray<int> get_freeMaskCounts() { }

	// RVA: 0x2AFD4D0 Offset: 0x2AFBED0 VA: 0x182AFD4D0
	private NativeArray<ulong> get_freeMasksStorage() { }

	// RVA: 0x2AFCA00 Offset: 0x2AFB400 VA: 0x182AFCA00
	private NativeArray<ulong> FreeMasks(int level) { }

	// RVA: 0x2AFD460 Offset: 0x2AFBE60 VA: 0x182AFD460
	private NativeArray<int> get_freeMaskIndicesStorage() { }

	// RVA: 0x2AFC870 Offset: 0x2AFB270 VA: 0x182AFC870
	private NativeArray<int> FreeMaskIndices(int level) { }

	// RVA: 0x2AFD580 Offset: 0x2AFBF80 VA: 0x182AFD580
	public int get_levelCount() { }

	// RVA: 0x2AFD1E0 Offset: 0x2AFBBE0 VA: 0x182AFD1E0
	public void .ctor(int levelCount, int branchingOrder, Allocator allocator = 4) { }

	// RVA: 0x2AFCF40 Offset: 0x2AFB940 VA: 0x182AFCF40
	public bool TryAllocate(int requestedLevel, out BuddyAllocation allocation) { }

	// RVA: 0x2AFCB90 Offset: 0x2AFB590 VA: 0x182AFCB90
	public void Free(BuddyAllocation allocation) { }

	// RVA: 0x2AFC840 Offset: 0x2AFB240 VA: 0x182AFC840 Slot: 4
	public void Dispose() { }

	// RVA: -1 Offset: -1
	private NativeArray<T> GetNativeArray<T>(int offset, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5AA50 Offset: 0xE59450 VA: 0x180E5AA50
	|-BuddyAllocator.GetNativeArray<int>
	|-BuddyAllocator.GetNativeArray<ulong>
	|
	|-RVA: 0xE5A9C0 Offset: 0xE593C0 VA: 0x180E5A9C0
	|-BuddyAllocator.GetNativeArray<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2AFCED0 Offset: 0x2AFB8D0 VA: 0x182AFCED0
	private static int LevelOffset(int level, int branchingOrder) { }

	// RVA: 0x2AFCE60 Offset: 0x2AFB860 VA: 0x182AFCE60
	private static int LevelLength(int level, int branchingOrder) { }

	// RVA: 0x2AFCE70 Offset: 0x2AFB870 VA: 0x182AFCE70
	private static int LevelOffset64(int level, int branchingOrder) { }

	// RVA: 0x2AFCE30 Offset: 0x2AFB830 VA: 0x182AFCE30
	private static int LevelLength64(int level, int branchingOrder) { }

	// RVA: -1 Offset: -1
	private static ValueTuple<int, int> AllocateRange<T>(int length, ref int dataSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5A880 Offset: 0xE59280 VA: 0x180E5A880
	|-BuddyAllocator.AllocateRange<int>
	|
	|-RVA: 0xE5A920 Offset: 0xE59320 VA: 0x180E5A920
	|-BuddyAllocator.AllocateRange<ulong>
	|
	|-RVA: 0xE5A7D0 Offset: 0xE591D0 VA: 0x180E5A7D0
	|-BuddyAllocator.AllocateRange<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2AFC820 Offset: 0x2AFB220 VA: 0x182AFC820
	private static int AlignForward(int offset, int alignment) { }

	// RVA: 0x2AFCF10 Offset: 0x2AFB910 VA: 0x182AFCF10
	private static void* PtrAdd(void* ptr, int bytes) { }

	// RVA: 0x2A55A70 Offset: 0x2A54470 VA: 0x182A55A70
	private static int Pow2(int n) { }

	// RVA: 0x2AFCF00 Offset: 0x2AFB900 VA: 0x182AFCF00
	private static int Pow2N(int x, int n) { }
}
