public class DynamicOcclusionDepthBuffer : DynamicOcclusionAbstractBase // TypeDefIndex: 320
{
	// Fields
	public const string ClassName = "DynamicOcclusionDepthBuffer";
	public LayerMask layerMask; // 0x70
	public bool useOcclusionCulling; // 0x74
	public int depthMapResolution; // 0x78
	public float fadeDistanceToSurface; // 0x7C
	private Camera m_DepthCamera; // 0x80
	private bool m_NeedToUpdateOcclusionNextFrame; // 0x88

	// Methods

	// RVA: 0x7AE730 Offset: 0x7AD130 VA: 0x1807AE730 Slot: 4
	protected override string GetShaderKeyword() { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 5
	protected override MaterialManager.SD.DynamicOcclusion GetDynamicOcclusionMode() { }

	// RVA: 0x7AF200 Offset: 0x7ADC00 VA: 0x1807AF200
	private void ProcessOcclusionInternal() { }

	// RVA: 0x7AF140 Offset: 0x7ADB40 VA: 0x1807AF140 Slot: 6
	protected override bool OnProcessOcclusion(DynamicOcclusionAbstractBase.ProcessOcclusionSource source) { }

	// RVA: 0x7AF4A0 Offset: 0x7ADEA0 VA: 0x1807AF4A0
	private void Update() { }

	// RVA: 0x7AF230 Offset: 0x7ADC30 VA: 0x1807AF230
	private void UpdateDepthCameraPropertiesAccordingToBeam() { }

	// RVA: 0x7AE760 Offset: 0x7AD160 VA: 0x1807AE760
	public bool HasLayerMaskIssues() { }

	// RVA: 0x7AF190 Offset: 0x7ADB90 VA: 0x1807AF190 Slot: 9
	protected override void OnValidateProperties() { }

	// RVA: 0x7AE7D0 Offset: 0x7AD1D0 VA: 0x1807AE7D0
	private void InstantiateOrActivateDepthCamera() { }

	// RVA: 0x7AEE30 Offset: 0x7AD830 VA: 0x1807AEE30 Slot: 8
	protected override void OnEnablePostValidate() { }

	// RVA: 0x7AED90 Offset: 0x7AD790 VA: 0x1807AED90 Slot: 13
	protected override void OnDisable() { }

	// RVA: 0x7ADA40 Offset: 0x7AC440 VA: 0x1807ADA40 Slot: 10
	protected override void Awake() { }

	// RVA: 0x7AEBD0 Offset: 0x7AD5D0 VA: 0x1807AEBD0 Slot: 11
	protected override void OnDestroy() { }

	// RVA: 0x7AE5C0 Offset: 0x7ACFC0 VA: 0x1807AE5C0
	private void DestroyDepthCamera() { }

	// RVA: 0x7AEE40 Offset: 0x7AD840 VA: 0x1807AEE40 Slot: 7
	protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner) { }

	// RVA: 0x7AF570 Offset: 0x7ADF70 VA: 0x1807AF570
	public void .ctor() { }
}
