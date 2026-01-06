public class BeamGeometryHD : BeamGeometryAbstractBase // TypeDefIndex: 273
{
	// Fields
	private VolumetricLightBeamHD m_Master; // 0x80
	private VolumetricCookieHD m_Cookie; // 0x88
	private VolumetricShadowHD m_Shadow; // 0x90
	private Camera m_CurrentCameraRenderingSRP; // 0x98
	private DirtyProps m_DirtyProps; // 0xA0

	// Properties
	public bool visible { set; }
	public int sortingLayerID { set; }
	public int sortingOrder { set; }
	public static bool isCustomRenderPipelineSupported { get; }
	private bool shouldUseGPUInstancedMaterial { get; }
	private bool isNoiseEnabled { get; }

	// Methods

	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400 Slot: 4
	protected override VolumetricLightBeamAbstractBase GetMaster() { }

	// RVA: 0x695080 Offset: 0x693A80 VA: 0x180695080
	public void set_visible(bool value) { }

	// RVA: 0x694F80 Offset: 0x693980 VA: 0x180694F80
	public void set_sortingLayerID(int value) { }

	// RVA: 0x695000 Offset: 0x693A00 VA: 0x180695000
	public void set_sortingOrder(int value) { }

	// RVA: 0x693520 Offset: 0x691F20 VA: 0x180693520
	private void OnDisable() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	public static bool get_isCustomRenderPipelineSupported() { }

	// RVA: 0x694E90 Offset: 0x693890 VA: 0x180694E90
	private bool get_shouldUseGPUInstancedMaterial() { }

	// RVA: 0x6935B0 Offset: 0x691FB0 VA: 0x1806935B0
	private void OnEnable() { }

	// RVA: 0x692F30 Offset: 0x691930 VA: 0x180692F30
	public void Initialize(VolumetricLightBeamHD master) { }

	// RVA: 0x693820 Offset: 0x692220 VA: 0x180693820
	public void RegenerateMesh() { }

	// RVA: 0x692BE0 Offset: 0x6915E0 VA: 0x180692BE0
	private Vector3 ComputeLocalMatrix() { }

	// RVA: 0x694E40 Offset: 0x693840 VA: 0x180694E40
	private bool get_isNoiseEnabled() { }

	// RVA: 0x692D60 Offset: 0x691760 VA: 0x180692D60
	private MaterialManager.StaticPropertiesHD ComputeMaterialStaticProperties() { }

	// RVA: 0x692A00 Offset: 0x691400 VA: 0x180692A00
	private bool ApplyMaterial() { }

	// RVA: 0x693BC0 Offset: 0x6925C0 VA: 0x180693BC0
	public void SetMaterialProp(int nameID, float value) { }

	// RVA: 0x693AD0 Offset: 0x6924D0 VA: 0x180693AD0
	public void SetMaterialProp(int nameID, Vector4 value) { }

	// RVA: 0x693930 Offset: 0x692330 VA: 0x180693930
	public void SetMaterialProp(int nameID, Color value) { }

	// RVA: 0x693D30 Offset: 0x692730 VA: 0x180693D30
	public void SetMaterialProp(int nameID, Matrix4x4 value) { }

	// RVA: 0x693CA0 Offset: 0x6926A0 VA: 0x180693CA0
	public void SetMaterialProp(int nameID, Texture value) { }

	// RVA: 0x693A20 Offset: 0x692420 VA: 0x180693A20
	public void SetMaterialProp(int nameID, BeamGeometryHD.InvalidTexture invalidTexture) { }

	// RVA: 0x6933A0 Offset: 0x691DA0 VA: 0x1806933A0
	private void MaterialChangeStart() { }

	// RVA: 0x693450 Offset: 0x691E50 VA: 0x180693450
	private void MaterialChangeStop() { }

	// RVA: 0x693E60 Offset: 0x692860 VA: 0x180693E60
	public void SetPropertyDirty(DirtyProps prop) { }

	// RVA: 0x694730 Offset: 0x693130 VA: 0x180694730
	private void UpdateMaterialAndBounds() { }

	// RVA: 0x694CA0 Offset: 0x6936A0 VA: 0x180694CA0
	private void UpdateMatricesPropertiesForGPUInstancingSRP() { }

	// RVA: 0x693500 Offset: 0x691F00 VA: 0x180693500
	private void OnBeginCameraRenderingSRP(ScriptableRenderContext context, Camera cam) { }

	// RVA: 0x6937E0 Offset: 0x6921E0 VA: 0x1806937E0
	private void OnWillRenderObject() { }

	// RVA: 0x693620 Offset: 0x692020 VA: 0x180693620
	private void OnWillCameraRenderThisBeam(Camera cam) { }

	// RVA: 0x693EF0 Offset: 0x6928F0 VA: 0x180693EF0
	private void UpdateDirtyMaterialProperties() { }

	// RVA: 0x6947D0 Offset: 0x6931D0 VA: 0x1806947D0
	private void UpdateMaterialPropertiesForCamera(Camera cam) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
