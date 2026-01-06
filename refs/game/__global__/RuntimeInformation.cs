public static class RuntimeInformation // TypeDefIndex: 4557
{
	// Fields
	private static readonly Architecture _osArchitecture; // 0x0
	private static readonly Architecture _processArchitecture; // 0x4
	private static readonly OSPlatform _osPlatform; // 0x8

	// Methods

	// RVA: 0x1B72F10 Offset: 0x1B71910 VA: 0x181B72F10
	private static void .cctor() { }

	// RVA: 0x1B72E00 Offset: 0x1B71800 VA: 0x181B72E00
	private static string GetRuntimeArchitecture() { }

	// RVA: 0x1B72DF0 Offset: 0x1B717F0 VA: 0x181B72DF0
	private static string GetOSName() { }

	// RVA: 0x1B72E10 Offset: 0x1B71810 VA: 0x181B72E10
	public static bool IsOSPlatform(OSPlatform osPlatform) { }
}
