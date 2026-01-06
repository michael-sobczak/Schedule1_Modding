public class Renderer : Component // TypeDefIndex: 11666
{
	// Properties
	public Bounds bounds { get; }
	public Bounds localBounds { get; }
	public bool enabled { get; set; }
	public bool isVisible { get; }
	public ShadowCastingMode shadowCastingMode { get; set; }
	public bool receiveShadows { set; }
	public bool forceRenderingOff { set; }
	public LightProbeUsage lightProbeUsage { set; }
	public ReflectionProbeUsage reflectionProbeUsage { set; }
	public uint renderingLayerMask { set; }
	public int sortingLayerID { get; set; }
	public int sortingOrder { get; set; }
	internal int sortingGroupID { get; }
	internal int sortingGroupOrder { get; }
	[NativeProperty("IsDynamicOccludee")]
	public bool allowOcclusionWhenDynamic { set; }
	public bool isPartOfStaticBatch { get; }
	public Matrix4x4 localToWorldMatrix { get; }
	public Transform probeAnchor { set; }
	public int lightmapIndex { get; }
	public int realtimeLightmapIndex { get; }
	public Vector4 lightmapScaleOffset { get; }
	public Vector4 realtimeLightmapScaleOffset { get; }
	public Material[] materials { get; set; }
	public Material material { get; set; }
	public Material sharedMaterial { get; set; }
	public Material[] sharedMaterials { get; set; }

	// Methods

	[FreeFunction(Name = "RendererScripting::GetWorldBounds", HasExplicitThis = True)]
	// RVA: 0x2C9E950 Offset: 0x2C9D350 VA: 0x182C9E950
	public Bounds get_bounds() { }

	[FreeFunction(Name = "RendererScripting::GetLocalBounds", HasExplicitThis = True)]
	// RVA: 0x2C9EB60 Offset: 0x2C9D560 VA: 0x182C9EB60
	public Bounds get_localBounds() { }

	[FreeFunction(Name = "RendererScripting::GetMaterial", HasExplicitThis = True)]
	// RVA: 0x2C9E350 Offset: 0x2C9CD50 VA: 0x182C9E350
	private Material GetMaterial() { }

	[FreeFunction(Name = "RendererScripting::GetSharedMaterial", HasExplicitThis = True)]
	// RVA: 0x2C9E540 Offset: 0x2C9CF40 VA: 0x182C9E540
	private Material GetSharedMaterial() { }

	[FreeFunction(Name = "RendererScripting::SetMaterial", HasExplicitThis = True)]
	// RVA: 0x2C9E7C0 Offset: 0x2C9D1C0 VA: 0x182C9E7C0
	private void SetMaterial(Material m) { }

	[FreeFunction(Name = "RendererScripting::GetMaterialArray", HasExplicitThis = True)]
	// RVA: 0x2C9E2D0 Offset: 0x2C9CCD0 VA: 0x182C9E2D0
	private Material[] GetMaterialArray() { }

	[FreeFunction(Name = "RendererScripting::GetMaterialArray", HasExplicitThis = True)]
	// RVA: 0x2C9E140 Offset: 0x2C9CB40 VA: 0x182C9E140
	private void CopyMaterialArray([Out] Material[] m) { }

	[FreeFunction(Name = "RendererScripting::GetSharedMaterialArray", HasExplicitThis = True)]
	// RVA: 0x2C9E190 Offset: 0x2C9CB90 VA: 0x182C9E190
	private void CopySharedMaterialArray([Out] Material[] m) { }

	[FreeFunction(Name = "RendererScripting::SetMaterialArray", HasExplicitThis = True)]
	// RVA: 0x2C9E6F0 Offset: 0x2C9D0F0 VA: 0x182C9E6F0
	private void SetMaterialArray(Material[] m, int length) { }

	// RVA: 0x2C9E750 Offset: 0x2C9D150 VA: 0x182C9E750
	private void SetMaterialArray(Material[] m) { }

	[FreeFunction(Name = "RendererScripting::SetPropertyBlock", HasExplicitThis = True)]
	// RVA: 0x2C9E6A0 Offset: 0x2C9D0A0 VA: 0x182C9E6A0
	internal void Internal_SetPropertyBlock(MaterialPropertyBlock properties) { }

	[FreeFunction(Name = "RendererScripting::GetPropertyBlock", HasExplicitThis = True)]
	// RVA: 0x2C9E4B0 Offset: 0x2C9CEB0 VA: 0x182C9E4B0
	internal void Internal_GetPropertyBlock(MaterialPropertyBlock dest) { }

	// RVA: 0x2C9E6A0 Offset: 0x2C9D0A0 VA: 0x182C9E6A0
	public void SetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0x2C9E4B0 Offset: 0x2C9CEB0 VA: 0x182C9E4B0
	public void GetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0x2C9E9B0 Offset: 0x2C9D3B0 VA: 0x182C9E9B0
	public bool get_enabled() { }

	// RVA: 0x2C9EEA0 Offset: 0x2C9D8A0 VA: 0x182C9EEA0
	public void set_enabled(bool value) { }

	[NativeName("IsVisibleInScene")]
	// RVA: 0x2C9EA30 Offset: 0x2C9D430 VA: 0x182C9EA30
	public bool get_isVisible() { }

	// RVA: 0x2C9ED10 Offset: 0x2C9D710 VA: 0x182C9ED10
	public ShadowCastingMode get_shadowCastingMode() { }

	// RVA: 0x2C9F0A0 Offset: 0x2C9DAA0 VA: 0x182C9F0A0
	public void set_shadowCastingMode(ShadowCastingMode value) { }

	// RVA: 0x2C9EFD0 Offset: 0x2C9D9D0 VA: 0x182C9EFD0
	public void set_receiveShadows(bool value) { }

	// RVA: 0x2C9EEF0 Offset: 0x2C9D8F0 VA: 0x182C9EEF0
	public void set_forceRenderingOff(bool value) { }

	// RVA: 0x2C9EF40 Offset: 0x2C9D940 VA: 0x182C9EF40
	public void set_lightProbeUsage(LightProbeUsage value) { }

	// RVA: 0x2C9F020 Offset: 0x2C9DA20 VA: 0x182C9F020
	public void set_reflectionProbeUsage(ReflectionProbeUsage value) { }

	// RVA: 0x2C9F060 Offset: 0x2C9DA60 VA: 0x182C9F060
	public void set_renderingLayerMask(uint value) { }

	// RVA: 0x2C9EDD0 Offset: 0x2C9D7D0 VA: 0x182C9EDD0
	public int get_sortingLayerID() { }

	// RVA: 0x2C9F0E0 Offset: 0x2C9DAE0 VA: 0x182C9F0E0
	public void set_sortingLayerID(int value) { }

	// RVA: 0x2C9EE10 Offset: 0x2C9D810 VA: 0x182C9EE10
	public int get_sortingOrder() { }

	// RVA: 0x2C9F120 Offset: 0x2C9DB20 VA: 0x182C9F120
	public void set_sortingOrder(int value) { }

	// RVA: 0x2C9ED50 Offset: 0x2C9D750 VA: 0x182C9ED50
	internal int get_sortingGroupID() { }

	// RVA: 0x2C9ED90 Offset: 0x2C9D790 VA: 0x182C9ED90
	internal int get_sortingGroupOrder() { }

	// RVA: 0x2C9EE50 Offset: 0x2C9D850 VA: 0x182C9EE50
	public void set_allowOcclusionWhenDynamic(bool value) { }

	[NativeName("IsPartOfStaticBatch")]
	// RVA: 0x2C9E9F0 Offset: 0x2C9D3F0 VA: 0x182C9E9F0
	public bool get_isPartOfStaticBatch() { }

	// RVA: 0x2C9EC10 Offset: 0x2C9D610 VA: 0x182C9EC10
	public Matrix4x4 get_localToWorldMatrix() { }

	// RVA: 0x2C9EF80 Offset: 0x2C9D980 VA: 0x182C9EF80
	public void set_probeAnchor(Transform value) { }

	[NativeName("GetLightmapIndexInt")]
	// RVA: 0x2C9E1E0 Offset: 0x2C9CBE0 VA: 0x182C9E1E0
	private int GetLightmapIndex(LightmapType lt) { }

	[NativeName("GetLightmapST")]
	// RVA: 0x2C9E270 Offset: 0x2C9CC70 VA: 0x182C9E270
	private Vector4 GetLightmapST(LightmapType lt) { }

	// RVA: 0x2C9EA70 Offset: 0x2C9D470 VA: 0x182C9EA70
	public int get_lightmapIndex() { }

	// RVA: 0x2C9EC70 Offset: 0x2C9D670 VA: 0x182C9EC70
	public int get_realtimeLightmapIndex() { }

	// RVA: 0x2C9EAB0 Offset: 0x2C9D4B0 VA: 0x182C9EAB0
	public Vector4 get_lightmapScaleOffset() { }

	// RVA: 0x2C9ECB0 Offset: 0x2C9D6B0 VA: 0x182C9ECB0
	public Vector4 get_realtimeLightmapScaleOffset() { }

	// RVA: 0x2C9E310 Offset: 0x2C9CD10 VA: 0x182C9E310
	private int GetMaterialCount() { }

	[NativeName("GetMaterialArray")]
	// RVA: 0x2C9E500 Offset: 0x2C9CF00 VA: 0x182C9E500
	private Material[] GetSharedMaterialArray() { }

	// RVA: 0x2C9E2D0 Offset: 0x2C9CCD0 VA: 0x182C9E2D0
	public Material[] get_materials() { }

	// RVA: 0x2C9E750 Offset: 0x2C9D150 VA: 0x182C9E750
	public void set_materials(Material[] value) { }

	// RVA: 0x2C9E350 Offset: 0x2C9CD50 VA: 0x182C9E350
	public Material get_material() { }

	// RVA: 0x2C9E7C0 Offset: 0x2C9D1C0 VA: 0x182C9E7C0
	public void set_material(Material value) { }

	// RVA: 0x2C9E540 Offset: 0x2C9CF40 VA: 0x182C9E540
	public Material get_sharedMaterial() { }

	// RVA: 0x2C9E7C0 Offset: 0x2C9D1C0 VA: 0x182C9E7C0
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x2C9E500 Offset: 0x2C9CF00 VA: 0x182C9E500
	public Material[] get_sharedMaterials() { }

	// RVA: 0x2C9E750 Offset: 0x2C9D150 VA: 0x182C9E750
	public void set_sharedMaterials(Material[] value) { }

	// RVA: 0x2C9E390 Offset: 0x2C9CD90 VA: 0x182C9E390
	public void GetMaterials(List<Material> m) { }

	// RVA: 0x2C9E810 Offset: 0x2C9D210 VA: 0x182C9E810
	public void SetMaterials(List<Material> materials) { }

	// RVA: 0x2C9E580 Offset: 0x2C9CF80 VA: 0x182C9E580
	public void GetSharedMaterials(List<Material> m) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	// RVA: 0x2C9E900 Offset: 0x2C9D300 VA: 0x182C9E900
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x2C9EB10 Offset: 0x2C9D510 VA: 0x182C9EB10
	private void get_localBounds_Injected(out Bounds ret) { }

	// RVA: 0x2C9EBC0 Offset: 0x2C9D5C0 VA: 0x182C9EBC0
	private void get_localToWorldMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2C9E220 Offset: 0x2C9CC20 VA: 0x182C9E220
	private void GetLightmapST_Injected(LightmapType lt, out Vector4 ret) { }
}
