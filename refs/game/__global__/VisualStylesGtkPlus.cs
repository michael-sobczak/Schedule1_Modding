internal class VisualStylesGtkPlus : IVisualStyles // TypeDefIndex: 6064
{
	// Properties
	private static GtkPlus GtkPlus { get; }
	public string VisualStyleInformationColorScheme { get; }
	public string VisualStyleInformationFileName { get; }
	public bool VisualStyleInformationIsSupportedByOS { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x22E7F30 Offset: 0x22E6930 VA: 0x1822E7F30
	public static bool Initialize() { }

	// RVA: 0x22E8740 Offset: 0x22E7140 VA: 0x1822E8740
	private static GtkPlus get_GtkPlus() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 4
	public int UxThemeCloseThemeData(IntPtr hTheme) { }

	// RVA: 0x22E8020 Offset: 0x22E6A20 VA: 0x1822E8020 Slot: 6
	public int UxThemeDrawThemeBackground(IntPtr hTheme, IDeviceContext dc, int iPartId, int iStateId, Rectangle bounds, Rectangle clipRectangle) { }

	// RVA: 0x22E7F40 Offset: 0x22E6940 VA: 0x1822E7F40 Slot: 5
	public int UxThemeDrawThemeBackground(IntPtr hTheme, IDeviceContext dc, int iPartId, int iStateId, Rectangle bounds) { }

	// RVA: 0x22E6780 Offset: 0x22E5180 VA: 0x1822E6780
	private bool DrawBackground(VisualStylesGtkPlus.ThemeHandle themeHandle, IDeviceContext dc, int part, int state, Rectangle bounds, Rectangle clipRectangle, Rectangle excludedArea) { }

	// RVA: 0x22E7CC0 Offset: 0x22E66C0 VA: 0x1822E7CC0
	private static bool GetGtkPlusState(SCROLLBARSTYLESTATES state, out GtkPlusState result) { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 7
	public int UxThemeDrawThemeText(IntPtr hTheme, IDeviceContext dc, int iPartId, int iStateId, string text, TextFormatFlags textFlags, Rectangle bounds) { }

	// RVA: 0x22E8110 Offset: 0x22E6B10 VA: 0x1822E8110 Slot: 8
	public int UxThemeGetThemeBackgroundRegion(IntPtr hTheme, IDeviceContext dc, int iPartId, int iStateId, Rectangle bounds, out Region result) { }

	// RVA: 0x22E8140 Offset: 0x22E6B40 VA: 0x1822E8140 Slot: 9
	public int UxThemeGetThemeColor(IntPtr hTheme, int iPartId, int iStateId, ColorProperty prop, out Color result) { }

	// RVA: 0x22E8180 Offset: 0x22E6B80 VA: 0x1822E8180 Slot: 10
	public int UxThemeGetThemePartSize(IntPtr hTheme, IDeviceContext dc, int iPartId, int iStateId, ThemeSizeType type, out Size result) { }

	// RVA: 0x22E7D10 Offset: 0x22E6710 VA: 0x1822E7D10
	private bool GetPartSize(VisualStylesGtkPlus.ThemeHandle themeHandle, IDeviceContext dc, int part, int state, Rectangle bounds, bool rectangleSpecified, ThemeSizeType type, out Size result) { }

	// RVA: 0x22E83D0 Offset: 0x22E6DD0 VA: 0x1822E83D0 Slot: 11
	public int UxThemeGetThemeTextExtent(IntPtr hTheme, IDeviceContext dc, int iPartId, int iStateId, string textToDraw, TextFormatFlags flags, Rectangle bounds, out Rectangle result) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 12
	public bool UxThemeIsAppThemed() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 13
	public bool UxThemeIsThemeActive() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 14
	public bool UxThemeIsThemeBackgroundPartiallyTransparent(IntPtr hTheme, int iPartId, int iStateId) { }

	// RVA: 0x22E8420 Offset: 0x22E6E20 VA: 0x1822E8420 Slot: 15
	public bool UxThemeIsThemePartDefined(IntPtr hTheme, int iPartId) { }

	// RVA: 0x22E85A0 Offset: 0x22E6FA0 VA: 0x1822E85A0 Slot: 16
	public IntPtr UxThemeOpenThemeData(IntPtr hWnd, string classList) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 17
	public string get_VisualStyleInformationColorScheme() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 18
	public string get_VisualStyleInformationFileName() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 19
	public bool get_VisualStyleInformationIsSupportedByOS() { }

	// RVA: 0x22E8690 Offset: 0x22E7090 VA: 0x1822E8690 Slot: 20
	public void VisualStyleRendererDrawBackgroundExcludingArea(IntPtr theme, IDeviceContext dc, int part, int state, Rectangle bounds, Rectangle excludedArea) { }
}
