public static class NetUtils // TypeDefIndex: 12421
{
	// Fields
	private static readonly List<string> IpList; // 0x0

	// Methods

	// RVA: 0xD063A0 Offset: 0xD04DA0 VA: 0x180D063A0
	public static IPEndPoint MakeEndPoint(string hostStr, int port) { }

	// RVA: 0xD06780 Offset: 0xD05180 VA: 0x180D06780
	public static IPAddress ResolveAddress(string hostStr) { }

	// RVA: 0xD066E0 Offset: 0xD050E0 VA: 0x180D066E0
	public static IPAddress ResolveAddress(string hostStr, AddressFamily addressFamily) { }

	// RVA: 0xD05C10 Offset: 0xD04610 VA: 0x180D05C10
	public static List<string> GetLocalIpList(LocalAddrType addrType) { }

	// RVA: 0xD05CA0 Offset: 0xD046A0 VA: 0x180D05CA0
	public static void GetLocalIpList(IList<string> targetList, LocalAddrType addrType) { }

	// RVA: 0xD061A0 Offset: 0xD04BA0 VA: 0x180D061A0
	public static string GetLocalIp(LocalAddrType addrType) { }

	// RVA: 0xD06440 Offset: 0xD04E40 VA: 0x180D06440
	internal static void PrintInterfaceInfos() { }

	// RVA: 0xD066B0 Offset: 0xD050B0 VA: 0x180D066B0
	internal static int RelativeSequenceNumber(int number, int expected) { }

	// RVA: -1 Offset: -1
	internal static T[] AllocatePinnedUninitializedArray<T>(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF118F0 Offset: 0xF102F0 VA: 0x180F118F0
	|-NetUtils.AllocatePinnedUninitializedArray<int>
	|-NetUtils.AllocatePinnedUninitializedArray<uint>
	|-NetUtils.AllocatePinnedUninitializedArray<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0xD06950 Offset: 0xD05350 VA: 0x180D06950
	private static void .cctor() { }
}
