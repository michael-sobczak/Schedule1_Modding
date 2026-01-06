public class TMP_ResourceManager // TypeDefIndex: 14950
{
	// Fields
	private static TMP_Settings s_TextSettings; // 0x0
	private static readonly Dictionary<int, TMP_ResourceManager.FontAssetRef> s_FontAssetReferences; // 0x8
	private static readonly Dictionary<int, TMP_FontAsset> s_FontAssetNameReferenceLookup; // 0x10
	private static readonly Dictionary<long, TMP_FontAsset> s_FontAssetFamilyNameAndStyleReferenceLookup; // 0x18
	private static readonly List<int> s_FontAssetRemovalList; // 0x20
	private static readonly int k_RegularStyleHashCode; // 0x28

	// Methods

	// RVA: 0x2C26980 Offset: 0x2C25380 VA: 0x182C26980
	internal static TMP_Settings GetTextSettings() { }

	// RVA: 0x2C262D0 Offset: 0x2C24CD0 VA: 0x182C262D0
	public static void AddFontAsset(TMP_FontAsset fontAsset) { }

	// RVA: 0x2C26E90 Offset: 0x2C25890 VA: 0x182C26E90
	public static void RemoveFontAsset(TMP_FontAsset fontAsset) { }

	// RVA: 0x2C270C0 Offset: 0x2C25AC0 VA: 0x182C270C0
	internal static bool TryGetFontAssetByName(int nameHashcode, out TMP_FontAsset fontAsset) { }

	// RVA: 0x2C26FF0 Offset: 0x2C259F0 VA: 0x182C26FF0
	internal static bool TryGetFontAssetByFamilyName(int familyNameHashCode, int styleNameHashCode, out TMP_FontAsset fontAsset) { }

	// RVA: 0x2C26940 Offset: 0x2C25340 VA: 0x182C26940
	public static void ClearFontAssetGlyphCache() { }

	// RVA: 0x2C26AA0 Offset: 0x2C254A0 VA: 0x182C26AA0
	internal static void RebuildFontAssetCache() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x2C27160 Offset: 0x2C25B60 VA: 0x182C27160
	private static void .cctor() { }
}
