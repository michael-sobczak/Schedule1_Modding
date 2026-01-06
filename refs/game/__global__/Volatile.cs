public static class Volatile // TypeDefIndex: 4005
{
	// Methods

	[Intrinsic]
	// RVA: 0x1D05970 Offset: 0x1D04370 VA: 0x181D05970
	public static bool Read(ref bool location) { }

	[Intrinsic]
	// RVA: 0x1D059C0 Offset: 0x1D043C0 VA: 0x181D059C0
	public static void Write(ref bool location, bool value) { }

	[Intrinsic]
	// RVA: 0x1D05950 Offset: 0x1D04350 VA: 0x181D05950
	public static int Read(ref int location) { }

	[Intrinsic]
	// RVA: 0x1D05990 Offset: 0x1D04390 VA: 0x181D05990
	public static void Write(ref int location, int value) { }

	[Intrinsic]
	// RVA: -1 Offset: -1
	public static T Read<T>(ref T location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF766F0 Offset: 0xF750F0 VA: 0x180F766F0
	|-Volatile.Read<object>
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1
	public static void Write<T>(ref T location, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF76710 Offset: 0xF75110 VA: 0x180F76710
	|-Volatile.Write<object>
	*/
}
