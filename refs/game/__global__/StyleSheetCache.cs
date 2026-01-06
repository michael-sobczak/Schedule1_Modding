internal static class StyleSheetCache // TypeDefIndex: 7176
{
	// Fields
	private static StyleSheetCache.SheetHandleKeyComparer s_Comparer; // 0x0
	private static Dictionary<StyleSheetCache.SheetHandleKey, StylePropertyId[]> s_RulePropertyIdsCache; // 0x8

	// Methods

	// RVA: 0x2E4F760 Offset: 0x2E4E160 VA: 0x182E4F760
	internal static StylePropertyId[] GetPropertyIds(StyleSheet sheet, int ruleIndex) { }

	// RVA: 0x2E4F940 Offset: 0x2E4E340 VA: 0x182E4F940
	internal static StylePropertyId[] GetPropertyIds(StyleRule rule) { }

	// RVA: 0x2E4F670 Offset: 0x2E4E070 VA: 0x182E4F670
	private static StylePropertyId GetPropertyId(StyleRule rule, int index) { }

	// RVA: 0x2E4FA20 Offset: 0x2E4E420 VA: 0x182E4FA20
	private static void .cctor() { }
}
