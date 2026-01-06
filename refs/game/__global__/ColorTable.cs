internal static class ColorTable // TypeDefIndex: 17089
{
	// Fields
	private static readonly Lazy<Dictionary<string, Color>> s_colorConstants; // 0x0

	// Properties
	internal static Dictionary<string, Color> Colors { get; }

	// Methods

	// RVA: 0x21353F0 Offset: 0x2133DF0 VA: 0x1821353F0
	private static Dictionary<string, Color> GetColors() { }

	// RVA: 0x2135700 Offset: 0x2134100 VA: 0x182135700
	internal static Dictionary<string, Color> get_Colors() { }

	// RVA: 0x2135210 Offset: 0x2133C10 VA: 0x182135210
	private static void FillConstants(Dictionary<string, Color> colors, Type enumType) { }

	// RVA: 0x2135550 Offset: 0x2133F50 VA: 0x182135550
	internal static bool TryGetNamedColor(string name, out Color result) { }

	// RVA: 0x2135630 Offset: 0x2134030 VA: 0x182135630
	private static void .cctor() { }
}
