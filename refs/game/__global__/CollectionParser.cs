internal static class CollectionParser // TypeDefIndex: 17720
{
	// Methods

	// RVA: -1 Offset: -1
	public static bool TryParse<T>(string input, int minimalCount, ElementTryParser<T> parser, out List<T> result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE64120 Offset: 0xE62B20 VA: 0x180E64120
	|-CollectionParser.TryParse<object>
	*/

	// RVA: 0x2180D20 Offset: 0x217F720 VA: 0x182180D20
	public static bool TryParse(string input, int minimalCount, out List<string> result) { }

	// RVA: 0x2180BB0 Offset: 0x217F5B0 VA: 0x182180BB0
	private static bool TryParseStringElement(Lexer lexer, out string parsedValue, out Token t) { }
}
