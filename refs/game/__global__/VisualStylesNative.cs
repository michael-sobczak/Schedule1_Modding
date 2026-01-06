internal class VisualStylesNative : IVisualStyles // TypeDefIndex: 6065
{
	// Properties
	public string VisualStyleInformationColorScheme { get; }
	public string VisualStyleInformationFileName { get; }
	public bool VisualStyleInformationIsSupportedByOS { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x2307C10 Offset: 0x2306610 VA: 0x182307C10 Slot: 4
	public int UxThemeCloseThemeData(IntPtr hTheme) { }

	// RVA: 0x2307D40 Offset: 0x2306740 VA: 0x182307D40 Slot: 5
	public int UxThemeDrawThemeBackground(IntPtr hTheme, IDeviceContext dc, int iPartId, int iStateId, Rectangle bounds) { }

	// RVA: 0x2307C20 Offset: 0x2306620 VA: 0x182307C20 Slot: 6
	public int UxThemeDrawThemeBackground(IntPtr hTheme, IDeviceContext dc, int iPartId, int iStateId, Rectangle bounds, Rectangle clipRectangle) { }

	// RVA: 0x2307E20 Offset: 0x2306820 VA: 0x182307E20 Slot: 7
	public int UxThemeDrawThemeText(IntPtr hTheme, IDeviceContext dc, int iPartId, int iStateId, string text, TextFormatFlags textFlags, Rectangle bounds) { }

	// RVA: 0x2307F30 Offset: 0x2306930 VA: 0x182307F30 Slot: 8
	public int UxThemeGetThemeBackgroundRegion(IntPtr hTheme, IDeviceContext dc, int iPartId, int iStateId, Rectangle bounds, out Region result) { }

	// RVA: 0x2308050 Offset: 0x2306A50 VA: 0x182308050 Slot: 9
	public int UxThemeGetThemeColor(IntPtr hTheme, int iPartId, int iStateId, ColorProperty prop, out Color result) { }

	// RVA: 0x23080F0 Offset: 0x2306AF0 VA: 0x1823080F0 Slot: 10
	public int UxThemeGetThemePartSize(IntPtr hTheme, IDeviceContext dc, int iPartId, int iStateId, ThemeSizeType type, out Size result) { }

	// RVA: 0x23081D0 Offset: 0x2306BD0 VA: 0x1823081D0 Slot: 11
	public int UxThemeGetThemeTextExtent(IntPtr hTheme, IDeviceContext dc, int iPartId, int iStateId, string textToDraw, TextFormatFlags flags, Rectangle bounds, out Rectangle result) { }

	// RVA: 0x2308310 Offset: 0x2306D10 VA: 0x182308310 Slot: 12
	public bool UxThemeIsAppThemed() { }

	// RVA: 0x2308320 Offset: 0x2306D20 VA: 0x182308320 Slot: 13
	public bool UxThemeIsThemeActive() { }

	// RVA: 0x2308360 Offset: 0x2306D60 VA: 0x182308360 Slot: 15
	public bool UxThemeIsThemePartDefined(IntPtr hTheme, int iPartId) { }

	// RVA: 0x2308330 Offset: 0x2306D30 VA: 0x182308330 Slot: 14
	public bool UxThemeIsThemeBackgroundPartiallyTransparent(IntPtr hTheme, int iPartId, int iStateId) { }

	// RVA: 0x2308380 Offset: 0x2306D80 VA: 0x182308380 Slot: 16
	public IntPtr UxThemeOpenThemeData(IntPtr hWnd, string classList) { }

	// RVA: 0x23085A0 Offset: 0x2306FA0 VA: 0x1823085A0 Slot: 17
	public string get_VisualStyleInformationColorScheme() { }

	// RVA: 0x23086B0 Offset: 0x23070B0 VA: 0x1823086B0 Slot: 18
	public string get_VisualStyleInformationFileName() { }

	// RVA: 0x23087C0 Offset: 0x23071C0 VA: 0x1823087C0 Slot: 19
	public bool get_VisualStyleInformationIsSupportedByOS() { }

	// RVA: 0x2307B70 Offset: 0x2306570 VA: 0x182307B70
	public static bool IsSupported() { }

	// RVA: 0x23083A0 Offset: 0x2306DA0 VA: 0x1823083A0 Slot: 20
	public void VisualStyleRendererDrawBackgroundExcludingArea(IntPtr theme, IDeviceContext dc, int part, int state, Rectangle bounds, Rectangle excludedArea) { }
}
