internal class MaterialReferenceManager // TypeDefIndex: 16714
{
	// Fields
	private static MaterialReferenceManager s_Instance; // 0x0
	private Dictionary<int, Material> m_FontMaterialReferenceLookup; // 0x10
	private Dictionary<int, FontAsset> m_FontAssetReferenceLookup; // 0x18
	private Dictionary<int, SpriteAsset> m_SpriteAssetReferenceLookup; // 0x20
	private Dictionary<int, TextColorGradient> m_ColorGradientReferenceLookup; // 0x28

	// Properties
	public static MaterialReferenceManager instance { get; }

	// Methods

	// RVA: 0x2D582E0 Offset: 0x2D56CE0 VA: 0x182D582E0
	public static MaterialReferenceManager get_instance() { }

	// RVA: 0x2D57990 Offset: 0x2D56390 VA: 0x182D57990
	public static void AddFontAsset(FontAsset fontAsset) { }

	// RVA: 0x2D57810 Offset: 0x2D56210 VA: 0x182D57810
	private void AddFontAssetInternal(FontAsset fontAsset) { }

	// RVA: 0x2D57CC0 Offset: 0x2D566C0 VA: 0x182D57CC0
	public static void AddSpriteAsset(int hashCode, SpriteAsset spriteAsset) { }

	// RVA: 0x2D57C00 Offset: 0x2D56600 VA: 0x182D57C00
	private void AddSpriteAssetInternal(int hashCode, SpriteAsset spriteAsset) { }

	// RVA: 0x2D57B90 Offset: 0x2D56590 VA: 0x182D57B90
	public static void AddFontMaterial(int hashCode, Material material) { }

	// RVA: 0x2D57B20 Offset: 0x2D56520 VA: 0x182D57B20
	private void AddFontMaterialInternal(int hashCode, Material material) { }

	// RVA: 0x2D57770 Offset: 0x2D56170 VA: 0x182D57770
	public static void AddColorGradientPreset(int hashCode, TextColorGradient spriteAsset) { }

	// RVA: 0x2D576E0 Offset: 0x2D560E0 VA: 0x182D576E0
	private void AddColorGradientPreset_Internal(int hashCode, TextColorGradient spriteAsset) { }

	// RVA: 0x2D57F10 Offset: 0x2D56910 VA: 0x182D57F10
	public static bool TryGetFontAsset(int hashCode, out FontAsset fontAsset) { }

	// RVA: 0x2D57E90 Offset: 0x2D56890 VA: 0x182D57E90
	private bool TryGetFontAssetInternal(int hashCode, out FontAsset fontAsset) { }

	// RVA: 0x2D58110 Offset: 0x2D56B10 VA: 0x182D58110
	public static bool TryGetSpriteAsset(int hashCode, out SpriteAsset spriteAsset) { }

	// RVA: 0x2D58090 Offset: 0x2D56A90 VA: 0x182D58090
	private bool TryGetSpriteAssetInternal(int hashCode, out SpriteAsset spriteAsset) { }

	// RVA: 0x2D57E10 Offset: 0x2D56810 VA: 0x182D57E10
	public static bool TryGetColorGradientPreset(int hashCode, out TextColorGradient gradientPreset) { }

	// RVA: 0x2D57D90 Offset: 0x2D56790 VA: 0x182D57D90
	private bool TryGetColorGradientPresetInternal(int hashCode, out TextColorGradient gradientPreset) { }

	// RVA: 0x2D58010 Offset: 0x2D56A10 VA: 0x182D58010
	public static bool TryGetMaterial(int hashCode, out Material material) { }

	// RVA: 0x2D57F90 Offset: 0x2D56990 VA: 0x182D57F90
	private bool TryGetMaterialInternal(int hashCode, out Material material) { }

	// RVA: 0x2D58190 Offset: 0x2D56B90 VA: 0x182D58190
	public void .ctor() { }
}
