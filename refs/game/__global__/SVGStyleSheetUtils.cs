internal static class SVGStyleSheetUtils // TypeDefIndex: 10323
{
	// Methods

	// RVA: 0x473C10 Offset: 0x472610 VA: 0x180473C10
	public static SVGStyleSheet Parse(string cssText) { }

	// RVA: 0x472840 Offset: 0x471240 VA: 0x180472840
	public static SVGPropertySheet ParseInline(string cssText) { }

	// RVA: 0x473390 Offset: 0x471D90 VA: 0x180473390
	private static bool ParseSelector(List<string> tokens, SVGStyleSheet sheet) { }

	// RVA: 0x4724B0 Offset: 0x470EB0 VA: 0x1804724B0
	private static void CombineProperties(SVGPropertySheet first, SVGPropertySheet second) { }

	// RVA: 0x472630 Offset: 0x471030 VA: 0x180472630
	private static SVGPropertySheet CopyProperties(SVGPropertySheet props) { }

	// RVA: 0x472DC0 Offset: 0x4717C0 VA: 0x180472DC0
	private static bool ParseProperties(List<string> tokens, SVGPropertySheet props) { }

	// RVA: 0x472F00 Offset: 0x471900 VA: 0x180472F00
	private static bool ParseProperty(List<string> tokens, out string name, out string value) { }

	// RVA: 0x4729E0 Offset: 0x4713E0 VA: 0x1804729E0
	private static string ParseParenValue(List<string> tokens) { }

	// RVA: 0x473FC0 Offset: 0x4729C0 VA: 0x180473FC0
	public static List<string> Tokenize(string cssText) { }

	// RVA: 0x473EA0 Offset: 0x4728A0 VA: 0x180473EA0
	private static string PeekToken(List<string> tokens) { }

	// RVA: 0x473F20 Offset: 0x472920 VA: 0x180473F20
	private static string PopToken(List<string> tokens) { }

	// RVA: 0x4727E0 Offset: 0x4711E0 VA: 0x1804727E0
	private static bool IsSeparator(char ch) { }

	// RVA: 0x472820 Offset: 0x471220 VA: 0x180472820
	private static bool IsWhitespace(char ch) { }
}
