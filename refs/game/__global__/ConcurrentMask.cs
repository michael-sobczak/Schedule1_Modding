internal class ConcurrentMask // TypeDefIndex: 15743
{
	// Fields
	internal const int ErrorFailedToFree = -1;
	internal const int ErrorFailedToAllocate = -2;
	internal const int EmptyBeforeAllocation = 0;
	internal const int EmptyAfterFree = 0;

	// Methods

	// RVA: 0x271E1B0 Offset: 0x271CBB0 VA: 0x18271E1B0
	internal static void longestConsecutiveOnes(long value, out int offset, out int count) { }

	// RVA: 0x271DF20 Offset: 0x271C920 VA: 0x18271DF20
	internal static bool foundAtLeastThisManyConsecutiveOnes(long value, int minimum, out int offset, out int count) { }

	// RVA: 0x271E060 Offset: 0x271CA60 VA: 0x18271E060
	internal static bool foundAtLeastThisManyConsecutiveZeroes(long value, int minimum, out int offset, out int count) { }

	// RVA: 0x271DB30 Offset: 0x271C530 VA: 0x18271DB30
	internal static bool Succeeded(int error) { }

	// RVA: 0x271DB00 Offset: 0x271C500 VA: 0x18271DB00
	internal static long MakeMask(int offset, int bits) { }

	// RVA: 0x271DD40 Offset: 0x271C740 VA: 0x18271DD40
	internal static int TryAllocate(ref long l, int offset, int bits) { }

	// RVA: 0x271DE30 Offset: 0x271C830 VA: 0x18271DE30
	internal static int TryFree(ref long l, int offset, int bits) { }

	// RVA: 0x271DB40 Offset: 0x271C540 VA: 0x18271DB40
	internal static int TryAllocate(ref long l, out int offset, int bits) { }

	// RVA: -1 Offset: -1
	internal static int TryAllocate<T>(ref T t, int offset, int bits) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE69A90 Offset: 0xE68490 VA: 0x180E69A90
	|-ConcurrentMask.TryAllocate<Long1024>
	|
	|-RVA: 0xE69750 Offset: 0xE68150 VA: 0x180E69750
	|-ConcurrentMask.TryAllocate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static int TryFree<T>(ref T t, int offset, int bits) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE69CC0 Offset: 0xE686C0 VA: 0x180E69CC0
	|-ConcurrentMask.TryFree<Long1024>
	|
	|-RVA: 0xE69BC0 Offset: 0xE685C0 VA: 0x180E69BC0
	|-ConcurrentMask.TryFree<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static int TryAllocate<T>(ref T t, out int offset, int begin, int end, int bits) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE69B00 Offset: 0xE68500 VA: 0x180E69B00
	|-ConcurrentMask.TryAllocate<Long1024>
	|
	|-RVA: 0xE69850 Offset: 0xE68250 VA: 0x180E69850
	|-ConcurrentMask.TryAllocate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static int TryAllocate<T>(ref T t, out int offset, int bits) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE69990 Offset: 0xE68390 VA: 0x180E69990
	|-ConcurrentMask.TryAllocate<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
