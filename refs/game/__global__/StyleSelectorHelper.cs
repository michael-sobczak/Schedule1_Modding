internal static class StyleSelectorHelper // TypeDefIndex: 7173
{
	// Methods

	// RVA: 0x2E4F3A0 Offset: 0x2E4DDA0 VA: 0x182E4F3A0
	public static MatchResultInfo MatchesSelector(VisualElement element, StyleSelector selector) { }

	// RVA: 0x2E4F190 Offset: 0x2E4DB90 VA: 0x182E4F190
	public static bool MatchRightToLeft(VisualElement element, StyleComplexSelector complexSelector, Action<VisualElement, MatchResultInfo> processResult) { }

	// RVA: 0x2E4E8C0 Offset: 0x2E4D2C0 VA: 0x182E4E8C0
	private static void FastLookup(IDictionary<string, StyleComplexSelector> table, List<SelectorMatchRecord> matchedSelectors, StyleMatchingContext context, string input, ref SelectorMatchRecord record) { }

	// RVA: 0x2E4ECC0 Offset: 0x2E4D6C0 VA: 0x182E4ECC0
	public static void FindMatches(StyleMatchingContext context, List<SelectorMatchRecord> matchedSelectors, int parentSheetIndex) { }
}
