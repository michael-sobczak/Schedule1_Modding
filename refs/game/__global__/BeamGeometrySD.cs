public class BeamGeometrySD : BeamGeometryAbstractBase, MaterialModifier.Interface // TypeDefIndex: 316
{
	// Fields
	private VolumetricLightBeamSD m_Master; // 0x80
	private MeshType m_CurrentMeshType; // 0x88
	private MaterialModifier.Callback m_MaterialModifierCallback; // 0x90
	private Coroutine m_CoFadeOut; // 0x98
	private Camera m_CurrentCameraRenderingSRP; // 0xA0

	// Properties
	private bool visible { get; set; }
	public int sortingLayerID { get; set; }
	public int sortingOrder { get; set; }
	public bool _INTERNAL_IsFadeOutCoroutineRunning { get; }
	public static bool isCustomRenderPipelineSupported { get; }
	private bool shouldUseGPUInstancedMaterial { get; }
	private bool isNoiseEnabled { get; }
	private bool isDepthBlendEnabled { get; }

	// Methods

	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400 Slot: 4
	protected override VolumetricLightBeamAbstractBase GetMaster() { }

	// RVA: 0x7AC940 Offset: 0x7AB340 VA: 0x1807AC940
	private bool get_visible() { }

	// RVA: 0x7AC9A0 Offset: 0x7AB3A0 VA: 0x1807AC9A0
	private void set_visible(bool value) { }

	// RVA: 0x7AC900 Offset: 0x7AB300 VA: 0x1807AC900
	public int get_sortingLayerID() { }

	// RVA: 0x7AC960 Offset: 0x7AB360 VA: 0x1807AC960
	public void set_sortingLayerID(int value) { }

	// RVA: 0x7AC920 Offset: 0x7AB320 VA: 0x1807AC920
	public int get_sortingOrder() { }

	// RVA: 0x7AC980 Offset: 0x7AB380 VA: 0x1807AC980
	public void set_sortingOrder(int value) { }

	// RVA: 0x7AC7E0 Offset: 0x7AB1E0 VA: 0x1807AC7E0
	public bool get__INTERNAL_IsFadeOutCoroutineRunning() { }

	// RVA: 0x7A9980 Offset: 0x7A8380 VA: 0x1807A9980
	private float ComputeFadeOutFactor(Transform camTransform) { }

	[IteratorStateMachine(typeof(BeamGeometrySD.<CoUpdateFadeOut>d__17))]
	// RVA: 0x7A9750 Offset: 0x7A8150 VA: 0x1807A9750
	private IEnumerator CoUpdateFadeOut() { }

	// RVA: 0x7A97C0 Offset: 0x7A81C0 VA: 0x1807A97C0
	private void ComputeFadeOutFactor() { }

	// RVA: 0x7AAC20 Offset: 0x7A9620 VA: 0x1807AAC20
	private void SetFadeOutFactorProp(float value) { }

	// RVA: 0x7AB1A0 Offset: 0x7A9BA0 VA: 0x1807AB1A0
	private void StopFadeOutCoroutine() { }

	// RVA: 0x7AAA10 Offset: 0x7A9410 VA: 0x1807AAA10
	public void RestartFadeOutCoroutine() { }

	// RVA: 0x7AA4D0 Offset: 0x7A8ED0 VA: 0x1807AA4D0
	public void OnMasterEnable() { }

	// RVA: 0x7AA470 Offset: 0x7A8E70 VA: 0x1807AA470
	public void OnMasterDisable() { }

	// RVA: 0x7AA2E0 Offset: 0x7A8CE0 VA: 0x1807AA2E0
	private void OnDisable() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	public static bool get_isCustomRenderPipelineSupported() { }

	// RVA: 0x7AC890 Offset: 0x7AB290 VA: 0x1807AC890
	private bool get_shouldUseGPUInstancedMaterial() { }

	// RVA: 0x7AA3B0 Offset: 0x7A8DB0 VA: 0x1807AA3B0
	private void OnEnable() { }

	// RVA: 0x7A9DD0 Offset: 0x7A87D0 VA: 0x1807A9DD0
	public void Initialize(VolumetricLightBeamSD master) { }

	// RVA: 0x7AA700 Offset: 0x7A9100 VA: 0x1807AA700
	public void RegenerateMesh(bool masterEnabled) { }

	// RVA: 0x7A9AC0 Offset: 0x7A84C0 VA: 0x1807A9AC0
	private Vector3 ComputeLocalMatrix() { }

	// RVA: 0x7AC840 Offset: 0x7AB240 VA: 0x1807AC840
	private bool get_isNoiseEnabled() { }

	// RVA: 0x7AC7F0 Offset: 0x7AB1F0 VA: 0x1807AC7F0
	private bool get_isDepthBlendEnabled() { }

	// RVA: 0x7A9C50 Offset: 0x7A8650 VA: 0x1807A9C50
	private MaterialManager.StaticPropertiesSD ComputeMaterialStaticProperties() { }

	// RVA: 0x7A94B0 Offset: 0x7A7EB0 VA: 0x1807A94B0
	private bool ApplyMaterial() { }

	// RVA: 0x7AACE0 Offset: 0x7A96E0 VA: 0x1807AACE0 Slot: 5
	public void SetMaterialProp(int nameID, float value) { }

	// RVA: 0x7AAFE0 Offset: 0x7A99E0 VA: 0x1807AAFE0 Slot: 6
	public void SetMaterialProp(int nameID, Vector4 value) { }

	// RVA: 0x7AAEF0 Offset: 0x7A98F0 VA: 0x1807AAEF0 Slot: 7
	public void SetMaterialProp(int nameID, Color value) { }

	// RVA: 0x7AADC0 Offset: 0x7A97C0 VA: 0x1807AADC0 Slot: 8
	public void SetMaterialProp(int nameID, Matrix4x4 value) { }

	// RVA: 0x7AB0D0 Offset: 0x7A9AD0 VA: 0x1807AB0D0 Slot: 9
	public void SetMaterialProp(int nameID, Texture value) { }

	// RVA: 0x7AA160 Offset: 0x7A8B60 VA: 0x1807AA160
	private void MaterialChangeStart() { }

	// RVA: 0x7AA210 Offset: 0x7A8C10 VA: 0x1807AA210
	private void MaterialChangeStop() { }

	// RVA: 0x7AAB50 Offset: 0x7A9550 VA: 0x1807AAB50
	public void SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb) { }

	// RVA: 0x7AB550 Offset: 0x7A9F50 VA: 0x1807AB550
	public void UpdateMaterialAndBounds() { }

	// RVA: 0x7AC670 Offset: 0x7AB070 VA: 0x1807AC670
	private void UpdateMatricesPropertiesForGPUInstancingSRP() { }

	// RVA: 0x7AA2C0 Offset: 0x7A8CC0 VA: 0x1807AA2C0
	private void OnBeginCameraRenderingSRP(ScriptableRenderContext context, Camera cam) { }

	// RVA: 0x7AA600 Offset: 0x7A9000 VA: 0x1807AA600
	private void OnWillRenderObject() { }

	// RVA: 0x7AA510 Offset: 0x7A8F10 VA: 0x1807AA510
	private void OnWillCameraRenderThisBeam(Camera cam) { }

	// RVA: 0x7AB1F0 Offset: 0x7A9BF0 VA: 0x1807AB1F0
	private void UpdateCameraRelatedProperties(Camera cam) { }

	// RVA: 0x44B2F0 Offset: 0x449CF0 VA: 0x18044B2F0
	public void .ctor() { }
}
