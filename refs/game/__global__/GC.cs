public static class GC // TypeDefIndex: 3816
{
	// Fields
	internal static readonly object EPHEMERON_TOMBSTONE; // 0x0

	// Properties
	public static int MaxGeneration { get; }

	// Methods

	// RVA: 0x1CA89C0 Offset: 0x1CA73C0 VA: 0x181CA89C0
	private static int GetCollectionCount(int generation) { }

	// RVA: 0x1CA89D0 Offset: 0x1CA73D0 VA: 0x181CA89D0
	private static int GetMaxGeneration() { }

	// RVA: 0x1CA8A10 Offset: 0x1CA7410 VA: 0x181CA8A10
	private static void InternalCollect(int generation) { }

	// RVA: 0x1CA8AC0 Offset: 0x1CA74C0 VA: 0x181CA8AC0
	private static void RecordPressure(long bytesAllocated) { }

	// RVA: 0x1CA8D80 Offset: 0x1CA7780 VA: 0x181CA8D80
	internal static void register_ephemeron_array(Ephemeron[] array) { }

	// RVA: 0x1CA8D70 Offset: 0x1CA7770 VA: 0x181CA8D70
	private static object get_ephemeron_tombstone() { }

	// RVA: 0x1CA89E0 Offset: 0x1CA73E0 VA: 0x181CA89E0
	internal static void GetMemoryInfo(out uint highMemLoadThreshold, out ulong totalPhysicalMem, out uint lastRecordedMemLoad, out UIntPtr lastRecordedHeapSize, out UIntPtr lastRecordedFragmentation) { }

	// RVA: 0x1CA8740 Offset: 0x1CA7140 VA: 0x181CA8740
	public static void AddMemoryPressure(long bytesAllocated) { }

	// RVA: 0x1CA8AD0 Offset: 0x1CA74D0 VA: 0x181CA8AD0
	public static void RemoveMemoryPressure(long bytesAllocated) { }

	// RVA: 0x1CA8880 Offset: 0x1CA7280 VA: 0x181CA8880
	public static void Collect() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1CA8900 Offset: 0x1CA7300 VA: 0x181CA8900
	public static int CollectionCount(int generation) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public static void KeepAlive(object obj) { }

	// RVA: 0x1CA8D30 Offset: 0x1CA7730 VA: 0x181CA8D30
	public static int get_MaxGeneration() { }

	// RVA: 0x1CA8CB0 Offset: 0x1CA76B0 VA: 0x181CA8CB0
	public static void WaitForPendingFinalizers() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1CA8CD0 Offset: 0x1CA76D0 VA: 0x181CA8CD0
	private static void _SuppressFinalize(object o) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1CA8C10 Offset: 0x1CA7610 VA: 0x181CA8C10
	public static void SuppressFinalize(object obj) { }

	// RVA: 0x1CA8CC0 Offset: 0x1CA76C0 VA: 0x181CA8CC0
	private static void _ReRegisterForFinalize(object o) { }

	// RVA: 0x1CA8A20 Offset: 0x1CA7420 VA: 0x181CA8A20
	public static void ReRegisterForFinalize(object obj) { }

	// RVA: 0x1CA8A00 Offset: 0x1CA7400 VA: 0x181CA8A00
	public static long GetTotalMemory(bool forceFullCollection) { }

	// RVA: 0x1CA8CE0 Offset: 0x1CA76E0 VA: 0x181CA8CE0
	private static void .cctor() { }
}
