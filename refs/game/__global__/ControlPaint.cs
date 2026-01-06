public sealed class ControlPaint // TypeDefIndex: 5293
{
	// Fields
	private static int RGBMax; // 0x0
	private static int HLSMax; // 0x4

	// Methods

	// RVA: 0x230D740 Offset: 0x230C140 VA: 0x18230D740
	private static void .cctor() { }

	// RVA: 0x230A820 Offset: 0x2309220 VA: 0x18230A820
	internal static void Color2HBS(Color color, out int h, out int l, out int s) { }

	// RVA: 0x230CA70 Offset: 0x230B470 VA: 0x18230CA70
	private static int HueToRGB(int n1, int n2, int hue) { }

	// RVA: 0x230C780 Offset: 0x230B180 VA: 0x18230C780
	internal static Color HBS2Color(int hue, int lum, int sat) { }

	// RVA: 0x230CD30 Offset: 0x230B730 VA: 0x18230CD30
	public static Color Light(Color baseColor) { }

	// RVA: 0x230CDC0 Offset: 0x230B7C0 VA: 0x18230CDC0
	public static Color Light(Color baseColor, float percOfLightLight) { }

	// RVA: 0x230CCA0 Offset: 0x230B6A0 VA: 0x18230CCA0
	public static Color LightLight(Color baseColor) { }

	// RVA: 0x230AC70 Offset: 0x2309670 VA: 0x18230AC70
	public static Color Dark(Color baseColor) { }

	// RVA: 0x230AD00 Offset: 0x2309700 VA: 0x18230AD00
	public static Color Dark(Color baseColor, float percOfDarkDark) { }

	// RVA: 0x230ABE0 Offset: 0x23095E0 VA: 0x18230ABE0
	public static Color DarkDark(Color baseColor) { }

	// RVA: 0x230B890 Offset: 0x230A290 VA: 0x18230B890
	public static void DrawBorder(Graphics graphics, Rectangle bounds, Color color, ButtonBorderStyle style) { }

	// RVA: 0x230BA70 Offset: 0x230A470 VA: 0x18230BA70
	public static void DrawBorder(Graphics graphics, Rectangle bounds, Color leftColor, int leftWidth, ButtonBorderStyle leftStyle, Color topColor, int topWidth, ButtonBorderStyle topStyle, Color rightColor, int rightWidth, ButtonBorderStyle rightStyle, Color bottomColor, int bottomWidth, ButtonBorderStyle bottomStyle) { }

	// RVA: 0x230B780 Offset: 0x230A180 VA: 0x18230B780
	public static void DrawBorder3D(Graphics graphics, Rectangle rectangle, Border3DStyle style) { }

	// RVA: 0x230B690 Offset: 0x230A090 VA: 0x18230B690
	public static void DrawBorder3D(Graphics graphics, Rectangle rectangle, Border3DStyle style, Border3DSide sides) { }

	// RVA: 0x230BC60 Offset: 0x230A660 VA: 0x18230BC60
	public static void DrawButton(Graphics graphics, Rectangle rectangle, ButtonState state) { }

	// RVA: 0x230BD40 Offset: 0x230A740 VA: 0x18230BD40
	public static void DrawCaptionButton(Graphics graphics, Rectangle rectangle, CaptionButton button, ButtonState state) { }

	// RVA: 0x230BE30 Offset: 0x230A830 VA: 0x18230BE30
	public static void DrawCheckBox(Graphics graphics, Rectangle rectangle, ButtonState state) { }

	// RVA: 0x230C030 Offset: 0x230AA30 VA: 0x18230C030
	public static void DrawFocusRectangle(Graphics graphics, Rectangle rectangle) { }

	// RVA: 0x230BF10 Offset: 0x230A910 VA: 0x18230BF10
	public static void DrawFocusRectangle(Graphics graphics, Rectangle rectangle, Color foreColor, Color backColor) { }

	// RVA: 0x230C1C0 Offset: 0x230ABC0 VA: 0x18230C1C0
	public static void DrawImageDisabled(Graphics graphics, Image image, int x, int y, Color background) { }

	// RVA: 0x230C2D0 Offset: 0x230ACD0 VA: 0x18230C2D0
	public static void DrawMenuGlyph(Graphics graphics, Rectangle rectangle, MenuGlyph glyph) { }

	// RVA: 0x230C490 Offset: 0x230AE90 VA: 0x18230C490
	public static void DrawMixedCheckBox(Graphics graphics, Rectangle rectangle, ButtonState state) { }

	// RVA: 0x230C570 Offset: 0x230AF70 VA: 0x18230C570
	public static void DrawSizeGrip(Graphics graphics, Color backColor, Rectangle bounds) { }

	// RVA: 0x230C660 Offset: 0x230B060 VA: 0x18230C660
	public static void DrawStringDisabled(Graphics graphics, string s, Font font, Color color, RectangleF layoutRectangle, StringFormat format) { }
}
