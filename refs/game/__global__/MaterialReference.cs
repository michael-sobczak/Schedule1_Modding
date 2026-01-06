internal struct MaterialReference // TypeDefIndex: 16713
{
	// Fields
	public int index; // 0x0
	public FontAsset fontAsset; // 0x8
	public SpriteAsset spriteAsset; // 0x10
	public Material material; // 0x18
	public bool isDefaultMaterial; // 0x20
	public bool isFallbackMaterial; // 0x21
	public Material fallbackMaterial; // 0x28
	public float padding; // 0x30
	public int referenceCount; // 0x34

	// Methods

	// RVA: 0x2D58950 Offset: 0x2D57350 VA: 0x182D58950
	public void .ctor(int index, FontAsset fontAsset, SpriteAsset spriteAsset, Material material, float padding) { }

	// RVA: 0x2D584B0 Offset: 0x2D56EB0 VA: 0x182D584B0
	public static int AddMaterialReference(Material material, FontAsset fontAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) { }

	// RVA: 0x2D58710 Offset: 0x2D57110 VA: 0x182D58710
	public static int AddMaterialReference(Material material, SpriteAsset spriteAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) { }
}
