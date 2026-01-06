internal interface IVisualStyles // TypeDefIndex: 5961
{
	// Properties
	public abstract string VisualStyleInformationColorScheme { get; }
	public abstract string VisualStyleInformationFileName { get; }
	public abstract bool VisualStyleInformationIsSupportedByOS { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int UxThemeCloseThemeData(IntPtr hTheme);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int UxThemeDrawThemeBackground(IntPtr hTheme, IDeviceContext dc, int iPartId, int iStateId, Rectangle bounds);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int UxThemeDrawThemeBackground(IntPtr hTheme, IDeviceContext dc, int iPartId, int iStateId, Rectangle bounds, Rectangle clipRectangle);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int UxThemeDrawThemeText(IntPtr hTheme, IDeviceContext dc, int iPartId, int iStateId, string text, TextFormatFlags textFlags, Rectangle bounds);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int UxThemeGetThemeBackgroundRegion(IntPtr hTheme, IDeviceContext dc, int iPartId, int iStateId, Rectangle bounds, out Region result);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int UxThemeGetThemeColor(IntPtr hTheme, int iPartId, int iStateId, ColorProperty prop, out Color result);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int UxThemeGetThemePartSize(IntPtr hTheme, IDeviceContext dc, int iPartId, int iStateId, ThemeSizeType type, out Size result);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int UxThemeGetThemeTextExtent(IntPtr hTheme, IDeviceContext dc, int iPartId, int iStateId, string textToDraw, TextFormatFlags flags, Rectangle bounds, out Rectangle result);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool UxThemeIsAppThemed();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool UxThemeIsThemeActive();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool UxThemeIsThemeBackgroundPartiallyTransparent(IntPtr hTheme, int iPartId, int iStateId);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool UxThemeIsThemePartDefined(IntPtr hTheme, int iPartId);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract IntPtr UxThemeOpenThemeData(IntPtr hWnd, string classList);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract string get_VisualStyleInformationColorScheme();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract string get_VisualStyleInformationFileName();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract bool get_VisualStyleInformationIsSupportedByOS();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void VisualStyleRendererDrawBackgroundExcludingArea(IntPtr theme, IDeviceContext dc, int part, int state, Rectangle bounds, Rectangle excludedArea);
}
