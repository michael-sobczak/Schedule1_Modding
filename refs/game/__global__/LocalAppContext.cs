internal class LocalAppContext // TypeDefIndex: 12847
{
	// Fields
	private static bool s_isDisableCachingInitialized; // 0x0
	private static bool s_disableCaching; // 0x1
	private static object s_syncObject; // 0x8

	// Properties
	private static bool DisableCaching { get; }

	// Methods

	// RVA: 0x2063AF0 Offset: 0x20624F0 VA: 0x182063AF0
	internal static bool GetCachedSwitchValue(string switchName, ref int switchValue) { }

	// RVA: 0x2063920 Offset: 0x2062320 VA: 0x182063920
	private static bool GetCachedSwitchValueInternal(string switchName, ref int switchValue) { }

	// RVA: 0x2063B10 Offset: 0x2062510 VA: 0x182063B10
	private static bool get_DisableCaching() { }
}
