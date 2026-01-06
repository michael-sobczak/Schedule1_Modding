public sealed class CheckBoxRenderer // TypeDefIndex: 5260
{
	// Fields
	private static bool always_use_visual_styles; // 0x0

	// Methods

	// RVA: 0x21C8BC0 Offset: 0x21C75C0 VA: 0x1821C8BC0
	public static void DrawCheckBox(Graphics g, Point glyphLocation, CheckBoxState state) { }

	// RVA: 0x21C8C80 Offset: 0x21C7680 VA: 0x1821C8C80
	public static void DrawCheckBox(Graphics g, Point glyphLocation, Rectangle textBounds, string checkBoxText, Font font, TextFormatFlags flags, Image image, Rectangle imageBounds, bool focused, CheckBoxState state) { }

	// RVA: 0x21C91D0 Offset: 0x21C7BD0 VA: 0x1821C91D0
	public static Size GetGlyphSize(Graphics g, CheckBoxState state) { }

	// RVA: 0x21C90B0 Offset: 0x21C7AB0 VA: 0x1821C90B0
	private static VisualStyleRenderer GetCheckBoxRenderer(CheckBoxState state) { }
}
