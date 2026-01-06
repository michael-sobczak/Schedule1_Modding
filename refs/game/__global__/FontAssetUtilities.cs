internal static class FontAssetUtilities // TypeDefIndex: 16706
{
	// Fields
	private static HashSet<int> k_SearchedAssets; // 0x0

	// Methods

	// RVA: 0x2D4B8E0 Offset: 0x2D4A2E0 VA: 0x182D4B8E0
	internal static Character GetCharacterFromFontAsset(uint unicode, FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x2D4B400 Offset: 0x2D49E00 VA: 0x182D4B400
	private static Character GetCharacterFromFontAsset_Internal(uint unicode, FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x2D4B9F0 Offset: 0x2D4A3F0 VA: 0x182D4B9F0
	public static Character GetCharacterFromFontAssets(uint unicode, FontAsset sourceFontAsset, List<FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x2D4BD90 Offset: 0x2D4A790 VA: 0x182D4BD90
	public static SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, SpriteAsset spriteAsset, bool includeFallbacks) { }

	// RVA: 0x2D4BBD0 Offset: 0x2D4A5D0 VA: 0x182D4BBD0
	private static SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, SpriteAsset spriteAsset, bool includeFallbacks) { }
}
