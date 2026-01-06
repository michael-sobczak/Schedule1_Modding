internal class TextBoxTextRenderer // TypeDefIndex: 5576
{
	// Fields
	private static Size max_size; // 0x0
	private static bool use_textrenderer; // 0x8
	private static StringFormat sf_nonprinting; // 0x10
	private static StringFormat sf_printing; // 0x18
	private static Hashtable measure_cache; // 0x20

	// Methods

	// RVA: 0x21FDE80 Offset: 0x21FC880 VA: 0x1821FDE80
	private static void .cctor() { }

	// RVA: 0x21FD7E0 Offset: 0x21FC1E0 VA: 0x1821FD7E0
	public static void DrawText(Graphics g, string text, Font font, Color color, float x, float y, bool showNonPrint) { }

	// RVA: 0x21FDB00 Offset: 0x21FC500 VA: 0x1821FDB00
	public static SizeF MeasureText(Graphics g, string text, Font font) { }
}
