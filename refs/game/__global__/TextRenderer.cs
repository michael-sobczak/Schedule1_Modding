public sealed class TextRenderer // TypeDefIndex: 5590
{
	// Methods

	// RVA: 0x2219420 Offset: 0x2217E20 VA: 0x182219420
	public static void DrawText(IDeviceContext dc, string text, Font font, Point pt, Color foreColor, TextFormatFlags flags) { }

	// RVA: 0x2219570 Offset: 0x2217F70 VA: 0x182219570
	public static void DrawText(IDeviceContext dc, string text, Font font, Rectangle bounds, Color foreColor, TextFormatFlags flags) { }

	// RVA: 0x221A060 Offset: 0x2218A60 VA: 0x18221A060
	public static Size MeasureText(string text, Font font) { }

	// RVA: 0x221A0F0 Offset: 0x2218AF0 VA: 0x18221A0F0
	public static Size MeasureText(string text, Font font, Size proposedSize, TextFormatFlags flags) { }

	// RVA: 0x221A180 Offset: 0x2218B80 VA: 0x18221A180
	public static Size MeasureText(IDeviceContext dc, string text, Font font, Size proposedSize, TextFormatFlags flags) { }

	// RVA: 0x2218B70 Offset: 0x2217570 VA: 0x182218B70
	internal static void DrawTextInternal(IDeviceContext dc, string text, Font font, Rectangle bounds, Color foreColor, Color backColor, TextFormatFlags flags, bool useDrawString) { }

	// RVA: 0x2219C60 Offset: 0x2218660 VA: 0x182219C60
	internal static Size MeasureTextInternal(IDeviceContext dc, string text, Font font, Size proposedSize, TextFormatFlags flags, bool useMeasureString) { }

	// RVA: 0x2218950 Offset: 0x2217350 VA: 0x182218950
	internal static void DrawTextInternal(IDeviceContext dc, string text, Font font, Rectangle bounds, Color foreColor, TextFormatFlags flags, bool useDrawString) { }

	// RVA: 0x2219B40 Offset: 0x2218540 VA: 0x182219B40
	internal static Size MeasureTextInternal(string text, Font font, bool useMeasureString) { }

	// RVA: 0x2218A20 Offset: 0x2217420 VA: 0x182218A20
	internal static void DrawTextInternal(IDeviceContext dc, string text, Font font, Point pt, Color foreColor, Color backColor, TextFormatFlags flags, bool useDrawString) { }

	// RVA: 0x2219BE0 Offset: 0x22185E0 VA: 0x182219BE0
	internal static Size MeasureTextInternal(IDeviceContext dc, string text, Font font, bool useMeasureString) { }

	// RVA: 0x2219AA0 Offset: 0x22184A0 VA: 0x182219AA0
	internal static Size MeasureTextInternal(string text, Font font, Size proposedSize, TextFormatFlags flags, bool useMeasureString) { }

	// RVA: 0x2219860 Offset: 0x2218260 VA: 0x182219860
	internal static SizeF MeasureString(string text, Font font) { }

	// RVA: 0x22198D0 Offset: 0x22182D0 VA: 0x1822198D0
	internal static SizeF MeasureString(string text, Font font, int width) { }

	// RVA: 0x2219960 Offset: 0x2218360 VA: 0x182219960
	internal static SizeF MeasureString(string text, Font font, int width, StringFormat format) { }

	// RVA: 0x2219A00 Offset: 0x2218400 VA: 0x182219A00
	internal static SizeF MeasureString(string text, Font font, SizeF layoutArea, StringFormat stringFormat) { }

	// RVA: 0x22197C0 Offset: 0x22181C0 VA: 0x1822197C0
	internal static SizeF GetDpi() { }

	// RVA: 0x2219640 Offset: 0x2218040 VA: 0x182219640
	private static StringFormat FlagsToStringFormat(TextFormatFlags flags) { }

	// RVA: 0x221A220 Offset: 0x2218C20 VA: 0x18221A220
	private static Rectangle PadRectangle(Rectangle r, TextFormatFlags flags) { }

	// RVA: 0x221A1B0 Offset: 0x2218BB0 VA: 0x18221A1B0
	private static Rectangle PadDrawStringRectangle(Rectangle r, TextFormatFlags flags) { }

	// RVA: 0x221A540 Offset: 0x2218F40 VA: 0x18221A540
	private static extern int Win32DrawText(IntPtr hdc, string lpStr, int nCount, ref XplatUIWin32.RECT lpRect, int wFormat) { }

	// RVA: 0x221A4B0 Offset: 0x2218EB0 VA: 0x18221A4B0
	private static extern int SetTextColor(IntPtr hdc, int crColor) { }

	// RVA: 0x221A300 Offset: 0x2218D00 VA: 0x18221A300
	private static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject) { }

	// RVA: 0x221A390 Offset: 0x2218D90 VA: 0x18221A390
	private static extern int SetBkColor(IntPtr hdc, int crColor) { }

	// RVA: 0x221A420 Offset: 0x2218E20 VA: 0x18221A420
	private static extern int SetBkMode(IntPtr hdc, int iBkMode) { }

	// RVA: 0x22188D0 Offset: 0x22172D0 VA: 0x1822188D0
	private static extern bool DeleteObject(IntPtr objectHandle) { }

	// RVA: 0x221A270 Offset: 0x2218C70 VA: 0x18221A270
	private static extern bool SelectClipRgn(IntPtr hdc, IntPtr hrgn) { }
}
