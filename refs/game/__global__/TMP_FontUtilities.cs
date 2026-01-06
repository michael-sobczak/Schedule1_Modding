public static class TMP_FontUtilities // TypeDefIndex: 14911
{
	// Fields
	private static List<int> k_searchedFontAssets; // 0x0

	// Methods

	// RVA: 0x2BEE710 Offset: 0x2BED110 VA: 0x182BEE710
	public static TMP_FontAsset SearchForCharacter(TMP_FontAsset font, uint unicode, out TMP_Character character) { }

	// RVA: 0x2BEE620 Offset: 0x2BED020 VA: 0x182BEE620
	public static TMP_FontAsset SearchForCharacter(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character) { }

	// RVA: 0x2BEE270 Offset: 0x2BECC70 VA: 0x182BEE270
	private static TMP_FontAsset SearchForCharacterInternal(TMP_FontAsset font, uint unicode, out TMP_Character character) { }

	// RVA: 0x2BEE530 Offset: 0x2BECF30 VA: 0x182BEE530
	private static TMP_FontAsset SearchForCharacterInternal(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character) { }
}
