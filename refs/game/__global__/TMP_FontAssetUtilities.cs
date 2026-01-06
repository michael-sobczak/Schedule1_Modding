public class TMP_FontAssetUtilities // TypeDefIndex: 14912
{
	// Fields
	private static readonly TMP_FontAssetUtilities s_Instance; // 0x0
	private static HashSet<int> k_SearchedAssets; // 0x8

	// Properties
	public static TMP_FontAssetUtilities instance { get; }

	// Methods

	// RVA: 0x2BED880 Offset: 0x2BEC280 VA: 0x182BED880
	private static void .cctor() { }

	// RVA: 0x2BED8F0 Offset: 0x2BEC2F0 VA: 0x182BED8F0
	public static TMP_FontAssetUtilities get_instance() { }

	// RVA: 0x2BECBE0 Offset: 0x2BEB5E0 VA: 0x182BECBE0
	public static TMP_Character GetCharacterFromFontAsset(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x2BEC710 Offset: 0x2BEB110 VA: 0x182BEC710
	private static TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x2BECD70 Offset: 0x2BEB770 VA: 0x182BECD70
	public static TMP_Character GetCharacterFromFontAssets(uint unicode, TMP_FontAsset sourceFontAsset, List<TMP_FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x2BED4F0 Offset: 0x2BEBEF0 VA: 0x182BED4F0
	internal static TMP_TextElement GetTextElementFromTextAssets(uint unicode, TMP_FontAsset sourceFontAsset, List<TMP_Asset> textAssets, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x2BED1B0 Offset: 0x2BEBBB0 VA: 0x182BED1B0
	public static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks) { }

	// RVA: 0x2BECFD0 Offset: 0x2BEB9D0 VA: 0x182BECFD0
	private static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
