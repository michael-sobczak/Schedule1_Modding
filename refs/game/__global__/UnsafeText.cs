public struct UnsafeText : INativeDisposable, IDisposable, IUTF8Bytes, INativeList<byte>, IIndexable<byte> // TypeDefIndex: 16016
{
	// Fields
	internal UntypedUnsafeList m_UntypedListData; // 0x0

	// Properties
	public bool IsCreated { get; }
	public bool IsEmpty { get; }
	public byte Item { get; set; }
	public int Capacity { get; set; }
	public int Length { get; set; }

	// Methods

	// RVA: 0x27479A0 Offset: 0x27463A0 VA: 0x1827479A0
	public void .ctor(int capacity, AllocatorManager.AllocatorHandle allocator) { }

	// RVA: 0x2747AE0 Offset: 0x27464E0 VA: 0x182747AE0
	public bool get_IsCreated() { }

	// RVA: 0x2747640 Offset: 0x2746040 VA: 0x182747640 Slot: 5
	public void Dispose() { }

	[NotBurstCompatible]
	// RVA: 0x27476B0 Offset: 0x27460B0 VA: 0x1827476B0 Slot: 4
	public JobHandle Dispose(JobHandle inputDeps) { }

	// RVA: 0x2747B50 Offset: 0x2746550 VA: 0x182747B50 Slot: 11
	public bool get_IsEmpty() { }

	// RVA: 0x2747C20 Offset: 0x2746620 VA: 0x182747C20 Slot: 12
	public byte get_Item(int index) { }

	// RVA: 0x2747D50 Offset: 0x2746750 VA: 0x182747D50 Slot: 13
	public void set_Item(int index, byte value) { }

	// RVA: 0x2747750 Offset: 0x2746150 VA: 0x182747750 Slot: 17
	public ref byte ElementAt(int index) { }

	// RVA: 0x2747630 Offset: 0x2746030 VA: 0x182747630 Slot: 14
	public void Clear() { }

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0 Slot: 7
	public byte* GetUnsafePtr() { }

	// RVA: 0x27478D0 Offset: 0x27462D0 VA: 0x1827478D0 Slot: 8
	public bool TryResize(int newLength, NativeArrayOptions clearOptions = 1) { }

	// RVA: 0x2747A70 Offset: 0x2746470 VA: 0x182747A70 Slot: 9
	public int get_Capacity() { }

	// RVA: 0x2747CD0 Offset: 0x27466D0 VA: 0x182747CD0 Slot: 10
	public void set_Capacity(int value) { }

	// RVA: 0x2747C60 Offset: 0x2746660 VA: 0x182747C60 Slot: 15
	public int get_Length() { }

	// RVA: 0x2747DA0 Offset: 0x27467A0 VA: 0x182747DA0 Slot: 16
	public void set_Length(int value) { }

	[NotBurstCompatible]
	// RVA: 0x2747820 Offset: 0x2746220 VA: 0x182747820 Slot: 3
	public override string ToString() { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x2747480 Offset: 0x2745E80 VA: 0x182747480
	private void CheckIndexInRange(int index) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x2747790 Offset: 0x2746190 VA: 0x182747790
	private void ThrowCopyError(CopyError error, string source) { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x2747340 Offset: 0x2745D40 VA: 0x182747340
	private static void CheckCapacityInRange(int value, int length) { }
}
