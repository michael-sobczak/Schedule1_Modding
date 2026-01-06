internal class TextResourceManager // TypeDefIndex: 16757
{
	// Fields
	private static readonly Dictionary<int, TextResourceManager.FontAssetRef> s_FontAssetReferences; // 0x0
	private static readonly Dictionary<int, FontAsset> s_FontAssetNameReferenceLookup; // 0x8
	private static readonly Dictionary<long, FontAsset> s_FontAssetFamilyNameAndStyleReferenceLookup; // 0x10
	private static readonly List<int> s_FontAssetRemovalList; // 0x18
	private static readonly int k_RegularStyleHashCode; // 0x20

	// Methods

	// RVA: 0x2D86720 Offset: 0x2D85120 VA: 0x182D86720
	internal static void AddFontAsset(FontAsset fontAsset) { }

	// RVA: 0x2D86D90 Offset: 0x2D85790 VA: 0x182D86D90
	private static void .cctor() { }
}
