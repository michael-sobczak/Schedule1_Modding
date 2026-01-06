public static class CGResourceHandler // TypeDefIndex: 10651
{
	// Fields
	private static readonly Dictionary<string, ICGResourceLoader> resourceLoadersCache; // 0x0

	// Methods

	// RVA: 0x4F6870 Offset: 0x4F5270 VA: 0x1804F6870
	public static void RegisterResourceLoader(string resourceName, ICGResourceLoader loader) { }

	[NotNull]
	// RVA: 0x4F6490 Offset: 0x4F4E90 VA: 0x1804F6490
	public static Component CreateResource(CGModule module, string resName, string context) { }

	// RVA: 0x4F6680 Offset: 0x4F5080 VA: 0x1804F6680
	public static void DestroyResource(CGModule module, string resName, Component obj, string context, bool kill) { }

	// RVA: 0x4F6990 Offset: 0x4F5390 VA: 0x1804F6990
	private static void .cctor() { }
}
