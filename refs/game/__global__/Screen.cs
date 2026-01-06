public sealed class Screen // TypeDefIndex: 11645
{
	// Properties
	public static int width { get; }
	public static int height { get; }
	public static float dpi { get; }
	public static ScreenOrientation orientation { get; }
	public static bool fullScreen { get; }
	public static FullScreenMode fullScreenMode { set; }
	public static DisplayInfo mainWindowDisplayInfo { get; }
	public static Resolution[] resolutions { get; }

	// Methods

	[NativeMethod(Name = "GetWidth", IsThreadSafe = True)]
	// RVA: 0x2C9F900 Offset: 0x2C9E300 VA: 0x182C9F900
	public static int get_width() { }

	[NativeMethod(Name = "GetHeight", IsThreadSafe = True)]
	// RVA: 0x2C9F830 Offset: 0x2C9E230 VA: 0x182C9F830
	public static int get_height() { }

	[NativeName("GetDPI")]
	// RVA: 0x2C9F7D0 Offset: 0x2C9E1D0 VA: 0x182C9F7D0
	public static float get_dpi() { }

	// RVA: 0x2C9F510 Offset: 0x2C9DF10 VA: 0x182C9F510
	private static ScreenOrientation GetScreenOrientation() { }

	// RVA: 0x2C9F510 Offset: 0x2C9DF10 VA: 0x182C9F510
	public static ScreenOrientation get_orientation() { }

	[NativeName("IsFullscreen")]
	// RVA: 0x2C9F800 Offset: 0x2C9E200 VA: 0x182C9F800
	public static bool get_fullScreen() { }

	[NativeName("RequestSetFullscreenModeFromScript")]
	// RVA: 0x2C9F930 Offset: 0x2C9E330 VA: 0x182C9F930
	public static void set_fullScreenMode(FullScreenMode value) { }

	[NativeName("RequestResolution")]
	// RVA: 0x2C9F670 Offset: 0x2C9E070 VA: 0x182C9F670
	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, RefreshRate preferredRefreshRate) { }

	[EditorBrowsable(1)]
	[Obsolete("SetResolution(int, int, bool, int) is obsolete. Use SetResolution(int, int, FullScreenMode, RefreshRate) instead.")]
	// RVA: 0x2C9F750 Offset: 0x2C9E150 VA: 0x182C9F750
	public static void SetResolution(int width, int height, bool fullscreen, int preferredRefreshRate) { }

	// RVA: 0x2C9F6D0 Offset: 0x2C9E0D0 VA: 0x182C9F6D0
	public static void SetResolution(int width, int height, bool fullscreen) { }

	// RVA: 0x2C9F860 Offset: 0x2C9E260 VA: 0x182C9F860
	public static DisplayInfo get_mainWindowDisplayInfo() { }

	// RVA: 0x2C9F400 Offset: 0x2C9DE00 VA: 0x182C9F400
	public static void GetDisplayLayout(List<DisplayInfo> displayLayout) { }

	// RVA: 0x2C9F5D0 Offset: 0x2C9DFD0 VA: 0x182C9F5D0
	public static AsyncOperation MoveMainWindowTo(in DisplayInfo display, Vector2Int position) { }

	[FreeFunction("GetMainWindowDisplayInfo")]
	// RVA: 0x2C9F4C0 Offset: 0x2C9DEC0 VA: 0x182C9F4C0
	private static DisplayInfo GetMainWindowDisplayInfo() { }

	[FreeFunction("GetDisplayLayout")]
	// RVA: 0x2C9F3C0 Offset: 0x2C9DDC0 VA: 0x182C9F3C0
	private static void GetDisplayLayoutImpl(List<DisplayInfo> displayLayout) { }

	[FreeFunction("MoveMainWindow")]
	// RVA: 0x2C9F590 Offset: 0x2C9DF90 VA: 0x182C9F590
	private static AsyncOperation MoveMainWindowImpl(in DisplayInfo display, Vector2Int position) { }

	[FreeFunction("ScreenScripting::GetResolutions")]
	// RVA: 0x2C9F8D0 Offset: 0x2C9E2D0 VA: 0x182C9F8D0
	public static Resolution[] get_resolutions() { }

	// RVA: 0x2C9F610 Offset: 0x2C9E010 VA: 0x182C9F610
	private static void SetResolution_Injected(int width, int height, FullScreenMode fullscreenMode, ref RefreshRate preferredRefreshRate) { }

	// RVA: 0x2C9F480 Offset: 0x2C9DE80 VA: 0x182C9F480
	private static void GetMainWindowDisplayInfo_Injected(out DisplayInfo ret) { }

	// RVA: 0x2C9F540 Offset: 0x2C9DF40 VA: 0x182C9F540
	private static AsyncOperation MoveMainWindowImpl_Injected(in DisplayInfo display, ref Vector2Int position) { }
}
