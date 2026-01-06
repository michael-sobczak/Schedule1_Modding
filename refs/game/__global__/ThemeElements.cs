internal class ThemeElements // TypeDefIndex: 5895
{
	// Fields
	private static ThemeElementsDefault theme; // 0x0

	// Properties
	public static ThemeElementsDefault CurrentTheme { get; }
	public static LabelPainter LabelPainter { get; }

	// Methods

	// RVA: 0x22E2F90 Offset: 0x22E1990 VA: 0x1822E2F90
	private static void .cctor() { }

	// RVA: 0x22E3030 Offset: 0x22E1A30 VA: 0x1822E3030
	public static ThemeElementsDefault get_CurrentTheme() { }

	// RVA: 0x22E2D40 Offset: 0x22E1740 VA: 0x1822E2D40
	private static ThemeElementsDefault LoadTheme(string themeName) { }

	// RVA: 0x22E29B0 Offset: 0x22E13B0 VA: 0x1822E29B0
	public static void DrawButton(Graphics g, Rectangle bounds, ButtonThemeState state, Color backColor, Color foreColor) { }

	// RVA: 0x22E2AE0 Offset: 0x22E14E0 VA: 0x1822E2AE0
	public static void DrawFlatButton(Graphics g, Rectangle bounds, ButtonThemeState state, Color backColor, Color foreColor, FlatButtonAppearance appearance) { }

	// RVA: 0x22E2C10 Offset: 0x22E1610 VA: 0x1822E2C10
	public static void DrawPopupButton(Graphics g, Rectangle bounds, ButtonThemeState state, Color backColor, Color foreColor) { }

	// RVA: 0x22E3080 Offset: 0x22E1A80 VA: 0x1822E3080
	public static LabelPainter get_LabelPainter() { }
}
