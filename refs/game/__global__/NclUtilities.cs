internal static class NclUtilities // TypeDefIndex: 9972
{
	// Fields
	private static IPAddress[] _LocalAddresses; // 0x0
	private static object _LocalAddressesLock; // 0x8
	internal static string _LocalDomainName; // 0x10

	// Properties
	internal static IPAddress[] LocalAddresses { get; }
	private static object LocalAddressesLock { get; }

	// Methods

	// RVA: 0x26C7840 Offset: 0x26C6240 VA: 0x1826C7840
	internal static bool IsFatal(Exception exception) { }

	// RVA: 0x26C77B0 Offset: 0x26C61B0 VA: 0x1826C77B0
	internal static bool IsAddressLocal(IPAddress ipAddress) { }

	// RVA: 0x26C7790 Offset: 0x26C6190 VA: 0x1826C7790
	private static IPHostEntry GetLocalHost() { }

	// RVA: 0x26C7990 Offset: 0x26C6390 VA: 0x1826C7990
	internal static IPAddress[] get_LocalAddresses() { }

	// RVA: 0x26C78F0 Offset: 0x26C62F0 VA: 0x1826C78F0
	private static object get_LocalAddressesLock() { }
}
