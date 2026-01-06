public static class TMP_MaterialManager // TypeDefIndex: 14945
{
	// Fields
	private static List<TMP_MaterialManager.MaskingMaterial> m_materialList; // 0x0
	private static Dictionary<long, TMP_MaterialManager.FallbackMaterial> m_fallbackMaterials; // 0x8
	private static Dictionary<int, long> m_fallbackMaterialLookup; // 0x10
	private static List<TMP_MaterialManager.FallbackMaterial> m_fallbackCleanupList; // 0x18
	private static bool isFallbackListDirty; // 0x20

	// Methods

	// RVA: 0x2C23110 Offset: 0x2C21B10 VA: 0x182C23110
	private static void .cctor() { }

	// RVA: 0x2C22310 Offset: 0x2C20D10 VA: 0x182C22310
	private static void OnPreRender() { }

	// RVA: 0x2C21F20 Offset: 0x2C20920 VA: 0x182C21F20
	public static Material GetStencilMaterial(Material baseMaterial, int stencilID) { }

	// RVA: 0x2C22AB0 Offset: 0x2C214B0 VA: 0x182C22AB0
	public static void ReleaseStencilMaterial(Material stencilMaterial) { }

	// RVA: 0x2C20F40 Offset: 0x2C1F940 VA: 0x182C20F40
	public static Material GetBaseMaterial(Material stencilMaterial) { }

	// RVA: 0x2C23020 Offset: 0x2C21A20 VA: 0x182C23020
	public static Material SetStencil(Material material, int stencilID) { }

	// RVA: 0x2C20400 Offset: 0x2C1EE00 VA: 0x182C20400
	public static void AddMaskingMaterial(Material baseMaterial, Material stencilMaterial, int stencilID) { }

	// RVA: 0x2C22EC0 Offset: 0x2C218C0 VA: 0x182C22EC0
	public static void RemoveStencilMaterial(Material stencilMaterial) { }

	// RVA: 0x2C22390 Offset: 0x2C20D90 VA: 0x182C22390
	public static void ReleaseBaseMaterial(Material baseMaterial) { }

	// RVA: 0x2C208E0 Offset: 0x2C1F2E0 VA: 0x182C208E0
	public static void ClearMaterials() { }

	// RVA: 0x2C21B20 Offset: 0x2C20520 VA: 0x182C21B20
	public static int GetStencilID(GameObject obj) { }

	// RVA: 0x2C21910 Offset: 0x2C20310 VA: 0x182C21910
	public static Material GetMaterialForRendering(MaskableGraphic graphic, Material baseMaterial) { }

	// RVA: 0x2C20DC0 Offset: 0x2C1F7C0 VA: 0x182C20DC0
	private static Transform FindRootSortOverrideCanvas(Transform start) { }

	// RVA: 0x2C215C0 Offset: 0x2C1FFC0 VA: 0x182C215C0
	internal static Material GetFallbackMaterial(TMP_FontAsset fontAsset, Material sourceMaterial, int atlasIndex) { }

	// RVA: 0x2C210C0 Offset: 0x2C1FAC0 VA: 0x182C210C0
	public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial) { }

	// RVA: 0x2C202C0 Offset: 0x2C1ECC0 VA: 0x182C202C0
	public static void AddFallbackMaterialReference(Material targetMaterial) { }

	// RVA: 0x2C22D10 Offset: 0x2C21710 VA: 0x182C22D10
	public static void RemoveFallbackMaterialReference(Material targetMaterial) { }

	// RVA: 0x2C20680 Offset: 0x2C1F080 VA: 0x182C20680
	public static void CleanupFallbackMaterials() { }

	// RVA: 0x2C228D0 Offset: 0x2C212D0 VA: 0x182C228D0
	public static void ReleaseFallbackMaterial(Material fallbackMaterial) { }

	// RVA: 0x2C20AD0 Offset: 0x2C1F4D0 VA: 0x182C20AD0
	public static void CopyMaterialPresetProperties(Material source, Material destination) { }
}
