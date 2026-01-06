internal class X11DesktopColors // TypeDefIndex: 5714
{
	// Fields
	private static X11DesktopColors.Desktop desktop; // 0x0

	// Methods

	// RVA: 0x2270E00 Offset: 0x226F800 VA: 0x182270E00
	private static void .cctor() { }

	// RVA: 0x22707C0 Offset: 0x226F1C0 VA: 0x1822707C0
	private static void GtkInit() { }

	// RVA: 0x22704C0 Offset: 0x226EEC0 VA: 0x1822704C0
	private static void FindDesktopEnvironment() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal static void Initialize() { }

	// RVA: 0x2270470 Offset: 0x226EE70 VA: 0x182270470
	private static Color ColorFromGdkColor(X11DesktopColors.GdkColorStruct gtkcolor) { }

	// RVA: 0x2270870 Offset: 0x226F270 VA: 0x182270870
	private static bool ReadKDEColorsheme() { }

	// RVA: 0x22705F0 Offset: 0x226EFF0 VA: 0x1822705F0
	private static Color GetColorFromKDEString(string line) { }

	// RVA: 0x2271B50 Offset: 0x2270550 VA: 0x182271B50
	private static extern bool gtk_init_check(IntPtr argc, IntPtr argv) { }

	// RVA: 0x2271BE0 Offset: 0x22705E0 VA: 0x182271BE0
	private static extern IntPtr gtk_invisible_new() { }

	// RVA: 0x2271C50 Offset: 0x2270650 VA: 0x182271C50
	private static extern IntPtr gtk_menu_new() { }

	// RVA: 0x2271CC0 Offset: 0x22706C0 VA: 0x182271CC0
	private static extern void gtk_widget_ensure_style(IntPtr raw) { }

	// RVA: 0x2271D40 Offset: 0x2270740 VA: 0x182271D40
	private static extern IntPtr gtk_widget_get_style(IntPtr raw) { }
}
