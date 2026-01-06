internal class GnomeUtil // TypeDefIndex: 5517
{
	// Fields
	private static bool inited; // 0x0
	private static IntPtr default_icon_theme; // 0x8

	// Methods

	// RVA: 0x23987D0 Offset: 0x23971D0 VA: 0x1823987D0
	private static void .cctor() { }

	// RVA: 0x23989B0 Offset: 0x23973B0 VA: 0x1823989B0
	private static extern bool gdk_pixbuf_save_to_buffer(IntPtr pixbuf, out IntPtr buffer, out UIntPtr buffer_size, string type, out IntPtr error, IntPtr option_dummy) { }

	// RVA: 0x2398820 Offset: 0x2397220 VA: 0x182398820
	private static extern void g_free(IntPtr mem) { }

	// RVA: 0x2398920 Offset: 0x2397320 VA: 0x182398920
	private static extern bool gdk_init_check(IntPtr argc, IntPtr argv) { }

	// RVA: 0x23988A0 Offset: 0x23972A0 VA: 0x1823988A0
	private static extern void g_object_unref(IntPtr nativeObject) { }

	// RVA: 0x2398AA0 Offset: 0x23974A0 VA: 0x182398AA0
	private static extern string gnome_icon_lookup(IntPtr icon_theme, IntPtr thumbnail_factory, string file_uri, string custom_icon, IntPtr file_info, string mime_type, GnomeUtil.GnomeIconLookupFlags flags, IntPtr result) { }

	// RVA: 0x2398BE0 Offset: 0x23975E0 VA: 0x182398BE0
	private static extern IntPtr gtk_icon_theme_get_default() { }

	// RVA: 0x2398C50 Offset: 0x2397650 VA: 0x182398C50
	private static extern IntPtr gtk_icon_theme_load_icon(IntPtr icon_theme, string icon_name, int size, GnomeUtil.GtkIconLookupFlags flags, out IntPtr error) { }

	// RVA: 0x23986A0 Offset: 0x23970A0 VA: 0x1823986A0
	private static void Init() { }

	// RVA: 0x2398430 Offset: 0x2396E30 VA: 0x182398430
	public static Image GetIcon(string file_name, string mime_type, int size) { }

	// RVA: 0x2398320 Offset: 0x2396D20 VA: 0x182398320
	public static Image GetIcon(string icon, int size) { }

	// RVA: 0x2398090 Offset: 0x2396A90 VA: 0x182398090
	public static Image GdkPixbufToImage(IntPtr pixbuf) { }
}
