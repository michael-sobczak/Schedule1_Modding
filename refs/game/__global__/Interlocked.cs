public static class Interlocked // TypeDefIndex: 3991
{
	// Methods

	[ReliabilityContract(3, 2)]
	// RVA: 0x1CF0F20 Offset: 0x1CEF920 VA: 0x181CF0F20
	public static int CompareExchange(ref int location1, int value, int comparand) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1CF0F00 Offset: 0x1CEF900 VA: 0x181CF0F00
	internal static int CompareExchange(ref int location1, int value, int comparand, ref bool succeeded) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1CF0EF0 Offset: 0x1CEF8F0 VA: 0x181CF0EF0
	private static void CompareExchange(ref object location1, ref object value, ref object comparand, ref object result) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1CF0F30 Offset: 0x1CEF930 VA: 0x181CF0F30
	public static object CompareExchange(ref object location1, object value, object comparand) { }

	// RVA: 0x1CF0F70 Offset: 0x1CEF970 VA: 0x181CF0F70
	public static float CompareExchange(ref float location1, float value, float comparand) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1CF0F90 Offset: 0x1CEF990 VA: 0x181CF0F90
	public static int Decrement(ref int location) { }

	// RVA: 0x1CF0FA0 Offset: 0x1CEF9A0 VA: 0x181CF0FA0
	public static long Decrement(ref long location) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1CF1040 Offset: 0x1CEFA40 VA: 0x181CF1040
	public static int Increment(ref int location) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1CF1030 Offset: 0x1CEFA30 VA: 0x181CF1030
	public static long Increment(ref long location) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1CF0FD0 Offset: 0x1CEF9D0 VA: 0x181CF0FD0
	public static int Exchange(ref int location1, int value) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1CF0FB0 Offset: 0x1CEF9B0 VA: 0x181CF0FB0
	private static void Exchange(ref object location1, ref object value, ref object result) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1CF0FE0 Offset: 0x1CEF9E0 VA: 0x181CF0FE0
	public static object Exchange(ref object location1, object value) { }

	// RVA: 0x1CF1010 Offset: 0x1CEFA10 VA: 0x181CF1010
	public static float Exchange(ref float location1, float value) { }

	// RVA: 0x1CF0F10 Offset: 0x1CEF910 VA: 0x181CF0F10
	public static long CompareExchange(ref long location1, long value, long comparand) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1CF0F10 Offset: 0x1CEF910 VA: 0x181CF0F10
	public static IntPtr CompareExchange(ref IntPtr location1, IntPtr value, IntPtr comparand) { }

	// RVA: 0x1CF0F80 Offset: 0x1CEF980 VA: 0x181CF0F80
	public static double CompareExchange(ref double location1, double value, double comparand) { }

	[ReliabilityContract(3, 2)]
	[ComVisible(False)]
	[Intrinsic]
	// RVA: -1 Offset: -1
	public static T CompareExchange<T>(ref T location1, T value, T comparand) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Interlocked.CompareExchange<object>
	*/

	// RVA: 0x1CF0FC0 Offset: 0x1CEF9C0 VA: 0x181CF0FC0
	public static long Exchange(ref long location1, long value) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1CF0FC0 Offset: 0x1CEF9C0 VA: 0x181CF0FC0
	public static IntPtr Exchange(ref IntPtr location1, IntPtr value) { }

	// RVA: 0x1CF1020 Offset: 0x1CEFA20 VA: 0x181CF1020
	public static double Exchange(ref double location1, double value) { }

	[ReliabilityContract(3, 2)]
	[ComVisible(False)]
	[Intrinsic]
	// RVA: -1 Offset: -1
	public static T Exchange<T>(ref T location1, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Interlocked.Exchange<object>
	*/

	// RVA: 0x1CF1060 Offset: 0x1CEFA60 VA: 0x181CF1060
	public static long Read(ref long location) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1CF0ED0 Offset: 0x1CEF8D0 VA: 0x181CF0ED0
	public static int Add(ref int location1, int value) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1CF0EE0 Offset: 0x1CEF8E0 VA: 0x181CF0EE0
	public static long Add(ref long location1, long value) { }

	// RVA: 0x1CF1050 Offset: 0x1CEFA50 VA: 0x181CF1050
	public static void MemoryBarrier() { }
}
