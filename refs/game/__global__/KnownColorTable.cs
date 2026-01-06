internal static class KnownColorTable // TypeDefIndex: 17092
{
	// Fields
	private static int[] s_colorTable; // 0x0
	private static string[] s_colorNameTable; // 0x8

	// Methods

	// RVA: 0x2145600 Offset: 0x2144000 VA: 0x182145600
	private static void EnsureColorTable() { }

	// RVA: 0x21477D0 Offset: 0x21461D0 VA: 0x1821477D0
	private static void InitColorTable() { }

	// RVA: 0x21455B0 Offset: 0x2143FB0 VA: 0x1821455B0
	private static void EnsureColorNameTable() { }

	// RVA: 0x2145650 Offset: 0x2144050 VA: 0x182145650
	private static void InitColorNameTable() { }

	// RVA: 0x21483D0 Offset: 0x2146DD0 VA: 0x1821483D0
	public static int KnownColorToArgb(KnownColor color) { }

	// RVA: 0x2148460 Offset: 0x2146E60 VA: 0x182148460
	public static string KnownColorToName(KnownColor color) { }

	// RVA: 0x21484F0 Offset: 0x2146EF0 VA: 0x1821484F0
	private static void UpdateSystemColors(int[] colorTable) { }
}
