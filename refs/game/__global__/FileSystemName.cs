public static class FileSystemName // TypeDefIndex: 5133
{
	// Fields
	private static readonly char[] s_wildcardChars; // 0x0
	private static readonly char[] s_simpleWildcardChars; // 0x8

	// Methods

	// RVA: 0x1C42230 Offset: 0x1C40C30 VA: 0x181C42230
	public static string TranslateWin32Expression(string expression) { }

	// RVA: 0x1C421A0 Offset: 0x1C40BA0 VA: 0x181C421A0
	public static bool MatchesWin32Expression(ReadOnlySpan<char> expression, ReadOnlySpan<char> name, bool ignoreCase = True) { }

	// RVA: 0x1C42110 Offset: 0x1C40B10 VA: 0x181C42110
	public static bool MatchesSimpleExpression(ReadOnlySpan<char> expression, ReadOnlySpan<char> name, bool ignoreCase = True) { }

	// RVA: 0x1C417C0 Offset: 0x1C401C0 VA: 0x181C417C0
	private static bool MatchPattern(ReadOnlySpan<char> expression, ReadOnlySpan<char> name, bool ignoreCase, bool useExtendedWildcards) { }

	// RVA: 0x1C42550 Offset: 0x1C40F50 VA: 0x181C42550
	private static void .cctor() { }
}
