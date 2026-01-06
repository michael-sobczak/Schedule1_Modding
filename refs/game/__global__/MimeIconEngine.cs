internal class MimeIconEngine // TypeDefIndex: 5511
{
	// Fields
	public static ImageList SmallIcons; // 0x0
	public static ImageList LargeIcons; // 0x8
	private static EPlatformHandler platform; // 0x10
	internal static Hashtable MimeIconIndex; // 0x18
	private static PlatformMimeIconHandler platformMimeHandler; // 0x20
	private static object lock_object; // 0x28

	// Methods

	// RVA: 0x2394620 Offset: 0x2393020 VA: 0x182394620
	private static void .cctor() { }

	// RVA: 0x2393CC0 Offset: 0x23926C0 VA: 0x182393CC0
	public static int GetIconIndexForFile(string full_filename) { }

	// RVA: 0x2393FE0 Offset: 0x23929E0 VA: 0x182393FE0
	public static int GetIconIndexForMimeType(string mime_type) { }

	// RVA: 0x2393B40 Offset: 0x2392540 VA: 0x182393B40
	internal static void AddIconByImage(string mime_type, Image image) { }

	// RVA: 0x2394330 Offset: 0x2392D30 VA: 0x182394330
	private static object GetIconIndex(string mime_type) { }
}
