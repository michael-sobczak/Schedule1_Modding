internal static class MonoBtlsX509StoreManager // TypeDefIndex: 9474
{
	// Fields
	private static bool initialized; // 0x0
	private static string machineTrustedRootPath; // 0x8
	private static string machineIntermediateCAPath; // 0x10
	private static string machineUntrustedPath; // 0x18
	private static string userTrustedRootPath; // 0x20
	private static string userIntermediateCAPath; // 0x28
	private static string userUntrustedPath; // 0x30

	// Methods

	// RVA: 0x2605370 Offset: 0x2603D70 VA: 0x182605370
	private static void Initialize() { }

	// RVA: 0x2605030 Offset: 0x2603A30 VA: 0x182605030
	private static void DoInitialize() { }

	// RVA: 0x2605230 Offset: 0x2603C30 VA: 0x182605230
	public static string GetStorePath(MonoBtlsX509StoreType type) { }
}
