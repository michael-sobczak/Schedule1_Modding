internal sealed class RequestCacheManager // TypeDefIndex: 10172
{
	// Fields
	private static RequestCachingSectionInternal s_CacheConfigSettings; // 0x0
	private static readonly RequestCacheBinding s_BypassCacheBinding; // 0x8
	private static RequestCacheBinding s_DefaultGlobalBinding; // 0x10
	private static RequestCacheBinding s_DefaultHttpBinding; // 0x18
	private static RequestCacheBinding s_DefaultFtpBinding; // 0x20

	// Methods

	// RVA: 0x25E19F0 Offset: 0x25E03F0 VA: 0x1825E19F0
	internal static RequestCacheBinding GetBinding(string internedScheme) { }

	// RVA: 0x25E1C80 Offset: 0x25E0680 VA: 0x1825E1C80
	private static void LoadConfigSettings() { }

	// RVA: 0x25E1DF0 Offset: 0x25E07F0 VA: 0x1825E1DF0
	private static void .cctor() { }
}
