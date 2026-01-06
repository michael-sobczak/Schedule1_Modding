internal class UXTheme // TypeDefIndex: 5965
{
	// Methods

	// RVA: 0x22E3D10 Offset: 0x22E2710 VA: 0x1822E3D10
	public static extern int CloseThemeData(IntPtr hTheme) { }

	// RVA: 0x22E3D90 Offset: 0x22E2790 VA: 0x1822E3D90
	public static extern int DrawThemeBackground(IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, ref XplatUIWin32.RECT pRect, ref XplatUIWin32.RECT pClipRect) { }

	// RVA: 0x22E3E50 Offset: 0x22E2850 VA: 0x1822E3E50
	public static extern int DrawThemeBackground(IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, ref XplatUIWin32.RECT pRect, IntPtr pClipRect) { }

	// RVA: 0x22E3F10 Offset: 0x22E2910 VA: 0x1822E3F10
	public static extern int DrawThemeText(IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, string text, int textLength, uint textFlags, uint textFlags2, ref XplatUIWin32.RECT pRect) { }

	// RVA: 0x22E46B0 Offset: 0x22E30B0 VA: 0x1822E46B0
	public static extern IntPtr OpenThemeData(IntPtr hWnd, string classList) { }

	// RVA: 0x22E4150 Offset: 0x22E2B50 VA: 0x1822E4150
	public static extern int GetThemeBackgroundRegion(IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, ref XplatUIWin32.RECT pRect, out IntPtr pRegion) { }

	// RVA: 0x22E4210 Offset: 0x22E2C10 VA: 0x1822E4210
	public static extern int GetThemeColor(IntPtr hTheme, int iPartId, int iStateId, int iPropId, out int pColor) { }

	// RVA: 0x22E42C0 Offset: 0x22E2CC0 VA: 0x1822E42C0
	public static extern int GetThemePartSize(IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, IntPtr pRect, int eSize, out UXTheme.SIZE size) { }

	// RVA: 0x22E4390 Offset: 0x22E2D90 VA: 0x1822E4390
	public static extern int GetThemeTextExtent(IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, string text, int textLength, int textFlags, ref XplatUIWin32.RECT boundingRect, out XplatUIWin32.RECT extentRect) { }

	// RVA: 0x22E4570 Offset: 0x22E2F70 VA: 0x1822E4570
	public static extern int IsThemeBackgroundPartiallyTransparent(IntPtr hTheme, int iPartId, int iStateId) { }

	// RVA: 0x22E4610 Offset: 0x22E3010 VA: 0x1822E4610
	public static extern bool IsThemePartDefined(IntPtr hTheme, int iPartId, int iStateId) { }

	// RVA: 0x22E4500 Offset: 0x22E2F00 VA: 0x1822E4500
	public static extern bool IsThemeActive() { }

	// RVA: 0x22E4490 Offset: 0x22E2E90 VA: 0x1822E4490
	public static extern bool IsAppThemed() { }

	// RVA: 0x22E4010 Offset: 0x22E2A10 VA: 0x1822E4010
	public static extern int GetCurrentThemeName(StringBuilder stringThemeName, int lengthThemeName, StringBuilder stringColorName, int lengthColorName, StringBuilder stringSizeName, int lengthSizeName) { }
}
