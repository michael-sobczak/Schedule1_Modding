internal static class OidLookup // TypeDefIndex: 9485
{
	// Fields
	private static readonly ConcurrentDictionary<string, string> s_lateBoundOidToFriendlyName; // 0x0
	private static readonly ConcurrentDictionary<string, string> s_lateBoundFriendlyNameToOid; // 0x8
	private static readonly Dictionary<string, string> s_friendlyNameToOid; // 0x10
	private static readonly Dictionary<string, string> s_oidToFriendlyName; // 0x18
	private static readonly Dictionary<string, string> s_compatOids; // 0x20

	// Methods

	// RVA: 0x26089B0 Offset: 0x26073B0 VA: 0x1826089B0
	public static string ToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x2608C20 Offset: 0x2607620 VA: 0x182608C20
	public static string ToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	private static bool ShouldUseCache(OidGroup oidGroup) { }

	// RVA: 0x2608660 Offset: 0x2607060 VA: 0x182608660
	private static string NativeOidToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x2608310 Offset: 0x2606D10 VA: 0x182608310
	private static string NativeFriendlyNameToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x2608E60 Offset: 0x2607860 VA: 0x182608E60
	private static void .cctor() { }
}
