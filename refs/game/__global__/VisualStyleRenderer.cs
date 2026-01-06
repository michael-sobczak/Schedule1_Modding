public sealed class VisualStyleRenderer // TypeDefIndex: 6061
{
	// Fields
	private string class_name; // 0x10
	private int part; // 0x18
	private int state; // 0x1C
	private IntPtr theme; // 0x20
	private int last_hresult; // 0x28
	private VisualStyleRenderer.ThemeHandleManager theme_handle_manager; // 0x30

	// Properties
	public IntPtr Handle { get; }
	public static bool IsSupported { get; }
	internal static IVisualStyles VisualStyles { get; }

	// Methods

	// RVA: 0x22E6160 Offset: 0x22E4B60 VA: 0x1822E6160
	public void .ctor(string className, int part, int state) { }

	// RVA: 0x22E6230 Offset: 0x22E4C30 VA: 0x1822E6230
	public void .ctor(VisualStyleElement element) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public IntPtr get_Handle() { }

	// RVA: 0x22E6310 Offset: 0x22E4D10 VA: 0x1822E6310
	public static bool get_IsSupported() { }

	// RVA: 0x22E5D60 Offset: 0x22E4760 VA: 0x1822E5D60
	public static bool IsElementDefined(VisualStyleElement element) { }

	// RVA: 0x22E5010 Offset: 0x22E3A10 VA: 0x1822E5010
	public void DrawBackground(IDeviceContext dc, Rectangle bounds) { }

	// RVA: 0x22E4E60 Offset: 0x22E3860 VA: 0x1822E4E60
	public void DrawBackground(IDeviceContext dc, Rectangle bounds, Rectangle clipRectangle) { }

	// RVA: 0x22E5190 Offset: 0x22E3B90 VA: 0x1822E5190
	public void DrawImage(Graphics g, Rectangle bounds, Image image) { }

	// RVA: 0x22E5260 Offset: 0x22E3C60 VA: 0x1822E5260
	public void DrawText(IDeviceContext dc, Rectangle bounds, string textToDraw, bool drawDisabled, TextFormatFlags flags) { }

	// RVA: 0x22E5410 Offset: 0x22E3E10 VA: 0x1822E5410
	public Region GetBackgroundRegion(IDeviceContext dc, Rectangle bounds) { }

	// RVA: 0x22E55C0 Offset: 0x22E3FC0 VA: 0x1822E55C0
	public Color GetColor(ColorProperty prop) { }

	// RVA: 0x22E5800 Offset: 0x22E4200 VA: 0x1822E5800
	public Size GetPartSize(IDeviceContext dc, ThemeSizeType type) { }

	// RVA: 0x22E5AB0 Offset: 0x22E44B0 VA: 0x1822E5AB0
	public Rectangle GetTextExtent(IDeviceContext dc, Rectangle bounds, string textToDraw, TextFormatFlags flags) { }

	// RVA: 0x22E5C70 Offset: 0x22E4670 VA: 0x1822E5C70
	public bool IsBackgroundPartiallyTransparent() { }

	// RVA: 0x22E5F50 Offset: 0x22E4950 VA: 0x1822E5F50
	public void SetParameters(string className, int part, int state) { }

	// RVA: 0x22E6130 Offset: 0x22E4B30 VA: 0x1822E6130
	public void SetParameters(VisualStyleElement element) { }

	// RVA: 0x22E64C0 Offset: 0x22E4EC0 VA: 0x1822E64C0
	internal static IVisualStyles get_VisualStyles() { }

	// RVA: 0x22E4D20 Offset: 0x22E3720 VA: 0x1822E4D20
	internal void DrawBackgroundExcludingArea(IDeviceContext dc, Rectangle bounds, Rectangle excludedArea) { }

	// RVA: 0x22E5ED0 Offset: 0x22E48D0 VA: 0x1822E5ED0
	private static bool IsElementKnownToBeSupported(string className, int part, int state) { }
}
